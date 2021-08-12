using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    class Category
    {
        String id;
        String name;

        public Category(String id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public String getId()
        {
            return this.id;
        }

        public String getName()
        {
            return this.name;
        }
    }
}
