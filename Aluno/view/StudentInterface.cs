using Aluno.model;

namespace Aluno.view
{
    public class StudentInterface
    {
        private string _inputName;
        private string _inputRegistration;
        private string _inputP1;
        private string _inputP2;
        public string InputName
        {
            get { return _inputName; }
            set { _inputName = value; }
        }
        public string InputRegistration
        {
            get { return _inputRegistration; }
            set { _inputRegistration = value; }
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
        public void Title()
        {
            Console.WriteLine("");
            Console.WriteLine("---- TELA DE CONTROLE DO ALUNO ----");
            Console.WriteLine("");
        }

        public void GetName()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            this._inputName = Console.ReadLine();
        }
        public void GetRegistration()
        {
            Console.WriteLine("Insira a matrícula do aluno: ");
            this._inputRegistration = Console.ReadLine();
        }
        public void GetP1()
        {
            Console.WriteLine("Insira a nota da primeira prova: ");
            this._inputP1 = Console.ReadLine();
        }
        public void GetP2()
        {
            Console.WriteLine("Insira a nota da segunda prova ");
            this._inputP2 = Console.ReadLine();
        }
        public void ShowData(Student s)
        {
            Console.WriteLine("");
            Console.WriteLine("---- ESTUDANTE CADASTRADO ----");
            Console.WriteLine("");
            Console.WriteLine($"Nome: {s.Name}");
            Console.WriteLine($"CPF: {s.Registration}");
            Console.WriteLine($"Média final: {s.FinalGrade}");
        }
    }
}
