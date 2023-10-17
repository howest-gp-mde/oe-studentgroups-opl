using Mde.ClassGroupsOrganizer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.ClassGroupsOrganizer.Domain.Services
{
    public class InMemoryStudentService : IStudentService
    {
        private readonly List<Student> students = new List<Student>
        {
            new Student { Name = "Andy", Group = 2 },
            new Student { Name = "Tristan", Group = 2 },
            new Student { Name = "Jorn", Group = 2 },
            new Student { Name = "Francesca", Group = 1 },
            new Student { Name = "Jarno", Group = 1 }
        };

        public void Add(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetAll()
        {
            return students;
        }
    }
}
