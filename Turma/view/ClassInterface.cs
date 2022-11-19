using Aluno.model;

namespace Turma.view
{
    public class ClassInterface
    {
        public void ShowStudents(Student student)
        {
            Console.WriteLine($"Nome: {student.Name}, Nota final: {student.FinalScore}");
        }
    }
}
