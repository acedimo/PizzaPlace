using PizzaPlace.Models;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface ISubscriptionRepository
    {
        void Add(Subscription newSubscription);
        Subscription GetByEmail(string email);
    }
}
