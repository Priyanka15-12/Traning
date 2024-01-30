// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Implement file name parser with state machine. Every file name has the components drive letter A to Z, colon,
// then one or more directory names followed by the actual file name which must always have an extension.
// Only uppercase letters allowed just A to Z and all these components must be there and return the drive letter, 
// the folder without any slash before or after and the actual file name. The return value can be a tuple with four strings.
// --------------------------------------------------------------------------------------------
using static EState;
namespace Training {
   #region Program ----------------------------------------------------------------------------
   /// <summary>Implement file name parser with state machine</summary>
   public class Program {
      #region Methods -----------------------------------------------
      /// <summary>Gets user input as a filepath and parse it</summary>
      static void Main () {
         for (; ; ) {
            Console.Write ("File Path: ");
            string fileName = Console.ReadLine ();
            if (fileName == "") break; // Exits when no input is provided.
            (bool isValid, string drive, string folder, string file, string ext) = GetParsedFilePath (fileName);
            if (isValid) {
               Console.Write ($"Drive     : {drive}\r\n" +
                              $"Folder    : {folder}\r\n" +
                              $"Filename  : {file}\r\n" +
                              $"Extension : {ext}\n\n");
            } else Console.WriteLine ("Invalid File path");
         }
      }

      /// <summary>Parse the file path</summary>
      /// <param name="filePath">String file path</param>
      /// <returns>Returns bool for path is valid or not, drive, folder, 
      /// filename and extension as tuple of four string</returns>
      public static (bool isValid, string drive, string folder, string file, string ext) GetParsedFilePath (string filePath) {
         filePath = (filePath + '~').Replace ('/', '\\').ToUpper ();
         EState s = A;
         Action none = () => { }, todo;
         string drive = "", folder = "", file = "", ext = "";
         foreach (var ch in filePath) {
            (s, todo) = (s, ch) switch {
               (A, >= 'A' and <= 'Z') => (B, () => drive = ch.ToString ()),
               (B, ':') => (C, none),
               (C, '\\') => (D, none),
               (D or E, >= 'A' and <= 'Z') => (E, () => folder += ch),
               (E or G, '\\') => (F, () => { file += ch; (folder, file) = (folder + file, ""); }),
               (F or G, >= 'A' and <= 'Z') => (G, () => file += ch),
               (G, '.') => (H, none),
               (H or I, >= 'A' and <= 'Z') => (I, () => ext += ch),
               (I, '~') => (J, none),
               _ => (Z, none)
            };
            todo ();
         }
         return s == J ? (true, drive, folder.Remove (folder.Length - 1), file, ext) : (false, "", "", "", "");
      }

      public static bool CheckFilePath (string filePath) => GetParsedFilePath (filePath).isValid;
      #endregion
   }
   #endregion
}

/// <summary>States of the file path</summary>
/// State Transition diagram: file://W://Traning//FileParser.jpg
public enum EState { A, B, C, D, E, F, G, H, I, J, Z };