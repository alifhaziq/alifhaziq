using System;
using System.Collections.Generic;
using practice.math;

namespace practice
{
    public enum shippingMethod
    {
        regularAirMall = 1,
        RegisteredAirMail = 2, 
        Express = 3,
    }
    public class person
    {
        public DateTime BirthDate { get; set; }

    }

    partial class Program
    {
        public class person
        {
            public string Name;
            
            public void Introduce(string to)
            {
                Console.WriteLine($"Hi I Am {Name}");
            }
            public static person Parse(string str)
            {
                var person = new person ();
                person.Name = str;

                return person;
            }
        }
        static void Main(string[] args)
        {
            ////var john = new person();
            ////john.firstName = "alyph";
            ////john.lastName = "haziq";
            ////john.fullName = "Bin Rosli";
            ////john.Introduce();

            //calculator calculator = new calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);

            //var method = shippingMethod.RegisteredAirMail;
            //Console.WriteLine((int)method);

            //var a = 10;
            //var b = a;
            //b++;
            //Console.WriteLine(string.Format($"a : {a} , b : {b}", a , b)) ;

            //int hour = 10;
            //if (hour > 0 && hour <= 10)
            //{
            //    Console.WriteLine("it's morning");
            //}
            //else
            //{
            //    Console.WriteLine("it's afternoon");
            //}

            //int z = 20;
            //for (var data = z; data > 20; data++) ;
            //Console.WriteLine("helloworld!");

            //int[] arr1 = { 1,  2, 3 } ;

            ////for (var i = 0; i > Name.Length; i++)
            ////{
            ////    Console.WriteLine(Name[i]);
            ////}
            //foreach (var character in arr1)
            //{
            //    Console.WriteLine(character);
            //}

            //var kedai = "d'rasa selera";
            //Console.WriteLine($"to upper: {kedai.ToUpper()}");
            //Console.WriteLine(kedai.Replace("d'rasa" , "kenyang"));

            //var index = kedai.IndexOf(' ');
            //var firstname = kedai.Substring(0, index);
            ////var lastname = kedai.Substring(1, index);
            //Console.WriteLine($"firstname:{firstname}");


            //var Person = person.Parse("john");
            //Person.Introduce("mosh");

            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.promote();

            Console.WriteLine(customer.Orders.Count);

            //var point = new Point(10, 20);
            //point.move(new Point(40, 60));
            //Console.WriteLine($"Point is at {point.x} {point.y}");

            //point.move(100, 200);
            //Console.WriteLine($"Point is at {point.x} {point.y}");


        }
    }
}
