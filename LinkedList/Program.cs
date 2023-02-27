using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                bool flag = true;
                LinkedList linkedList = new LinkedList();

                while (flag)
                {
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.AddFirst");
                    Console.WriteLine("3.AddLast");
                    Console.WriteLine("4.Remove the First Node");
                    Console.WriteLine("5.Remove the Last Node");
                    Console.WriteLine("6.Find");
                    Console.WriteLine("7.Size");
                    Console.WriteLine("8.Display");
                    Console.Write("Enter The Option:");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    switch (option)
                    {
                        case 1:
                            linkedList.Add(56);
                            linkedList.Add(30);
                            linkedList.Add(70);
                            break;
                        case 2:
                            linkedList.AddFirst(70);
                            linkedList.AddFirst(30);
                            linkedList.AddFirst(56);
                            break;
                        case 3:
                            linkedList.AddLast(56);
                            linkedList.AddLast(30);
                            linkedList.AddLast(70);
                            break;
                        case 4:
                            linkedList.Add(56);
                            linkedList.Add(30);
                            linkedList.Add(70);
                            linkedList.RemoveFirstNode();
                            break;
                        case 5:
                            linkedList.Add(56);
                            linkedList.Add(30);
                            linkedList.Add(70);
                            linkedList.RemoveLastNode();
                            break;
                        case 6:
                            linkedList.Add(56);
                            linkedList.Add(30);
                            linkedList.Add(70);
                            linkedList.Add(56);
                            linkedList.Add(30);
                            linkedList.Add(70);
                            linkedList.Display();
                            linkedList.Find(30);
                            break;
                        case 7:
                            linkedList.Add(56);
                            linkedList.Add(30);
                            linkedList.Add(70);
                            linkedList.Add(56);
                            linkedList.Add(30);
                            linkedList.Add(70);
                            linkedList.Display();
                            linkedList.Size();
                            break;
                        case 8:
                            linkedList.Display();
                            break;
                        default: Console.WriteLine("Please Enter Currect Option"); break;
                    }
                }
            }
        }
    }
}
            
        
    
