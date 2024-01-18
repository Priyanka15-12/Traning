// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Implement double ended queue using array of T
// This is like a queue but we can add or remove
// i.e. enqueue or dequeue at both the ends at the head and the tail. 
// This should allow to add at the head or remove at the head and
// add to the tail or remove at the tail.
// --------------------------------------------------------------------------------------------
namespace Training {
   internal class Program {
      static void Main () { }
   }
   #region Queue ------------------------------------------------------------------------------

   public class Deque<T> {
      #region Properties --------------------------------------------
      /// <summary>Capacity of the TDeque</summary>
      public int Capacity => mElements.Length;

      /// <summary>Count of the elements in TDeque</summary>
      public int Count => mCount;

      /// <summary>Tells if the queue is empty or not</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Method ------------------------------------------------
      /// <summary>Throws exception when queue is empty</summary>
      /// <exception cref="InvalidOperationException"></exception>
      void CheckEmpty () {
         if (IsEmpty) throw new InvalidOperationException ("Empty Queue");
      }

      /// <summary>Adds an element at front of the queue</summary>
      /// <param name="a">Elements of queue</param>
      public void EnqueueFront (T a) {
         if (mCount == mElements.Length) Resize ();
         //Move the pointer to front position
         mFront = (mFront - 1 + mElements.Length) % mElements.Length;
         mElements[mFront] = a;
         mCount++;
      }

      /// <summary>Adds an element at end of the queue</summary>
      /// <param name="a">Elements of queue</param>
      public void EnqueueRear (T a) {
         if (mCount == mElements.Length) Resize ();
         mElements[mRear] = a;
         mRear = (mRear + 1) % mElements.Length;
         mCount++;
      }

      /// <summary>Removes an element at end of the queue</summary>
      /// <returns>Returns removed element</returns>
      public T DequeueRear () {
         CheckEmpty ();
         //Move the pointer to rear position
         mRear = (mRear - 1 + mElements.Length) % mElements.Length;
         T a = mElements[mRear];
         mElements[mRear] = default;
         mCount--;
         return a;
      }

      /// <summary>Removes an element at front of the queue</summary>
      /// <returns>Returns removed element</returns>
      public T DequeueFront () {
         CheckEmpty ();
         T a = mElements[mFront];
         mElements[mFront] = default;
         mFront = (mFront + 1) % mElements.Length;
         mCount--;
         return a;
      }

      /// <summary>Returns the first element in queue without removing it</summary> 
      public T PeekFront () {
         CheckEmpty ();
         return mElements[mFront];
      }

      /// <summary>Returns the last element in queue without removing it</summary> 
      public T PeekRear () {
         CheckEmpty ();
         return mElements[(mRear - 1 + mElements.Length) % mElements.Length];
      }

      /// <summary>Double the capacity of queue when needed</summary>
      void Resize () {
         var temp = new T[Capacity * 2];
         for (int i = 0; i < Capacity; i++) {
            temp[i] = mElements[mRear];
            mRear = (mRear + 1) % Capacity;
         }
         (mElements, mRear, mFront) = (temp, mCount, 0);
      }
      #endregion

      #region Private data ------------------------------------------
      int mCount = 0, mFront = 0, mRear = 0;
      T[] mElements = new T[4];
      #endregion
   }
   #endregion
}