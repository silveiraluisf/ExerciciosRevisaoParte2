using Aluno.model;
using Aluno.view;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Turma.model;
using Turma.view;

namespace Turma.controller
{
    public class SystemController
    {
        ClassController x = new();
        ClassInterface a = new();
        StudentInterface i = new();
        Student s = new();
        //List<Student> students = new();
        Class c = new (new List<Student>());
        public void OpenInterface()
        {                       
            a.Tittle();
            SelectOption(a, x, c, s, i);
        }
        public void SelectOption(ClassInterface a, ClassController x, Class c, Student s, StudentInterface i)
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
                        x.AddStudent(i, c);
                        break;
                    case 2:
                        x.RemoveStudent(s);
                        break;
                    case 3:
                        x.GetStudents(c);
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
