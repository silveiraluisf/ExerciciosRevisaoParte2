using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.entidade
{
    public class Client
    {
        //private string Name;
        //private long CPF;
        //private DateTime BornDate;
        //private float MonthlyIncome;
        //private char MaritalStatus;
        //private int NumberOfDependents;

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public long CPF
        {
            get { return CPF; }
            set { CPF = value; }
        }
        public DateTime BornDate
        {
            get { return BornDate; }
            set { BornDate = value; }
        }
        public float MonthlyIncome
        {
            get { return MonthlyIncome; }
            set { MonthlyIncome = value; }
        }
        public char MaritalStatus
        {
            get { return MaritalStatus; }
            set { MaritalStatus = value; }
        }
        public int NumberOfDependents
        {
            get { return NumberOfDependents; }
            set { NumberOfDependents = value; }
        }

    }
}
