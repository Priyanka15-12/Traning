
namespace MyListTest {
    [TestClass]
    public class UnitTest1 {
        MyList<int> mNumList = new ();
        [TestMethod]
        public void AddTest () {
            mNumList.Add (1);
            mNumList.Add (2);
            mNumList.Add (3);
            mNumList.Add (4);
            mNumList.Add (5);
            Assert.AreEqual (5, mNumList.Count);
            Assert.AreEqual (8, mNumList.Capacity);
            Assert.AreEqual (1, mNumList[0]);
            mNumList[2] = 6;
            Assert.AreEqual (6, mNumList[2]);
            Assert.ThrowsException<IndexOutOfRangeException> (() => mNumList[9] = 3, "Item not found in the list");
        }
        [TestMethod]
        public void RemoveTest () {
            mNumList.Add (1);
            mNumList.Add (2);
            mNumList.Remove (1);
            Assert.AreEqual (1, mNumList.Count);
            mNumList.Add (3);
            Assert.IsTrue (mNumList.Remove (3));
            Assert.IsFalse (mNumList.Remove (5), "Item not found in the list");
            Assert.IsFalse (mNumList.Remove (-2), "Item not found in the list");
        }
        [TestMethod]
        public void ClearTest () {
            mNumList.Add (1);
            mNumList.Add (1);
            mNumList.Add (3);
            mNumList.Clear ();
            Assert.AreEqual (0, mNumList.Count);
        }
        [TestMethod]
        public void InsertTest () {
            mNumList.Add (1);
            mNumList.Add (2);
            mNumList.Add (4);
            mNumList.Insert (2, 3);
            Assert.AreEqual (4, mNumList.Count);
            Assert.AreEqual (3, mNumList[2]);
            mNumList.Insert (1, 7);
            Assert.ThrowsException<IndexOutOfRangeException> (() => mNumList.Insert (7, 6), "Index is out of range");

        }
        [TestMethod]
        public void RemoveAtTest () {
            mNumList.Add (1);
            mNumList.Add (2);
            mNumList.Add (4);
            mNumList.Add (2);
            mNumList.Add (1);
            mNumList.RemoveAt (2);
            Assert.ThrowsException<IndexOutOfRangeException> (() => mNumList.RemoveAt (9), "Index is out of range");
        }
    }
}