using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int i = new int();
			while (i <= 300)
			{
				i += 1;
				var root = 300 % i;
				if (root == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
