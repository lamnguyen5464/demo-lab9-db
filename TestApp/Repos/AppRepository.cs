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

        public List<Category> getListCategories(){
        	DataTable result = DatabaseHelper.query("SELECT * FROM Category");
        	List<Category> listModels = new List<Category>();
        	foreach (DataRow row in result.Rows)
            {
        		Category model = new Category();
                model.setId(row["Id"].ToString());
                model.setName(row["Name"].ToString());
        		listModels.Add(model);
            }
        	return listModels;
        }

        public void addModel(String name, String Id){
        	String sqlCommand = $"INSERT INTO Model Values({Id}, {name}";
        	DatabaseHelper.execute(sqlCommand);
        }
    }
}
