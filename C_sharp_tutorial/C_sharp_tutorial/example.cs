using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_tutorial
{
    public class example
    {
        public class CloudConnect
        {
            public CloudConnect(string name, int totalStaff, string project)
            {
                this.Name = name;
                this.TotalStaff = totalStaff;
                this.Project = project;
            }
            public string Name { get; set; }
            public int TotalStaff { get; set; }

            public string printName()
            {
                return Project;
            }

            public string[] manipulateData(double age)
            {
                var newAge = age.ToString().Split('.');
                return newAge; 
            }


            public string Project { get; set; }
        }

        public class StaffObj : CloudConnect
        {
            public StaffObj(string staffName, int staffage, string name, int totalstaff, string project) : base(name, totalstaff, project)
            {
                this.Name = name;
                this.TotalStaff = totalstaff;
                this.Project = project;
                this.TotalStaff = totalstaff;
                this.StaffAge = staffage;
            }

            public string StaffName { get; set; }

            public int StaffAge { get; set; }

            public string printProject()
            {
                return Project;
            }
        }


        public static class User
        {
            public static int Id = 10;

            public static int printId()
            {
                return Id;
            }
        }

        public enum department
        {
            hr,
            development,
            admin
        }
    }
}
