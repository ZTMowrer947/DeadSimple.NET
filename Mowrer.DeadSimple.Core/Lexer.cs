using System.IO;
using System.Collections.Generic;
using Mowrer.DeadSimple.Core.Models;

namespace Mowrer.DeadSimple.Core
{
	/// <summary>
	/// Responsible for splitting the file into tokens which identify which operations to perform.
	/// </summary>
    public static class Lexer
    {
		/// <summary>
		/// Reads the file and converts it into a list of tokens for the parser to, well.. parse.
		/// </summary>
		/// <param name="streamReader">The stream reader of the requested file.</param>
		/// <returns>A list of OperatorChars for the parser to parse through.</returns>
		public static List<OperatorChar> LexFile(StreamReader streamReader)
		{
			// Create list to hold the instructions
			var ops = new List<OperatorChar>();

			// Continue reading characters from the file while there are still some to be read
			while (streamReader.Peek() >= 0)
			{
				// Actually read the character
				var ch = (char)streamReader.Read();
				
				// Create a variable to hold it if it symbolizes an instruction
				OperatorChar op;
				
				// Look at the characters value
				switch (ch)
				{
					// _, +, -, and S become their respective instructions
					case '_':
						op = OperatorChar.Underscore;
						break;

					case '+':
						op = OperatorChar.Plus;
						break;

					case '-':
						op = OperatorChar.Minus;
						break;

					case 'S':
						op = OperatorChar.S;
						break;

					// All other characters are ignored and the loop continues
					default:
						continue;
				}

				// If the character was an instruction, add it to the list
				ops.Add(op);
			}

			// Return the list of instructions
			return ops;
		}
    }
}
