using System;
public class A
{

	public static void Main()
	{
		Console.WriteLine("limit");

		int n = Convert.ToInt32(Console.ReadLine());

		//var c = "";
		//int m = 0;
		//int k = 0;
		int[] a = new int[n];
Console.WriteLine("elements");
 
		for (int i = 0; i < n; i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());

		}

		int j = oddout(a);
		Console.WriteLine(j);

	}
	public static int oddout(int[] a)
	{
		int c = 0;
		int n = a.Length;
		int j = 0;
		int[] b = new int[n];
		int k;
		//int h=0;
		b = (int[])a.Clone();

		do
		{
			k = b[j];
			for (int i = 0; i < a.Length; i++)
			{
				
				if (a[i] == k)
				{
					c++;
				}


			}

			if (c % 2 != 0)
			{

				break;
			}
			j++;

		} while (j < n);

		return k;
	}

}