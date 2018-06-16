using Mowrer.RUDS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mowrer.RUDS.Core
{
    public static class Parser
    {
		public static void ParseFile(List<OperatorChar> operations)
		{
			int stack = 0;

			foreach (var op in operations)
			{
				switch (op)
				{
					case OperatorChar.R:
						stack = 0;
						break;

					case OperatorChar.U:
						stack++;
						break;

					case OperatorChar.D:
						stack--;
						break;

					case OperatorChar.S:
						Console.Write((char)stack);
						break;
				}
			}
		}
    }
}
