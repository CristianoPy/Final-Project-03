using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_03.Models
{
    internal class StudentManager
    {
        private List<Student> Students;

        public StudentManager()
        {
            Students = new List<Student>();
            StartingData();
        }

        //Starting student´s list

        public void StartingData()
        {
            Students.Add(new Student(1, "Max Cavallera", 20, new Address("Minas Gerais", "Str. Da Macumba", 12)));
            Students.Add(new Student(2, "Fred Dust", 41, new Address("California", "13 Av.", 5)));
            Students.Add(new Student(3, "Marilyn Manson", 59, new Address("Hollywood", "Hell Av.", 666)));
            Students.Add(new Student(4, "Ozzy Osbourne", 66, new Address("London", "Rich Mont", 8)));
            Students.Add(new Student(5, "Joe Ramone", 34, new Address("New York", "Forest Hills", 1234)));

        }

        // Showing all students

        public void ShowAllStudents()
        {
            foreach(var student in Students)
            {
                Console.WriteLine(student.ToString());
               
            }
        }

        //Showing a student by id

        public void StudentById(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
                Console.WriteLine(student.ToString);

            else
                Console.WriteLine("Student not found.");
        }

        //Creating a new student


        public void CreateStudent(int id, string name, int age, Address address)
        {
            Students.Add(new Student(id, name, age, address));
        }

        //Deleting a student by id

        public void DeleteById(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
                Students.Remove(student);
            else
                Console.WriteLine("Student not found.");
        }

        //Changing student´s data

        public void ChangingData(int id, string newName, int newAge)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                student.Name = newName;
                student.Age = newAge;
            }
                
            else
                Console.WriteLine("Student not found.");
        }

        //Changing sudent´s address

        public void ChangeAddress(int id, Address newAddress)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
                student.Adress = newAddress;
            else
                Console.WriteLine("Student not found.");
        }

        //Giving a grade to a student

        public void Grade(int id, int value, string course)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                student.Grades.Add(new Grade(value, course));
            }
            else
                Console.WriteLine("Student not found.");
        }

        //Showing the general average of a student

        public void GenAvrg(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                Console.WriteLine($"General average of {student.Name} is {student.GeneralAverage()}");
            }
            else
                Console.WriteLine("Student not found.");
        }

        //Showing the average per subject of a student

        public void CrsAvrg(int id, string course)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                Console.WriteLine($"{student.Name}´s average in {course} is: {student.CourseAverage(course)}");
            }
            else
                Console.WriteLine("Student not found.");
        }
    }
}
