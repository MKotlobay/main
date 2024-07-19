using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static studying_c_sharp_mark_kotlobay.mahat_practice.Summer_2023_due_b;

namespace studying_c_sharp_mark_kotlobay.mahat_practice
{
    #region Task 3
    public class Summer_2023_due_b
    {
        public class First
        {
            protected int num;
            public First(int num)
            {
                this.num = num;
            }
            public First()
            {
                this.num = 10;
            }
            public override string ToString()
            {
                return $"num = {this.num}";
            }
        }
        public class Second : First
        {
            private double x;
            private First f;
            public Second() : base()
            {
                // num = 10 by default of "base"
                this.x = 1.1;
                // f by defauly will be null by constructor
            }
            public Second(int num, First f) : base(num)
            {
                base.num = num;
                this.x = num * 1.1;
                this.f = f;
            }
            public Second(int num1, double num2, First f)
            {
                int num = 5;
                this.x = num * 1.1;
                this.f = f;
            }
            public override string ToString()
            {
                return base.ToString() + $" ,x = {this.x} ,f = {this.f}";
            }
        }
    }
    public class Test
    {
        public static void Test3()
        {
            First[] arr = new First[5];
            arr[0] = new First(13);
            arr[1] = new First();
            arr[2] = new Second();
            arr[3] = new Second(5, arr[0]);
            arr[4] = new Second(2, 3.7, arr[2]);

            // To print
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    #endregion End task 3

    public class Shape
    {
        public Shape()
        {
        }
    }
    public class Circle : Shape
    {
        public Circle() : base()
        {
        }
    }
    public class Triangle : Shape
    {
        public Triangle() : base()
        {
        }
    }
    public class Square : Shape
    {
        public Square() : base()
        {
        }
    }
    public class Cylinder : Circle
    {
        public Cylinder() : base()
        {
        }
    }
    public class shapingIt
    {
        /*
        public static void testIt()
        {
            // Default
            Shape s1 = new Shape();
            Shape s2 = new Circle();
            Shape s3 = new Cylinder();
            Circle c = new Cylinder();


            Circle c0 = new Shape(); // שגיאת קומפילציה
            Circle c1 = s1; // שגיאת קומפילציה
            Circle c2 = (Circle)s2; // תקין
            Circle c3 = (Circle)s3; // תקין 
            Circle c4 = (Circle)s1; // תקין
            // תקין
            Triangle t = new Triangle();
            Shape s5 = t;
            Circle c5 = (Circle)s5;
            Shape s = (Circle)(new Cylinder()); // תקין
            Circle c = (Shape)(new Cylinder()); // שגיאת קומפילציה
        }
        */
    }
}
