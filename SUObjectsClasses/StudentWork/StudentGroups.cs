using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace StudentWork
{
    class StudentGroups
    {
        static string format = "d-MMM-yyyy";
        static List<Town> townsWithStudents = new List<Town>();
        
        private static void PopulateStudents()
        {
            string newLine = Console.ReadLine();
            while (true)
            {
                if (newLine=="End")
                {
                    break;
                }

                int index = newLine.IndexOf("=>");
                if (index>0)
                {
                    //Initialize town
                    string townName = newLine.Substring(0, index).Trim();
                    string seatsNumber = newLine.Substring(index+2).Trim().Split(' ').First();

                    townsWithStudents.Add(new Town(townName, int.Parse(seatsNumber)));

                    while (true)
                    {
                        newLine = Console.ReadLine();
                        index = newLine.IndexOf("=>");
                        if (newLine == "End" || index != -1)
                        {
                            break;
                        }
                        //populate Students
                        string[] newStudent = newLine.Split('|').ToArray();
                        string name = newStudent[0].Trim();
                        string email = newStudent[1].Trim();
                        DateTime registration = DateTime
                            .ParseExact(newStudent[2].Trim(),format,CultureInfo.InvariantCulture);

                        foreach (var town in townsWithStudents)
                        {
                            if (town.Name== townName)
                            {
                                //add student
                                town.StudentsInTown.Add(new Student(name, email, registration));
                            }
                        }

                    }

                }           
                               
            }
            
        }

        static void Main(string[] args)
        {
            PopulateStudents();

            var townsNumber = townsWithStudents.Count;
            var groupsCount = 0;
            foreach (var town in townsWithStudents)
            {
                int groupsInTown =town.StudentsInTown.Count / town.NumberOfSeats;
                if (town.StudentsInTown.Count % town.NumberOfSeats>=1)
                {
                    groupsInTown++;
                }
                groupsCount += groupsInTown;
            }
            Console.WriteLine($"Created {groupsCount} groups in {townsNumber} towns:");

            var sortedTowns = townsWithStudents
                .OrderBy(x => x.Name);
            foreach (var town in sortedTowns)
            {
                Console.Write(town.Name+" => ");
                var sortedStudents = town.StudentsInTown
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email);
                int groupCounter = 0;
                int groupLastMember = 0;

                foreach (var student in sortedStudents)
                {
                    if (groupCounter==town.NumberOfSeats)
                    {
                        Console.WriteLine();
                        Console.Write(town.Name + " => ");
                        groupCounter = 0;
                    }
                    Console.Write(student.Email);
                    groupCounter++;
                    if (groupCounter< town.NumberOfSeats&& groupLastMember < town.StudentsInTown.Count-1)
                    {
                        Console.Write(", ");
                    }
                    groupLastMember++;
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }

    }
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Student(string name, string email, DateTime registation)
        {
            this.Name = name;
            this.Email = email;
            this.RegistrationDate = registation;
        }
    }
    public class Town
    {
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public List<Student> StudentsInTown { get; set; }

        public Town(string name, int numberOfSeats)
        {
            this.Name = name;
            this.NumberOfSeats = numberOfSeats;
            this.StudentsInTown = new List<Student>();
        }
    }
}
