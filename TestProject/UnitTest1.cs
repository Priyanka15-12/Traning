namespace Training.EState;

[TestClass]
public class UnitTest1 {

   [TestMethod]
   public void FileParseTest () {
      Assert.AreEqual ("C", Program.GetParsedFilePath ("C:\\PROGRAM\\DATA.EXT").drive);
      Assert.AreEqual ("PROGRAM", Program.GetParsedFilePath ("C:\\PROGRAM\\DATA.EXT").folder);
      Assert.AreEqual ("DATA", Program.GetParsedFilePath ("C:\\PROGRAM\\DATA.EXT").file);
      Assert.AreEqual ("EXT", Program.GetParsedFilePath ("C:\\PROGRAM\\DATA.EXT").ext);
      Assert.IsTrue (Program.CheckFilePath ("C:\\PROGRAM\\DATA.EXT"));
      Assert.IsTrue (Program.CheckFilePath ("W:\\TRAINING\\PROGRAM.CS"));
      Assert.IsTrue (Program.CheckFilePath ("W:/TRAINING\\PROGRAM.CS"));
      Assert.IsTrue (Program.CheckFilePath ("W:\\TRAINING/PROGRAM.CS"));
      Assert.AreEqual ((true, "C", "USERS\\DOWNLOADS", "ASSIGNMENT", "DOCX"),
         Program.GetParsedFilePath ("C:\\USERS\\DOWNLOADS\\ASSIGNMENT.DOCX"));
      Assert.AreEqual ((true, "C", "PROGRAM", "DATA", "EXT"), Program.GetParsedFilePath ("C:/PROGRAM/DATA.EXT"));
   }

   [TestMethod]
   public void InValidFileParser () {
      string[] filePaths = { "C:\\DATA.EXT", "W:\\TRAINING\\.CS", "W:\\TRAINING\\PROGRAM" ,
         "W:\\TRAINING\\CS" ,"WW:\\TRAINING\\PROGRAM", "W:\\\\TRAINING\\PROGRAM",
         "W:\\PROGRAM\\", ":\\PROGRAM\\DATA.CS", "W\\PROGRAM\\DATA.CS",
         "\\W:PROGRAM.CS", "W:\\PROGRAM\\DATA.CS~" };
      foreach (var filePath in filePaths)
         Assert.IsFalse (Program.CheckFilePath (filePath));
   }
}