using System;

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

        // public List<Model> getListModels(){
        // 	DataTable result = DatabaseHelper.query("SELECT * FROM Model");
        // 	List<Model> listModels = new List<Model>();
        // 	foreach (DataRow row in result.Rows)
        //     {
        // 		Model model = new Model();
        //         model.setId(row["Id"]);
        //         model.setName(row["Name"].ToString());
        // 		listModels.add(model);
        //     }
        // 	return listModels;
        // }

        // public void addModel(String name, String Id){
        // 	String sqlCommand = $"INSERT INTO Model Values({Id}, {name}";
        // 	DatabaseHelper.execute(sqlCommand);
        // }
    }
}
