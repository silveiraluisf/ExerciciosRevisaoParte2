﻿using Turma.model;
using Aluno.model;
using Aluno.controller;
using Aluno.view;

namespace Turma.controller
{
    public class ClassController
    {
        Class c = new(new List<Student>());

        public void AddStudent(StudentInterface i, StudentController x)
        {
            Student student = new Student();
            x.CreateStudent(i, student);
            c.ListOfStudents.Add(student);
        }
        public void RemoveStudent()
        {
            //c.ListOfStudents?.Remove(s);
            //y.OpenInterface();
        }
        public void GetStudents()
        {
            for (int i = 0; i < c.ListOfStudents.Count; i++) 
            {
                Console.WriteLine("teste");
                Student s = c.ListOfStudents[i];
                Console.WriteLine($"{s.Name}");
            }
            //y.OpenInterface();
        }
        public void GetMaxScore(Class c)
        {
            List<Student> students = c.ListOfStudents;
            double maxScore = (double)students.Max(s => s.FinalGrade);
        }
        public void GetP1Average(Class c)
        {
            List<Student> students = c.ListOfStudents;
            double sum = (double)students.Sum(s => s.P1);
            double average = sum/students.Count;
            c.P1Average = average;
        }
        public void GetP2Avergage(Class c)
        {
            List<Student> students = c.ListOfStudents;
            double sum = (double)students.Sum(s => s.P2);
            double average = sum / students.Count;
            c.P2Average = average;
        }

        public void GetFSAverage(Class c)
        {
            List<Student> students = c.ListOfStudents;
            double sum = (double)students.Sum(s => s.FinalGrade);
            double average = sum / students.Count;
            c.FSAverage = average;
        }
        public void ClassStatics()
        {
            //Fazer
        }
    }
}
