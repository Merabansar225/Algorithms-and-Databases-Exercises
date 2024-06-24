using System;

namespace Ex3TaskB
{
    public class Student
    {
        private string id;
        private string name;
        private bool enrolmentStatus;

        public Student(string id, string name, bool enrolmentStatus = true)
        {
            ID = id;
            Name = name;
            EnrolmentStatus = enrolmentStatus;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool EnrolmentStatus
        {
            get { return enrolmentStatus; }
            set { enrolmentStatus = value; }
        }
    }

}

