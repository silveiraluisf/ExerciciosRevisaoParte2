using Aluno.model;

namespace Turma.model
{
    public class Class
    {
        private List<Student> _ListOfStudents = new();
        private int _Id;

        public List<Student> ListOfStudents
        {
            get { return _ListOfStudents; }
            set { _ListOfStudents = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public double P1Average { get; set; }
        public double P2Average { get; set; }
        public double FSAverage { get; set; }
        public double MaxScore { get; set; }

        public Class(List<Student> students)
        {
            _ListOfStudents = students;
        }
    }
}
