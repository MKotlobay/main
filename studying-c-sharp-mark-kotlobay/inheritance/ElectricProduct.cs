using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace studying_c_sharp_mark_kotlobay.inheritance
{
    public class ElectricProduct
    {
        public static void Test()
        {
            GameConsole sonyConsole = new GameConsole("sony", "PS5", "AC");

            sonyConsole.DisplayDetails();
        }

        private int id;
        private string model;
        private string connectionType;

        public ElectricProduct(string name, string connectionType)
        {
            this.id = ++idGenerator;
            this.model = name;
            this.connectionType = connectionType;
        }

        public static int idGenerator = 0; // Gives id's number


        public void DisplayDetails()
        {
            Console.WriteLine($"id={this.id}, name={this.model}, connection type = {this.connectionType}");
        }
    }

    public class GameConsole : ElectricProduct
    {
        private string manufacturer;

        public GameConsole(string manufacturer , string model, string connectionType) : base(model, connectionType)
        {
            this.manufacturer = manufacturer;
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
    }

    public class SmartTV : Monitor
    {
        private bool smart;

        public SmartTV(bool smart, string manufacturer, int mhz, string model, string connectionType) : base(manufacturer, mhz, model, connectionType)
        {
            this.smart = smart;
        }

        public override string ToString()
        {
            if (this.smart == true)
                return "That monitor has Smart function";
            else
                return "Has no smart function";
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
