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
      /// <summary>Print all the possible solutions or unique solutions</summary>
      static void Main () {
         Write ("Press U for unique solutions.");
         bool isUni = false;
         if (ReadKey (true).Key is ConsoleKey.U) isUni = true;
         PlaceQueen (isUni, 0);
         PrintChessBoard ();
      }

      /// <summary>Place Queens in safe cell</summary>
      /// <param name="isUnique"></param>
      /// <param name="row"></param>
      static void PlaceQueen (bool isUnique, int row) {
         for (int column = 0; column < 8; column++) {
            if (IsSafeCell (row, column)) {
               sPosition[row] = column;
               var sln = sPosition.ToArray ();
               if (isUnique ? row == 7 && IsUniqueSln (sln) : row == 7) sSolutionsList.Add (sln);
               else PlaceQueen (isUnique, row + 1);
            }
         }

         /// <summary>Checks if the cell is safe</summary>
         static bool IsSafeCell (int row, int column) {
            for (int preRow = 0; preRow < row; preRow++) {
               int preColumn = sPosition[preRow];
               if (Math.Abs (column - preColumn) == Math.Abs (row - preRow) || column == preColumn) return false;
            }
            return true;
         }
      }

      /// <summary>Print chess board grid</summary>
      static void PrintChessBoard () {
         OutputEncoding = Encoding.UTF8;
         for (int i = 0; i < sSolutionsList.Count; i++) {
            CursorLeft = CursorTop = 0;
            WriteLine ($"\nSolution {i + 1} of {sSolutionsList.Count}\n");
            var solution = sSolutionsList[i];
            for (int j = 0; j < 8; j++) {
               WriteLine (j == 0 ? $"{PrintLines ("┌", "───┬", "───┐")}" : $"{PrintLines ("├", "───┼", "───┤")}");
               QueenOrSpace (solution[j]);
            }
            WriteLine ($"{PrintLines ("└", "───┴", "───┘")}");
            ReadKey ();
         }

         /// <summary>Prints all the grid lines</summary>
         static string PrintLines (string lCorner, string mid, string rCorner) => $"{lCorner}{string.Concat (Enumerable.Repeat (mid, 7))}{rCorner}";

         /// <summary>Prints the queen or spaces</summary>
         static void QueenOrSpace (int queen) {
            for (int i = 0; i < 8; i++) Write ($"│ {(i == queen ? "♕" : " ")} ");
            WriteLine ("│");
         }
      }

      /// <summary>Checks, the solution is unique or not</summary>
      /// <param name="sln">solution</param>
      /// <returns>Return all the unique solutions</returns>
      static bool IsUniqueSln (int[] sln) => !IsVerticalMirror (sln) && (!IsRotated (sln));

      /// <summary>Checks the solutions are identical or not</summary>
      /// <param name="sln">solution</param>
      static bool IsIdentical (int[] sln) => sSolutionsList.Any (a => a.SequenceEqual (sln));

      /// <summary>Return mirror solution of some identical solutions</summary>
      /// <param name="sln"></param>
      static bool IsVerticalMirror (int[] sln) => IsIdentical (sln.Reverse ().ToArray ());

      /// <summary>Rotate the solution</summary>
      /// <param name="a">Rotated solution array</param>
      /// <param name="b">Copy of rotated solution array</param>
      static void Rotate (int[] a, int[] b) {
         for (int i = 0; i < 8; i++) a[b[i]] = 7 - i;
         for (int i = 0; i < 8; i++) b[i] = a[i];
      }

      /// <summary>Checks, if rotated solution is identical and mirror image</summary>
      /// <param name="arr">Solution</param>
      static bool IsRotated (int[] arr) {
         int[] a = new int[8]; int[] b = new int[8];
         for (int i = 0; i < 8; i++) b[i] = arr[i];
         for (int i = 0; i < 3; i++) {
            Rotate (a, b);
            if (IsVerticalMirror (a) || IsIdentical (a)) return true;
         }
         return false;
         #endregion
      }
      #endregion

      #region Private -----------------------------------------------
      static int[] sPosition = new int[8];
      static List<int[]> sSolutionsList = new ();
      #endregion
   }
}