using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace practice_linq
{
     public class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int age { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID &&
                     x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }




    public class Program
    {
        //cara cari element collections in linq
        //    static void Main(string[] args)
        //    {
        //        Student[] studentArray = {
        //                new Student() { StudentID = 1, StudentName = "John", age = 18 } ,
        //                new Student() { StudentID = 2, StudentName = "Steve",  age = 21 } ,
        //                new Student() { StudentID = 3, StudentName = "Bill",  age = 25 } ,
        //                new Student() { StudentID = 4, StudentName = "Ram" , age = 20 } ,
        //                new Student() { StudentID = 5, StudentName = "Ron" , age = 31 } ,
        //                new Student() { StudentID = 6, StudentName = "Chris",  age = 17 } ,
        //                new Student() { StudentID = 7, StudentName = "Rob",age = 19  } ,
        //            };

        //        Use LINQ to find teenager students
        //        Student[] teenAgerStudents = studentArray.Where(s => s.age > 12 && s.age < 20).ToArray();

        //        Use LINQ to find first student whose name is Bill
        //       Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

        //        Use LINQ to find student whose StudentID is 5
        //        Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
        //    }

        //LAMBDA EXPRESSION
        //delegate bool IsTeenAger(Student stud);
        public static void Main()
        {
            //        linq  query ke array 
            //        Data source
            //        string[] names = { "Bill", "Steve", "James", "Mohan" };

            //        LINQ Query
            //        var myLinqQuery = from name in names
            //                          where name.Contains('a')
            //                          select name;

            //        Query execution
            //        foreach (var name in myLinqQuery)
            //            Console.Write(name + " ");



            // linq query syntax in C#
            //        // string collection
            //        IList<string> stringList = new List<string>() {
            //        "C# Tutorials",
            //        "VB.NET Tutorials",
            //        "Learn C++",
            //        "MVC Tutorials" ,
            //        "Java"
            //    };

            //        // LINQ Query Syntax
            //        var result = from s in stringList
            //                     where s.Contains("Tutorials")
            //                     select s;

            //        foreach (var str in result)
            //        {
            //            Console.WriteLine(str);
            //        }


            // Student collection
            //    IList<Student> studentList = new List<Student>() {
            //        new Student() { StudentID = 1, StudentName = "John", age = 13} ,
            //        new Student() { StudentID = 2, StudentName = "Moin",  age = 21 } ,
            //        new Student() { StudentID = 3, StudentName = "Bill",  age = 18 } ,
            //        new Student() { StudentID = 4, StudentName = "Ram" , age = 20} ,
            //        new Student() { StudentID = 5, StudentName = "Ron" , age = 15 }
            //    };

            //    // LINQ Query Syntax to find out teenager students
            //    var teenAgerStudent = from s in studentList
            //                          where s.age > 12 && s.age < 20
            //                          select s;
            //    Console.WriteLine("Teen age Students:");

            //    foreach (Student std in teenAgerStudent)
            //    {
            //        Console.WriteLine(std.StudentName);
            //    }
            //}


            //// Student collection
            //IList<Student> studentList = new List<Student>() {
            //new Student() { StudentID = 1, StudentName = "John", age = 13 } ,
            //new Student() { StudentID = 2, StudentName = "Moin", age = 21 } ,
            //new Student() { StudentID = 3, StudentName = "Bill", age = 18 } ,
            //new Student() { StudentID = 4, StudentName = "Ram" , age = 20 } ,
            //new Student() { StudentID = 5, StudentName = "Ron" , age = 15 }

            //};

            //// LINQ Query Method to find out teenager students
            //var filteredResult = studentList.Where(s => s.age > 12).Where(s => s.age < 20);

            //Console.WriteLine("Teen age Students:");

            //foreach (Student std in filteredResult)
            //{
            //    Console.WriteLine(std.StudentName);
            //}


            //    // LINQ Query Method to find out teenager students
            //    var teenAgerStudent = studentList.Where(s => s.age > 12 && s.age < 20);

            //    Console.WriteLine("Teen age Students:");

            //    foreach (Student std in teenAgerStudent)
            //    {
            //        Console.WriteLine(std.StudentName);
            //    }

            //IList mixedList = new ArrayList();
            //mixedList.Add(0);
            //mixedList.Add("One");
            //mixedList.Add("Two");
            //mixedList.Add(3);
            //mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            //var stringResult = from s in mixedList.OfType<string>()
            //                   select s;

            //var intResult = from s in mixedList.OfType<int>()
            //                select s;

            //var stdResult = from s in mixedList.OfType<Student>()
            //                select s;

            //foreach (var str in stringResult)
            //    Console.WriteLine(str);

            //foreach (var integer in intResult)
            //    Console.WriteLine(integer);

            //foreach (var std in stdResult)
            //    Console.WriteLine(std.StudentName);

            //orderby operators query synta
            // Student collection
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            //};

            //var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

            //var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);

            //Console.WriteLine("Ascending Order:");

            //foreach (var std in studentsInAscOrder)
            //    Console.WriteLine(std.StudentName);

            //Console.WriteLine("");
            //Console.WriteLine("Descending Order:");

            //foreach (var std in studentsInDescOrder)
            //    Console.WriteLine(std.StudentName);


            //thenby operators
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            //};

            //var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            //var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            //Console.WriteLine("ThenBy:");

            //foreach (var std in thenByResult)
            //    Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

            //Console.WriteLine("ThenByDescending:");

            //foreach (var std in thenByDescResult)
            //    Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

            //groupby operator
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            //};

            //var groupedResult = studentList.GroupBy(s => s.Age);

            ////iterate each group        
            //foreach (var ageGroup in groupedResult)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

            //    foreach (Student s in ageGroup) // Each group has inner collection
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}

            //tolookup operator
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            //};

            //var lookupResult = studentList.ToLookup(s => s.Age);

            //foreach (var group in lookupResult)
            //{
            //    Console.WriteLine(""); 
            //    Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 

            //    foreach (Student s in group)  //Each group has a inner collection  
            //        Console.WriteLine("Student Name: {0}", s.StudentName);
            //}

            //join operator
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            //};

            //IList<Standard> standardList = new List<Standard>() {
            //    new Standard(){ StandardID = 1, StandardName="Standard 1"},
            //    new Standard(){ StandardID = 2, StandardName="Standard 2"},
            //    new Standard(){ StandardID = 3, StandardName="Standard 3"}
            //};

            //var innerJoinResult = from s in studentList // outer sequence
            //                      join st in standardList //inner sequence 
            //                      on s.StandardID equals st.StandardID // key selector 
            //                      select new
            //                      { // result selector 
            //                          StudentName = s.StudentName,
            //                          StandardName = st.StandardName
            //                      };

            //foreach (var obj in innerJoinResult)
            //{

            //    Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            //}

            //groupjoin operator
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            //};

            //IList<Standard> standardList = new List<Standard>() {
            //    new Standard(){ StandardID = 1, StandardName="Standard 1"},
            //    new Standard(){ StandardID = 2, StandardName="Standard 2"},
            //    new Standard(){ StandardID = 3, StandardName="Standard 3"}
            //};

            //var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
            //                        std => std.StandardID, //outerKeySelector 
            //                        s => s.StandardID,     //innerKeySelector
            //                        (std, studentsGroup) => new // resultSelector 
            //                    {
            //                            Students = studentsGroup,
            //                            StandarFulldName = std.StandardName
            //                        });

            //foreach (var item in groupJoin)
            //{
            //    Console.WriteLine(item.StandarFulldName);

            //    foreach (var stud in item.Students)
            //        Console.WriteLine(stud.StudentName);
            //}

            //select operator
            // IList<Student> studentList = new List<Student>() {
            //     new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            //     new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            //     new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            //     new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //     new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            //};

            // // returns collection of anonymous objects with Name and Age property
            // var selectResult = studentList.Select(s => new { Name = s.StudentName, Age = s.Age });

            // // iterate selectResult
            // foreach (var item in selectResult)
            //     Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);

            //any operator
            //    IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            //    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            //};

            //    // checks whether any the students are teenagers    
            //    bool areAllStudentsTeenAger = studentList.Any(s => s.Age < 12 && s.Age > 20);


            //    Console.WriteLine(areAllStudentsTeenAger);

            //contains operator
            {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

                Student std = new Student() { StudentID = 3, StudentName = "Bill" };

                bool result = studentList.Contains(std, new StudentComparer());

                Console.WriteLine(result);
            }

        }
    }
}




