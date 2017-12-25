using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp_Example_Usage
{
    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string name { get; set; }
        public string tag { get; set; }
        public int rank { get; set; }
        public int previousRank { get; set; }
        public int expLevel { get; set; }
        public int trophies { get; set; }
        public Clan clan { get; set; }
        public Arena arena { get; set; }
    }

    public class Clan
    {
        public string tag { get; set; }
        public string name { get; set; }
        public int badge { get; set; }
    }

    public class Arena
    {
        public string name { get; set; }
        public string arena { get; set; }
        public int arenaID { get; set; }
        public int trophyLimit { get; set; }
    }
}
