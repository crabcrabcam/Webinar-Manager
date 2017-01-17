using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Course
    {
        public string name;
        public List<Student> students;
        public List<Trainer> trainers;

        public Course(string name, List<Student> students, List<Trainer> trainers)
        {
            this.name = name;
            this.students = students;
            this.trainers = trainers;
        }
    }
}
