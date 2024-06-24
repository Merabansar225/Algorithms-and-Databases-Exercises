using System;
using System.Xml.Linq;

namespace Ex1TaskC
{
    class Customer
    {
        private string name = "";
        private int age = 0;

        public Customer(string name, int age)
        {
            SetName(name);
            SetAge(age);
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

    }

}
