using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_mark_kotlobay.basic_objects
{
    // Home work 24.05.2024
    public class StockExchange
    {
        public static void StockMarket()
        {
            #region Builders + Full details prints
            Stock Apple = new Stock("Apple", 189.98, "AAPL", 191.09, 192.73, "Tech", "Nasdaq");
            Stock Tesla = new Stock("Tesla", 179.24, "TSLA", 175.51, 186.875, "Tech", "Nasdaq");
            Stock CocaCola = new Stock("Coca-Cola Consolidated", 992.65, "COKE", 944.17, 928.90, "Common", "Nasdaq");

            // Prints all details of the stock
            Console.WriteLine("#############################################");
            Apple.ToString();
            Console.WriteLine("---------------------------------------------");
            Tesla.ToString();
            Console.WriteLine("---------------------------------------------");
            CocaCola.ToString();
            #endregion Builders + Full details prints

            #region Price update + prints details updated
            // Updating higher value for price per stock
            Apple.UpdatePrice();
            Tesla.UpdatePrice();
            CocaCola.UpdatePrice();

            // Prints after changes all important details
            Console.WriteLine("#############################################");
            Apple.ToStringMiddleChange();
            Console.WriteLine("---------------------------------------------");
            Tesla.ToStringMiddleChange();
            Console.WriteLine("---------------------------------------------");
            CocaCola.ToStringMiddleChange();
            #endregion Price update + prints details updated

            #region Active update + prints details updated
            // Updating by time if stock is active
            Apple.UpdateIsActive();
            Tesla.UpdateIsActive();
            CocaCola.UpdateIsActive();

            // Prints after changes all important details
            Console.WriteLine("#############################################");
            Apple.ToStringMiddleChange();
            Console.WriteLine("---------------------------------------------");
            Tesla.ToStringMiddleChange();
            Console.WriteLine("---------------------------------------------");
            CocaCola.ToStringMiddleChange();
            #endregion Active update + prints details updated

            // Prints changes been in market per stock
            Console.WriteLine("#############################################");
            Apple.GetChanges();
            Console.WriteLine("---------------------------------------------");
            Tesla.GetChanges();
            Console.WriteLine("---------------------------------------------");
            CocaCola.GetChanges();
            Console.WriteLine("#############################################");

        }


        public class Stock
        {
            public string name;
            public double price;
            public string sign;
            public double startPrice;
            public double endPrice;
            public string industry;
            public string exchange;
            public bool isActive;

            public Stock(string name, double price, string sign, double startPrice, double endPrice, string industry, string exchange)
            {
                this.name = name;
                this.price = price;
                this.sign = sign;
                this.startPrice = startPrice;
                this.endPrice = endPrice;
                this.industry = industry;
                this.exchange = exchange;
                this.isActive = true;
            }

            public void ToString() // Fully details of the stock
            {
                Console.WriteLine(this.name + " Has price per stock " + this.price + " sign of the stock is " + sign + " price started today " + this.startPrice + " and planning to end price " + this.endPrice + " the industry is " + this.industry + " exchange is " + this.exchange + " is now " + this.isActive);
            }

            public void ToStringMiddleChange()
            {
                Console.WriteLine("Stock name: " + this.name);
                Console.WriteLine("Stock sign: " + this.sign);
                Console.WriteLine("Price in Live: " + this.price);
                Console.WriteLine("Price started: " + this.startPrice);
                Console.WriteLine("Status active: " + this.isActive);
            }

            public void GetChanges() // returns value of amount precentage change in Float
            {
                float value = (float)(((startPrice - endPrice) / endPrice) * 100);

                Console.WriteLine("Price changed today by " + value +'%');
            }

            public bool UpdateIsActive()
            {
                DateTime now = DateTime.Now;
                TimeSpan nowTime = now.TimeOfDay;
                TimeSpan marketOpen = new TimeSpan(9, 0, 0); // 09:00:00
                TimeSpan marketClose = new TimeSpan(16, 0, 0); // 16:00:00

                if (now.DayOfWeek >= DayOfWeek.Sunday && now.DayOfWeek <= DayOfWeek.Thursday && nowTime > marketOpen && nowTime < marketClose)
                    return this.isActive = true;
                return this.isActive = false;
            }

            public double UpdatePrice()
            {
                if (this.isActive == false)
                {
                    if (this.startPrice > this.price)
                        return this.price = this.startPrice;
                    else if (this.endPrice > this.price)
                        return this.price = this.endPrice;
                }
                return this.price;
            }
        }
    }
}
