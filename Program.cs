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
      /// <summary>Capacity of the TQueue</summary>
      public int Capacity => mElements.Length;

      /// <summary>Count of the elements in TQueue</summary>
      public int Count => mCount;

      /// <summary>Tells if the queue is empty or not </summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Method ------------------------------------------------
      /// <summary>Throws Exception when queue is empty</summary>
      /// <exception cref="CheckEmpty"></exception>
      void CheckEmpty () {
         if (IsEmpty) throw new InvalidOperationException ("Empty Queue");
      }

      /// <summary>Removes the element in order of FIFO</summary>
      /// <returns>Returns the removed element</returns>
      public T Dequeue () {
         CheckEmpty ();
         T a = mElements[mFront];
         mElements[mFront] = default;
         mFront = (mFront + 1) % mElements.Length;
         mCount--;
         return a;
      }

      /// <summary>Adds element to end of Queue</summary>
      /// <param name="a">Elements of queue</param>
      public void Enqueue (T a) {
         if (mCount == mElements.Length) {
            var temp = new T[Capacity * 2];
            for (int i = 0; i < Capacity; i++) {
               temp[i] = mElements[mRear];
               mRear = (mRear + 1) % Capacity;
            }
            (mElements, mRear, mFront) = (temp, mCount, 0);
         }
         mElements[mRear] = a;
         mRear = (mRear + 1) % mElements.Length;
         mCount++;
      }

      /// <summary>Returns the first element in queue without removing it</summary>
      public T Peek () {
         CheckEmpty ();
         return mElements[mFront];
      }
      #endregion

      #region Private data ------------------------------------------
      int mCount = 0, mFront = 0, mRear = 0;
      T[] mElements = new T[4];
      #endregion
   }
   #endregion
}