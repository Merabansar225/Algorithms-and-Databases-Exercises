using System.Linq;

namespace Ex3TaskB;
class Program
{
    static Dictionary<string, Student> students = new Dictionary<string, Student>();

    static void Main(string[] args)
    {
        string choice;
        do
        {
            Console.WriteLine("\nStudent Management System");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Remove student");
            Console.WriteLine("3. Display enrolment status");
            Console.WriteLine("4. Update enrolment status");
            Console.WriteLine("5. Display enrolled students");
            Console.WriteLine("6. Display student information by name");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    RemoveStudent();
                    break;
                case "3":
                    DisplayEnrolmentStatus();
                    break;
                case "4":
                    UpdateEnrolmentStatus();
                    break;
                case "5":
                    DisplayEnrolledStudents();
                    break;
                case "6":
                    DisplayStudentInfoByName();
                    break;
                case "7":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != "5");
    }

    static void AddStudent()
    {
        Console.Write("Enter student ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Student student = new Student(id, name);
        students[id] = student;

        Console.WriteLine("Student added successfully.");
    }

    static void RemoveStudent()
    {
        Console.Write("Enter student ID: ");
        string id = Console.ReadLine();

        if (students.ContainsKey(id))
        {
            students.Remove(id);
            Console.WriteLine("Student removed successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void DisplayEnrolmentStatus()
    {
        Console.Write("Enter student ID: ");
        string id = Console.ReadLine();

        if (students.ContainsKey(id))
        {
            Console.WriteLine("Enrolment status for {0} ({1}): {2}", students[id].Name, id, students[id].EnrolmentStatus);
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void UpdateEnrolmentStatus()
    {
        Console.Write("Enter student ID: ");
        string id = Console.ReadLine();

        if (students.ContainsKey(id))
        {
            Console.Write("Enter new enrolment status (true/false): ");
            bool enrolmentStatus;
            if (bool.TryParse(Console.ReadLine(), out enrolmentStatus))
            {
                students[id].EnrolmentStatus = enrolmentStatus;
                Console.WriteLine("Enrolment status updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid enrolment status. Please enter true or false.");
            }
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void DisplayEnrolledStudents()
    {
        Console.WriteLine("Enrolled students:");
        foreach (var student in students.Values)
        {
            if (student.EnrolmentStatus)
            {
                Console.WriteLine("ID: {0}, Name: {1}", student.ID, student.Name);
            }
        }
    }

    static void DisplayStudentInfoByName()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        var foundStudents = students.Values.Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();

        if (foundStudents.Count > 0)
        {
            Console.WriteLine("Student information:");
            foreach (var student in foundStudents)
            {
                Console.WriteLine("ID: {0}, Enrolment status: {1}", student.ID, student.EnrolmentStatus);
            }
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

}

