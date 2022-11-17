namespace Cliente
{
    public class Client
    {
        private string _Name;
        private long _CPF;
        private DateTime _BornDate;
        private float _MonthlyIncome;
        private char _MaritalStatus;
        private int _NumberOfDependents;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public long CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }
        public DateTime BornDate
        {
            get { return _BornDate; }
            set { _BornDate = value; }
        }
        public float MonthlyIncome
        {
            get { return _MonthlyIncome; }
            set { _MonthlyIncome = value; }
        }
        public char MaritalStatus
        {
            get { return _MaritalStatus; }
            set { _MaritalStatus = value; }
        }
        public int NumberOfDependents
        {
            get { return _NumberOfDependents; }
            set { _NumberOfDependents = value; }
        }
    }
}