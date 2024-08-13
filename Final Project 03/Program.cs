

using Final_Project_03.Models;

StudentManager student = new StudentManager();

bool menu = true;

while (menu)
{
    Console.WriteLine("\nChoose an option:");
    Console.WriteLine("1. Show all students;");
    Console.WriteLine("2. Show student by Id;");
    Console.WriteLine("3. Create a new student;");
    Console.WriteLine("4. Delete a student;");
    Console.WriteLine("5. Change data;");
    Console.WriteLine("6. Change student´s address;");
    Console.WriteLine("7. Granting a student grade;");
    Console.WriteLine("8. Show general average;");
    Console.WriteLine("9. Show average per course;");
    Console.WriteLine("10. Exit.");

    var choice = Console.ReadLine();

    switch (choice)
    {

        case "1":
            student.ShowAllStudents();
            break;

        case "2":
            Console.Write("Enter the student ID: ");
            int id = int.Parse(Console.ReadLine());

            student.StudentById(id);
            break;

        case "3":
            Console.Write("Enter the Id: ");
            int newId = int.Parse(Console.ReadLine());
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the city: ");
            string cty = Console.ReadLine();
            Console.Write("Enter the street: ");
            string s3t = Console.ReadLine();
            Console.Write("Enter the number ");
            int nmber = int.Parse(Console.ReadLine());

            student.CreateStudent(newId, name, age, new Address(cty, s3t, nmber));
            break;

        case "4":
            Console.Write("Enter the student´s Id: ");
            int idToDelete = int.Parse(Console.ReadLine());

            student.DeleteById(idToDelete);
            break;

        case "5":
            Console.Write("Enter student´s id: ");
            int idToUpdate = int.Parse(Console.ReadLine());
            Console.Write("Enter the new name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter the age: ");
            int newAge = int.Parse(Console.ReadLine());

            student.ChangingData(idToUpdate, newName, newAge);
            break;

        case "6":
            Console.Write("Enter the student´s id: ");
            int idChngAdrs = int.Parse(Console.ReadLine());
            Console.Write("Enter the city: ");
            string city = Console.ReadLine();
            Console.Write("Enter the street: ");
            string street = Console.ReadLine();
            Console.Write("Enter the number ");
            int number = int.Parse(Console.ReadLine());

            student.ChangeAddress(idChngAdrs, new Address(city, street, number));
            break;

        case "7":
            Console.Write("Enter student´s id: ");
            int idGrade = int.Parse(Console.ReadLine());
            Console.Write("Enter the exam´s score: ");
            int score = int.Parse(Console.ReadLine());
            Console.Write("Enter the course: ");
            string course = Console.ReadLine();

            student.Grade(idGrade, score, course);
            break;

        case "8":
            Console.Write("Enter student´s id: ");
            int idgenAvrg = int.Parse(Console.ReadLine());

            student.GenAvrg(idgenAvrg);
            break;

        case "9":
            Console.Write("Enter student´s id: ");
            int idCourseAvrg = int.Parse(Console.ReadLine());
            Console.Write("Enter the course: ");
            string crs = Console.ReadLine();

            student.CrsAvrg(idCourseAvrg, crs);
            break;

        case "10":
            menu = false;
            break;

        default:
            Console.Write("Invalid choice. Please try again.");
            break;
    
    }
}
