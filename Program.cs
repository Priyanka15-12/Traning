// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ---------------------------------------------------------------------------------------
// Program.cs
// Solve the famous 8 Queens problem
// On a standard chessboard 8 queens have to be placed so that no queen can attack any other.
// As per the rules of chess, the queen can move horizontally, vertically or in a diagonal.
// No two queens can be on the same row or column or diagonal.
// Find all the possible solutions. Each solution should display the Queens in 8x8 grid.
// Extend the assignment to eliminate identical solutions. A solution is identical to another if it is:
// 90, 180 or 270 degree rotation of the other
// mirror image of the other : horizontal mirror, vertical mirror
// ---------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Eight Queens problem</summary>
   class Program {
      #region Method ------------------------------------------------
      /// <summary>Print the solutions according to the input (unique or all solutions)</summary>
      static void Main () {
         Write ("Press U for unique solutions.");
         bool isUnique = false;
         if (ReadKey (true).Key is ConsoleKey.U) isUnique = true;
         PlaceQueen (isUnique, 0);
         PrintChessBoard ();
      }

      /// <summary>Creates a solution array consisting of safe cells
      /// and store the solution arrays in a list</summary>
      /// <param name="isUnique">Whether to determine unique solutions only or not</param>
      /// <param name="row">Row of the chessboard</param>
      static void PlaceQueen (bool isUnique, int row) {
         for (int column = 0; column < 8; column++) {
            if (IsSafeCell (row, column)) {
               sPosition[row] = column;
               var sln = sPosition.ToArray ();
               if (isUnique ? row == 7 && IsUniqueSolution (sln) : row == 7) sSolutionsList.Add (sln);
               else PlaceQueen (isUnique, row + 1);
            }
         }
      }

      /// <summary>Check if the queen collides with any other queen 
      /// horizontally or vertically or diagonally</summary>
      /// <param name="row">Row of the chessboard</param>
      /// <param name="column">Column of the chessboard</param>
      /// <returns>True if a queen can't attack any other</returns>
      static bool IsSafeCell (int row, int column) {
         for (int preRow = 0; preRow < row; preRow++) { // Row Check
            int preColumn = sPosition[preRow];
            if (Math.Abs (column - preColumn) == Math.Abs (row - preRow) // Diagonal check
                || column == preColumn) return false; // Column Check
         }
         return true;
      }

      /// <summary>Print the solutions on chessboard grid</summary>
      static void PrintChessBoard () {
         OutputEncoding = Encoding.UTF8;
         for (int i = 0; i < sSolutionsList.Count; i++) {
            CursorLeft = CursorTop = 0;
            WriteLine ($"\nSolution {i + 1} of {sSolutionsList.Count}\n");
            var solution = sSolutionsList[i];
            for (int j = 0; j < 8; j++) {
               WriteLine (j == 0 ? $"{PrintLine ("┌", "───┬", "───┐")}" : $"{PrintLine ("├", "───┼", "───┤")}");
               PrintQueenOrSpace (solution[j]);
            }
            WriteLine ($"{PrintLine ("└", "───┴", "───┘")}");
            ReadKey ();
         }


         /// <summary>Print the horizontal lines on chessboard grid</summary>
         /// <param name="leftSide">Left corner string</param>
         /// <param name="midPart">Middle part string</param>
         /// <param name="rightSide">Right corner string</param>
         /// <returns>String representing the lines</returns>
         static string PrintLine (string leftSide, string midPart, string rightSide)
            => $"{leftSide}{string.Concat (Enumerable.Repeat (midPart, 7))}{rightSide}";

         /// <summary>Prints queen or empty spaces on chessboard grid</summary>
         /// <param name="queen">Column position of queen</param>
         static void PrintQueenOrSpace (int queen) {
            for (int i = 0; i < 8; i++) Write ($"│ {(i == queen ? "♕" : " ")} ");
            WriteLine ("│");
         }
      }

      /// <summary>Tells if the solution is unique i.e. neither mirror image nor rotated image</summary>
      /// <param name="sln">The solution to check</param>
      /// <returns>True if solution is unique</returns>
      static bool IsUniqueSolution (int[] sln) => !IsMirrorImage (sln) && (!IsRotatedImage (sln));

      /// <summary>Tells if the solution is identical with any previous solutions</summary>
      /// <param name="sln">The solution to check</param>
      /// <returns>True if the solution is identical to any previously found solution</returns>
      static bool IsIdentical (int[] sln) => sSolutionsList.Any (a => a.SequenceEqual (sln));

      /// <summary>Tells if the solution is vertical mirror of any previous solutions</summary>
      /// <param name="sln">The solution to check</param>
      /// <returns>True if the solution is vertical mirror of any previous solutions</returns>
      static bool IsMirrorImage (int[] sln) => IsIdentical (sln.Reverse ().ToArray ());

      /// <summary>Rotate the given solution by 90 degrees</summary>
      /// <param name="a">Rotated solution array</param>
      /// <param name="b">Copy of rotated solution array</param>
      static void Rotate90 (int[] a, int[] b) {
         for (int i = 0; i < 8; i++) a[b[i]] = 7 - i;
         for (int i = 0; i < 8; i++) b[i] = a[i];
      }

      /// <summary>Checks if rotated solution or its mirror 
      /// is identical with any previous solutions</summary>
      /// <param name="arr">Input solution array</param>
      /// <returns>True if present, else false</returns>
      static bool IsRotatedImage (int[] arr) {
         int[] a = new int[8]; int[] b = new int[8];
         for (int i = 0; i < 8; i++) b[i] = arr[i];
         for (int i = 0; i < 3; i++) {
            Rotate90 (a, b);
            if (IsMirrorImage (a) || IsIdentical (a)) return true;
         }
         return false;
      }
      #endregion

      #region Private -----------------------------------------------
      static int[] sPosition = new int[8];
      static List<int[]> sSolutionsList = new ();
      #endregion
   }
   #endregion
}