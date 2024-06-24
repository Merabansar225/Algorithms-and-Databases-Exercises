using System;
namespace Ex1TaskA
{
	public class Student
	{
        private string name, id;
        private int age;

        public Student(string name, string id, int age) // constructor 
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public string Name // property
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        //method
        public string GetInformation()
        {
            return string.Format("Id: {1}  \tName: {0}  \tAge: {2}", this.Name, this.Id, this.Age);
        }
    }
}

