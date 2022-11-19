using Aluno.model;

namespace Turma.view
{
    public class ClassInterface
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
        public void GetName()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            this._inputName = Console.ReadLine();
        }
        public void GetRegistration()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            this._inputRegistration = Console.ReadLine();
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
        public void ShowStudents(Student student)
        {
            Console.WriteLine($"Nome: {student.Name}, Nota final: {student.FinalScore}");
        }
    }
}
