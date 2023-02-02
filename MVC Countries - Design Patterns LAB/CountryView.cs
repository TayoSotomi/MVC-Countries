using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___Design_Patterns_LAB
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }

        //constructor
        public CountryView(Country _country)
        {
            DisplayCountry = _country;
        }

        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} {DisplayCountry.Continent} {DisplayCountry.Colors}");
            
        }
    }
}
