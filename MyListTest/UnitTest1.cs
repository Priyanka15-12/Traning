
namespace MyListTest {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void AddTest () {
            mNumbers.Add (1);
            mNumbers.Add (2);
            mListNum.Add (1);
            mListNum.Add (2);
            Assert.AreEqual (mNumbers.Count, mListNum.Count);
            Assert.AreEqual (mNumbers.Capacity, mListNum.Capacity);
            Assert.AreEqual (1, mNumbers[0]);
            mNumbers[2] = 6;
            Assert.AreEqual (6, mNumbers[2]);
            Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[9] = 3, "Item not found in the list");
        }

        [TestMethod]
        public void RemoveTest () {
            mNumbers.Add (1);
            mNumbers.Add (2);
            mListNum.Add (1);
            mListNum.Add (2);
            mNumbers.Remove (1);
            mListNum.Remove (1);
            Assert.AreEqual (mNumbers.Count, mListNum.Count);
            mNumbers.Add (3);
            mListNum.Add (4);
            Assert.IsTrue (mListNum.Remove (4));
            Assert.IsTrue (mNumbers.Remove (3));
            Assert.IsFalse (mNumbers.Remove (5), "Item not found in the list");
            Assert.IsFalse (mListNum.Remove (-2), "Item not found in the list");
        }

        [TestMethod]
        public void ClearTest () {
            mNumbers.Add (1);
            mNumbers.Add (3);
            mListNum.Add (4);
            mListNum.Add (5);
            mNumbers.Clear ();
            mListNum.Clear ();
            Assert.AreEqual (mNumbers.Count, mListNum.Count);
        }

        [TestMethod]
        public void InsertTest () {
            mNumbers.Add (1);
            mNumbers.Add (2);
            mNumbers.Add (4);
            mListNum.Add (1);
            mListNum.Add (2);
            mListNum.Add (3);
            mNumbers.Insert (2, 3);
            mListNum.Insert (2, 5);
            Assert.AreEqual (mNumbers.Count, mListNum.Count);
            Assert.AreEqual (3, mNumbers[2]);
            Assert.AreEqual (5, mListNum[2]);
            mNumbers.Insert (1, 7);
            mListNum.Insert (3, 8);
            Assert.AreEqual (8, mListNum[3]);
            Assert.ThrowsException<ArgumentOutOfRangeException> (() => mNumbers.Insert (7, 6), "Index is out of range");
            Assert.ThrowsException<ArgumentOutOfRangeException> (() => mListNum.Insert (10, 7), "Index is out of range");
        }

        [TestMethod]
        public void RemoveAtTest () {
            mNumbers.Add (1);
            mNumbers.Add (2);
            mNumbers.Add (4);
            mListNum.Add (1);
            mListNum.Add (2);
            mNumbers.RemoveAt (2);
            mListNum.RemoveAt (1);
            Assert.AreEqual (2, mNumbers[1]);
            Assert.AreEqual (1, mListNum[0]);
            Assert.ThrowsException<ArgumentOutOfRangeException> (() => mNumbers.RemoveAt (9), "Index is out of range");
        }

        MyList<int> mNumbers = new ();
        List<int> mListNum = new ();
    }
}