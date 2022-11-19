using Cliente.controller;
using Cliente.model;
using Cliente.view;

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

