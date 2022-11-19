using Cliente.model;
using Cliente.view;

namespace Cliente.controller
{
    public class ClientController
    {

        public void AddClientName(Interface a, Client c)
        {
            a.GetName(c);            
        }

        public void AddClientCPF(Interface a, Client c)
        {
            a.GetCPF(c);
        }

        public void AddClientBirthDate(Interface a, Client c)
        {
            a.GetDate(c);
        }

        public void ShowClient(Interface a, Client c)
        {
            a.ShowData(c);
        }

        public void NameValidate(Interface a, Client c)
        {
            string name = a.InputName;
            switch (name.Length)
            {
                case 0:
                    a.ErrorMessages(0);
                    a.GetName(c);
                    break;
                case < 5:
                    a.ErrorMessages(1);
                    break;
                case >= 5:
                    c.Name = name;
                    break;
            }
            }

        public void CPFValidate(Interface a, Client C)
        {
            string inputCPF = a.InputCPF;
            long outputCPF;
            switch (inputCPF.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out outputCPF);
                    if (parseSuccess)
                    {
                        C.CPF = outputCPF;
                    }
                    else
                    {
                        a.ErrorMessages(2);
                    }
                    break;
                default:
                    a.ErrorMessages(2);
                    break;
            }
        }

        public void BirthDateValidate(Interface a, Client c)
        {
            string inputDate = a.InputDate;
            DateTime outputDate;
            DateTime now = DateTime.Now;
            TimeSpan eighteenYears = new TimeSpan(6574, 0, 0, 0);
            bool parseSuccess = DateTime.TryParse(inputDate, out outputDate);
            if (parseSuccess)
            {
                c.BornDate = Convert.ToDateTime(outputDate);
                TimeIntervalController timeInterval = new(outputDate, now);
                if (timeInterval.Duration > eighteenYears)
                {
                    outputDate = c.BornDate;
                }
                else
                {
                    a.ErrorMessages(3);
                }
            }
            else
            {
                a.ErrorMessages(4);            
            }

        }
    }
    
}

