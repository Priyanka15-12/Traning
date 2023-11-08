using Training;
namespace TStackTest {
   [TestClass]
   public class UnitTest1 {
      TStack<int> mNumbers = new ();

      [TestMethod]
      public void PushTest () {
         mNumbers.Push (1);
         mNumbers.Push (2);
         mNumbers.Push (3);
         mNumbers.Push (4);
         Assert.AreEqual (4, mNumbers.Count);
         Assert.AreEqual (4, mNumbers.Capacity);
         mNumbers.Push (5);
         Assert.IsFalse (mNumbers.IsEmpty);
         Assert.AreEqual (5, mNumbers.Count);
         Assert.AreEqual (8, mNumbers.Capacity);
      }

      [TestMethod]
      public void PopTest () {
         mNumbers.Push (2);
         mNumbers.Push (1);
         mNumbers.Push (3);
         Assert.IsTrue (mNumbers.Count == 3);
         Assert.AreEqual (3, mNumbers.Pop ());
         Assert.IsTrue (mNumbers.Count == 2);
         mNumbers.Pop ();
         mNumbers.Pop ();
         Assert.IsTrue (mNumbers.Count == 0);
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Pop ());
      }

      [TestMethod]
      public void PeekTest () {
         mNumbers.Push (1);
         mNumbers.Push (2);
         mNumbers.Push (3);
         Assert.AreEqual (4, mNumbers.Capacity);
         Assert.AreEqual (3, mNumbers.Peek ());
         Assert.IsTrue (mNumbers.Count == 3);
         Assert.AreEqual (3, mNumbers.Pop ());
         Assert.AreEqual (2, mNumbers.Pop ());
         Assert.AreEqual (1, mNumbers.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Peek ());
         Assert.IsTrue (mNumbers.IsEmpty);

      }
   }
}