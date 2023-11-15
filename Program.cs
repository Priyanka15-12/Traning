// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Implement a Queue<T> using arrays as the underlying data structure. The queue should grow the array when needed (like the TStack above does).
// If the array does not have to be grown, both Enqueue and Dequeue should be constant time (O(1)) operations.Throw exceptions as needed. 
// class TQueue<T> {
//   public void Enqueue (T a) { }
//   public T Dequeue () { }
//   public T Peek () { }
//   public bool IsEmpty { get; }
// }
// --------------------------------------------------------------------------------------------
namespace Training {
   internal class Program {
      static void Main () { }
   }
   #region TQueue ------------------------------------------------------------------------------
   /// <summary>TQueue</summary>
   /// <typeparam name="T"></typeparam>
   public class TQueue<T> {
      #region Properties --------------------------------------------
      /// <summary>Shows count of the Queue</summary>
      public int Count => mCount;

      /// <summary>shows capacity of the Queue</summary>
      public int Capacity => mElements.Length;

      /// <summary>Shows whether the queue is empty or not </summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>Add elements in queue</summary>
      /// <param name="a">Elements of queue</param>
      public void Enqueue (T a) {
         if (Count == Capacity) Array.Resize (ref mElements, Capacity * 2);
         mElements[mCount++] = a;
      }

      /// <summary>Remove elements in the order of FIFO</summary>
      /// <returns>Shows the removed element</returns>
      public T Dequeue () {
         InvalidOperationException ();
         T a = mElements[mDCount];
         mElements[mDCount++] = default;
         mCount--;
         return a;
      }

      /// <summary>Shows the first element of queue</summary>
      /// <returns>Returns the element which added at first</returns>
      public T Peek () {
         InvalidOperationException ();
         return mElements[mDCount];
      }

      /// <summary>Throws
      /// . the Exception</summary>
      /// <exception cref="InvalidOperationException"></exception>
      void InvalidOperationException () {
         if (IsEmpty) throw new InvalidOperationException ("Empty Queue");
      }
      #endregion

      #region Private data ------------------------------------------
      T[] mElements = new T[4];
      int mCount = 0, mDCount = 0;
      #endregion
   }
   #endregion
}
