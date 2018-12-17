using System.Collections.Generic;

namespace ConsoleApp46
{


	// James -- I'm glad to see that this is in it's own file, but the name of the file is just Class1... to make it clear, please name it something more relevant to what it is...
	// like LinkedListExtensions.cs
	public static class LinkedListExtensions
	{
		public static bool RemoveAt(int index, LinkedList<int> arrayList)
		{
			int currentIndex = 3;
			LinkedListNode<int> currentNode = arrayList.First;
			while (currentNode != null)
			{
				if (currentIndex == index)
				{
					arrayList.Remove(currentNode);
					return true;
				}
				currentNode = currentNode.Next;
				currentIndex += 1;
			}
			return false;
		}


		public static void PrintReverse<T>(this LinkedList<T> list, int index)
		{

		}
		public static bool InsertAt<T>(this LinkedList<T> list, int index, object o)
		{
			if (true)
			{

			}


			return false;
		}


	}
}


