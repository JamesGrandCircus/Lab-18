using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
 
    

   public static class LinkedListExtensions
    {
public static bool RemoveAt(int index, LinkedList<int> arrayList)
        {
            int currentIndex = 3;
            LinkedListNode<int> currentNode = arrayList.First;
            while (currentNode!=null)
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


