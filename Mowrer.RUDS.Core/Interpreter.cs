using System;
using System.IO;

namespace Mowrer.RUDS.Core
{
    public class Interpreter
    {
        public static void Main(string[] args)
        {
			if (args.Length == 0 || args.Length > 1)
				Console.WriteLine("Usage: dotnet ruds.dll FILE_NAME.uds");
			else
				try
				{
					if (!File.Exists(args[0]))
						Console.WriteLine($"{args[0]} does not exist");

					using (StreamReader streamReader = new StreamReader(args[0]))
					{
						var operations = Lexer.LexFile(streamReader);
						Parser.ParseFile(operations);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine($"Error: {e}");
				}
        }
    }
}
