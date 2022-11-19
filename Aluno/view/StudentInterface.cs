using Aluno.model;

namespace Aluno.view
{
    internal class StudentInterface
    {
        private string _inputName;

        public string InputName
        {
            get { return _inputName; }
            set { _inputName = value; }
        }
        public void GetName(Student s)
        {
            Console.WriteLine("Insira o nome do aluno: ");
            this._inputName = Console.ReadLine();
        }
    }
}
