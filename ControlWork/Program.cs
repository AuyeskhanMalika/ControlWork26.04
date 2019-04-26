using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What do you want to do?\n" + "1.Registration \n" + "2.Entry");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                User newUser = new User();
                newUser.Registration();
            }
            if (choice == 2)
            {
                User issuerUser = new User();
                issuerUser.Entry();
            }
        }
    }
}
