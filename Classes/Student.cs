using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student : Person
    {
        public Student(string name, int age, string email, string course) : base(name, age, email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.course = course;
        }

        public string course;

        /// <summary>
        /// Return string of information rather than breaking
        /// </summary>
        public override string ToString()
        {
            return String.Format("Name: {0}, Email: {1}, Age: {2}", name, email, age);
        }

    }
}
