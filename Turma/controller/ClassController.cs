using Turma.model;
using Aluno.model;
using Turma.view;

namespace Turma.controller
{
    public class ClassController
    {
        public void AddStudent(Student s, Class c)
        {
            List<Student> students = c.ListOfStudents;
            students.Add(s);
        }
        public void RemoveStudent(Student s, Class c)
        {
            List<Student> students = c.ListOfStudents;
            students.Remove(s);
        }
        public void GetStudents(Class c, ClassInterface a)
        {
            List<Student> students = c.ListOfStudents;
            foreach (Student s in students)
            {
                a.ShowStudents(s);
            }
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
