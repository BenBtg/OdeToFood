using Microsoft.Extensions.Configuration;

namespace OdeToFood
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