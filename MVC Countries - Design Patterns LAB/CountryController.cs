using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___Design_Patterns_LAB
{
    public class CountryController
    {
               

        List<Country>CountryDb = new List<Country>()
        {
            new Country("USA", "North America",new List<string>(){"blue","red","white"}),
            new Country("Nigeria", "Africa",new List<string>(){"Green","White","Green"}),
            new Country("England", "Europe",new List<string>(){"White","Red"})

        };
        
        public void CountryAction(Country c)
        {
            CountryView View = new CountryView(c);
            View.Display();
        }

        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");

            CountryListView list = new CountryListView(CountryDb);
                list.Display();
            
          int index = Circle.Validator.GetUserNumberInt();

            CountryAction(CountryDb[index]);

          

        }
       
    }
}
