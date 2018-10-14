using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
	public class MathSubClass
	{
		public void DivUserNum(int userNum)
		{
			//TempUserNum2 = new int(TempUserNum);

			for (int j = 0; j < userNum;)
			{
				int divUserNum1 = userNum / 2;
				//userNum = divUserNum1;
				Console.WriteLine("Your number divided by 2 is: " + divUserNum1);
				return;
			}
		}

		public int TempUserNum { get; set; }

		public static int TimesUserNumber(int j)
		{
			return j * 3;
		}


		//public void SubUserNum(int userNum2, int times =1)
		//{
		//	for (int i=0; i< userNum2; i++)
		//	{
		//		int subUserNum = userNum2 - 10;
		//		userNum2 = subUserNum;
		//	}

		//}
	}
}
