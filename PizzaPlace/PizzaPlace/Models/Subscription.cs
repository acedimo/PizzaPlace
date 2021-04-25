using System;

namespace PizzaPlace.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
