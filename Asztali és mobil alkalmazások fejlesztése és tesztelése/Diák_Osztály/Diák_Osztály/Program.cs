using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diák_Osztály
{
    class Student
    {
        public Student(int iD, string name, int age, bool gender, bool sC = false)
        {
            ID = iD;
            Name = name;
            Age = age;
            Gender = gender;
            SC = sC;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public bool SC { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age}, {(Gender ? "Férfi" : "Nő")}";
        }

    }

    class Classroom
    {
        public Classroom(string name, int accommodation)
        {
            Name = name;
            this.accommodation = accommodation;
            Students = new List<Student>();
        }

        public Classroom(string name, int accommodation, List<Student> students)
        {
            Name = name;
            this.accommodation = accommodation;
            Students = students;
        }

        public string AddStudent(Student student)
        {
            if (student.SC)
                return "Ez az esemény nem megvalósítható!";
            else
            {
                if (Students.Count() < accommodation)
                {
                    int count = Students.Count;
                    Students.Add(student);
                    if (count < Students.Count)
                    {
                        return $"Sikeres Felvétel! ({student.Name})";
                    }
                    else
                        return "Sikerteken felvétel";

                }
                else
                    return "Az osztályterem megtelt";

            }

        }

        public string RemoveStudent(Student student)
        {
            if (student.SC)
                return "Ez az esemény nem megvalósítható!";
            else
            {
                if (Students.Count > 0)
                {
                    int count = Students.Count;
                    Students.Remove(student);
                    if (count > Students.Count)
                        return $"Sikeres törlés! ({student.Name})";
                    else
                        return "Sikerteken törlés!";
                }
                else
                {
                    return "Az osztályterem üres";
                }
            }
            
        }

        public List<Student> ScearchInClassroom(string studentName)
        { 
            return Students.Where(x => x.Name.ToLower() == studentName.ToLower()).ToList();
        }

        public override string ToString()
        {
            string output = "";
            foreach (Student student in Students)
            {
                output += student.ToString() + "\n";
            }
            return output;
        }


        public string Name { get; set; } 
        public int accommodation { get; set; }
        public List<Student> Students { get; set; }

    }

    internal class Program
    {
        internal static Classroom classroom = new Classroom("classroom1", 15);
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Ferike", 15, true);
            Student student2 = new Student(2, "Gábor", 16, true);
            Student student3 = new Student(3, "Lilla", 19, false, true);

            Console.WriteLine(classroom.AddStudent(student1));
            Console.WriteLine(classroom.AddStudent(student2));

            Console.WriteLine(classroom.RemoveStudent(student1));

            Console.WriteLine(classroom.AddStudent(student3));

            Console.WriteLine(classroom.ToString());

            Console.WriteLine($"adja meg a kersett diák nevét");
            string search = Console.ReadLine();
            if (classroom.ScearchInClassroom(search).Count()<=0)
                Console.WriteLine("Nincs ilyen diák");
            else
            {
                foreach (var student in classroom.ScearchInClassroom(search))
                {
                    Console.WriteLine(student.ToString());
                }
            }
            
            Console.ReadLine();

        }
    }
}
