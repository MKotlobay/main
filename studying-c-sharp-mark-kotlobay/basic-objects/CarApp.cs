using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_mark_kotlobay.basic_objects
{
    public class CarApp
    {
        public static void CarGarageHome()
        {
            Console.WriteLine("#############################################");

            Console.WriteLine("City located ?");
            string city = Console.ReadLine();

            Console.WriteLine("Address of home ?");
            string address = Console.ReadLine();

            Console.WriteLine("Garage amount of parkings ?");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("#############################################");

            Garage garage = new Garage(num);

            Home home = new Home(address, city, garage);

            home.ToString();
        }
    }

    public class Car
    {
        public int HorsePower;
        public int YearBuilt;
        public string FuelType;
        public string Model;

        public Car(int horsePower, int yearBuilt, string fuelType, string model)
        {
            this.HorsePower = horsePower;
            this.FuelType = fuelType;
            this.Model = model;
            this.YearBuilt = yearBuilt;
        }

        public void ToString()
        {
            Console.WriteLine("Have " + this.HorsePower + " amount with fuel type " + this.FuelType + " and the model is " + this.Model + " that built in year " + this.YearBuilt);
        }
    }

    public class Garage
    {
        public Car[] park;

        public Garage(int num)
        {
            this.park = new Car[num];

            for (int i = 0; i < num; i++)
            {   
                Console.WriteLine("How much HP ?");
                int horsePower = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Year made ?");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Fuel type ? hybrid/fuel/plug in ?");
                string fueltype = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Full name of model");
                string model = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("#############################################");

                Car car = new Car(horsePower, year, fueltype, model);

                this.park[i] = car;
            }

        }
        public void ToString()
        {
            for (int i = 0;i < this.park.Length; i++)
            {
                park[i].ToString();
            }
        }
    }

    public class Home
    {
        public string Address;
        public string City;
        public Garage Garage;

        public Home(string address, string city, Garage garage)
        {
            this.Address = address;
            this.City = city;
            this.Garage = garage;
        }

        public void ToString()
        {
            Console.WriteLine("In city: " + this.City + "In Address: " + this.Address + " Have this cars models in garage");
            Garage.ToString();
        }
    }
}
