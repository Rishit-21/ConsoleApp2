using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        class Student
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public List<string> Subject { get; set; }
        }
        class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public string Country { get; set; }
        }
        class Program
        {
            static void Main(string[] args)
            {

            //////// LIST ////////////////

            //Console.WriteLine("LiST value: ");
            var names = new List<string>();
            //for (int i = 0; i <= 5; i++)
            //{
            //    string name = Console.ReadLine();

            //    names.Add(name);
            //}
            //foreach (var n in names)
            //{
            //    Console.WriteLine(n);
            //}


            //Console.WriteLine("hashSET value: ");
            var namesHash = new HashSet<string>();

            //for (int i = 0; i <= 5; i++)
            //{
            //    string hashName = Console.ReadLine();

            //    namesHash.Add(hashName);
            //}
            //foreach (var n in namesHash)
            //{
            //    Console.WriteLine(n);
            //}

            ///// Sorted Set 
            //Console.WriteLine("Sorted Set : ");
            var nameSorted = new SortedSet<string>() { "Rishit", "hardi", "darshan", "Rishit", "Hemangi", "Nishita", "Shivraj" };

            //foreach (var n in nameSorted)
            //{
            //    Console.WriteLine(n);
            //}

            ////// Stack
            //Console.WriteLine("Stack: ");

            var nameStack = new Stack<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    string stackName = Console.ReadLine();
            //    nameStack.Push(stackName);
            //}

            //foreach (var n in nameStack)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine("peek element: " + nameStack.Peek());
            //Console.WriteLine("poped element: " + nameStack.Pop());
            //Console.WriteLine("peek element: " + nameStack.Peek());

            //// linked List //////
            LinkedList<string> nameLinked = new LinkedList<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    string linkedName = Console.ReadLine();

            //    nameLinked.AddFirst(linkedName);
            //}

            LinkedListNode<string> node = nameLinked.Find("rishit");
            //nameLinked.AddBefore(node, "rk");
            //nameLinked.AddAfter(node, "rk1");

            //foreach (var n in nameLinked)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine(nameLinked.Contains("rk"));

            ////// dictonary /////

            Dictionary<int, string> nameDict = new Dictionary<int, string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    string dictName = Console.ReadLine();
            //    nameDict.Add(i, dictName);
            //}

            //foreach (KeyValuePair<int, string> n in nameDict)
            //{
            //    Console.WriteLine(n.Key + "  " + n.Value);
            //}

            nameDict.Remove(1);
            //foreach (KeyValuePair<int, string> n in nameDict)
            //{
            //    Console.WriteLine(n.Key + "  " + n.Value);
            //}
            //Console.WriteLine(nameDict.ContainsValue("rishit"));

            ///// sorted dict ///////
            SortedDictionary<int, string> nameSortDict = new SortedDictionary<int, string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    string dictName = Console.ReadLine();
            //    nameSortDict.Add(i, dictName);
            //}

            //foreach (KeyValuePair<int, string> n in nameSortDict)
            //{
            //    Console.WriteLine(n.Key + "  " + n.Value);
            //}

            nameSortDict.Remove(1);
            //foreach (KeyValuePair<int, string> n in nameSortDict)
            //{
            //    Console.WriteLine(n.Key + "  " + n.Value);
            //}
            //Console.WriteLine(nameSortDict.ContainsValue("rishit"));

            /////LinQ 
            ////// Query Syntax
            var num = new List<int>()
                {
                    1,22,3,5,66,45,12,23,52,88,96,100,56,89,41,35,38,18
                };

            var QuerySyntax = from objss in num
                              where objss > 50
                              select objss;


            //foreach(int n in QuerySyntax)
            //{
            //    Console.WriteLine(n +" ");
            //}


            //////Method Syntax
            var MethodSyntax = num.Where(obj => obj > 50).ToList();
            //foreach (int n in MethodSyntax)
            //{
            //    Console.WriteLine(n + " ");
            //}


            ///////Mixed Syntax
            var MixedSyntax = (from objjs in num
                               select objjs).Max();
            //Console.WriteLine(MixedSyntax);


            /////Lambda Expression
            var lambdaExp = num.Where(number => number > 50).Select(number => number + 10);
            //foreach (int n in lambdaExp)
            //{
            //    Console.WriteLine(n + " ");
            //}

            ////////// Aggeregate function
            var minNum = num.Min();
            //Console.WriteLine(minNum);

            var maxNum = num.Max();
            //Console.WriteLine(maxNum);

            var sumNum = num.Sum();
            //Console.WriteLine(sumNum);

            var countNum = num.Count();
            //Console.WriteLine(countNum);

            var aggNum = num.Aggregate((a, b) => a * b);
            //Console.WriteLine(aggNum);

            ////// Sorting Operators 
            List<Student> objStudent = new List<Student>()
                {
                    new Student()
                    {
                        Name = "Rishit",
                        Gender = "Male",
                        Subject=new List<string>{"ADA","DBMS"},

                    },
                    new Student()
                    {
                        Name = "Hardi",
                        Gender = "Female",
                        Subject=new List<string>{"C++","CN"},

                    },
                    new Student()
                    {
                        Name = "Sahil",
                        Gender = "Male",
                        Subject=new List<string>{"IPDC","C"},

                    },
                    new Student()
                    {
                        Name = "Nishita",
                        Gender = "Female",
                        Subject=new List<string>{"Python","Mobile Devlopment"},

                    },
                    new Student()
                    {
                        Name = "Darshan",
                        Gender = "Male",
                        Subject=new List<string>{"ADA","DBMS"},

                    },
                    new Student()
                    {
                        Name = "Darshan",
                        Gender = "Female",
                        Subject=new List<string>{"ADA","DBMS"},

                    },
                    new Student()
                    {
                        Name = "Nishita",
                        Gender = "Male",
                        Subject=new List<string>{"Python","Mobile Devlopment"},

                    },


                };

            ////// Simple sorting
            var SortedStud = objStudent.OrderBy(x => x.Name);

            //foreach(var std in SortedStud)
            //{
            //    Console.WriteLine(std.Name);
            //}

            ///////Descending
            var SortedDecStud = objStudent.OrderByDescending(x => x.Name);

            //foreach (var Decstd in SortedDecStud)
            //{
            //    Console.WriteLine(Decstd.Name);
            //}

            ////////then by 
            var ThenByStud = objStudent.OrderBy(x => x.Name).ThenBy(x => x.Gender);

            //foreach (var std in ThenByStud)
            //{
            //    Console.WriteLine(std.Name+ " " +std.Gender);
            //}


            ///////then by desc
            var ThenByDescStud = objStudent.OrderBy(x => x.Name).ThenBy(x => x.Gender);

            //foreach (var std in ThenByDescStud)
            //{
            //    Console.WriteLine(std.Name + " " + std.Gender);
            //}

            ////////////////// Partition Operator //////////////////
            ///

            ///////   Take key word   ///////////////
            string[] countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };
                Console.WriteLine(countries.Min());

            IEnumerable<string> countrys = countries.Take(3);
            //foreach(string c in countrys)
            //{
            //    Console.WriteLine(c);
            //}

            IEnumerable<string> country = (from c in countries select c).Take(3);
            //foreach (string c in country)
            //{
            //    Console.WriteLine(c);
            //}

            ///////// Take while ///////////
            IEnumerable<string> countryy = (from c in countries select c).TakeWhile(c => c.StartsWith("I"));
            //foreach (string c in countryy)
            //{
            //    Console.WriteLine(c);
            //}
            List<string> countries1 = countries.ToList();
            //foreach(string c in countries1)
            //{
            //    Console.WriteLine(c);
            //}

            //// Conversion type
            ///// to List 
            List<string> countries2 = (from x in countries select x).ToList();

                //foreach (string c in countries2)
                //{
                //    Console.WriteLine(c);
                //}
                ///// To Array 

                string[] countrArr = countries2.ToArray();
                //foreach (string c in countrArr)
                //{
                //    Console.WriteLine(c);
                //}
                /////// TO LOOKUP /////

                List<Employee> empList = new List<Employee>()
                {
                    new Employee()
                    {
                        Name = "Rishit",
                        Department = "IT",
                        Country = "India",
                    },
                    new Employee()
                    {
                        Name = "Hardi",
                        Department = "IT",
                        Country = "India",
                    },
                    new Employee()
                    {
                        Name = "Sahil",
                        Department = "HR",
                        Country = "US",
                    },
                    new Employee()
                    {
                        Name = "Darshan",
                        Department = "SALES",
                        Country = "China",
                    },
                    new Employee()
                    {
                        Name = "Shivraj",
                        Department = "SALES",
                        Country = "China",
                    },
                    new Employee()
                    {
                        Name = "Nishita",
                        Department = "HR",
                        Country = "US",
                    },
                    new Employee()
                    {
                        Name = "Hemangi",
                        Department = "MARKETING",
                        Country = "Australia",
                    },
                    new Employee()
                    {
                        Name = "Janvi",
                        Department = "MARKETING",
                        Country = "Australia",
                    },
                };
            //// to Look Up 
            var Emp1 = empList.ToLookup(x => x.Department);
            //foreach (var KeyValuePair in Emp1)
            //{
            //    Console.WriteLine(KeyValuePair.Key);
            //    foreach (var item in Emp1[KeyValuePair.Key])
            //    {
            //        Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
            //    }
            //}


            var Emp2 = (from employee in empList
                        where employee.Department == "SALES"
                        select employee).ToLookup(x => x.Department);
            //foreach (var KeyValuePair in Emp2)
            //{
            //    Console.WriteLine(KeyValuePair.Key);
            //    foreach (var item in Emp2[KeyValuePair.Key])
            //    {
            //        Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
            //    }
            //}

            ////// cast() method
            ArrayList obj = new ArrayList() { 1, 2, 3, 4, 5 };
            IEnumerable<int> CountriesResult = obj.Cast<int>();
            //foreach(int c in CountriesResult)
            //{
            //    Console.WriteLine(c);
            //}

            //// typeof operator
           List<string> obj1 = new List<string>() { "India","USA","UK","Canada","1", "2", "3", "4", "5" };
            Console.WriteLine(obj1.OfType<string>());
            IEnumerable<string> ToStringResult = obj1.OfType<string>();
            //foreach(string s in ToStringResult)
            //{
            //    Console.WriteLine(s);
            //}

            Console.ReadKey();
            }
        }

}



