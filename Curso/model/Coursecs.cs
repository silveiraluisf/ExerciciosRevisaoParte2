using Aluno.model;
using Turma.model;

namespace Curso.model
{
    public class Coursecs
    {
        private string _name;
        //private Class _c = new(new List<Student>());
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Class c
        {
            get { return c; }
            set { c = value; }
        }
        public Student student 
        { 
            get { return student; } 
            set { student = value; } 
        }
    }

}
