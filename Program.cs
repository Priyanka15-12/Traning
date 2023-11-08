// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Implement a Stack<T> class using arrays as the underlying data structure.
// The Stack<T> should start with an  initial capacity of 4 and double its capacity when needed.
// Use the template shown below for implementation. Throw exceptions when necessary. 
// class TStack<T> {
//    public void Push (T a) { }
//    public T Pop () { }
//    public T Peek () { }
//    public bool IsEmpty { get; }
// }
// InvalidOperationException: This exception should be thrown when attempting to pop or peek an empty stack. 
// --------------------------------------------------------------------------------------------
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         TStack<int> num = new TStack<int> ();
         num.Push(1);
         num.Push(2);
         num.Push(3);
         Console.Write(num.Pop());
         Console.Write(num.Pop());
         Console.Write(num.Pop());
      }
   }
   #region TStack ------------------------------------------------------------------------------
   /// <summary>TSatck</summary>
   /// <typeparam name="T"></typeparam>
   public class TStack<T> {
      #region Properties --------------------------------------------
      /// <summary>Shows count of the stack</summary>
      public int Count => mCount;

      /// <summary>Shows capacity of the stack</summary>
      public int Capacity => mCapacity;

      /// <summary>Shows whether the stack is empty or not</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>Add a element in the stack</summary>
      /// <param name="a">Element of stack</param>
      public void Push (T a) {
         //Resize the capacity of stack when needed
         if (mCount == mCapacity) {
            mCapacity *= 2;
            Array.Resize (ref mElements, mCapacity);
         }
         mElements[mCount++] = a;
      }

      /// <summary>Remove the element in the order of LIFO</summary>
      /// <returns>Shows the removed element</returns>
      public T Pop () {
         if (IsEmpty) throw new InvalidOperationException ("Pop can't do in empty stack");
         T a = mElements[mCount - 1];
         mElements[mCount--] = default;
         return a;
      }

      /// <summary>Shows the element in the order of LIFO</summary>
      /// <returns>Return element which added at last</returns>
      public T Peek () {
         if (IsEmpty) throw new InvalidOperationException ("Peek can't do in empty stack");
         return mElements[mCount - 1];
      }
      #endregion

      #region Private data ------------------------------------------
      T[] mElements = new T[4];
      int mCount = 0, mCapacity = 4;
      #endregion 
   }
   #endregion
}