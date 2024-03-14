using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
	internal static class Utility
	{
		public static string GetStringInput(string message)
		{
			Console.WriteLine(message);
			return Console.ReadLine();
		}

		public static int GetIntInput(string message)
		{
			string input = GetStringInput(message);
			int res;
			if (int.TryParse(input, out res))
			{
				return res;
			}
			else { return 0; }
		}

	}
}
