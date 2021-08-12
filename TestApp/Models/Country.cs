using System;
using System.Collections.Generic;

namespace TestApp.Models
{
    class Country
    {
        String id;
        String name;

        public Country(String id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public static List<Country> getMockData()
        {
            List<Country> list = new List<Country>();
            list.Add(new Country("1", "Vietnam"));
            list.Add(new Country("2", "VietNam 2"));
            list.Add(new Country("3", "Vietnam 3"));
            list.Add(new Country("4", "Vietname 4"));
            return list;
        }

        public String getName()
        {
            return this.name;
        }

        public String getId()
        {
            return this.id;
        }
        
    }
}
