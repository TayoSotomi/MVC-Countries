using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___Design_Patterns_LAB
{
    public class CountryListView
    {
        public List <Country> Countries { get; set; }


        //constructor
        public CountryListView(List<Country>countries)
        {
            Countries = countries;

        }

        //Method
        

        public void Display()
        {     
            int i = 0;
            foreach(Country country in Countries) 
            {
                Console.WriteLine($"{i}. {country.Name}");i++;

            }



        }
    }
}
