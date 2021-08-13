using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV102_CS486_Team13.model
{
    class Round
    {
        public String id;
        public int roundNumber;
        public int numberReverse;
        public int numberOfficial;
        public Round() { }
        public Round(String id, int roundNumber, int numberReverse, int numberOfficial)
        {
            this.id = id;
            this.roundNumber = roundNumber;
            this.numberReverse = numberReverse;
            this.numberOfficial = numberOfficial;
        }
        public static List<Round> getMockdata()
        {
            List<Round> list = new List<Round>();
            list.Add(new Round("Start", 1, 2,4));
            list.Add(new Round("Attack", 1,1,2));
            return list;
        }
    }
}
