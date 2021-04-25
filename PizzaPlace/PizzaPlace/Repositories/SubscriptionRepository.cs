using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly PizzaPlaceDbContext dbContext;

        public SubscriptionRepository(PizzaPlaceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Subscription newSubscription)
        {
            dbContext.Subscriptions.Add(newSubscription);
            dbContext.SaveChanges();
        }
    }
}
