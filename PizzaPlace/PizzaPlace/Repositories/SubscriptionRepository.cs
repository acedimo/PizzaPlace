using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System.Linq;

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

        public Subscription GetByEmail(string email)
        {
            return dbContext.Subscriptions.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
