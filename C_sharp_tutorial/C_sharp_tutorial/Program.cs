using System;
using static c_sharp_tutorial.example;

namespace C_sharp_tutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            StaffObj data = new StaffObj("haziq", 24, "ahmad", 28, "ipms");
            Console.WriteLine(data.Name);
            Console.WriteLine(data.Project);
            Console.WriteLine(data.StaffAge);
            Console.WriteLine(data.StaffName);
            Console.WriteLine(data.TotalStaff);

            var data2 = new CloudConnect("haziq", 10, "ipms");

            var enumdata = Enum.GetValues(typeof(department));
            var singleenum = Enum.Parse(typeof(department), department.development.ToString());

            double a = 7.99;
            Console.WriteLine(data2.manipulateData(a));

            string nama = "cloud connect asia sdn bhd";
            string email = "alifhaziq@gmail.com";
            string kosong = "";
            string number = "1234567890";

            Console.WriteLine(nama.Replace("connect", "artanis"));
            Console.WriteLine(nama.Contains("connect"));
            Console.WriteLine(email.Substring(0, email.IndexOf("@") +1));
            Console.WriteLine(nama.Remove(0,5));
            Console.WriteLine(string.IsNullOrEmpty(kosong));
            Console.WriteLine($"xxxxxx{number.Substring(5,4)}");


            //string oldskoll = myname[0] + " " + myname[1];
            //string format = string.Format("{0} {1}", myname[0], myname[1]);
            //string terpolation = $"{myname[0]} {myname[1]}";

            //Console.WriteLine(oldskoll);
            //Console.WriteLine(format);
            //Console.WriteLine(terpolation);



        }
    }
}
