using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    public class NomadInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Subscriptions.AddRange(new List<Subscription>
            {
                new Subscription
                {
                    Cost = 15000,
                    Duration = "12 month"
                },
                 new Subscription
                {
                    Cost = 25000,
                    Duration = "24 month"
                },
                  new Subscription
                {
                    Cost = 40000,
                    Duration = "36 month"
                },
            });
            context.SaveChanges();
        }
    }
}
