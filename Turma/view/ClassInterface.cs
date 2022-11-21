using Aluno.model;

namespace Turma.view
{
    public class ClassInterface
    {
        private string _inputName;
        private string _inputRegistration;
        private string _inputP1;
        private string _inputP2;
        private string _inputOption;
        private List<string> _errorList;
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
        public string Option
        {
            get { return _inputOption; }
            set { _inputOption = value; }
        }
        public List<string> ErrorList
        {
            get { return _errorList; }
            set { _errorList = value; }
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
        public void ShowStudents(Student student)
        {
            Console.WriteLine($"Nome: {student.Name}, Nota final: {student.FinalScore}");
        }
        public void Tittle()
        {
            Console.WriteLine("---- TELA DE CONTROLE DA TURMA ----");
        }
        public void Options()
        {
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 = Adicionar aluno.");
            Console.WriteLine("2 = remover aluno.");
            Console.WriteLine("3 = Mostrar lista de alunos.");
            Console.WriteLine("4 = Mostrar estatísticas da turma.");
            this._inputOption = Console.ReadLine();            
        }
        public void ErrorMessages(int n)
        {
            this._errorList = new List<string>
            {
                $"Insira uma opção válida." ,
            };
            Console.WriteLine($"{ErrorList[n]}");
        }
    }
}
