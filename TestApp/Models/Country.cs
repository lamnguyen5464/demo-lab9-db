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

        public String getName()
        {
            return this.name;
        }
        
    }
}
