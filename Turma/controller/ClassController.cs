using Turma.model;
using Aluno.model;
using Turma.view;

namespace Turma.controller
{
    public class ClassController
    {
        public void AddStudent(List<Student> students)
        {
            students.Add(new Student() { });
        }
        public void RemoveStudent(List<Student> students)
        {
            students.Remove(new Student() { });
        }
        public void P1Score(Student student)
        {
            return;
        }
        public void P2Score(Student student)
        {
            return;
        }
        public void GetStudents(List<Student> c, ClassInterface a)
        {
            c = c.OrderBy(e => e.Name).ToList();
            foreach (Student student in c) 
            {
                a.ShowStudents(student);
            }
        }
    }
}
