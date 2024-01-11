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
            Console.Write ("File name: ");
            string fileName = Console.ReadLine ();
            if (fileName == "") break; // Exits when no input is provided.
            try {
               (string drive, string folder, string file, string ext) = GetParsedFilePath (fileName);
               Console.Write ($"Drive     : {drive}\n" +
                              $"Folder    : {folder}\n" +
                              $"File      : {file}\n" +
                              $"Extension : {ext}\n\n");
            } catch (InValidPathException e) { Console.Write (e.Message + "\n\n"); }
         }
      }

      /// <summary>Parse the file path</summary>
      /// <param name="filePath">String file path</param>
      /// <returns>Returns drive, folder, filename and extension as tuple of four string</returns>
      public static (string, string, string, string) GetParsedFilePath (string filePath) {
         filePath = (filePath + '~').Replace ('/', '\\');
         EState s = A;
         int firstSlash = filePath.IndexOf ('\\'),
             lastSlash = filePath.LastIndexOf ("\\"), dotIndex = filePath.IndexOf ('.');
         Action none = () => { }, todo;
         string drive = "", folder = "", file = "", ext = "";
         foreach (var ch in filePath) {
            (s, todo) = (s, ch) switch {
               (A, >= 'A' and <= 'Z') => (B, none),
               (B, ':') => (C, () => drive = filePath[0].ToString ()),
               (C, '\\') => (D, none),
               (D or E, >= 'A' and <= 'Z') => (E, none),
               (E or G, '\\') => (F, () => folder = filePath[(firstSlash + 1)..lastSlash]),
               (F or G, >= 'A' and <= 'Z') => (G, none),
               (G, '.') => (H, () => file = filePath[(lastSlash + 1)..dotIndex]),
               (H or I, >= 'A' and <= 'Z') => (I, none),
               (I, '~') => (J, () => ext = filePath[(dotIndex + 1)..(filePath.Length - 1)]),
               _ => (Z, none)
            };
            todo ();
         }
         return s == J ? (drive, folder, file, ext) : throw new InValidPathException ("Invalid file path!");
      }
      #endregion
   }
   #endregion
}

/// <summary>Class for invalid file path exception</summary>
#region InValidPathException -------------------------------------------------------------------  
public class InValidPathException : Exception {
   public InValidPathException (string message) : base (message) { }
}
#endregion

/// <summary>States of file path</summary>
public enum EState { A, B, C, D, E, F, G, H, I, J, Z };

///<summary>Have a look at the State Transition diagram</summary>
///See file://W://Traning//FileParser.jpg