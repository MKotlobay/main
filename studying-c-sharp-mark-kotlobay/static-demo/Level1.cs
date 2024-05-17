using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_mark_kotlobay.static_demo
{
    public class Level1
    {
        public static void RunMe()
        {
            Console.WriteLine("Hi, I am class Level1");
            Level2.RunMe();
        }
    }
}
