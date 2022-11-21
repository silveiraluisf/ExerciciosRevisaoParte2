﻿using Aluno.model;
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
        
        public void ShowStudents(Class c, Student s)
        {
            List<Student> students = c.ListOfStudents;
            Console.WriteLine($"Nome: {students}");
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
