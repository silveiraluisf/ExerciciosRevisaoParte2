namespace Cliente.controle
{
    internal class ClientController
    {
        public void NameValidate(entidade.Client C)
        {
            C.Name = Console.ReadLine();
            string name = C.Name;
            switch (name.Length)
            {
                case 0:
                    NameValidate(C);
                    break;
                case < 5:                    
                    NameValidate(C);
                    break;
                case >= 5:
                    C.Name = name;
                    break;
            }
        }

        public void CPFValidate(entidade.Client C)
        {
            string inputCPF = Console.ReadLine();
            long outputCPF;
            switch (inputCPF.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out outputCPF);
                    if (parseSuccess)
                    {
                        //CPF = Convert.ToInt64(inputCPF);
                        C.CPF = outputCPF;
                    }
                    else
                    {
                        CPFValidate(C);
                    }
                    break;
                default:
                    CPFValidate(C);
                    break;
            }
        }

        public void BirthDateValidate(entidade.Client C)
        {
            string inputDate = Console.ReadLine();
            DateTime outputDate;
            DateTime now = DateTime.Now;
            TimeSpan eighteenYears = new TimeSpan(6574, 0, 0, 0);
            bool parseSuccess = DateTime.TryParse(inputDate, out outputDate);
            if (parseSuccess)
            {
                C.BornDate = Convert.ToDateTime(outputDate);
                TimeInterval timeInterval = new(outputDate, now);
                if (timeInterval.Duration > eighteenYears)
                {
                    C.BornDate = outputDate;
                }
                else
                {
                    BirthDateValidate(C);
                }
            }
            else
            {
                BirthDateValidate(C);
            }

        }

        public void IncomeValidate(entidade.Client C)
        {
            string inputIncome = Console.ReadLine();
            float outputIncome;
            bool parseSuccess = float.TryParse(inputIncome, out outputIncome);
            if (parseSuccess)
            {
                C.MonthlyIncome = (float)Convert.ToDouble(outputIncome);
            }
            else
            {
                IncomeValidate(C);
            }
        }
        public void StatusValidate(entidade.Client C)
        {
            string inputStatus = Console.ReadLine();
            char outputStatus;
            bool parseSuccess = char.TryParse(inputStatus, out outputStatus);
            if (parseSuccess)
            {
                Convert.ToChar(outputStatus);
                switch (char.ToUpper(outputStatus))
                {
                    case 'C':
                        C.MaritalStatus = 'C';
                        break;
                    case 'S':
                        C.MaritalStatus = 'S';
                        break;
                    case 'V':
                        C.MaritalStatus = 'V';
                        break;
                    case 'D':
                        C.MaritalStatus = 'D';
                        break;
                    default:
                        StatusValidate(C);
                        break;
                }
            }
            else
            {
                StatusValidate(C);
            }
        }

        public void DependentsValidate(entidade.Client C)
        {
            string inputDependents = Console.ReadLine();
            int outputDependents;
            bool parseSuccess = int.TryParse(inputDependents, out outputDependents);
            if (parseSuccess)
            {
                C.NumberOfDependents = Convert.ToInt32(outputDependents);
                int n = C.NumberOfDependents;
                switch (n)
                {
                    case >= 0 and <= 10:
                        C.NumberOfDependents = outputDependents;
                        break;
                    default:
                        DependentsValidate(C);
                        break;
                }
            }
            else
            {
                DependentsValidate(C);
            }
        }
    }
}
}
