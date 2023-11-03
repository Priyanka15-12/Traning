
namespace MyListTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void AddTest () {
            MyList<int> mNumList = new ();
            mNumList.Add (1);
            mNumList.Add (2);
            mNumList.Add (3);
            mNumList.Add (4);
            mNumList.Add (5);
            Assert.AreEqual (5, mNumList.Count);
            Assert.AreEqual (8, mNumList.Capacity);
            Assert.AreEqual (1, mNumList[0]);
            mNumList[2] = 6;
            Assert.AreEqual (6, mNumList[2 ]);
            Assert.ThrowsException<IndexOutOfRangeException> (() => mNumList[9] = 3, "Item not found in the list");

        }
        [TestMethod]
        public void RemoveTest () {
            MyList<int> numList = new ();
            numList.Add (1);
            numList.Add (2);
            numList.Remove (1);
            Assert.AreEqual (1, numList.Count);
            Assert.ThrowsException<InvalidOperationException> (() => numList.Remove (5), "Item not found in the list");
            Assert.ThrowsException<IndexOutOfRangeException> (() => numList[-2]);
        }
        [TestMethod]
        public void ClearTest () {
            MyList<int> numList = new ();
            numList.Add (1);
            numList.Add (1);
            numList.Add (3);
            numList.Clear ();
            Assert.AreEqual (0, numList.Count);
        }
        [TestMethod]
        public void InsertTest () {
            MyList<int> numList = new ();
            numList.Add (1);
            numList.Add (2);
            numList.Add (4);
            numList.Insert (2, 3);
            Assert.AreEqual (4, numList.Count);
            Assert.AreEqual (3, numList[2]);
            numList.Insert (1, 7);
            Assert.ThrowsException<IndexOutOfRangeException> (() => numList.Insert (7, 6), "Index is out of range");

        }
        [TestMethod]
        public void RemoveAtTest () {
            MyList<int> numList = new ();
            numList.Add (1);
            numList.Add (2);
            numList.Add (4);
            numList.Add (2);
            numList.Add (1);
            numList.RemoveAt (2);
            Assert.ThrowsException<IndexOutOfRangeException> (() => numList.RemoveAt (9), "Index is out of range");
        }
    }
}
