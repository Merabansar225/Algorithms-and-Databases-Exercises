namespace Ex1TaskA;
class Program
{
    static void Main(string[] args)
    {
        // array of students

        Student[] studentsArray = new Student[10];

        studentsArray[0] = new Student("Ben", "A101", 18);
        studentsArray[1] = new Student("Joe", "A102", 23);
        studentsArray[2] = new Student("George", "A103", 32);
        studentsArray[3] = new Student("Ibrahim", "A104", 12);
        studentsArray[4] = new Student("Stella", "A105", 25);
        studentsArray[5] = new Student("Luisa", "A106", 24);
        studentsArray[6] = new Student("Ahmed", "A107", 28);
        studentsArray[7] = new Student("Oliver", "A108", 33);
        studentsArray[8] = new Student("Nadia", "A109", 22);
        studentsArray[9] = new Student("Laura", "A110", 31);

        // loop for array

        for (int i = 0; i < studentsArray.Length; i++)
        {
            Console.WriteLine(studentsArray[i].GetInformation());
        }
    }
}

