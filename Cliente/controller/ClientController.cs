using Cliente.view;
using Cliente.model;

namespace Cliente.controller
{
    public class ClientController
    {

        public void AddClientName(Interface a, Client c)
        {
            a.GetName(c);            
        }

        public void AddClientCPF(Interface a, Client c)
        {
            a.GetCPF(c);
        }

        public void ShowClient(Interface a, Client c)
        {
            a.ShowData(c);
        }

        public void NameValidate(Interface a, Client c)
        {
            string name = c.Name;
            switch (name.Length)
            {
                case 0:
                    a.ErrorMessages();
                    a.GetName(c);
                    break;
                case < 5:
                    Console.WriteLine("O nome deve possuir pelo menos 5 caracteres");
                    //NameValidate(c);
                    break;
                case >= 5:
                    c.Name = name;
                    break;
            }
            }

        public void CPFValidate(Interface a, Client C)
        {
            string inputCPF = a.InputCPF;
            long outputCPF;
            switch (inputCPF.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out outputCPF);
                    if (parseSuccess)
                    {
                        C.CPF = outputCPF;
                    }
                    else
                    {
                        Console.WriteLine("Favor insira um CPF válido (11 caracteres, apenas números).");
                        //CPFValidate(C);
                    }
                    break;
                default:
                    Console.WriteLine("Favor insira um CPF válido (11 caracteres, apenas números).");
                    //CPFValidate(C);
                    break;
            }
        }
    }
    
}

