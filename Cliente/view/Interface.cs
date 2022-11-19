using Cliente.model;

namespace Cliente.view
{
    public class Interface
    {
        private string _inputName;
        private string _inputCPF;
        private string _inputDate;
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

        public void ShowData(Client C)
        {
            Console.WriteLine($"Nome é {C.Name}");
            Console.WriteLine($"O CPF é {C.CPF}");
            
        }

        public void ErrorMessages(int n)
        {
            this._errorList = new List<string> 
            { 
                "O nome não pode ser vazio!" ,
                "O nome deve possuir pelo menos 5 caracteres",
                "Favor insira um CPF válido (11 caracteres, apenas números).",
                "O cliente deve ter pelo menos 18 anos!",
                "Favor insira uma data no formato DD,MM,AAAA. "

            };
            Console.WriteLine($"{ErrorList[n]}");
        }
    }
}
