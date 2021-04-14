using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class kereta
    {
        public kereta(string Name, int noPlat, bool isAvailble)
        {
            this.nama = Name;
            this.Noplat = noPlat;
            this.Isavailable = isAvailble;
        }
        public string nama { get; set; }
        public int Noplat { get; set; }
        public bool Isavailable { get; set; }

    }
        public class carsObj : kereta
        {
            public carsObj(string tayar, int numberTyre , string Name, int noPlat, bool isAvailble) : base(Name,noPlat,isAvailble)
        {
            this.Tyre = tayar;
            this.blgntyre = numberTyre;
            

        }
        public string Tyre { get; set; }

        public int blgntyre { get; set; }

    }

    
    public static class user
    {
        public static int id = 5;
    }
    public class car
    {
        public string person(string name, int age)
        {
            var info = string.Format("Name: {0}, Age: {1}", name, age);
            return info;
        }
    }

}
