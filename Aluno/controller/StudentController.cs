using Aluno.model;
using Aluno.view;

namespace Aluno.controller
{
    public class StudentController
    {
        public void CreateStudent(StudentInterface a, Student s) 
        {
            AddStudentName(a);
            NameValidate(a, s);
            AddStudentRegistrationNumber(a);
            RegistrationValidate(a, s);          
            ShowStudent(a, s);
        }
        public void AddStudentName(StudentInterface a)
        {
            a.GetName();
        }
        public void AddStudentRegistrationNumber(StudentInterface a)
        {
            a.GetRegistration();
        }
        public void P1Grade(StudentInterface a, Student student)
        {
            if (student != null)
            {
                a.GetRegistration();
                string inputRegistration = a.InputRegistration;
                long.TryParse(inputRegistration, out long outputRegistration);
                if(student.Registration == outputRegistration) 
                {
                    a.GetP1();
                    P1Validate(a, student);
                }               
            }
        }
        public void P2Grade(StudentInterface a, Student student)
        {
            if (student != null)
            {
                a.GetRegistration();
                string inputRegistration = a.InputRegistration;
                long.TryParse(inputRegistration, out long outputRegistration);
                if (student.Registration == outputRegistration)
                {
                    a.GetP2();
                    P2Validate(a, student);
                }
            }
        }
        public void FinalScore(Student s)
        {
            if (s.P1 == null)
            {
                s.P1 = 0;
            }
            if (s.P2 == null)
            {
                s.P2 = 0;
            }
            s.FinalGrade = (s.P1 + s.P2)/2;
        }
        public void ShowStudent(StudentInterface a, Student s)
        {
            a.ShowData(s);
        }
        public void NameValidate(StudentInterface a, Student s)
        {
            string name = a.InputName;
            switch (name.Length)
            {
                case 0:
                    NameValidate(a, s);
                    break;
                case < 5:
                    NameValidate(a, s);
                    break;
                case >= 5:
                    s.Name = name;
                    break;
            }
        }
        public void RegistrationValidate(StudentInterface a, Student s)
        {
            string inputRegistration = a.InputRegistration;
            long outputRegistration;
            switch (inputRegistration.Length)
            {
                case 9:
                    bool parseSuccess = long.TryParse(inputRegistration, out outputRegistration);
                    if (parseSuccess)
                    {
                        s.Registration = outputRegistration;
                    }
                    else
                    {
                        RegistrationValidate(a, s);
                    }
                    break;
                default:
                    RegistrationValidate(a, s);
                    break;
            }
        }
        public void P1Validate(StudentInterface a, Student s)
        {
            string inputP1 = a.P1;
            bool parseSuccess = double.TryParse(inputP1, out double outputP1);
            if (parseSuccess)
            {
                s.P1 = Convert.ToInt32(outputP1);
                double n = (double)s.P1;
                switch (n)
                {
                    case >= 0 and <= 10:
                        s.P1 = outputP1;
                        break;
                    default:
                        P1Validate(a, s);
                        break;
                }
            }
            else
            {
                P1Validate(a, s);
            }
        }
        public void P2Validate(StudentInterface a, Student s)
        {
            string inputP2 = a.P2;
            bool parseSuccess = double.TryParse(inputP2, out double outputP2);
            if (parseSuccess)
            {
                s.P2 = Convert.ToInt32(outputP2);
                double n = (double)s.P2;
                switch (n)
                {
                    case >= 0 and <= 10:
                        s.P2 = outputP2;
                        break;
                    default:
                        P2Validate(a, s);
                        break;
                }
            }
            else
            {
                P1Validate(a, s);
            }
        }
    }
}
