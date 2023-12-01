using Training;
namespace TestProject {
   [TestClass]
   public class UnitTest1 {
      [TestMethod]
      public void DoubleParseValid () {
         Assert.AreEqual (double.Parse ("0"), MyDouble.Parse ("0"));
         Assert.AreEqual (double.Parse ("0.0"), MyDouble.Parse ("0.0"));
         Assert.AreEqual (double.Parse ("-8772"), MyDouble.Parse ("-8772"));
         Assert.AreEqual (double.Parse ("-.03e4"), MyDouble.Parse ("-.03e4"));
         Assert.AreEqual (double.Parse ("-45.e+234"), MyDouble.Parse ("-45.e+234"));
         Assert.AreEqual (double.Parse ("-32.56e-34"), MyDouble.Parse ("-32.56E-34"));
         Assert.AreEqual (double.Parse ("-877.86E2"), MyDouble.Parse ("-877.86e2"));
         Assert.AreEqual (double.Parse ("+667.9"), MyDouble.Parse ("+667.9"));
         Assert.AreEqual (double.Parse ("+34.3e4"), MyDouble.Parse ("+34.3e4"));
         Assert.AreEqual (double.Parse ("+1.e-1"), MyDouble.Parse ("+1.e-1"));
         Assert.AreEqual (double.Parse ("+.2e+3"), MyDouble.Parse ("+.2e+3"));
         Assert.AreEqual (double.Parse ("667.9"), MyDouble.Parse ("667.9"));
         Assert.AreEqual (double.Parse ("66989"), MyDouble.Parse ("66989"));
         Assert.AreEqual (double.Parse (".023e4"), MyDouble.Parse (".023e4"));
         Assert.AreEqual (double.Parse ("0.2e3"), MyDouble.Parse ("0.2e3"));
         Assert.AreEqual (double.Parse ("67.e34"), MyDouble.Parse ("67.e34"));
         Assert.AreEqual (double.Parse ("67.e+4"), MyDouble.Parse ("67.e+4"));
         Assert.AreEqual (double.Parse ("6e3"), MyDouble.Parse ("6e3"));
         Assert.AreEqual (double.Parse ("6734"), MyDouble.Parse ("6734"));
         Assert.AreEqual (double.Parse (".734"), MyDouble.Parse (".734"));
         Assert.AreEqual (double.Parse (".73e4"), MyDouble.Parse (".73e4"));
         Assert.AreEqual (double.Parse ("67."), MyDouble.Parse ("67."));
      }

      [TestMethod]
      public void DoubleParseInvalid () {
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("e34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("+e34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("-e34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("e+34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("e-34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse (".e34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("e3-4"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("4e3.4"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("3/.e34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("34+e34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("79.+e34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("87.6e3+"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("67.6.34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("67.6a34"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("67.8e3.4"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("67.8e1+4"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("67.8e3.4"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("67.8e3.4"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("67e8e3.4"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("+3+3.e-2"));
         Assert.ThrowsException<FormatException> (() => MyDouble.Parse ("+3-3.e+2"));
      }
   }
}