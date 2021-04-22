using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly PizzaPlaceDbContext _dbContext;

        public OfferRepository(PizzaPlaceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Offer> GetAllValid()
        {
            return _dbContext.Offers.Where(x => x.ValidTo.Date >= DateTime.Now.Date).ToList();
        }
    }
}
