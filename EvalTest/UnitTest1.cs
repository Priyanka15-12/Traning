using Eval;
namespace EvalTest {
   [TestClass]
   public class UnitTest1 {
      Evaluator eval = new ();

      [TestMethod]
      public void TestMethod1 () {
         Dictionary<string, double> mTestCases = new () {
            ["56+23"] = 79, ["2-1"] = 1, ["2*23"] = 46, ["2/4"] = 0.5,
            ["(5*2)-2"] = 8, ["sqrt 256"] = 16, ["sin90"] = 1, ["cos 0"] = 1,
            ["tan 0"] = 0, ["asin 0"] = 0, ["atan 1"] = 45, ["acos0"] = 90,
            ["a=7+3"] = 10, ["---5"] = -5, ["-(5-10)"] = 5, ["sin -90"] = -1,
            ["-sin 90"] = -1, ["-5-+3"] = -8, ["4----------3"] = 7,
            ["2^3"] = 8, ["log1"] = 0, ["exp0"] = 1, ["-2"] = -2, ["2.2+2"] = 4.2
         };
         foreach (var item in mTestCases)
            Assert.AreEqual (eval.Evaluate (item.Key), item.Value);
      }
   }
}