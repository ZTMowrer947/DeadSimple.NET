using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Mowrer.RUDS.Core.Models;

namespace Mowrer.RUDS.Core
{
    public static class Lexer
    {
		public static List<OperatorChar> LexFile(StreamReader streamReader)
		{
			var ops = new List<OperatorChar>();

			while (streamReader.Peek() >= 0)
			{
				var ch = (char)streamReader.Read();
				
				OperatorChar op;
					
				switch (ch)
				{
					case 'R':
						op = OperatorChar.R;
						break;

					case 'U':
						op = OperatorChar.U;
						break;

					case 'D':
						op = OperatorChar.D;
						break;

					case 'S':
						op = OperatorChar.S;
						break;

					default:
						continue;
				}

				ops.Add(op);
			}

			return ops;
		}
    }
}
