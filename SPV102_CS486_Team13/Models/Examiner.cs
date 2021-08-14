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

        public Examiner()
        {

        }
        public Examiner(String id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public static List<Examiner> getMockdata()
        {
            List<Examiner> list = new List<Examiner>();
            list.Add(new Examiner("31", "Luong Vi Minh"));
            list.Add(new Examiner("32", "Dinh Ba Tien"));
            list.Add(new Examiner("33", "Tran Minh Triet"));
            return list;
        }
    }
}
