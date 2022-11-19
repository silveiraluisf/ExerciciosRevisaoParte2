using Aluno.model;
using System.IO.IsolatedStorage;

namespace Aluno.controller
{
    public class StudentController
    {
        public double FinalScore(Student s)
        {
            return s.FinalScore = (s.P1 + s.P2)/2 ;
        }
    }
}
