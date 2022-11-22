using Turma.model;
using Aluno.model;
using Aluno.controller;
using Aluno.view;

namespace Turma.controller
{
    public class ClassController
    {
        Class c = new(new List<Student>());

        public void AddStudent(StudentInterface i, StudentController x, SystemController y)
        {
            Student student = new Student();
            x.CreateStudent(i, student);
            c.ListOfStudents.Add(student);
            y.OpenInterface();
        }
        public void RemoveStudent(SystemController y)
        {
            int n = 0; 
            Student s = c.ListOfStudents[n];
            c.ListOfStudents.Remove(s);
            y.OpenInterface();
        }
        public void GetStudents(StudentController x, SystemController y)
        {
            for (int i = 0; i < c.ListOfStudents.Count; i++) 
            {
                Student s = c.ListOfStudents[i];
                x.FinalScore(s);
                Console.WriteLine($"Nome: {s.Name} | Matrícula: {s.Registration} | Nota final: {s.FinalGrade} | Nota P1: {s.P1} | Nota P2: {s.P2}");
            }
            y.OpenInterface();
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
        public void SetP1(StudentInterface i, StudentController x, SystemController y)
        {
            for (int n = 0; n < c.ListOfStudents.Count; n++) 
            {
                Student student = c.ListOfStudents[n];
                x.P1Grade(i, student);
                y.OpenInterface();
            }
                
        }
        public void SetP2(StudentInterface i, StudentController x, SystemController y)
        {
            for (int n = 0; n < c.ListOfStudents.Count; n++)
            {
                Student student = c.ListOfStudents[n];
                x.P2Grade(i, student);
                y.OpenInterface();
            }
        }
        public void ClassStatics()
        {
            //Fazer
        }
    }
}
