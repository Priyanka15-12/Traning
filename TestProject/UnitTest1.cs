namespace TestProject {
   [TestClass]
   public class UnitTest1 {
      [TestMethod]
      public void DoubleParseTest () {
         Assert.AreEqual (Double.Parse ("667.9"), double.Parse ("667.9"));
         Assert.AreEqual (Double.Parse ("66989"), double.Parse ("66989"));
         Assert.AreEqual (Double.Parse ("+667.9"), double.Parse ("+667.9"));
         Assert.AreEqual (Double.Parse ("-877.86e2"), double.Parse ("-877.86e2"));
         Assert.AreEqual (Double.Parse ("+34.34e45"), double.Parse ("+34.34e45"));
         Assert.AreEqual (Double.Parse ("-32.56e-34"), double.Parse ("-32.56e-34"));
         Assert.AreEqual (Double.Parse ("-45.e+234"), double.Parse ("-45.e+234"));
         Assert.AreEqual (Double.Parse ("+1.e-1"), double.Parse ("+1.e-1"));
         Assert.AreEqual (Double.Parse ("0.0"), double.Parse ("0.0"));
         Assert.AreEqual (Double.Parse ("0"), double.Parse ("0"));
         Assert.AreEqual (Double.Parse (".023e4"), double.Parse (".023e4"));
         Assert.AreEqual (Double.Parse ("-.03e4"), double.Parse ("-.03e4"));
         Assert.AreEqual (Double.Parse ("+.2e+3"), double.Parse ("+.2e+3"));
         Assert.AreEqual (Double.Parse ("0.2e3"), double.Parse ("0.2e3"));
         Assert.AreEqual (Double.Parse ("67.e34"), double.Parse ("67.e34"));
         Assert.AreEqual (Double.Parse ("6e34"), double.Parse ("6e34"));
         Assert.AreEqual (Double.Parse ("6734"), double.Parse ("6734"));
         Assert.AreEqual (Double.Parse ("67."), double.Parse ("67."));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("e34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("+e34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("-e34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("e+34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("e-34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("e3-4"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("3/.e34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("79.+e34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("34+e34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("67.8e3.4"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("67.8e1+4"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("67.8e3.4"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("67.8e3.4"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("67e8e3.4"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("87.6e3+"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("67.6a34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse ("67.6.34"));
         Assert.ThrowsException<FormatException> (() => Double.Parse (".e34"));
      }
   }
}