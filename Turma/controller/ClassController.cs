﻿using Turma.model;
using Aluno.model;
using Turma.view;

namespace Turma.controller
{
    public class ClassController
    {
        public void AddStudent(Class c, ClassInterface a, SystemController s)
        {
            Student student= new Student();
            student.Name = a.InputName;
            string inputRegistration = a.InputRegistration;
            long outputRegistration;
            long.TryParse(inputRegistration, out outputRegistration);
            student.Registration= outputRegistration;
            c.ListOfStudents.Add(student);
            s.openInterface();
        }
        public void RemoveStudent(Class c, ClassInterface a)
        {
            Student student = new Student();
            string inputRegistration = a.InputRegistration;
            long outputRegistration;
            long.TryParse(inputRegistration, out outputRegistration);
            student.Registration = outputRegistration;
            c.ListOfStudents.Remove(student); 
        }

        public void AddP1(Student student, ClassInterface a)
        {
            string inputP1 = a.P1;
            double outputP1;
            double.TryParse(inputP1, out outputP1);
            student.P1 = outputP1;
        }
        public void AddP2(Student student, ClassInterface a)
        {
            string inputP2 = a.P2;
            double outputP2;
            double.TryParse(inputP2, out outputP2);
            student.P1 = outputP2;
        }

        public void GetStudents(Class c, ClassInterface a)
        {
            List<Student> students = c.ListOfStudents;
            students.OrderBy(e => e.Name).ToList();
            foreach (Student student in students) 
            {
                a.ShowStudents(student);
            }
        }

        public void GetMaxScore(List<Student> c)
        {
            double maxScore = c.Max(s => s.FinalScore);
        }
        public void P1Average(List<Student> c, Class t)
        {
            double sum = c.Sum(s => s.P1);
            double average = sum/c.Count;
            t.P1 = average;
        }
        public void P2Avergage(List<Student> c, Class t)
        {
            double sum = c.Sum(s => s.P2);
            double average = sum / c.Count;
            t.P2 = average;
        }

        public void FSAverage(List<Student> c, Class t)
        {
            double sum = c.Sum(s => s.FinalScore);
            double average = sum / c.Count;
            t.FS= average;
        }
        public void ClassStatics()
        {
            //Fazer
        }
    }
}
