using Aluno.view;
using Aluno.model;

namespace Aluno.controller
{
    internal class SystemController
    {
        public SystemController() 
        { 
            object value = new StudentController();
        }
        public void OpenInterface()
        {
            StudentInterface a = new StudentInterface();
            StudentController x = new StudentController();
            Student s = new Student();
            a.Title();
            x.AddStudentName(a);
            x.NameValidate(a, s);
            x.AddStudentRegistrationNumber(a);
            x.RegistrationValidate(a, s);
            x.P1Grade(a);
            x.P1Validate(a, s); 
            x.P2Grade(a);
            x.P2Validate(a, s);
            x.FinalScore(s);
            x.ShowStudent(a, s);
        }
    }
}
