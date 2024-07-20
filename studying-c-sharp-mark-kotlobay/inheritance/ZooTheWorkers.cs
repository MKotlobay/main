using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_mark_kotlobay.inheritance
{
    public class ZooTheWorkers
    {
        public void testZoo()
        {
            Animal[] animals = new Animal[]
            {
                new Eagle("Eagle", 5, true, 2000, 3000, 200, 500, "Screech", "Soar", true),
                new Bird("Parrot", 3, false, 1000, 1000, 50, 100, "Chirp", "Bounce"),
                new Animal("Penguin", 4, false, 500),
                new Bird("Sparrow", 2 , false, 500, 500, 20, 50, "Tweet", "Flit"),
                new Bird("Owl", 6, true, 1800, 2000, 100, 300, "Hoot", "Glide"),
                new Hipo("Hippo1", 7, false, 3000, 2000, 9, 20),
                new Hipo("Hippo2", 8, false, 3500, 2500, 10, 25)
            };
            BirdSings(animals);
            Console.WriteLine("Amount of calories for all" + OverallCaloriesInArr(animals));
            DancingBirdsSnakes(animals);
            Console.WriteLine("Hipopotam with most fat is: " + MostFatHipo(animals));
        }

        public class Animal
        {
            protected string animalName;
            protected int age;
            protected bool isApexPredator;
            protected int caloriesToMeal;
            public Animal(string animalName, int age, bool isApexPredator, int caloriesToMeal)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
            }
            public string AnimalName { get => animalName; set => animalName = value; }
            public int Age { get => age; set => age = value; }
            public bool IsApexPredator { get => isApexPredator; set => isApexPredator = value; }
            public int CaloriesToMeal { get => caloriesToMeal; set => caloriesToMeal = value; }
            public override string ToString()
            {
                return $"Animal name: {this.animalName}, Age: {this.age}, is Apex predator: {this.isApexPredator}, Eating amount of calories in one meal: {this.caloriesToMeal}";
            }
            public virtual int Eat() { return 3 * this.caloriesToMeal; }
        }

        public class Mammal : Animal
        {
            protected int milkCalories;
            protected int pregnancyMonths;
            public Mammal(string animalName, int age, bool isApexPredator, int caloriesToMeal, int milkCalories, int pregnancyMonths) : base(animalName, age, isApexPredator, caloriesToMeal)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.milkCalories = milkCalories;
                this.pregnancyMonths = pregnancyMonths;
            }
            public int MilkCalories { get => milkCalories; set => milkCalories = value; }
            public int PregnancyMonths { get => pregnancyMonths; set => pregnancyMonths = value; }
            public override string ToString()
            {
                return base.ToString() + $" Calories in milk: {this.milkCalories}, Amount of pregnancy months: {this.pregnancyMonths}";
            }
            public override int Eat() { return (base.Eat() + (this.milkCalories) * 3); }
        }

        public class Reptile : Animal
        {
            protected int tailLength;
            public Reptile(string animalName, int age, bool isApexPredator, int caloriesToMeal, int tailLength) : base(animalName, age, isApexPredator, caloriesToMeal)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.tailLength = tailLength;
            }
            public int TailLength { get => tailLength; set => tailLength = value; }
            public override string ToString()
            {
                return base.ToString() + $" Length of tail: {this.tailLength}";
            }
            public override int Eat() { return base.Eat(); }
        }

        public class Bird : Animal
        {
            protected int flightHeight;
            protected int wingsLength;
            protected int endDaySnack;
            protected string typeOfWhistle;
            protected string typeOfDance;
            public Bird(string animalName, int age, bool isApexPredator, int caloriesToMeal, int flightHeight, int wingsLength, int endDaySnack, string typeOfWhistle, string typeOfDance) : base(animalName, age, isApexPredator, caloriesToMeal)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.flightHeight = flightHeight;
                this.wingsLength = wingsLength;
                this.endDaySnack = endDaySnack;
                this.typeOfWhistle = typeOfWhistle;
                this.typeOfDance = typeOfDance;
            }
            public override string ToString()
            {
                return base.ToString() + $" Flight height: {this.flightHeight}, Wings length: {this.wingsLength}";
            }
            public override int Eat() { return base.Eat() + this.endDaySnack; }
            public string Sing() { return this.typeOfWhistle; }
            public void Dance() { Console.WriteLine($"This bird likes to dance this type of dance: {this.typeOfDance}"); }
        }

        public class Cow : Mammal
        {
            protected int birthsAmount;
            public Cow(string animalName, int age, bool isApexPredator, int caloriesToMeal, int milkCalories, int pregnancyMonths, int birthsAmount) : base(animalName, age, isApexPredator, caloriesToMeal, milkCalories, pregnancyMonths)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.milkCalories = milkCalories;
                this.pregnancyMonths = pregnancyMonths;
                this.birthsAmount = birthsAmount;
            }
            public int BirthsAmount { get => birthsAmount; set => birthsAmount = value; }
            public override string ToString()
            {
                return base.ToString() + $" Births amount: {this.birthsAmount}";
            }
            public override int Eat() { return base.Eat(); }
        }

        public class Hipo : Mammal
        {
            private int fatPercentage;
            public Hipo(string animalName, int age, bool isApexPredator, int caloriesToMeal, int milkCalories, int pregnancyMonths, int fatPercentage) : base(animalName, age, isApexPredator, caloriesToMeal, milkCalories, pregnancyMonths)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.milkCalories = milkCalories;
                this.pregnancyMonths = pregnancyMonths;
                this.fatPercentage = fatPercentage;
            }
            public int FatPercentage { get => fatPercentage; set => fatPercentage = value; }
            public override string ToString()
            {
                return base.ToString() + $" Fat percentage: {this.fatPercentage}";
            }
        }

        public class Crocodile : Reptile
        {
            private bool hadDentalTreatment;
            private int endDaySnack;
            public Crocodile(string animalName, int age, bool isApexPredator, int caloriesToMeal, int tailLength, bool hadDentalTreatment, int endDaySnack) : base(animalName, age, isApexPredator, caloriesToMeal, tailLength)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.tailLength = tailLength;
                this.hadDentalTreatment = hadDentalTreatment;
                this.endDaySnack = endDaySnack;
            }
            public bool HadDentalTreatment { get => hadDentalTreatment; set => hadDentalTreatment = value; }
            public override string ToString()
            {
                return base.ToString() + $" Had dental treatment: {this.hadDentalTreatment}";
            }
            public override int Eat() { return base.Eat() + this.endDaySnack; }
        }

        public class Snake : Reptile
        {
            private bool isPoisonous;
            private string typeOfDance;
            public Snake(string animalName, int age, bool isApexPredator, int caloriesToMeal, int tailLength, bool isPoisonous, string typeOfDance) : base(animalName, age, isApexPredator, caloriesToMeal, tailLength)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.tailLength = tailLength;
                this.isPoisonous = isPoisonous;
                this.typeOfDance = typeOfDance;
            }
            public bool IsPoisonous { get => isPoisonous; set => isPoisonous = value; }
            public override string ToString()
            {
                return base.ToString() + $" Is it poisonous: {this.isPoisonous}";
            }
            public void Dance() { Console.WriteLine($"This snake likes to dance this type of dance: {this.typeOfDance}"); }
        }

        public class Eagle : Bird
        {
            private bool canFlyFar;
            public Eagle(string animalName, int age, bool isApexPredator, int caloriesToMeal, int flightHeight, int wingsLength, int endDaySnack, string typeOfWhistle, string typeOfDance, bool canFlyFar) : base(animalName, age, isApexPredator, caloriesToMeal, flightHeight, wingsLength, endDaySnack, typeOfWhistle, typeOfDance)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.flightHeight = flightHeight;
                this.wingsLength = wingsLength;
                this.endDaySnack = endDaySnack;
                this.typeOfWhistle = typeOfWhistle;
                this.typeOfDance = typeOfDance;
                this.canFlyFar = canFlyFar;
            }
            public bool CanFlyFar { get => canFlyFar; set => canFlyFar = value; }
            public override string ToString()
            {
                return base.ToString() + $" Is it able to make far flights: {this.canFlyFar}";
            }
        }

        public class DairyCattle : Cow
        {
            private string feedType;
            public DairyCattle(string animalName, int age, bool isApexPredator, int caloriesToMeal, int milkCalories, int pregnancyMonths, int birthsAmount, string feedType) : base(animalName, age, isApexPredator, caloriesToMeal, milkCalories, pregnancyMonths, birthsAmount)
            {
                this.animalName = animalName;
                this.age = age;
                this.isApexPredator = isApexPredator;
                this.caloriesToMeal = caloriesToMeal;
                this.milkCalories = milkCalories;
                this.pregnancyMonths = pregnancyMonths;
                this.birthsAmount = birthsAmount;
                this.feedType = feedType;
            }
            public string FeedType { get => feedType; set => feedType = value; }
            public override string ToString()
            {
                return base.ToString() + $" Feed type: {this.feedType}";
            }
        }

        public int OverallCaloriesInArr(Animal[] zooArr) // Test it
        {
            int caloriesAmount = 0;

            for (int i = 0; i < zooArr.Length; i++)
            {
                caloriesAmount += zooArr[i].Eat();
            }
            return caloriesAmount;
        }
        public void BirdSings(Animal[] zooArr)
        {
            for (int i = 0; i < zooArr.Length; i++)
            {
                if (zooArr[i] is Bird bird) // not only checks if the object is of type Bird but also assigns it to a variable (bird) in same statment
                {
                    Console.WriteLine(bird.Sing());
                }
            }
        }
        public void DancingBirdsSnakes(Animal[] zooArr)
        {
            for (int i = 0; i < zooArr.Length; i++)
            {
                switch (zooArr[i])
                {
                    case Bird bird:
                        bird.Dance();
                        break;
                    case Snake snake:
                        snake.Dance();
                        break;
                }
            }
        }
        public string MostFatHipo(Animal[] zooArr)
        {
            int fat = 0;
            string name = null;
            for (int i = 0; i < zooArr.Length; i++)
            {
                if (zooArr[i] is Hipo hipo)
                {
                    if (fat < hipo.FatPercentage)
                    {
                        fat = hipo.FatPercentage;
                        name = hipo.AnimalName;
                    }
                }
            }
            return name;
        }
    }
    public class Park
    {
        private ZooTheWorkers.Animal[] zoo;
        public Park(ZooTheWorkers zooTheWorkers)
        {
            this.zoo = new ZooTheWorkers.Animal[20];

            zoo[0] = new ZooTheWorkers.Eagle("Eagle", 5, true, 2000, 3000, 200, 500, "Screech", "Soar", true);
            zoo[1] = new ZooTheWorkers.Bird("Parrot", 3, false, 1000, 1000, 50, 100, "Chirp", "Bounce");
            zoo[2] = new ZooTheWorkers.Animal("Penguin", 4, false, 500);
            zoo[3] = new ZooTheWorkers.Bird("Sparrow", 2, false, 500, 500, 20, 50, "Tweet", "Flit");
            zoo[4] = new ZooTheWorkers.Bird("Owl", 6, true, 1800, 2000, 100, 300, "Hoot", "Glide");
            zoo[5] = new ZooTheWorkers.Hipo("Hippo1", 7, false, 3000, 2000, 9, 20);
            zoo[6] = new ZooTheWorkers.Hipo("Hippo2", 8, false, 3500, 2500, 10, 25);
            zoo[7] = new ZooTheWorkers.Crocodile("Crocodile1", 10, true, 2500, 300, true, 100);
            zoo[8] = new ZooTheWorkers.Snake("Python", 5, true, 1000, 250, true, "Slither");
            zoo[9] = new ZooTheWorkers.Cow("Cow1", 5, false, 1500, 1000, 9, 2);
            zoo[10] = new ZooTheWorkers.DairyCattle("DairyCattle1", 4, false, 1400, 900, 9, 3, "Grass");
            zoo[11] = new ZooTheWorkers.Bird("Finch", 2, false, 300, 200, 10, 20, "Chirp", "Hop");
            zoo[12] = new ZooTheWorkers.Mammal("Lion", 8, true, 2500, 200, 4);
            zoo[13] = new ZooTheWorkers.Reptile("Lizard", 3, false, 400, 50);
            zoo[14] = new ZooTheWorkers.Animal("Frog", 1, false, 100);
            zoo[15] = new ZooTheWorkers.Eagle("BaldEagle", 6, true, 2200, 3200, 220, 550, "Screech", "Glide", true);
            zoo[16] = new ZooTheWorkers.Hipo("Hippo3", 9, false, 3700, 2700, 11, 27);
            zoo[17] = new ZooTheWorkers.Crocodile("Crocodile2", 12, true, 2700, 350, false, 150);
            zoo[18] = new ZooTheWorkers.Snake("Cobra", 6, true, 1200, 300, true, "Sway");
            zoo[19] = new ZooTheWorkers.DairyCattle("DairyCattle2", 5, false, 1600, 950, 9, 4, "Hay");

            List<ZooTheWorkers.Animal> listAnimalsByAge = ByAge(zoo, int.Parse(Console.ReadLine()));
            Console.WriteLine(AmountReptilesBirds(zoo));
            #region For user
            /*
            for (int i = 0;i < zoo.Length; i++)
            {
                Console.WriteLine("Choose animal to insert to zoo");
                Console.WriteLine("1 - Animal , 2 - Mammal , 3 - Reptile , 4 - Bird , 5 - Cow , 6 - Hipo , 7 - Crocodile , 8 - Snake , 9 - Eagle , 10 - Dairy Cattle");
                int choosenNum = int.Parse(Console.ReadLine());
                switch (choosenNum)
                {
                    case 1:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        zoo[i] = new ZooTheWorkers.Animal(animalName, age, isApexPredator, caloriesToMeal);
                        break;
                    }
                    case 2:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int milkCalories = int.Parse(Console.ReadLine());
                        int pregnancyMonths = int.Parse(Console.ReadLine());
                        zoo[i] = new ZooTheWorkers.Mammal(animalName, age, isApexPredator, caloriesToMeal, milkCalories, pregnancyMonths);
                        break;
                    }
                    case 3:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int tailLength = int.Parse(Console.ReadLine());
                        zoo[i] = new ZooTheWorkers.Reptile(animalName,age, isApexPredator,caloriesToMeal, tailLength);
                        break;
                    }
                    case 4:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int flightHeight = int.Parse(Console.ReadLine());
                        int wingsLength = int.Parse(Console.ReadLine());
                        int endDaySnack = int.Parse(Console.ReadLine());
                        string typeOfWhistle = Console.ReadLine();
                        string typeOfDance = Console.ReadLine();
                        zoo[i] = new ZooTheWorkers.Bird(animalName, age, isApexPredator,caloriesToMeal,flightHeight, wingsLength,endDaySnack,typeOfWhistle,typeOfDance);
                        break;
                    }
                    case 5:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int milkCalories = int.Parse(Console.ReadLine());
                        int pregnancyMonths = int.Parse(Console.ReadLine());
                        int birthsAmount = int.Parse(Console.ReadLine());
                        zoo[i] = new ZooTheWorkers.Cow(animalName, age, isApexPredator, caloriesToMeal, milkCalories, pregnancyMonths, birthsAmount);
                        break;
                    }
                    case 6:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int milkCalories = int.Parse(Console.ReadLine());
                        int pregnancyMonths = int.Parse(Console.ReadLine());
                        int fatPercentage = int.Parse(Console.ReadLine());
                        zoo[i] = new ZooTheWorkers.Hipo(animalName, age, isApexPredator, caloriesToMeal, milkCalories, pregnancyMonths, fatPercentage);
                        break;
                    }
                    case 7:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int tailLength = int.Parse(Console.ReadLine());
                        bool hadDentalTreatment = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int endDaySnack = int.Parse(Console.ReadLine());
                        zoo[i] = new ZooTheWorkers.Crocodile(animalName, age, isApexPredator, caloriesToMeal, tailLength, hadDentalTreatment, endDaySnack);
                        break;
                    }
                    case 8:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int tailLength = int.Parse(Console.ReadLine());
                        bool isPoisonous = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        string typeOfDance = Console.ReadLine();
                        zoo[i] = new ZooTheWorkers.Snake(animalName, age, isApexPredator, caloriesToMeal, tailLength, isPoisonous, typeOfDance);
                        break;
                    }
                    case 9:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int flightHeight = int.Parse(Console.ReadLine());
                        int wingsLength = int.Parse(Console.ReadLine());
                        int endDaySnack = int.Parse(Console.ReadLine());
                        string typeOfWhistle = Console.ReadLine();
                        string typeOfDance = Console.ReadLine();
                        bool canFlyFar = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        zoo[i] = new ZooTheWorkers.Eagle(animalName, age, isApexPredator, caloriesToMeal, flightHeight, wingsLength, endDaySnack, typeOfWhistle, typeOfDance, canFlyFar);
                        break;
                    }
                    case 10:
                    {
                        string animalName = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        bool isApexPredator = Console.ReadLine() == "true" || Console.ReadLine() == "false";
                        int caloriesToMeal = int.Parse(Console.ReadLine());
                        int milkCalories = int.Parse(Console.ReadLine());
                        int pregnancyMonths = int.Parse(Console.ReadLine());
                        int birthsAmount = int.Parse(Console.ReadLine());
                        string feedType = Console.ReadLine();
                        zoo[i] = new ZooTheWorkers.DairyCattle(animalName, age, isApexPredator, caloriesToMeal, milkCalories, pregnancyMonths, birthsAmount, feedType);
                        break;
                    }
                }
            }
            */
            #endregion End for user
        }
        public List<ZooTheWorkers.Animal> ByAge(ZooTheWorkers.Animal[] zooArr, int num)
        {
            List<ZooTheWorkers.Animal> listAnimalsByAge = new List<ZooTheWorkers.Animal>();
            for (int i = 0; i < zooArr.Length; i++)
            {
                if (zooArr[i].Age > num && zooArr[i].IsApexPredator == true)
                {
                    listAnimalsByAge.Add(zooArr[i]);
                }
            }
            return listAnimalsByAge;
        }
        public int AmountReptilesBirds(ZooTheWorkers.Animal[] zooArr)
        {
            int num = 0;
            for (int i = 0; i < zooArr.Length; i++)
            {
                if (zooArr[i] is ZooTheWorkers.Reptile && zooArr[i].IsApexPredator == true || zooArr[i] is ZooTheWorkers.Bird && zooArr[i].IsApexPredator == true)
                    num++;
            }
            return num;
        }
    }
}
