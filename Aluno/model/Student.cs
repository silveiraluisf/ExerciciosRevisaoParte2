namespace Aluno.model
{
    public class Student
    {
        private string _name;
        private long _registration;

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
        public double? P1
        {
            get; set;
        }
        public double? P2
        {
            get; set;
        }

        public double? FinalGrade
        {
            get; set;
        }
    }
}
