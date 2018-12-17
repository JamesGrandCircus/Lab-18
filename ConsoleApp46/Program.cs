using System;
using System.Collections.Generic;

namespace ConsoleApp46
{
	public class Program
	{
		public static void Main(string[] args)
		{
			LinkedList<int> arrayList = new LinkedList<int>();

			arrayList.AddFirst(1);
			arrayList.AddLast(2);
			arrayList.AddFirst(3);
			arrayList.AddLast(2);
			arrayList.AddFirst(2);
			arrayList.AddLast(4);
			arrayList.AddFirst(5);
			arrayList.AddLast(5);
			arrayList.AddLast(7);
			arrayList.AddLast(8);
			arrayList.AddLast(4);
			arrayList.AddLast(4);
			arrayList.AddLast(1);
			arrayList.AddLast(0);
			arrayList.AddLast(10);
			do
			{
				// James -- I'm not sure what you think  you are doing with this foreach loop, but it is not doing what you think it is doing 
				foreach (int item in arrayList)
				{
					Console.Write(item.ToString() + " ");
					int frequency = 0;
					for (int i = 0; i < arrayList.Count; ++i)
					{
						if (arrayList.Count == item) ++frequency;
					}
					Console.WriteLine(frequency.ToString());
				}
			} while (arrayList == null);

			Console.ReadLine();



		}
	}
}

