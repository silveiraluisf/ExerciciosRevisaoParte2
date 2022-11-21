using Aluno.model;

namespace Turma.model
{
    public class Class
    {
        //private List<Student>? _listOfStudents {};
        //private double _P1;
        //private double _P2;
        //private double _FS;

        public List<Student>? ListOfStudents
        {
            get; set;
        }

        public double P1Average
        {
            get; set;
        }
        public double P2Average
        {
            get; set;
        }
        public double FSAverage
        {
            get; set;       
        }
    }
}
