namespace Training.EState;

[TestClass]
public class UnitTest1 {

   [TestMethod]
   public void FileParseTest () {
      Assert.AreEqual (("C", "PROGRAM", "DATA", "EXT"), Program.GetParsedFilePath ("C:\\PROGRAM\\DATA.EXT"));
      Assert.AreEqual (("W", "TRAINING", "PROGRAM", "CS"), Program.GetParsedFilePath ("W:\\TRAINING\\PROGRAM.CS"));
      Assert.AreEqual (("C", "USERS\\DOWNLOADS", "ASSIGNMENT", "DOCX"), Program.GetParsedFilePath ("C:\\USERS\\DOWNLOADS\\ASSIGNMENT.DOCX"));
      Assert.AreEqual (("C", "PROGRAM", "DATA", "EXT"), Program.GetParsedFilePath ("C:/PROGRAM/DATA.EXT"));
      Assert.AreEqual (("W", "TRAINING", "PROGRAM", "CS"), Program.GetParsedFilePath ("W:/TRAINING\\PROGRAM.CS"));
      Assert.AreEqual (("W", "TRAINING", "PROGRAM", "CS"), Program.GetParsedFilePath ("W:\\TRAINING/PROGRAM.CS"));
   }

   [TestMethod]
   public void InValidFileParser () {
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("C:\\DATA.EXT"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("W:\\TRAINING\\.CS"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("W:\\TRAINING\\PROGRAM"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("W:\\TRAINING\\CS"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("WW:\\TRAINING\\PROGRAM"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("W:\\\\TRAINING\\PROGRAM"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("W:\\PROGRAM\\"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath (":\\PROGRAM\\DATA.CS"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("W\\PROGRAM\\DATA.CS"));
      Assert.ThrowsException<InValidPathException> (() => Program.GetParsedFilePath ("W:PROGRAM.CS"));
   }
}