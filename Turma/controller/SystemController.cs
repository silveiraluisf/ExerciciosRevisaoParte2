using Aluno.controller;
using Aluno.model;
using Aluno.view;
using Turma.view;
using Turma.model;
using System.Net;

namespace Turma.controller
{
    public class SystemController
    {
        ClassInterface a = new();
        StudentController x = new();
        ClassController y = new();
        StudentInterface i = new();
        Student s = new();
        public void OpenInterface()
        {                       
            a.Tittle();
            SelectOption(x , y, i, s, a);
        }
        public void SelectOption(StudentController x, ClassController y, StudentInterface i, Student s, ClassInterface a)
        {
            a.Options();
            string input = a.Option;
            int output;
            bool parseSuccess = int.TryParse(input, out output);
            if (parseSuccess)
            {
                switch(output)
                {
                    case 0:
                        break;
                    case 1:
                        y.AddStudent(i, x, this);
                        break;
                    case 2:
                        y.RemoveStudent(this);
                        break;
                    case 3:
                        y.GetStudents(x, this, a);
                        break;
                    case 4:
                        y.ClassStatics(a);
                        break;
                    case 5:
                        y.SetP1(i, x, this);
                        break;
                    case 6:
                        y.SetP2(i, x, this);
                        break;
                    default:
                        a.ErrorMessages(0);
                        break;
                }
            }
        }
    }
}
