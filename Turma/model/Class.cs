using Aluno.model;

namespace Turma.model
{
    public class Class
    {
        private List<Student> _listOfStudents;

        public List<Student> ListOfStudents
        {
            get { return _listOfStudents; }
            set { _listOfStudents = value; }
        }
    }
}
