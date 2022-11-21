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
            x.CreateStudent(a, s);
        }
    }
}
