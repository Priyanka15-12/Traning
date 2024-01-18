using Training;
namespace TestProject;

[TestClass]
public class UnitTest1 {

   [TestMethod]
   public void DequeTest () {
      for (int i = 0; i < 4; i++) mDeque.EnqueueRear (i);
      Assert.AreEqual (4, mDeque.Count);
      Assert.AreEqual (0, mDeque.DequeueFront ());
      for (int i = 0; i > -4; i--) mDeque.EnqueueFront (i);
      Assert.AreEqual (7, mDeque.Count);
      Assert.AreEqual (8, mDeque.Capacity);
      for (int i = 0; i < 2; i++) mDeque.DequeueRear ();
      Assert.AreEqual (1, mDeque.PeekRear ());
      Assert.AreEqual (-3, mDeque.PeekFront ());
      mDeque.DequeueRear ();
      mDeque.DequeueRear ();
      Assert.AreEqual (-1, mDeque.DequeueRear ());
      mDeque.DequeueRear ();
      mDeque.DequeueFront ();
      Assert.ThrowsException<InvalidOperationException> (() => mDeque.DequeueRear ());
      Assert.ThrowsException<InvalidOperationException> (() => mDeque.PeekRear ());
   }
   Deque<int> mDeque = new ();
}