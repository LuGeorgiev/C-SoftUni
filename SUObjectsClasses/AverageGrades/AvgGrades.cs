using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class AvgGrades
    {
        static void Main()
        {
            //List < Student > students = new List<Student>()
            //{
            //    new Student("Ani", new List<double>{6, 5, 6, 5, 6, 5, 6, 5 }),
            //    new Student("Ani", new List<double>{5.50, 5.25, 6.00 }),
            //    new Student("Petara", new List<double>{3, 5, 4, 3, 2, 5, 6, 2, 6 }),
            //    new Student("Mitko", new List<double>{6, 6, 5, 6, 5, 6 }),

            //};

            var students = new List<Student>();
            int studetsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < studetsNumber; i++)
            {
                string[] newStudent = Console.ReadLine().Split(' ').ToArray();
                string name = newStudent[0];
                var marks = (newStudent.Skip(1).Select(double.Parse).Sum()) / (newStudent.Length - 1);

                students.Add(new Student(name, marks));
                    //new List<double>();
                //for (int j = 1; j < newStudent.Length; j++)
                //{
                //    marks.Add(double.Parse(newStudent[j]));
                //}
                //students.Add(new Student( name, marks));
            }

            var sortedStudents = students
                .Where(x=>x.AvgGrade>=5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AvgGrade);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AvgGrade:F2}");
            }
        }
    }
    public class Student
    {
        private string name;
        private List<double> marks;
        private double avgGrade;


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public double AvgGrade
        {
            get
            {
                return this.avgGrade;
            }
           
        }
        public List<double> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {                
                this.marks = value;
            }
        }

        public Student(string name, double avgMarks)
        {
            this.Name = name;
            this.avgGrade = avgMarks;
        }
    }
}
