using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV102_CS486_Team13.Models
{
    class Examiner
    {
        public String id;
        public String name;
        public String birthday;
        public String moreInfo;

        public Examiner()
        {

        }
        public Examiner(String id, String name, String birthday, String moreInfo)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.moreInfo = moreInfo;
        }
        public static List<Examiner> getMockdata()
        {
            List<Examiner> list = new List<Examiner>();
            list.Add(new Examiner("31", "Luong Vi Minh", "1/1/1",""));
            list.Add(new Examiner("32", "Dinh Ba Tien", "1/1/1", ""));
            list.Add(new Examiner("33", "Tran Minh Triet", "1/1/1", ""));
            return list;
        }
    }
}
