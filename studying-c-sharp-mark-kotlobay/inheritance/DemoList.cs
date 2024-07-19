using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_mark_kotlobay.inheritance
{
    public class DemoList
    {
        public static void test()
        {
            List<int> intList = new List<int>(); // List for int's
            intList.Add(5);
            intList.Add(6);
            intList.Add(7);
            intList.Add(8);
            intList.Add(9);

            List<ElectricProduct> list = new List<ElectricProduct>(); // List for Game Consoles
            list.Add(new GameConsole("Sony", "PS5", "AC"));
            list.Add(new GameConsole("Microsoft", "Xbox one", "AC"));
            list.Add(new GameConsole("Meta", "Meta Quest 3", "WireLess"));

            list.Remove(list[0]);

            Console.WriteLine(list[1]);
        }
    }
}
