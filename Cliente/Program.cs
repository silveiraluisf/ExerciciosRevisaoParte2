using Cliente.controle;
using Cliente.entidade;
using Cliente.limite;

namespace Cliente
{
    class Program
    {
        static public void Main()
        {
            SystemController s = new SystemController();
            s.openInterface();
        }
    }
}

