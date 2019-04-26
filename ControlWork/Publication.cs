using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    public class Publication : Entity
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public void CreatePublication()
        {
            Console.WriteLine("Enter the title: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter your text: ");
            Text = Console.ReadLine();
        }
    }
}
