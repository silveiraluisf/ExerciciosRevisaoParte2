using Cliente.entidade;

namespace Cliente.limite
{
    public class Interface
    {
        public void GetName(Client C)
        {
            Console.WriteLine("Insira o nome do cliente: ");
            C.Name = Console.ReadLine();
            
        }

        public void GetCPF(Client C)
        {
            Console.WriteLine("Insira o CPF: ");
            string inputCPF = Console.ReadLine();
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
