using System;
using System.Text;

namespace ConsoleAp
{
    class Program
    {
        static void Main()
        {
            IList<Student> studentList = new List<Student>() //this is the anonymous type
            {
              new Student(){StudentID = 1, StudentName = "John", age = 28},
              new Student(){StudentID = 2, StudentName = "Henry", age = 18},
              new Student(){StudentID = 3, StudentName = "Gate", age = 20},
              new Student() {StudentID = 4, StudentName = "Fred", age = 30},
              new Student(){StudentID= 5, StudentName = "Joe", age = 25}
            };

            var students = from s in studentList //using the LINQ syntax
                           select new { Id = s.StudentID, Name = s.StudentName, Age = s.age};

            foreach (var stud in students)
                Console.WriteLine(stud.Id + "_" + stud.Name);
        }

        public class Student // creating a class Student with a property (StudenrID, StudentName & age)
        {
            public int StudentID { get ; set; }
            public string  StudentName { get; set; }
            public int age { get; set; }
        }
    }
}
