// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Implement a custom MyList<T> class using arrays as the underlying data structure.
// The MyList<T> should start with an initial capacity of 4 and double its capacity when needed.
// Use the template shown below for implementation. Throw exceptions when necessary. 
// class MyList<T> {
//   public MyList () { }
//   public int Count { get; }
//   public int Capacity { get; }
//   public T this[int index] { get; set; }
//   public void Add (T a) { }
//   public bool Remove (T a) { }
//   public void Clear () { }
//   public void Insert (int index, T a) { }
//   public void RemoveAt (int index) { }
// }
// --------------------------------------------------------------------------------------------
internal class Program {
   public static void Main () { }
}
#region MyList ------------------------------------------------------------------------------
/// <summary>MyList class</summary>
/// <typeparam name="T"></typeparam>
public class MyList<T> {
   #region Properties --------------------------------------------
   /// <summary>Count of the list</summary>   
   public int Count => mCount;

   /// <summary>Capacity of the list</summary>
   public int Capacity => mCapacity;

   /// <summary>Set a element</summary>
   /// <param name="index">Index of element</param>
   /// <returns>Return the element from list using its index</returns>
   public T this[int index] {
      get {
         IndexException (index);
         return mElements[index];
      }
      set {
         IndexException (index);
         mElements[index] = value; //Set the value at the index
      }
   }
   #endregion

   #region Methods -----------------------------------------------
   /// <summary>Add a element at end of the list</summary>
   /// <param name="a"></param>
   public void Add (T a) {
      ResizeCapacity (); // Double its capacity when needed
      mElements[mCount++] = a;
   }

   /// <summary>Remove a element from the list</summary>
   /// <param name="a"></param>
   /// <returns>Returns true when a element removed</returns>
   public bool Remove (T a) {
      int index = Array.IndexOf (mElements, a);
      if (index == -1) return false;
      // Remove the element using its index
      RemoveAt (index);
      return true;
   }

   /// <summary>Clear all the elements in list</summary>
   public void Clear () {
      Array.Clear (mElements, 0, mCount);
      mCount = 0;
   }

   /// <summary>Insert a element with the index</summary>
   /// <param name="index"></param>
   /// <param name="a"></param>
   public void Insert (int index, T a) {
      ArgumentException (index, mCount);
      ResizeCapacity ();
      for (int i = mCount; i > index; i--) mElements[i] = mElements[i - 1];
      mElements[index] = a; mCount++;
   }

   /// <summary>Remove the element using its index</summary>
   /// <param name="index"></param>
   /// <exception cref="ArgumentOutOfRangeException">Throw exception when index is out of range</exception>
   public void RemoveAt (int index) {
      ArgumentException (index, mCount - 1);
      for (int i = index; i < mCount - 1; i++) mElements[i] = mElements[i + 1];
      mElements[--mCount] = default;
   }

   /// <summary>Resize the capacity of list</summary>
   private void ResizeCapacity () {
      if (mCount == mCapacity) {
         mCapacity *= 2; // Double the capacity
         Array.Resize (ref mElements, mCapacity);
      }
   }

   /// <summary>Index out of range exception</summary>
   /// <param name="index">Index of elements</param>
   /// <exception cref="IndexOutOfRangeException"></exception>
   private void IndexException (int index) {
      if (index < 0 || index > mCount) throw new IndexOutOfRangeException ("Index is out of range");
   }

   /// <summary>Argument out of range exception</summary>
   /// <param name="index">Index of elements</param>
   /// <param name="count">Count of elements in list</param>
   /// <exception cref="ArgumentOutOfRangeException"></exception>
   private void ArgumentException (int index, int count) {
      if (index < 0 || index > count) throw new ArgumentOutOfRangeException ("Index is out of range");
   }
   #endregion

   #region Private data ------------------------------------------
   T[] mElements = new T[4];
   int mCapacity = 4, mCount = 0;
   #endregion
   #endregion
}
