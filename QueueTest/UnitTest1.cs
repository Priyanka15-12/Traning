using Training;
namespace QueueTest {
   [TestClass]
   public class UnitTest1 {
      TQueue<int> mNumbers = new ();
      Queue<int> mQueueNum = new ();

      [TestMethod]
      public void EnqueueTest () {
         mNumbers.Enqueue (1);
         mNumbers.Enqueue (2);
         mNumbers.Enqueue (3);
         mQueueNum.Enqueue (1);
         mQueueNum.Enqueue (2);
         mQueueNum.Enqueue (3);
         Assert.AreEqual (mNumbers.Count, mQueueNum.Count);
         mNumbers.Enqueue (4);
         mNumbers.Enqueue (5);
         Assert.AreEqual (8, mNumbers.Capacity);
      }

      [TestMethod]
      public void DequeueTest () {
         mNumbers.Enqueue (1);
         mNumbers.Enqueue (2);
         mNumbers.Enqueue (3);
         mQueueNum.Enqueue (1);
         mQueueNum.Enqueue (2);
         mQueueNum.Enqueue (3);
         Assert.AreEqual (mNumbers.Dequeue (), mQueueNum.Dequeue ());
         Assert.IsFalse (mNumbers.IsEmpty);
         Assert.AreEqual (mNumbers.Dequeue (), mQueueNum.Dequeue ());
         Assert.AreEqual (mNumbers.Dequeue (), mQueueNum.Dequeue ());
         Assert.IsTrue (mNumbers.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Dequeue (), "Dequeue can't do in empty queue");
      }

      [TestMethod]
      public void PeekTest () {
         mNumbers.Enqueue (1);
         mNumbers.Enqueue (2);
         mNumbers.Enqueue (3);
         mQueueNum.Enqueue (1);
         mQueueNum.Enqueue (2);
         mQueueNum.Enqueue (3);
         Assert.AreEqual (mNumbers.Peek (), mQueueNum.Peek ());
         mNumbers.Dequeue ();
         Assert.AreEqual (2, mNumbers.Peek ());
      }
   }
}