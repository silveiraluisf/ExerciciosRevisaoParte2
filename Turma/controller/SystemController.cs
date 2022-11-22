using Aluno.controller;
using Aluno.model;
using Aluno.view;
using Turma.view;

namespace Turma.controller
{
    public class SystemController
    {
        ClassInterface a = new();
        StudentController x = new();
        ClassController y = new();
        StudentInterface i = new();
        public void OpenInterface()
        {                       
            a.Tittle();
            SelectOption(x , y, i);
        }
        public void SelectOption(StudentController x, ClassController y, StudentInterface i)
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
                        y.AddStudent(i, x);
                        break;
                    case 2:
                        y.RemoveStudent();
                        break;
                    case 3:
                        y.GetStudents();
                        break;
                    case 4:
                        break;
                    default:
                        a.ErrorMessages(0);
                        break;
                }
            }
        }
    }
}
