using System;
using practice.math;

namespace practice
{
    public class person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("my name is "+ firstName + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new person();
            john.firstName = "alyph";
            john.lastName = "haziq";
            john.Introduce();

            calculator calculator = new calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

        }
    }
}
