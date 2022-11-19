using Cliente.view;
using Cliente.model;

namespace Cliente.controller
{
    internal class SystemController
    {
        public SystemController() {
            object value = new ClientController();
        }

        public void openInterface()
        {
            ClientController x = new ClientController();
            Interface a = new Interface();
            Client c = new Client();
            a.Title();
            x.AddClientName(a, c);
            x.AddClientCPF(a, c);
            x.AddClientBirthDate(a, c); 
            x.AddClientIncome(a, c);
            x.AddClientMaritalStatus(a, c);
            x.AddNumberOfDependents(a, c);  
            x.NameValidate(a, c);
            x.CPFValidate(a, c);
            x.BirthDateValidate(a, c);
            x.IncomeValidate(a, c);
            x.StatusValidate(a, c);
            x.DependentsValidate(a, c);
            x.ShowClient(a, c);
        }
    }
}
