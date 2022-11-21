using Cliente.controller;

namespace Cliente
{
    class Program
    {
        static public void Main()
        {
            SystemController s = new SystemController();
            s.OpenInterface();
        }
    }
}

