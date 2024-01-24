namespace Training {
   internal class Program {
      static void Main (string[] args) {
         string[] read = File.ReadAllLines ("C:\\etc\\input.txt");
         Console.WriteLine (Game (read));
         static int Game (string[] str) {
            List<int> validList = new ();
            List<int> invalidList = new ();
            for (int k = 0; k < str.Length; k++) {
               str[k] = str[k].Replace (',', ' ');
               string[] games = str[k].Split (';');
               List<int> bluelist = new ();
               List<int> redlist = new ();
               List<int> greenlist = new ();
               for (int j = 0; j < games.Length; j++) {
                  string[] parts = games[j].Split (' ');
                  for (int i = 0; i < parts.Length; i++) {
                     if (parts[i] == "blue") bluelist.Add (int.Parse (parts[i - 1]));
                     else if (parts[i] == "red") redlist.Add (int.Parse (parts[i - 1]));
                     else if (parts[i] == "green") greenlist.Add (int.Parse (parts[i - 1]));
                  }
               }
               int blueCount = bluelist.Sum (), redCount = redlist.Sum (), greenCount = greenlist.Sum ();
               if (blueCount <= 14 && redCount <= 12 && greenCount <= 13)
                  validList.Add (k + 1);
            }
            for (int i = 0; i < validList.Count; i++)
               Console.WriteLine (validList[i]);
            return validList.Sum ();
         }
      }
   }
}