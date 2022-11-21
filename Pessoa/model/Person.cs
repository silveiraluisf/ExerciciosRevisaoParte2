using CertidaoNascimento.model;

namespace Pessoa.model
{
    internal class Person
    {
        private string _name;

        public string Name { 
            get { return _name; }
            set { _name = value; }
        }

        public BirthCertificate Certificate { get; set; }
    }
}
