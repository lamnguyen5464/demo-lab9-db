using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPV102_CS486_Team13.Helpers;
using SPV102_CS486_Team13.Models;
using System.Data;
using SPV102_CS486_Team13.Models;
using System.Windows.Forms;

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

        public List<Contestant> getAllContestant()
        {
            if (isDev)
            {
                return Contestant.getMockdata();
            }

            List<Contestant> list = new List<Contestant>();
            String sqlString = $"SELECT * FROM";
            DataTable result = DatabaseHelper.query(sqlString);
            foreach(DataRow row in result.Rows)
            {
                Contestant model = new Contestant();
                model.id = row["id"].ToString();
                model.name = row["name"].ToString();
                model.birthday = row["birthday"].ToString();
                model.moreInfo = row["moreInfo"].ToString();
                list.Add(model);
            }
            return list;
        }

        public List<Examiner> getAllExaminers()
        {
            if (isDev)
            {
                return Examiner.getMockdata();
            }

            List<Examiner> list = new List<Examiner>();
            String sqlString = $"SELECT * FROM Examiners";
            DataTable result = DatabaseHelper.query(sqlString);
            foreach(DataRow row in result.Rows)
            {
                Examiner model = new Examiner();
                model.id = row["id"].ToString();
                model.name = row["name"].ToString();
                model.birthday = row["birthday"].ToString();
                model.moreInfo = row["moreInfo"].ToString();
                list.Add(model);
            }
            return list;
        }

        public List<Contestant> getListContestantsByRoundId()
        {
            if (isDev)
            {
                return Contestant.getMockdata();
            }
            List<Contestant> list = new List<Contestant>();
            String sqlString = $"SELECT * FROM";
            DataTable result = DatabaseHelper.query(sqlString);
            foreach (DataRow row in result.Rows)
            {
                Contestant model = new Contestant();
                model.id = row["id"].ToString();
                model.name = row["name"].ToString();
                model.birthday = row["birthday"].ToString();
                model.moreInfo = row["moreInfo"].ToString();
                list.Add(model);
            }
            return list;
        }

        public List<Round> getAllRounds()
        {
            if (isDev)
            {
                return Round.getMockdata();
                
            }

            List<Round> list = new List<Round>();
            String sqlString = $"SELECT * FROM";
            DataTable result = DatabaseHelper.query(sqlString);
            foreach(DataRow row in result.Rows)
            {

            }
            return list;
        }



    }
}
