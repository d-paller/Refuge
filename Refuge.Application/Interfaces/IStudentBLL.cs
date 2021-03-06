﻿using Refuge.Model.Classes;
using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Application.Interfaces
{
    public interface IStudentBLL
    {
        Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId);

        Task<Student> GetStudentByIdAsync(int studentId);

        Task<IEnumerable<Student>> GetAllStudentsAsync();

        Task CreateStudentAsync(Student student);

        Task UpdateStudentAsync(Student s);

        Task DeleteStudentAsync(string id);

        Task LogStudentOut(string id, DateTime? differentDate = null);
    }
}
