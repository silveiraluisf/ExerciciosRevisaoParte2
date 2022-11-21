using Aluno.model;

namespace Turma.model
{
    public class Class
    {
        private List<Student>? _listOfStudents;
        private double _P1;
        private double _P2;
        private double _FS;

        public List<Student>? ListOfStudents
        {
            get { return _listOfStudents; }
            set { _listOfStudents = value; }
        }

        public double P1
        {
            get { return _P1;  } 
            set { _P1 = value; }
        }
        public double P2
        {
            get { return _P2; }
            set { _P2 = value; }
        }
        public double FS
        {
            get { return _FS; }
            set { _FS = value; }
        }
    }
}
