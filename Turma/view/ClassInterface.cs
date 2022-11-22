using Aluno.model;
using Turma.model;

namespace Turma.view
{
    public class ClassInterface
    {
        private string _inputOption;
        private List<string> _errorList;
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
        public void Tittle()
        {
            Console.WriteLine("---- TELA DE CONTROLE DA TURMA ----");
        }
        public void Options()
        {
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 = Adicionar aluno.");
            Console.WriteLine("2 = Remover aluno.");
            Console.WriteLine("3 = Mostrar lista de alunos.");
            Console.WriteLine("4 = Mostrar estatísticas da turma.");
            Console.WriteLine("5 = Lançar nota da P1 para aluno.");
            Console.WriteLine("6 = Lançar nota da P2 para aluno.");
            this._inputOption = Console.ReadLine();            
        }
        public void ShowStudents(Student s)
        {
            Console.WriteLine($"Nome: {s.Name} | Matrícula: {s.Registration} | Nota final: {s.FinalGrade} | Nota P1: {s.P1} | Nota P2: {s.P2}");
        }
        public void ShowStatics(Class c)
        {
            Console.WriteLine($"---- ESTATÍSTICAS DA TURMA ----");
            Console.WriteLine($"Média das notas finais: {c.FSAverage}");
            Console.WriteLine($"Média das notas da P1: {c.P1Average}");
            Console.WriteLine($"Média das notas da P2: {c.P2Average}");
            Console.WriteLine($"Nota mais alta da turma: {c.MaxScore}");
            Console.WriteLine($"");
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
