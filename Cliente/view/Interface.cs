using Cliente.model;

namespace Cliente.view
{
    public class Interface
    {
        private string _inputName;
        private string _inputCPF;
        private string _inputDate;
        private string _inputIncome;
        private string _inputStatus;
        private string _inputNOfDependents;
        private List<string> _errorList;

        public string InputName
        {
            get { return _inputName; }
            set { _inputName = value; }
        }
        public string InputCPF {
            get { return _inputCPF; }
            set { _inputCPF = value; } 
        }

        public string InputDate
        {
            get { return _inputDate; }
            set { _inputDate = value; }
        }

        public string InputIncome
        {
            get { return _inputIncome; }
            set { _inputIncome = value; }
        }

        public string InputStatus
        {
            get { return _inputStatus; }
            set { _inputStatus = value; }
        }

        public string InputNOfDependents
        {
            get { return _inputNOfDependents;}
            set { _inputNOfDependents = value;}
        }

        public List<string> ErrorList 
        { 
            get { return _errorList; }
            set { _errorList = value; }
        }
        public void GetName(Client C)
        {
            Console.WriteLine("Insira o nome do cliente: ");
            this._inputName = Console.ReadLine();           
        }

        public void GetCPF(Client C)
        {
            Console.WriteLine("Insira o CPF: ");
            this._inputCPF = Console.ReadLine();
        }

        public void GetDate(Client C)
        {
            Console.WriteLine("Insira da data de nascimento (dd/mm/aaaa): ");
            this._inputDate = Console.ReadLine();
        }
        public void GetIncome(Client C)
        {
            Console.WriteLine("Insira a renda mensal: ");
            this._inputIncome = Console.ReadLine();
        }

        public void GetStatus(Client C)
        {
            Console.WriteLine("Insira o estado civil (C, S, V ou D):  ");
            this._inputStatus = Console.ReadLine();
        }

        public void GetDependents(Client C)
        {
            Console.WriteLine("Insira o número de dependentes (de 0 a 10):  ");
            this._inputNOfDependents = Console.ReadLine();
        }

        public void ShowData(Client C)
        {
            Console.WriteLine($"Nome: {C.Name}");
            Console.WriteLine($"CPF: {C.CPF}");
            Console.WriteLine($"Data de nascimento: {C.BirthDate}");
            Console.WriteLine($"Renda mensal: {C.MonthlyIncome}");
            Console.WriteLine($"Estado civil: {C.MaritalStatus}");
            Console.WriteLine($"Número de dependentes: {C.NumberOfDependents}");

        }

        public void ErrorMessages(int n)
        {
            this._errorList = new List<string> 
            { 
                "O nome não pode ser vazio!" ,
                "O nome deve possuir pelo menos 5 caracteres",
                "Favor insira um CPF válido (11 caracteres, apenas números).",
                "O cliente deve ter pelo menos 18 anos!",
                "Favor insira uma data no formato DD,MM,AAAA. ",
                "Insira um valor válido em $.",
                "Favor insira um estado civil válido (C, S, V ou D).",
                "Favor insira um valor válido (entre 0 e 10)."
            };
            Console.WriteLine($"{ErrorList[n]}");
        }
    }
}
