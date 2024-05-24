using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_mark_kotlobay.basic_objects
{
    public class ObjectTemplate
    {
        public int intProperty = 10;

        public string stringProperty = "Some string";

        public bool boolProperty = false;

        public void ToggleBoolProperty()
        {
            boolProperty = !boolProperty;
        }

    }

    public class TestBasicObject
    {
        public static void Demo()
        {
            ObjectTemplate template1 = new ObjectTemplate();

            Console.WriteLine("Template1 = intProperty = {0}, stringProperty = {1}, boolProperty = {2}", template1.intProperty, template1.stringProperty, template1.boolProperty);
            template1.intProperty = 100;
            template1.stringProperty = "hello";
            template1.boolProperty = true;

            Console.WriteLine("Template1 = intProperty = {0}, stringProperty = {1}, boolProperty = {2}", template1.intProperty, template1.stringProperty, template1.boolProperty);
            ObjectTemplate template2 = new ObjectTemplate();

            Console.WriteLine("Template2 = intProperty = {0}, stringProperty = {1}, boolProperty = {2}", template2.intProperty, template2.stringProperty, template2.boolProperty);
        }
    }
}
