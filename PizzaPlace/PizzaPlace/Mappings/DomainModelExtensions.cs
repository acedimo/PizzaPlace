using PizzaPlace.Models;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Mappings
{
    public static class DomainModelExtensions
    {
        public static OfferViewModel ToViewModel(this Offer entity)
        {
            return new OfferViewModel 
            { Title = entity.Title,
              Description = entity.Description, 
              ValidTo = entity.ValidTo 
            };
        }

        public static MenuItemViewModel ToViewModel(this MenuItem entity)
        {
            return new MenuItemViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                ImageUrl = entity.ImageUrl,
                Description = entity.Description,
                Price = entity.Price,
                Currency = entity.Currency,
                Slug = entity.Slug
            };
        }

        public static OrdersListViewModel ToOrderListViewModel(this Order entity)
        {
            return new OrdersListViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Surname = entity.Surname,
                Address = entity.Address,
                Phone = entity.Phone,
                Message = entity.Message,
                Status = entity.Status
            };
        }
    }
}
