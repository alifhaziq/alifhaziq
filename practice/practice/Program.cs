using System;
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
        public string firstName;
        public string lastName;
        public string fullName;

        public void Introduce()
        {
            Console.WriteLine("my name is "+ firstName + " " + lastName);
            Console.WriteLine($"my name is : {firstName} {lastName} {fullName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new person();
            john.firstName = "alyph";
            john.lastName = "haziq";
            john.fullName = "Bin Rosli";
            john.Introduce();

            calculator calculator = new calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var method = shippingMethod.RegisteredAirMail;
            Console.WriteLine((int)method);

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format($"a : {a} , b : {b}", a , b)) ;

            int hour = 10;
            if (hour > 0 && hour <= 10)
            {
                Console.WriteLine("it's morning");
            }
            else
            {
                Console.WriteLine("it's afternoon");
            }

            int z = 20;
            for (var data = z; data > 20; data++) ;
            Console.WriteLine("helloworld!");

            int[] arr1 = { 1,  2, 3 } ;

            //for (var i = 0; i > Name.Length; i++)
            //{
            //    Console.WriteLine(Name[i]);
            //}
            foreach (var character in arr1)
            {
                Console.WriteLine(character);
            }

            var kedai = "d'rasa selera";
            Console.WriteLine($"to upper: {kedai.ToUpper()}");
            Console.WriteLine(kedai.Replace("d'rasa" , "kenyang"));

            var index = kedai.IndexOf(' ');
            var firstname = kedai.Substring(0, index);
            //var lastname = kedai.Substring(1, index);
            Console.WriteLine($"firstname:{firstname}");
        }
    }
}
