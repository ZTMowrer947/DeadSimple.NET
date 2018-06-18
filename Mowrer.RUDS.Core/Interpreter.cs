using System;
using System.IO;

namespace Mowrer.RUDS.Core
{
	/// <summary>
	/// The main class that calls upon the Lexer and Parser to interpret the file recieved as an argument.
	/// </summary>
    public class Interpreter
    {
		/// <summary>
		/// The function that runs the whole show.
		/// </summary>
		/// <param name="args">The arguments to the function. This should only contain the filename.</param>
        public static void Main(string[] args)
        {
			// Display usage message if # of arguments is wrong
			if (args.Length == 0 || args.Length > 1)
				Console.WriteLine("Usage: dotnet ruds.dll FILE_NAME.uds");
			else
				// Otherwise, attempt to open the file
				try
				{
					// If the file doesn't exist, show a message
					if (!File.Exists(args[0]))
						Console.WriteLine($"{args[0]} does not exist");

					// Create a StreamReader for the file that will be automatically be disposed
					using (StreamReader streamReader = new StreamReader(args[0]))
					{
						// Lex the file to get all the operations we need to perform
						var operations = Lexer.LexFile(streamReader);

						// Parse the file to perform the operations
						Parser.ParseFile(operations);
					}
				}
				// If any error occurs, display it to the console
				catch (Exception e)
				{
					Console.WriteLine($"Error: {e}");
				}
        }
    }
}
