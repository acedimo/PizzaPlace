using PizzaPlace.Models;
using System.Collections.Generic;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IOfferRepository
    {
        List<Offer> GetAllValid();
    }
}
