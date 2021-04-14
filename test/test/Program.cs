using System;

namespace test
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string Name = "haziq";
            int number = 10;
            float num = 10.54f;
            bool isWork = true;
            double pormotion = 10.00;

            Console.WriteLine($"First name is: {Name}  type:{Name.GetType()} , number: {number} type: {number.GetType()} , float: {num} type: {num.GetType()} , boolean: {isWork} type: {isWork.GetType()} , double: {pormotion} type: {pormotion.GetType()}");

            Console.WriteLine("");
            Console.WriteLine("**ENUM**");
            Console.WriteLine($"enum values: {University.cafe} , {University.department} , {University.office}");
            var enumdata = Enum.GetValues(typeof(University));
            var singleenum = Enum.Parse(typeof(University), University.office.ToString());
            Console.WriteLine(enumdata);
            Console.WriteLine(singleenum);

            Console.WriteLine("");
            Console.WriteLine("**NAMESPACE AND USING**");
            Console.WriteLine("using untuk input folder dan namespace nama folder");


            var a = 10;
            var b = 20;

            Console.WriteLine("");
            Console.WriteLine("**ARITHEMIC**");
            Console.WriteLine($"addition: {a + b}");
            Console.WriteLine($"mutiple: {a * b}");
            Console.WriteLine($"subtraction: {a - b}");
            Console.WriteLine($"division: {a / b}");
            Console.WriteLine($"reminder: {a % b}");

            Console.WriteLine("");
            Console.WriteLine("**OPERATOR**");
            Console.WriteLine($"Equal to: {a == b}");
            Console.WriteLine($"Not equal: {a != b}");
            Console.WriteLine($"lebih besar / sama: {a >= b}");
            Console.WriteLine($"lebih kecil / sama: {a <= b}");


            var z = 5;
            var x = 3;
            Console.WriteLine("");
            Console.WriteLine("**LOGICAL**");
            Console.WriteLine($"And : {z > x && z < x}");
            Console.WriteLine($"Or: {z <= x || z >= x }");

            var kira = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("");
            Console.WriteLine("**ARRAY**");
            for (var c = 0; c < kira.Length; c++)
            {
                Console.WriteLine(kira[c]);
            }

            Console.WriteLine("");
            var phone = new string[] { "nokia", "samsung", "iphone" };
            foreach (string i in phone)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("**INHERIT : BASE**");
            var data2 = new carsObj("dunlop", 4, "honda", 219, true);//instance
            var data4 = new carsObj("dunlop", 4, "honda", 219, true);//instance

            Console.WriteLine($"nama tayar: {data2.Tyre}, bilangan tayar:{data2.blgntyre}, nama kereta:{data2.nama}, No Plat:{data2.Noplat}, is Available{data2.Isavailable}");

            Console.WriteLine("");
            Console.WriteLine("**STATIC**");
            Console.WriteLine($"static value: {user.id}");

            Console.WriteLine("");
            car p = new car();
            string result = p.person("alyph haziq", 25);
            Console.WriteLine(result);

            Console.WriteLine("");
            Console.WriteLine("**BREAK**");
            for(int i =1; i < 4; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("**GOTO**");
            for (int k = 1; k < 10; k++)
            {
                if(k == 9)
                {
                    goto folder;
                }
                Console.WriteLine(k);
            }
            folder: Console.WriteLine("the end");
            

            string PhoneNumber = "01234567890";
            string Nama = "CLOUD CONNECT SDN BHD";
            string BrokenName = "  Desa Rasa  ";
            char[] trimchar = {' '};
            Console.WriteLine("");
            Console.WriteLine(Nama.Replace("CLOUD" , "MEGAH"));
            Console.WriteLine(BrokenName.Trim(trimchar));
            Console.WriteLine($"xxxxxx{PhoneNumber.Substring(5, 4)}");
        }
    }
    public enum University
    {
        department,
        office,
        cafe
    }
}
