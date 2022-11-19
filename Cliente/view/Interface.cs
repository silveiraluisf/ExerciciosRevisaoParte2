using Cliente.model;

namespace Cliente.view
{
    public class Interface
    {
        private string _inputName;
        private string _inputCPF;

        public string InputName
        {
            get { return _inputName; }
            set { _inputName = value; }
        }
        public string InputCPF {
            get { return _inputCPF; }
            set { _inputCPF = value; } 
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

        public void ShowData(Client C)
        {
            Console.WriteLine($"Nome é {C.Name}");
            Console.WriteLine($"O CPF é {C.CPF}");
            
        }

        public void ErrorMessages()
        {
            Console.WriteLine("O nome não pode ser vazio!");
        }
    }
}
