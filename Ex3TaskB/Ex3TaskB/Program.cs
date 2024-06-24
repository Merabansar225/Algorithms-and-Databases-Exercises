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
            Console.WriteLine("5. Exit");
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
}

