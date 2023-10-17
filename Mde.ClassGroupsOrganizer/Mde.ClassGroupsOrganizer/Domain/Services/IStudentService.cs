using Mde.ClassGroupsOrganizer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.ClassGroupsOrganizer.Domain.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        void Add(Student student);
    }
}
