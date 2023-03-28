using System;
namespace Lec_1
{
	public class LearningParameters
	{

		public int PassByValue(int a, int b)
		{
			a = 100;
			b = 200;
			Console.WriteLine("a = {0}, b = {1}, sum = {2} inside function", a, b, a + b);
			return a + b;
		}

		public int PassByReference(ref int a, ref int b)
		{
			a = 100;
			b = 200;
            Console.WriteLine("a = {0}, b = {1}, sum = {2} inside function", a, b, a + b);
            return a + b;
		}
		public bool Author(string uname, string pass, out string msg)
		{
			msg = "";
			if (uname == "bob" && pass == "smith")
			{
				msg = "verified";
				return true;
			}
			else
			{
				msg = "not verified";
				return false;
			}
		
		}
		public void ParamsLearning(int a, string str, params int[] ints) //Formal parameters
			//params must at end

		{
			int sum = 0;
			for (int i = 0; i < ints.Length; i++)
			{
				sum += ints[i];
			}
			Console.WriteLine(sum);
		}


	}
}

