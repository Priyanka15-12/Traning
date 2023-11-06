using Training;
namespace TStackTest {
   [TestClass]
   public class UnitTest1 {
      [TestMethod]
      public void PushTest () {
         TStack<int> numbers = new ();
         numbers.Push (1);
         numbers.Push (2);
         numbers.Push (3);
         numbers.Push (4);
         Assert.AreEqual (4, numbers.Count);
         Assert.AreEqual (4, numbers.Capacity);
         numbers.Push (5);
         Assert.IsTrue (numbers.IsEmpty == false);
         Assert.AreEqual (5, numbers.Count);
         Assert.AreEqual (8, numbers.Capacity);
      }
      [TestMethod]
      public void PopTest () {
         TStack<int> numbers = new ();
         numbers.Push (1);
         numbers.Push (2);
         numbers.Push (3);
         Assert.IsTrue (numbers.Count == 3);
         Assert.AreEqual (3, numbers.Pop ());
         Assert.IsTrue (numbers.Count == 2);
         numbers.Pop ();
         numbers.Pop ();
         Assert.IsTrue (numbers.Count == 0);
         Assert.ThrowsException<InvalidOperationException> (() => numbers.Pop ());
      }
      [TestMethod]
      public void PeekTest () {
         TStack<int> numbers = new ();
         numbers.Push (1);
         numbers.Push (2);
         numbers.Push (3);
         Assert.AreEqual (4, numbers.Capacity);
         Assert.AreEqual (3, numbers.Peek ());
         Assert.IsTrue (numbers.Count == 3);
         Assert.AreEqual (3, numbers.Pop ());
         Assert.AreEqual (2, numbers.Pop ());
         Assert.AreEqual (1, numbers.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => numbers.Peek ());
         Assert.IsTrue (numbers.IsEmpty == true);

      }
   }
}