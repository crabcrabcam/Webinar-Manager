using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public string name;
        public int age;
        public string email;

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            if (email == "")
            {
                this.email = "nil";
            }
            else
            {
                this.email = email;
            }
            
        }

        /// <summary>
        /// Return string of information rather than breaking
        /// </summary>
        public override string ToString()
        {
            return String.Format("Name: {0}, Email: {1}, Age: {2}", name, email, age);
        }
    }
}
