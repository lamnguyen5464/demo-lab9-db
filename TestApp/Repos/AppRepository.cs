using System;
using System.Collections.Generic;
using System.Data;
using TestApp.Models;
using TestApp.Helpers;

namespace TestApp.Repos
{
    class AppRepository
    {
        private static AppRepository instance = null;
        private AppRepository() { }

        //data-model
        // List<Model> listModels = new List<Model>()


        public static AppRepository getIntance()
        {
            if (AppRepository.instance == null)
            {
                AppRepository.instance = new AppRepository();
            }
            return AppRepository.instance;
        }

        public List<Country> getListCountries(){
        	List<Country> listModels = new List<Country>();
            DataTable result = DatabaseHelper.query("exec dbo.sp_getCountries");
            foreach (DataRow row in result.Rows)
            {
                String id = row["Id"].ToString();
                String name = row["Name"].ToString();
                Country model = new Country(id, name);
                listModels.Add(model);
            }
            return listModels;
        }

        public List<Category> getCatOnId(String Id)
        {
            List<Category> list = new List<Category>();
            String sqlString = $"exec dbo.fn_getCategoryByCountryId {Id}";
            DataTable result = DatabaseHelper.query(sqlString);
            foreach (DataRow row in result.Rows)
            {
                String id = row["Id"].ToString();
                String name = row["Name"].ToString();
                Category model = new Category(id, name);
                list.Add(model);
            }
            return list;
        }




        public void addModel(String name, String Id){
        	String sqlCommand = $"INSERT INTO Model Values({Id}, {name}";
        	DatabaseHelper.execute(sqlCommand);
        }
    }
}
