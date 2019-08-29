using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DayThreeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAB 1");
            Program program = new Program();
            int sum = 0;
            int product = program.multiplyThreeIntegers(2, 4, 8, out sum);
            Console.WriteLine("product: " + product);
            Console.WriteLine("sum: " + sum);


            Console.WriteLine("LAB 2");
            Cat cat01 = new Cat("Tibby", 2);
            Cat.Age(cat01);
            Cat.Age(cat01);

            var json = new JavaScriptSerializer().Serialize(cat01);
            Console.WriteLine("Cat: " + json.ToString());
            Console.Read();

        }

        public int multiplyThreeIntegers(int arg0, int arg1, int arg2, out int sum)
        {
            sum = arg0 + arg1 + arg2;
            return arg0 * arg1 * arg2;
        }
    }

    class Cat
    {
        public string name;
        public int age;
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static void Age(Cat cat)
        {
            cat.age += 5;
        }
    }
}
