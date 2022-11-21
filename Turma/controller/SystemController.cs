using Aluno.model;
using Turma.model;
using Turma.view;

namespace Turma.controller
{
    public class SystemController
    {
        public SystemController() 
        {
            object value = new ClassController();
        }
        public void openInterface()
        {
            ClassController x = new ClassController();
            ClassInterface a = new ClassInterface();
            Class c = new Class();
            Student s= new Student();
            a.Tittle();
            SelectOption(a, x, c, s );
        }
        public void SelectOption(ClassInterface a, ClassController x, Class c, Student s)
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
                        x.AddStudent(s, c);
                        break;
                    case 2:
                        x.RemoveStudent(s, c);
                        break;
                    case 3:
                        x.GetStudents(c, a);
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
