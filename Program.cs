using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////// LIST ////////////////
            Console.WriteLine("LiST value: ");
            var names = new List<string>();
            for (int i = 0; i <= 5; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }


            Console.WriteLine("hashSET value: ");
            var namesHash = new HashSet<string>();

            for (int i = 0; i <= 5; i++)
            {
                string hashName = Console.ReadLine();

                namesHash.Add(hashName);
            }
            foreach (var n in namesHash)
            {
                Console.WriteLine(n);
            }

            /// Sorted Set 
            Console.WriteLine("Sorted Set : ");
            var nameSorted = new SortedSet<string>() { "Rishit", "hardi", "darshan", "Rishit", "Hemangi", "Nishita", "Shivraj" };

            foreach (var n in nameSorted)
            {
                Console.WriteLine(n);
            }

            //// Stack
            Console.WriteLine("Stack: ");

            var nameStack = new Stack<string>();

            for (int i = 0; i < 5; i++)
            {
                string stackName = Console.ReadLine();
                nameStack.Push(stackName);
            }

            foreach (var n in nameStack)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("peek element: " + nameStack.Peek());
            Console.WriteLine("poped element: " + nameStack.Pop());
            Console.WriteLine("peek element: " + nameStack.Peek());

            // linked List //////
            LinkedList<string> nameLinked = new LinkedList<string>();
            for (int i = 0; i < 5; i++)
            {
                string linkedName = Console.ReadLine();

                nameLinked.AddFirst(linkedName);
            }

            LinkedListNode<string> node = nameLinked.Find("rishit");
            nameLinked.AddBefore(node, "rk");
            nameLinked.AddAfter(node, "rk1");

            foreach (var n in nameLinked)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(nameLinked.Contains("rk"));

            //// dictonary /////

            Dictionary<int, string> nameDict = new Dictionary<int, string>();

            for (int i = 0; i < 5; i++)
            {
                string dictName = Console.ReadLine();
                nameDict.Add(i, dictName);
            }

            foreach (KeyValuePair<int, string> n in nameDict)
            {
                Console.WriteLine(n.Key + "  " + n.Value);
            }

            nameDict.Remove(1);
            foreach (KeyValuePair<int, string> n in nameDict)
            {
                Console.WriteLine(n.Key + "  " + n.Value);
            }
            Console.WriteLine(nameDict.ContainsValue("rishit"));

            /// sorted dict ///////
            SortedDictionary<int, string> nameSortDict = new SortedDictionary<int, string>();
            for (int i = 0; i < 5; i++)
            {
                string dictName = Console.ReadLine();
                nameSortDict.Add(i, dictName);
            }

            foreach (KeyValuePair<int, string> n in nameSortDict)
            {
                Console.WriteLine(n.Key + "  " + n.Value);
            }

            nameSortDict.Remove(1);
            foreach (KeyValuePair<int, string> n in nameSortDict)
            {
                Console.WriteLine(n.Key + "  " + n.Value);
            }
            Console.WriteLine(nameSortDict.ContainsValue("rishit"));

        }
    }
}
