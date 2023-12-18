using System;

using System.Collections.Generic;

namespace Marko2155 {
	public class LBLEd {
		public static void Main(string[] args) {
			List<string> fileContent = new List<string>();
			bool saved = true;
			while(true) {
			string input = Console.ReadLine();

			if (input.StartsWith("?w ") && input.Substring(3) != "") {
				System.IO.File.WriteAllLines(input.Substring(3), fileContent.ToArray());
				saved = true;
				fileContent.Clear();
			} else if (input == "?q") {
				if (fileContent.Count == 0 && saved == true) {
					Environment.Exit(1);
				} else {
					Console.WriteLine("[LBLEd] You have not saved the text you have written. Save it then quit.");
				}
			} else if (input == "?qa") {
				Environment.Exit(0);
			} else if (!input.StartsWith("?")) {
				saved = false;
				fileContent.Add(input);
			} else if (input.StartsWith("?wq ") && input.Substring(4) != "") {
				System.IO.File.WriteAllLines(input.Substring(4), fileContent.ToArray());
				saved = true;
				fileContent.Clear();
				Environment.Exit(2);
			} else if (input == "?dll") {
				fileContent.RemoveAt(fileContent.Count - 1);
			}
			}
		}
	}
}
