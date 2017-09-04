using System;
namespace FacebookImageDownloader.Helpers
{
    public class ConsoleHelper
    {
		public static void WriteLineColorRed(string values)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(values);
			Console.ResetColor();
		}

		public static void WriteLineColorGreen(string values)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(values);
			Console.ResetColor();
		}

		public static void WriteLineColorBlue(string values)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(values);
			Console.ResetColor();
		}
    }
}
