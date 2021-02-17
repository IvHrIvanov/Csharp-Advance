using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> data;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            data = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public string RegisterStudent(Student student)
        {
            if (data.Count < Capacity)
            {
                data.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return "No seats in the classroom";
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student current = data.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (data.Contains(current))
            {
                data.Remove(current);
                return $"Dismissed student {firstName} {lastName}";
            }
            return "Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            List<Student> students = new List<Student>();
            foreach (Student item in data)
            {
                if (item.Subject == subject)
                {
                    students.Add(item);
                }
            }
            StringBuilder sb = new StringBuilder();
            if (students.Any(x => x.Subject == subject))
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (Student item in students)
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }
            }
            else
            {
                sb.AppendLine("No students enrolled for the subject");
            }

            return sb.ToString().TrimEnd();
        }
        public int GetStudentsCount()
        {
            return data.Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
           
            return data.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
