namespace Cliente.entidade
{
    public class Client
    {
        private string _name;
        private long _cpf;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public long CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public DateTime BornDate
        {
            get { return BornDate; }
            set { BornDate = value; }
        }
        public float MonthlyIncome
        {
            get { return MonthlyIncome; }
            set { MonthlyIncome = value; }
        }
        public char MaritalStatus
        {
            get { return MaritalStatus; }
            set { MaritalStatus = value; }
        }
        public int NumberOfDependents
        {
            get { return NumberOfDependents; }
            set { NumberOfDependents = value; }
        }

    }
}
