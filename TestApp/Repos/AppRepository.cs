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
            //DataTable result = DatabaseHelper.query("SELECT * FROM Countries");
            //foreach (DataRow row in result.Rows)
            //   {
            //       String id = row["Id"].ToString();
            //       String name = row["Name"].ToString();
            //	Country model = new Country(id, name);
            //	listModels.Add(model);
            //   }
            listModels.Add(new Country("1", "VietNam"));
            listModels.Add(new Country("2", "UK"));
            listModels.Add(new Country("3", "Han"));
            listModels.Add(new Country("4", "Other"));
        	return listModels;
        }

        public void addModel(String name, String Id){
        	String sqlCommand = $"INSERT INTO Model Values({Id}, {name}";
        	DatabaseHelper.execute(sqlCommand);
        }
    }
}
