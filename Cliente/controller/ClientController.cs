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

        public void AddClientIncome(Interface a, Client c)
        {
            a.GetIncome(c);
        }

        public void AddClientMaritalStatus(Interface a, Client c)
        {
            a.GetStatus(c);
        }

        public void AddNumberOfDependents(Interface a, Client c)
        {
            a.GetDependents(c);
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
                    NameValidate(a, c);
                    break;
                case < 5:
                    a.ErrorMessages(1);
                    a.GetName(c);
                    NameValidate(a, c);
                    break;
                case >= 5:
                    c.Name = name;
                    break;
            }
        }

        public void CPFValidate(Interface a, Client c)
        {
            string inputCPF = a.InputCPF;
            long outputCPF;
            switch (inputCPF.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out outputCPF);
                    if (parseSuccess)
                    {
                        c.CPF = outputCPF;
                    }
                    else
                    {
                        a.ErrorMessages(2);
                        a.GetCPF(c);
                        CPFValidate(a, c);
                    }
                    break;
                default:
                    a.ErrorMessages(2);
                    a.GetCPF(c);
                    CPFValidate(a, c);
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
                c.BirthDate = Convert.ToDateTime(outputDate);
                TimeIntervalController timeInterval = new(outputDate, now);
                if (timeInterval.Duration > eighteenYears)
                {
                    outputDate = c.BirthDate;
                }
                else
                {
                    a.ErrorMessages(3);
                    a.GetDate(c);
                    BirthDateValidate(a, c);
                }
            }
            else
            {
                a.ErrorMessages(4);
                a.GetDate(c);
                BirthDateValidate(a, c);
            }
        }

        public void IncomeValidate(Interface a, Client c)
        {
            string inputIncome = a.InputIncome;
            float outputIncome;
            bool parseSuccess = float.TryParse(inputIncome, out outputIncome);
            if (parseSuccess)
            {
                c.MonthlyIncome = (float)Convert.ToDouble(outputIncome);
            }
            else
            {
                a.ErrorMessages(5);
                a.GetIncome(c);
                IncomeValidate(a, c);
            }
        }

        public void StatusValidate(Interface a, Client c)
        {
            string inputStatus = a.InputStatus;
            char outputStatus;
            bool parseSuccess = char.TryParse(inputStatus, out outputStatus);
            if (parseSuccess)
            {
                Convert.ToChar(outputStatus);
                switch (char.ToUpper(outputStatus))
                {
                    case 'C':
                        c.MaritalStatus = 'C';
                        break;
                    case 'S':
                        c.MaritalStatus = 'S';
                        break;
                    case 'V':
                        c.MaritalStatus = 'V';
                        break;
                    case 'D':
                        c.MaritalStatus = 'D';
                        break;
                    default:
                        a.ErrorMessages(6);
                        a.GetStatus(c);
                        StatusValidate(a, c);
                        break;
                }
            }
            else
            {
                a.ErrorMessages(6);
                a.GetStatus(c);
                StatusValidate(a, c);
            }
        }

        public void DependentsValidate(Interface a, Client c)
        {
            string inputDependents = a.InputNOfDependents;
            int outputDependents;
            bool parseSuccess = int.TryParse(inputDependents, out outputDependents);
            if (parseSuccess)
            {
                c.NumberOfDependents = Convert.ToInt32(outputDependents);
                int n = c.NumberOfDependents;
                switch (n)
                {
                    case >= 0 and <= 10:
                        c.NumberOfDependents = outputDependents;
                        break;
                    default:
                        a.ErrorMessages(7);
                        a.GetDependents(c);
                        DependentsValidate(a, c);
                        break;
                }
            }
            else
            {
                a.ErrorMessages(7);
                a.GetDependents(c);
                DependentsValidate(a, c);
            }
        }
    }
}

