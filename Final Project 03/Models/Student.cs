using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_03.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Adress { get; set; }
        public List<Grade> Grades { get; set; }

        public Student(int id, string name, int age, Address adress)
        {
            Id = id;
            Name = name;
            Age = age;
            Adress = adress;
            Grades = new List<Grade>();
        }

        public double GeneralAverage()
        {
            if (Grades.Count == 0) return 0;
            return Grades.Average(g => g.Value);
        }

        public double CourseAverage(string course)
        {
            var courseGrade = Grades.Where(a => a.Course == course).ToList();
            if (courseGrade.Count == 0) return 0;
            return courseGrade.Average(a => a.Value);
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Age: {Age}, Adress:{Adress}";
        }
    }
}
