using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {

        public static List<Course> listOfCourses = new List<Course>();
        public static List<Student> listOfStudents = new List<Student>();
        public static List<Trainer> listOfTrainers = new List<Trainer>();

        static void Main(string[] args)
        {
            
            bool quit = false;

            Console.WriteLine("Hello");

            while (!quit)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1: Add a student");
                Console.WriteLine("2: Add a teacher");
                Console.WriteLine("3: Add a course");
                Console.WriteLine("4: Test Int");
                Console.WriteLine("5: Try DateTime");
                Console.WriteLine("Q: Quit");

                char option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        addStudent();
                        break;
                    case '2':
                        addTrainer();
                        break;
                    case '3':
                        addCourse();
                        break;
                    case '4':
                        testInt();
                        break;
                    case '5':
                        testDateTime();
                        break;
                    case 'Q':
                    case 'q':
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }

            }
        }

        static void testDateTime()
        {
            Input.getDateTime("Please enter a date");
        }

        static void testInt()
        {
            Input.GetInt("Please enter a number");
        }

        static void addCourse()
        {
            string name;
            List<Trainer> trainers = new List<Trainer>();
            List<Student> students = new List<Student>();

            while ("pigs" != "flying")
            {
                Console.WriteLine("What is the name of the course?");
                name = Console.ReadLine();

                if (name != "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a name for the course");
                }

            }

            Course course = new Course(name, students, trainers);
            Console.WriteLine("You added {0}", course);

            foreach (var student in listOfStudents)
            {
                if (student.course == course.name)
                {
                    course.students.Add(student);
                }
            }

            foreach (var trainer in listOfTrainers)
            {
                if (trainer.subject == course.name)
                {
                    course.trainers.Add(trainer);
                }
            }

        }

        static void addTrainer()
        {
            //Defining the variables
            string name;
            int age;
            string email;
            string subject;

            while ("pigs" != "flying")
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Please enter your name");
                    continue;
                }
                else
                {
                    break;
                }

            }



            //Loop to make sure age is a number
            while ("pigs" != "flying")
            {
                Console.WriteLine("Thank you {0}, what is your age? (As a number please)", name);
                string stringAge = Console.ReadLine();
                //Leaves loop if age is a number
                if (int.TryParse(stringAge, out age))
                {
                    break;
                }
                //Continues if it isn't.
                else
                {
                    Console.WriteLine("Please enter a number");
                    continue;
                }
            }

            while ("pigs" != "flying")
            {
                Console.WriteLine("What is your email? (If none, leave blank)");
                email = Console.ReadLine();
                if (email == "")
                {
                    //Email is allowed to be blank
                    break;
                }
                if (email.Contains("@") && email != "")
                {
                    //Leaves loop if email contains @
                    break;
                }
                else
                {
                    //Email must contain an @ symbol
                    Console.WriteLine("Please enter a valid email address or nothing");
                    continue;
                }
            }

            while ("pigs" != "flying")
            {
                Console.WriteLine("What subject do you teach?");
                subject = Console.ReadLine();

                if (subject != "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a subject");
                    continue;
                }
            }

            Trainer trainer = new Trainer(name, age, email, subject);
            Console.WriteLine("Thank you {0}", trainer.ToString());

            listOfTrainers.Add(trainer);

            foreach (var course in listOfCourses)
            {
                if (course.name == trainer.subject)
                {
                    course.trainers.Add(trainer);
                }
            }
            

            
        }

        static void addStudent()
        {

            //Defining the variables
            string name;
            int age;
            string email;
            string course;

            while ("pigs" != "flying")
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Please enter your name");
                    continue;
                }
                else
                {
                    break;
                }

            }



            //Loop to make sure age is a number
            while ("pigs" != "flying")
            {
                Console.WriteLine("Thank you {0}, what is your age? (As a number please)", name);
                string stringAge = Console.ReadLine();
                //Leaves loop if age is a number
                if (int.TryParse(stringAge, out age))
                {
                    break;
                }
                //Continues if it isn't.
                else
                {
                    Console.WriteLine("Please enter a number");
                    continue;
                }
            }

            while ("pigs" != "flying")
            {
                Console.WriteLine("What is your email? (If none, leave blank)");
                email = Console.ReadLine();
                if (email == "")
                {
                    //Email is allowed to be blank
                    break;
                }
                if (email.Contains("@") && email != "")
                {
                    //Leaves loop if email contains @
                    break;
                }
                else
                {
                    //Email must contain an @ symbol
                    Console.WriteLine("Please enter a valid email address or nothing");
                    continue;
                }
            }

            while ("pigs" != "flying")
            {
                Console.WriteLine("What course are you on?");
                course = Console.ReadLine();

                bool courseTest = true;

                if (course != "")
                {
                    
                    foreach (var oldCourse in listOfCourses)
                    {
                        while (courseTest)
                        {
                            if (oldCourse.name == course)
                            {
                                courseTest = false;
                                break;
                            }
                        }
                        
                    }
                    //If there's no course with that name, add it
                    if (courseTest)
                    {
                        Student newStudent = new Student(name, age, email, course);
                        List<Trainer> trainers = new List<Trainer>();
                        List<Student> students = new List<Student>();
                        students.Add(newStudent);
                        Course newCourse = new Course(name, students, trainers);
                        listOfCourses.Add(newCourse);
                    }
                    
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a course");
                    break;
                }
            }

            Student student = new Student(name, age, email, course);
            Console.WriteLine("Thank you {0}", student.ToString());

            listOfStudents.Add(student);
        }
    }
}
