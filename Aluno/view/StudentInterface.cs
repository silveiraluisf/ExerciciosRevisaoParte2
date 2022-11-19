using Aluno.model;

namespace Aluno.view
{
    internal class StudentInterface
    {
        private string _inputName;
        private string _inputP1;
        private string _inputP2;

        public string InputName
        {
            get { return _inputName; }
            set { _inputName = value; }
        }
        public string P1
        {
            get { return _inputP1; }
            set { _inputP1 = value; }
        }
        public string P2
        {
            get { return _inputP2; }
            set { _inputP2 = value; }
        }
        public void GetName()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            this._inputName = Console.ReadLine();
        }
        public void GetP1()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            this._inputP1 = Console.ReadLine();
        }
        public void GetP2()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            this._inputP2 = Console.ReadLine();
        }
    }
}
