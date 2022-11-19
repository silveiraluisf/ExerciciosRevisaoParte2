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
            x.AddClientName(a, c);
            x.AddClientCPF(a, c);
            //x.ShowClient(a, c);
            x.NameValidate(a, c);
            x.CPFValidate(a, c);
        }
    }
}
