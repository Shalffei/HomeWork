using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Models;

namespace HomeWork.Service
{
    public class StudentService
    {
        public Student GetStudent(string name, string lastName, int age, University university)
        {
            var student = new Student();
            student.Name = name;
            student.LastName = lastName;
            student.Age = age;
            if (university.Students == null)
                university.Students = new List<Student>();
            university.Students.Add(student);
            return student;   
        }
        public Student GetStudent2(string name, string lastName, int age, University university)
        {
            var student = new Student();
            student.Name = name;
            student.LastName = lastName;
            student.Age = age;
            if (university.Students2 == null)
                university.Students2 = new List<Student>();
            university.Students2.Add(student);
            return student;
        }
        public Student GetStudent3(string name, string lastName, int age, University university)
        {
            var student = new Student();
            student.Name = name;
            student.LastName = lastName;
            student.Age = age;
            if (university.Students3 == null)
                university.Students3 = new List<Student>();
            university.Students3.Add(student);
            return student;
        }
    }
}
