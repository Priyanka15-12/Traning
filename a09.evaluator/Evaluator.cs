namespace Eval {
   #region EvalException --------------------------------------------------------------------------
   /// <summary>Class EvalException</summary>
   public class EvalException : Exception {
      public EvalException (string message) : base (message) { }
   }
   #endregion

   #region Evaluator ------------------------------------------------------------------------------
   /// <summary>Class Evaluator</summary>
   public class Evaluator {
      #region Property-----------------------------------------------
      public int BasePriority { get; private set; }
      #endregion

      #region Method ------------------------------------------------
      /// <summary>Evaluate the expressions</summary>
      /// <param name="input">Expression input</param>
      /// <returns>Returns a double after evaluating</returns>
      public double Evaluate (string input) {
         Reset ();
         var tokenizer = new Tokenizer (this, input);
         for (; ; ) {
            var token = tokenizer.Next (); // Gets each token
            if (token is TEnd) break;
            if (token is TError err) ThrowException (err.Message);
            mTokens.Add (token);
         }
         // Check if this is a variable assignment
         TVariable? tVariable = null;
         if (mTokens.Count > 2 && mTokens[0] is TVariable tVar && mTokens[1] is TOpArithmetic bin
                               && bin.Operator == '=') {
            tVariable = tVar;
            mTokens.RemoveRange (0, 2);
         }
         foreach (var token in mTokens) Process (token);
         while (mOperators.Count > 0) ApplyOperator ();
         if (mOperands.Count > 1) ThrowException ("Too many operands");
         if (mOperators.Count > 0) ThrowException ("Too many operators");
         if (BasePriority != 0) ThrowException ("Mismatched parentheses");
         double f = mOperands.Pop ();
         if (tVariable != null) mVariables[tVariable.Name] = f; // For assignment expression
         return f;
      }

      /// <summary>Gets the assigned variable</summary>
      /// <param name="name">Variable name</param>
      /// <returns>Returns the value of the variable</returns>
      /// <exception cref="EvalException">Throws exception if variable is unknown</exception>
      public double GetVariable (string name) {
         if (mVariables.TryGetValue (name, out double f)) return f;
         throw new EvalException ($"Unknown variable: {name}");
      }

      /// <summary>Push operands and operators in individual stack based on its priority</summary>
      /// <param name="token">Each token</param>
      void Process (Token token) {
         switch (token) {
            case TNumber num:
               mOperands.Push (num.Value);
               break;
            case TOperator op:
               op.FinalPriority = BasePriority + op.Priority;
               // Pushes the operator if it is unary or has higher priority than the previous one
               while (op is not TOpUnary 
                      && (mOperators.Count != 0 
                      && op.FinalPriority < mOperators.Peek ().FinalPriority)) ApplyOperator ();
               mOperators.Push (op);
               break;
            case TPunctuation p:
               BasePriority += p.Punct == '(' ? 10 : -10;
               break;
            default: throw new EvalException ($"Unknown token: {token}");
         }
      }

      /// <summary>Apply the operator with its corresponding operands</summary>
      void ApplyOperator () {
         var op = mOperators.Pop ();
         var f1 = mOperands.Pop ();
         switch (op) {
            case TOpFunction func:
               mOperands.Push (func.Evaluate (f1)); break;
            case TOpUnary un: mOperands.Push (un.Apply (f1)); break;
            case TOpArithmetic arith:
               var f2 = mOperands.Pop ();
               mOperands.Push (arith.Evaluate (f2, f1)); break;
         }
      }

      /// <summary>Gets the previous token</summary>
      public Token GetPreviousToken () => mTokens[^1];

      /// <summary>Resets the evaluator</summary>
      void Reset () {
         mOperands.Clear (); mOperators.Clear ();
         BasePriority = 0;
         mTokens.Clear ();
      }

      /// <summary>Throws exception if needed</summary>
      /// <param name="message">string error message</param>
      void ThrowException (string message) => throw new EvalException (message);
      #endregion

      #region private data-------------------------------------------
      Stack<double> mOperands = new ();
      Stack<TOperator> mOperators = new ();
      List<Token> mTokens = new ();
      Dictionary<string, double> mVariables = new ();
      #endregion
   }
   #endregion
}