using Microsoft.Extensions.Configuration;
using OdeToFood.Services;

namespace OdeToFood.Services
{
    public class Greeter : IGreeter
    {
        IConfiguration _configuration;
        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetMessageOfTheDay()
        { 
            var greeting = _configuration["Greeting"];
            return greeting;

        }
    }
}