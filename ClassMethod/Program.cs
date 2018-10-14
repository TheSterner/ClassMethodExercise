using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			MathSubClass mathSubClass = new MathSubClass();
			Console.WriteLine("Pick pick a number between 1-50.");
			int userNumIn = Convert.ToInt32(Console.ReadLine());
			mathSubClass.DivUserNum(userNumIn);
			int timesUserNum = MathSubClass.TimesUserNumber(userNumIn);
			Console.WriteLine("Your number times 3 is: " + timesUserNum);
			Console.ReadLine();

		}
	}
}
