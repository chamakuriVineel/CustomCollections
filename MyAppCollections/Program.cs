using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppCollections
{
    class Program
    {
        public static int CompareString(String first, String second)
        {
            return first.CompareTo(second);
        }
         public  static void Main(string[] args)
        {
            Console.WriteLine("Collection namespace");

            Console.WriteLine("Stack");
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            Console.Write("Total number of elements in the Stack are : ");
            Console.WriteLine(myStack.Count);
            Console.WriteLine("Top : " + myStack.Peek()); 
            Console.WriteLine("count : "+myStack.Count);
            Console.WriteLine("contains 3 ? "+myStack.Contains(3));
            myStack.Clear();
            Console.WriteLine("Stack is cleared :");

            Console.WriteLine("Queue");
            Queue myQueue = new Queue();
            myQueue.Enqueue("Chandigarh");
            myQueue.Enqueue("Delhi");
            myQueue.Enqueue("Noida");
            myQueue.Enqueue("Himachal");
            myQueue.Enqueue("Punjab");
            myQueue.Enqueue("Jammu");
            Console.WriteLine("front element is : "+myQueue.Peek());
            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Contains("Khammam");
            object[] ar = myQueue.ToArray();
            foreach (var value in ar)
            {
                Console.Write(value+",");
            }
            Console.WriteLine();

            Console.WriteLine("Hashtable");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Hi");
            hashtable.Add(2, "this");
            hashtable.Add(3, "is");
            hashtable.Add(4, "vineel");
            hashtable.Add(5, "chamakuri");
            ICollection key = hashtable.Keys;
            Console.WriteLine("Hashtable:");
            hashtable.Remove(3);
            foreach (var val in key)
            {
                Console.Write(val + "-" + hashtable[val]+",");
            }
            Console.WriteLine("length of hastable: "+hashtable.Count);

            Console.WriteLine("sorted list");
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "Hi");
            sortedList.Add(2, "this");
            sortedList.Add(3, "is");
            sortedList.Add(4, "vineel");
            sortedList.Add(5, "chamakuri");
            key = sortedList.Keys;
            Console.WriteLine("sorted list:");
            hashtable.Remove(3);
            foreach (var val in key)
            {
                Console.Write(val + "-" + sortedList[val]+",");
            }
            Console.WriteLine("length of hastable: " + sortedList.Count);
            Console.WriteLine("is Read Only: " +sortedList.IsReadOnly);
            Console.WriteLine("is fixed size: " + sortedList.IsFixedSize);

            Console.WriteLine("Generics namespace");

            Console.WriteLine("List");
            List<String> myList = new List<String>();
            myList.Add("B");
            myList.Add("A");
            myList.Add("E");
            myList.Add("D");
            myList.Add("C");
            Console.WriteLine("length of list: "+myList.Count);
            myList.RemoveAt(3);
            myList.Sort(CompareString);
            Console.WriteLine(myList.Contains("A"));
            foreach (var value in myList)
            {
                Console.Write(value+",");
            }
            Console.WriteLine("list ");
            List<int> firstlist = new List<int>(); 
            firstlist.Add(17);
            firstlist.Add(19);
            firstlist.Add(21);
            firstlist.Add(9);
            firstlist.Add(75);
            firstlist.Add(19);
            firstlist.Add(73);
            Console.WriteLine("Elements Present in List:\n");
            int index = 0; 
            foreach (int val in firstlist)
            {
                Console.Write("At Position {0}: ", index);
                Console.WriteLine(val);
                index++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Removing the element at index 3\n");
            firstlist.RemoveAt(3);
            index = 0;
            foreach (int  val in firstlist)
            {
                Console.Write("At Position {0}: ", index);
                Console.WriteLine(val);
                index++;
            }

            Console.WriteLine("hash set");

            HashSet<int> mySet1 = new HashSet<int>();
            for (int pointer = 1; pointer <= 5; pointer++)
                mySet1.Add(2 * pointer);
            HashSet<int> mySet2 = new HashSet<int>();
            for (int pointer = 1; pointer <= 10; pointer++)
                mySet2.Add(pointer);
            Console.WriteLine(mySet1.IsSubsetOf(mySet2));

            Console.WriteLine("specialized namespace");
            Console.WriteLine("String collection");
            StringCollection myCol = new StringCollection();
            String[] myArr1 = new String[] { "A", "B", "C", "D", "E" };
            myCol.AddRange(myArr1);
            String[] myArr2 = new String[myCol.Count];
            myCol.CopyTo(myArr2, 0);
            for (int i = 0; i < myArr2.Length; i++)
            {
                Console.WriteLine(myArr2[i]);
            }


            Console.Read();

        }
    }
    
}
