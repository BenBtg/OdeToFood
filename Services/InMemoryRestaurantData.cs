using System.Collections.Generic;
using System.Linq;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id = 1, Name = "Bens Balti"},
                new Restaurant{Id= 2, Name = "Nics Nachos"},
                new Restaurant {Id = 3, Name =  "Dave's Delhi"}
            };
        }

        public Restaurant Add(Restaurant restaurant)
        {
            var id = _restaurants.Max(r => r.Id) + 1;
            restaurant.Id = id;
            _restaurants.Add(restaurant);
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return  _restaurants.OrderBy(r => r.Name);
        }
    }
}