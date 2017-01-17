using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Trainer : Person
    {
        public Trainer(string name, int age, string email, string subject) : base(name, age, email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.subject = subject;
        }
        public string subject;


        /// <summary>
        /// Return string of information rather than breaking
        /// </summary>
        public override string ToString()
        {
            return String.Format("Name: {0}, Email: {1}, Age: {2}, Subject: {3}", name, email, age, subject);
        }
    }
}
