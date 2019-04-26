using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string Address { get; set; }
        public int Purse { get; set; }
        public DateTime Since { get; set; }
        public virtual Subscription Subscription { get; set; }

        public void Registration()
        {
            using (var context = new DataContext())
            {
                Console.WriteLine("Enter your login: ");
                Login = Console.ReadLine();
                
                Console.WriteLine("Enter your password:  ");
                Password = Console.ReadLine();
                Console.WriteLine("Repeat your password: : ");
                RepeatPassword = Console.ReadLine();
                if (RepeatPassword == Password)
                    { Console.WriteLine(";)"); }
                else
                { Console.WriteLine("Passwords don't match. Please try again"); }

                Console.WriteLine("Enter your Address: ");
                Address = Console.ReadLine();

                Console.WriteLine("Your money: ");
                Purse = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Choose a subscription that you want: ");
                context.Subscriptions.ToList();

                Since = DateTime.Today;
                context.SaveChanges();
            }
        }
        public void Entry()
        {
            using (var secondcontext = new DataContext())
            {
                Console.WriteLine("Enter your login: ");
                Login = Console.ReadLine();

                Console.WriteLine("Enter your password:  ");
                Password = Console.ReadLine();
                secondcontext.SaveChanges();
            }
        }
        public void Payment()
        {
            Purse = Purse - Subscription.Cost;
        }

        void CancelSubscription()
        {
            Subscription = null;
        }

    }
}