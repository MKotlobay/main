using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studying_c_sharp_mark_kotlobay.inheritance
{
    public class ElectricProduct
    {
        public static void ShowPoly(ElectricProduct aaa)
        {
            Console.WriteLine(aaa.GetDetails());
        }
        public static void Test()
        {
            #region Build console + override
            GameConsole sonyConsole = new GameConsole("sony", "PS5", "AC");

            //sonyConsole.DisplayDetails();

            //sonyConsole.SetVersion(2);

            //sonyConsole.DisplayDetails();
            #endregion End build console + override

            #region Upcasting / Downcasting && Using is
            SmartTV SmartLGMonitor = new SmartTV(true, "lgMonitor", 100, "OLED75C3", "HDMI 2.1");
            //SmartLGMonitor.DisplaySmartFunction();

            //if (SmartLGMonitor is SmartTV)
            //{
            //    Monitor lgMonitor = (Monitor)SmartLGMonitor; // Only possible to cast from lower to higher
            //    lgMonitor.DisplayDetails();
            //}

            #region Test with Izhar
            ElectricProduct[] arr = new ElectricProduct[5];
            arr[0] = sonyConsole;
            arr[1] = SmartLGMonitor;
            arr[2] = new SmartTV(true, "aaa", 100, "OLED55C3", "HDMI 2.1");
            arr[3] = new PcAccessories("Asus", "Red", "Astrix", "HDMI 2.1");
            arr[4] = new GameConsole("Microsoft", "XBOX X", "AC");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetDetails());
            }
            ShowPoly(SmartLGMonitor);
            #endregion End test with Izhar

            #endregion End Upcasting / Downcasting && Using is
        }

        private int id;
        private string model;
        private string connectionType;
        protected int version = 1;

        public ElectricProduct(string name, string connectionType)
        {
            this.id = ++idGenerator;
            this.model = name;
            this.connectionType = connectionType;
        }

        public virtual void SetVersion(int version)
        {
            this.version = version;
        }

        public static int idGenerator = 0; // Gives id's number


        public virtual string GetDetails()
        {
            return $"id={this.id}, name={this.model}, connection type = {this.connectionType}, version={this.version}";
        }
        public void DisplayDetails()
        {
            Console.WriteLine(GetDetails());
        }
    }

    public class GameConsole : ElectricProduct
    {
        private string manufacturer;

        public GameConsole(string manufacturer, string model, string connectionType) : base(model, connectionType)
        {
            this.manufacturer = manufacturer;
        }

        public override void SetVersion(int version)
        {
            this.version = version;
        }
    }

    public class Monitor : ElectricProduct
    {
        private string manufacturer;
        private int mhz;

        public Monitor(string manufacturer, int mhz, string model, string connectionType) : base(model, connectionType)
        {
            this.manufacturer = manufacturer;
            this.mhz = mhz;
        }
        public override string GetDetails()
        {
            return base.GetDetails() + $" manufacturer={this.manufacturer}, mhz={this.mhz}";
        }
    }

    public class SmartTV : Monitor
    {
        private bool smart;

        public SmartTV(bool smart, string manufacturer, int mhz, string model, string connectionType) : base(manufacturer, mhz, model, connectionType)
        {
            this.smart = smart;
        }

        public void DisplaySmartFunction()
        {
            if (this.smart == true)
                Console.WriteLine("That monitor has Smart function");
            else
                Console.WriteLine("Has no smart function");
        }
    }

    public class PcAccessories : ElectricProduct
    {
        private string manufacturer;
        private string color;

        public PcAccessories(string manufacturer, string color, string model, string connectioType) : base(model, connectioType)
        {
            this.manufacturer = manufacturer;
            this.color = color;
        }
    }
}
