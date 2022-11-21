using Turma.model;
using Aluno.model;
using Turma.view;
using Aluno.controller;
using Aluno.view;
using System.Xml.Linq;

namespace Turma.controller
{
    public class ClassController
    {
        StudentController x;
        SystemController y;
       
        public void AddStudent(StudentInterface i, Class c)
        {
            //Student student = new Student();          
            //x.CreateStudent(i, student);
            Console.WriteLine("print antes de add");
            Console.WriteLine($"{c.ListOfStudents.Count}");
            c.ListOfStudents.Add(new Student() { Name = "dedede", Registration = 123123123 });
            Console.WriteLine("print depois de add");
            Console.WriteLine($"{c.ListOfStudents.Count}");
            GetStudents(c);
            //c.ListOfStudents?.Add(student);
            //y.OpenInterface();
            //this.AddStudent(i, c);
            y.OpenInterface();
        }
        public void RemoveStudent(Student s)
        {
            //c.ListOfStudents?.Remove(s);
            y.OpenInterface();
        }
        public void GetStudents(Class c)
        {
            for (int i = 0; i < c.ListOfStudents.Count; i++) 
            {
                Console.WriteLine("teste");
                Student s = c.ListOfStudents[i];
                Console.WriteLine($"{s.Name}");
            }
            //y.OpenInterface();
        }
        public void GetMaxScore(Class c)
        {
            List<Student> students = c.ListOfStudents;
            double maxScore = (double)students.Max(s => s.FinalGrade);
        }
        public void GetP1Average(Class c)
        {
            List<Student> students = c.ListOfStudents;
            double sum = (double)students.Sum(s => s.P1);
            double average = sum/students.Count;
            c.P1Average = average;
        }
        public void GetP2Avergage(Class c)
        {
            List<Student> students = c.ListOfStudents;
            double sum = (double)students.Sum(s => s.P2);
            double average = sum / students.Count;
            c.P2Average = average;
        }

        public void GetFSAverage(Class c)
        {
            List<Student> students = c.ListOfStudents;
            double sum = (double)students.Sum(s => s.FinalGrade);
            double average = sum / students.Count;
            c.FSAverage = average;
        }
        public void ClassStatics()
        {
            //Fazer
        }
    }
}
