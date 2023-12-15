using Training;
namespace TestProject {
   [TestClass]
   public class UnitTest1 {
      MyDouble mMyDouble = new ();

      [TestMethod]
      public void DoubleParseValid () {
         string[] inputs = {"0","0.0","-8772","-.03e4","-45.e+234","-32.56E-34","-877.86e2","+667.9","+34.3e4",
               "+1.e-1","+.2e+3","667.9","66989",".023e4","0.2e3","67.e34","67.e+4","6e3","6734",".734",".73e4","67."};
         foreach (string input in inputs)
            Assert.AreEqual (double.Parse (input), mMyDouble.Parse (input));
      }

      [TestMethod]
      public void DoubleParseInvalid () {
         string[] inputs = {"e34","+e34","-e34","e+34","e-34",".e34","e3-4","4e3.4","3/.e34","34+e34","79.+e34","87.6e3+",
            "67.6.34","67.6a34","67.8e3.4","67.8e1+4","67.8e3.4","67.8e3.4","67e8e3.4","+3+3.e-2","+3-3.e+2"};
         foreach (string input in inputs)
            Assert.ThrowsException<FormatException> (() => mMyDouble.Parse (input));
      }
   }
}