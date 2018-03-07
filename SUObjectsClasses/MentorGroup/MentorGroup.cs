using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace MentorGroup
{     
    //NOT FINISHED
    class MentorGroup
    {
        static string format = "dd/MM/yyyy";

        private static void PrintStudentsInfo(List<Student> allActiveStudents)
        {
            //var studentsWithAttendence = allActiveStudents
            //    .Where(x => x.Attend.Count > 0);

            var studentsWithAttendence = allActiveStudents
                .OrderBy(x => x.Name);
            foreach (var stud in studentsWithAttendence)
            {
                Console.WriteLine(stud.Name);
                Console.WriteLine("Comments:");                
                foreach (var item in stud.Comment)
                {
                    Console.WriteLine($"- {item}");
                }
                Console.WriteLine("Dates attended:");
                var sortedDates = stud.Attend.
                    OrderBy(x=>x.Date);
                foreach (var item in sortedDates)
                {
                    Console.WriteLine($"-- {item.ToString(format)}");
                }
            }
        }

        static List<DateTime> ParsePresense(string[] attendancies)
        {
            var presence = new List<DateTime>();
            foreach (var date in attendancies)
            {
                presence.Add(DateTime.ParseExact(date, format, CultureInfo.InvariantCulture));
            }

            return presence;
        }
        static void Main()
        {
            string newStudentInfo = Console.ReadLine();
            var allActiveStudents = new List<Student>();
            //enter students and dates
            while (newStudentInfo!= "end of dates")
            {
                string studentName = newStudentInfo.Split(' ').First().Trim();
                string[] studetAttendances = newStudentInfo
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .ToArray();
                
                bool isStudenInList = allActiveStudents.Any(x => x.Name == studentName);
                if (isStudenInList)
                {
                    //add dates
                    foreach (var student in allActiveStudents)
                    {
                        if (student.Name== studentName)
                        {
                            student.Attend.AddRange(ParsePresense(studetAttendances));
                        }
                    }
                }
                else
                {
                    //add student with dates
                    allActiveStudents.Add(
                        new Student(studentName,ParsePresense(studetAttendances)));
                }               
                

                newStudentInfo = Console.ReadLine();
            }

            //Add commets to students
            string commnetsToStudent = Console.ReadLine();
            while (commnetsToStudent!= "end of comments")
            {
                string[] nameAndComment = commnetsToStudent.Split('-').ToArray();
                string studName = nameAndComment[0];
                
                string studComment = nameAndComment[1];
                foreach (var student in allActiveStudents)
                {
                    if (student.Name== studName)
                    {
                        student.Comment.Add(studComment);
                    }                     
                }                    
                
                commnetsToStudent = Console.ReadLine();
            }

            //print method
            PrintStudentsInfo(allActiveStudents);       
            
        }

    }

    internal class Student
    {
        public string Name{ get; set; }
        public List<string> Comment{ get; set; }
        public List<DateTime> Attend{ get; set; }

        public Student(string name)
        {
            this.Name = name;
            this.Comment = new List<string>();
            this.Attend = new List<DateTime>();
        }
        public Student(string name, List<DateTime> attendances)
        {
            this.Name = name;
            this.Comment = new List<string>();
            this.Attend = new List<DateTime>();
            this.Attend.AddRange(attendances);
        }
    }
}
