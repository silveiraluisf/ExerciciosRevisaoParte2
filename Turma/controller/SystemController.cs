using Turma.model;
using Turma.view;

namespace Turma.controller
{
    public class SystemController
    {
        public void openInterface()
        {
            SystemController s = new SystemController();
            ClassController x = new ClassController();
            ClassInterface a = new ClassInterface();
            Class c = new Class();
            a.Tittle();
            SelectOption(a, x, c , s);
        }
        public void SelectOption(ClassInterface a, ClassController x, Class c, SystemController s)
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
                        a.GetName();
                        a.GetRegistration();
                        x.AddStudent(c, a, s);
                        break;
                    case 2:
                        a.GetRegistration();
                        x.RemoveStudent(c, a);
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
