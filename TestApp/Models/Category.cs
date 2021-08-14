using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static List<Category> getMockData()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category("1", "Nhac tre"));
            list.Add(new Category("2", "Nhac tre 2"));
            list.Add(new Category("3", "Nhac tre 3"));
            list.Add(new Category("4", "Nhac tre 4"));
            list.Add(new Category("5", "Nhac tre 5"));
            list.Add(new Category("6", "Nhac tre 6"));
            list.Add(new Category("7", "Nhac tre 7"));
            return list;
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
