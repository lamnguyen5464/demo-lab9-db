using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPV102_CS486_Team13.Helpers;
using System.Data;

namespace SPV102_CS486_Team13.Repos
{
    class AppRepo
    {
        private static AppRepo instance = null;
        private static Boolean isDev = true;
        private AppRepo() { }

        public static AppRepo getInstnace()
        {
            if (AppRepo.instance == null)
            {
                AppRepo.instance = new AppRepo();
            }
            return AppRepo.instance;
        }

        public List<string> getAllContestant()
        {
            if (isDev)
            {

            }

            List<String> list = new List<string>();
            String sqlString = $"SELECT * FROM";
            DataTable result = DatabaseHelper.query(sqlString);
            foreach(DataRow row in result.Rows)
            {

            }
            return list;
        }

        public List<string> getAllExaminers()
        {
            if (isDev)
            {

            }

            List<String> list = new List<string>();
            String sqlString = $"SELECT * FROM";
            DataTable result = DatabaseHelper.query(sqlString);
            foreach(DataRow row in result.Rows)
            {

            }
            return list;
        }

        public List<string> getAllRounds()
        {
            if (isDev)
            {

            }

            List<String> list = new List<string>();
            String sqlString = $"SELECT * FROM";
            DataTable result = DatabaseHelper.query(sqlString);
            foreach(DataRow row in result.Rows)
            {

            }
            return list;
        }


    }
}
