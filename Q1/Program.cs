using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int N = 1;
			while ((1 + N) * N / 2 < 105)
			{
				N += 1;
			}
			Console.WriteLine(N);
		}
	}
}
