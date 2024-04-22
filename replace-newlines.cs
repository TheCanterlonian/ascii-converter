using System;
using System.IO;
using System.Text;
namespace replaceNewlines
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("\n");
			if (! (File.Exists("file.txt")))
			{
				File.Create("file.txt");
			}
			string s = File.ReadAllText("file.txt");
			if (s.Contains("\n"))
			{
				s = s.Replace("\n", @"\n");
			}
			else if (s.Contains(@"\n"))
			{
				s = s.Replace(@"\n", "\n");
			}
			else
			{
				s = "This string has neither newlines nor the symbols to create newlines.";
			}
			Console.WriteLine(s);
			return;
		}
	}
}
