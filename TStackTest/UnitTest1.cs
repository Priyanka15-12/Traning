using Training;
namespace TStackTest {
   [TestClass]
   public class UnitTest1 {
      TStack<int> mNumbers = new ();
      Stack<int> mStackNum = new ();

      [TestMethod]
      public void PushTest () {
         mNumbers.Push (1);
         mNumbers.Push (2);
         mNumbers.Push (3);
         mNumbers.Push (4);
         mStackNum.Push (1);
         mStackNum.Push (2);
         mStackNum.Push (3);
         mStackNum.Push (4);
         Assert.AreEqual (mStackNum.Count, mNumbers.Count);
         Assert.AreEqual (4, mNumbers.Capacity);
         Assert.IsFalse (mNumbers.IsEmpty);
         mNumbers.Push (5);
         Assert.AreEqual (5, mNumbers.Count);
         Assert.AreEqual (8, mNumbers.Capacity);
      }

      [TestMethod]
      public void PopTest () {
         mNumbers.Push (2);
         mNumbers.Push (1);
         mNumbers.Push (3);
         mStackNum.Push (2);
         mStackNum.Push (1);
         mStackNum.Push (3);
         Assert.AreEqual (mStackNum.Pop (), mNumbers.Pop ());
         Assert.IsTrue (mNumbers.Count == 2);
         Assert.AreEqual (mNumbers.Count, mStackNum.Count);
         Assert.AreEqual (1, mNumbers.Pop ());
         Assert.IsTrue (mNumbers.Count == 1);
         mNumbers.Pop ();
         Assert.IsTrue (mNumbers.Count == 0);
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Pop ());
      }

      [TestMethod]
      public void PeekTest () {
         mNumbers.Push (1);
         mNumbers.Push (2);
         mNumbers.Push (3);
         mStackNum.Push (1);
         mStackNum.Push (2);
         mStackNum.Push (3);
         Assert.AreEqual (4, mNumbers.Capacity);
         Assert.AreEqual (3, mNumbers.Peek ());
         Assert.AreEqual (3, mStackNum.Peek ());
         Assert.IsTrue (mNumbers.Count == 3);
         Assert.AreEqual (mNumbers.Pop (), mStackNum.Pop ());
         Assert.AreEqual (mNumbers.Pop (), mStackNum.Pop ());
         Assert.AreEqual (mNumbers.Pop (), mStackNum.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Peek ());
         Assert.IsTrue (mNumbers.IsEmpty);
      }
   }
}