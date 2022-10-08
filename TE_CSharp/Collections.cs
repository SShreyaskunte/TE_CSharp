using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TE_CSharp
{
    internal class Collections
    {
        public static void ArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2.23);
            arrayList.Add("John");
            arrayList.Add('S');
            Console.WriteLine("Array List : ");
            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");

            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
        }
        public static void ListDemo()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.RemoveAt(0);
            Console.WriteLine("List Generic class : ");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");

        }
        public static void SortedListDemo()
        {
            Console.WriteLine("SortedList class : ");
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(2, "Shreyas");
            list.Add(3, "Peter");
            list.Add(1, "Parker");
            list.Add(4, "Uncle Ben");
            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");

        }
        public static void StackDemo()
        {
            Console.WriteLine("Stack class : ");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            Console.WriteLine("Top is : "+ stack.Peek());
            foreach(var obj in stack)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Top is : " + stack.Peek());
            Console.WriteLine("-------------------------------");
        }
        public static void QueueDemo()
        {
            Console.WriteLine("Queue class : ");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            Console.WriteLine("Top is : " + queue.Peek());
            foreach (var obj in queue)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");

        }

        public static void LinkedListDemo()
        {
            Console.WriteLine("Linked List :");
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddFirst(0);
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");
        }
        public static void DictionaryDemo()
        {
            Console.WriteLine("Dictinoary");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "C#");
            dict.Add(2, "SQL");
            dict.Add(3, "Angular");
            foreach (var obj in dict)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");

            var key = new List<int>(dict.Keys);
            Console.WriteLine("Keys");

            foreach (var obj in key)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");

            var values = new List<string>(dict.Values);
            Console.WriteLine("Values");

            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Value of Key 1 is : {dict[1]}");
            Console.WriteLine("-------------------------------");
        }
        public static void HashtableDemo()
        {
            Console.WriteLine("Hashtable");
            Hashtable ht = new Hashtable();
            ht.Add(1, "C#");
            ht.Add(2, "C#12");
            ht.Add(3, "C#34");
            ht.Add(4, "C#56");
            ht.Add(5, "C#78");
            ht.Add(6, 123);
            ICollection key = ht.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Value of Key 1 is : {ht[1]}");
            Console.WriteLine($"Value of Key 0 is : {ht[0]}");//gives null value
        }
        public static void Main()
        {
            ArrayList();
            Console.WriteLine("-------------------------------");
            ListDemo();
            SortedListDemo();
            StackDemo();
            QueueDemo();
            LinkedListDemo();
            DictionaryDemo();
            HashtableDemo();
        }
    }
}
