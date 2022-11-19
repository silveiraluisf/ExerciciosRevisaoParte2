using Turma.model;
using Aluno.model;
using Turma.view;

namespace Turma.controller
{
    public class ClassController
    {
        public void AddStudent(List<Student> students, ClassInterface a)
        {
            Student student= new Student();
            student.Name = a.InputName;
            string inputRegistration = a.InputRegistration;
            long outputRegistration;
            long.TryParse(inputRegistration, out outputRegistration);
            student.Registration= outputRegistration;
            students.Add(student);
        }
        public void RemoveStudent(List<Student> students)
        {
            students.Remove(new Student() { });
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
