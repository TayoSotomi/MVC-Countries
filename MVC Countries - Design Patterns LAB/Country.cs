﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___Design_Patterns_LAB
{
    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List <string> Colors { get; set; }
        

        //constructor
        public Country(string _name,string _continent,List<string> _color)
        { 
            Name = _name;
            Continent = _continent;
            Colors = _color;



        }
       
      
        
    }
}
