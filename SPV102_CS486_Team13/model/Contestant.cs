using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV102_CS486_Team13.model
{
    class Contestant
    {
        public String id;
        public String name;
        public Contestant() { }
        public Contestant(String id, String name) {
            this.id = id;
            this.name = name;
        }
        public static List<Contestant> getMockdata()
        {
            List<Contestant> list = new List<Contestant>();
            list.Add(new Contestant("11", "Tran Hai Dien"));
            list.Add(new Contestant("12", "Nguyen Truong Lam"));
            list.Add(new Contestant("13", "Mai Quoc Khanh"));
            return list;
        }
    }
}
