using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV102_CS486_Team13.Models
{
    class Contestant
    {
        public String id;
        public String name;
        public String birthday;
        public String moreInfo;

        public String averageScore;



        public Contestant()
        {

        }
        public Contestant(String id, String name, String birthday, String moreInfo, String averageScore)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.moreInfo = moreInfo;
            this.averageScore = averageScore;
        }
        public static List<Contestant> getMockdata()
        {
            List<Contestant> list = new List<Contestant>();
            list.Add(new Contestant("11", "Tran Hai Dien", "", "","10"));
            list.Add(new Contestant("12", "Nguyen Truong Lam", "","","10"));
            list.Add(new Contestant("13", "Mai Quoc Khanh", "", "", "10"));
            return list;
        }
    }
}
