namespace CertidaoNascimento.model
{
    public class BirthCertificate
    {
        private DateTime _emissionDate;

        public DateTime EmissionDate
        {
            get { return _emissionDate; }
            set { _emissionDate = value; }
        }
    }
}
