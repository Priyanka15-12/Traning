using Training;
namespace QueueTest {
   [TestClass]
   public class UnitTest1 {
      TQueue<int> mTQueue = new ();
      Queue<int> mQueue = new ();

      [TestMethod]
      public void EnqueueTest () {
         for (int i = 1; i <= 5; i++) {
            mTQueue.Enqueue (i);
            mQueue.Enqueue (i);
         }
         Assert.AreEqual (5, mTQueue.Count);
         Assert.AreEqual (4, mQueue.Count);
         for (int i = 1; i <= 2; i++)
            mTQueue.Enqueue (i);
         Assert.AreEqual (7, mTQueue.Count);
         Assert.AreEqual (8, mTQueue.Capacity);
      }

      [TestMethod]
      public void DequeueTest () {
         for (int i = 1; i <= 5; i++) {
            mTQueue.Enqueue (i);
            mQueue.Enqueue (i);
         }
         Assert.AreEqual (mTQueue.Dequeue (), mQueue.Dequeue ());
         Assert.IsFalse (mTQueue.IsEmpty);
         Assert.AreEqual (mTQueue.Dequeue (), mQueue.Dequeue ());
         mTQueue.Enqueue (6);
         mTQueue.Enqueue (7);
         mQueue.Enqueue (6);
         mQueue.Enqueue (7);
         Assert.AreEqual (5, mTQueue.Count);
         Assert.AreEqual (5, mQueue.Count);
         (var a, var b) = (mTQueue.Count, mQueue.Count);
         for (int i = 0; i < a; i++) mTQueue.Dequeue ();
         for (int i = 0; i < b; i++) mQueue.Dequeue ();
         Assert.IsTrue (mTQueue.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => mTQueue.Dequeue (), "Dequeue cannot be done in an empty queue");
         Assert.ThrowsException<InvalidOperationException> (() => mQueue.Dequeue (), "Dequeue cannot be done in an empty queue");
      }

      [TestMethod]
      public void PeekTest () {
         for (int i = 1; i <= 3; i++)
            mTQueue.Enqueue (i);
         for (int i = 1; i <= 5; i += 2)
            mQueue.Enqueue (i);
         Assert.AreEqual (mTQueue.Peek (), mQueue.Peek ());
         mTQueue.Dequeue ();
         mQueue.Dequeue ();
         Assert.AreEqual (2, mTQueue.Peek ());
         Assert.AreEqual (3, mQueue.Peek ());
         mTQueue.Dequeue ();
         mTQueue.Dequeue ();
         Assert.ThrowsException<InvalidOperationException> (() => mTQueue.Peek (), "Peek cannot be done in an empty queue");
      }
   }
}