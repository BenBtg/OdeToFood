using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        Restaurant Add(Restaurant restaurant);
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
}