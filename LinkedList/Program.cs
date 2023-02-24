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
            bool flag = true;
            LinkedList linkedList = new LinkedList();
            while (flag)
            {
                Console.WriteLine("1 Add");
                Console.WriteLine("2: AddFirst");
                Console.WriteLine("3: Display");
                Console.WriteLine("Enter a Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.Addfirst(70);
                        linkedList.Addfirst(30);
                        linkedList.Addfirst(56);
                        break;
                    case 3:
                        linkedList.Display();
                            break;
                    default: 
                        Console.WriteLine("Please Enter Correct Option");
                         break;
                }
            }
        }
    }
}
