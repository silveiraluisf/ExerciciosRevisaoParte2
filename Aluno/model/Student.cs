namespace Aluno.model
{
    public class Student
    {
        private string _name;
        private long _registration;
        private double _p1;
        private double _p2;
        private double _fs;

        public string Name
        {
            get => _name;
            set { _name = value; }
        }
        public long Registration
        {
            get { return _registration; }
            set { _registration = value; }
        }
        public double P1
        {
            get { return _p1;}
            set { _p1 = value; }
        }
        public double P2
        {
            get { return _p2; }
            set { _p2 = value; }
        }

        public double FinalScore
        {
            get { return _fs; }
            set { _fs = value; }
        }
    }
}
