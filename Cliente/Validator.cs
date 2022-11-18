namespace Cliente
{
    internal class Validator
    {
        public void NameValidate(Client C)
        {
            Console.WriteLine("Insira o nome do cliente: ");
            C.Name = Console.ReadLine();
            string name = C.Name;
            switch (name.Length)
            {
                case 0:
                    Console.WriteLine("O nome não pode ser vazio!");
                    NameValidate(C);
                    break;
                case < 5:
                    Console.WriteLine("O nome deve possuir pelo menos 5 caracteres");
                    NameValidate(C);
                    break;
                case >= 5:
                    C.Name = name;
                    break;
            }
        }

        public void CPFValidate(Client C)
        {
            Console.WriteLine("Insira o CPF: ");
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
                        Console.WriteLine("Favor insira um CPF válido (11 caracteres, apenas números).");
                        CPFValidate(C);
                    }
                    break;
                default:
                    Console.WriteLine("Favor insira um CPF válido (11 caracteres, apenas números).");
                    CPFValidate(C);
                    break;
            }
        }

        public void BirthDateValidate(Client C)
        {
            Console.WriteLine("Insira a data de nascimento (DD/MM/AAAA):");
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
                    Console.WriteLine("O cliente deve ter pelo menos 18 anos!");
                    BirthDateValidate(C);
                }
            }
            else
            {
                Console.WriteLine("Favor insira uma data no formato DD,MM,AAAA. ");
                BirthDateValidate(C);
            }

        }

        public void IncomeValidate(Client C)
        {
            Console.WriteLine("Insira a renda mensal: ");
            string inputIncome = Console.ReadLine();
            float outputIncome;
            bool parseSuccess = float.TryParse(inputIncome, out outputIncome);
            if (parseSuccess)
            {
                C.MonthlyIncome = (float)Convert.ToDouble(outputIncome);
            }
            else
            {
                Console.WriteLine("Insira um valor válido em $.");
                IncomeValidate(C);
            }
        }

        public void StatusValidate(Client C)
        {
            Console.WriteLine("Insira o estado civil (C, S, V ou D): ");
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
                        C.MaritalStatus = MaritalStatus;
                        break;
                    case 'S':
                        C.MaritalStatus = 'S';
                        C.MaritalStatus = MaritalStatus;
                        break;
                    case 'V':
                        C.MaritalStatus = 'V';
                        C.MaritalStatus = MaritalStatus;
                        break;
                    case 'D':
                        C.MaritalStatus = 'D';
                        C.MaritalStatus = MaritalStatus;
                        break;
                    default:
                        Console.WriteLine("Favor insira um estado civil válido (C, S, V ou D).");
                        StatusValidate(C);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Favor insira um estado civil válido (C, S, V ou D).");
                StatusValidate(C);
            }
        }

        public void DependentsValidate(Client C)
        {
            Console.WriteLine("Insira o número de dependentes (de 0 a 10): ");
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
                        C.NumberOfDependents = NumberOfDependents;
                        break;
                    default:
                        Console.WriteLine("Favor insira um valor válido (entre 0 e 10).");
                        DependentsValidate(C);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Favor insira um valor válido (entre 0 e 10).");
                DependentsValidate(C);
            }
        }
    }
}
}
