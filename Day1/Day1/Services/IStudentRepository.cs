using Day1.Models;
using System;
using System.Collections.Generic;

namespace Day1.Services
{
    public interface IStudentRepository
    {
        Guid id { get; set; }
        int Create(Student std);
        int Delete(int id);
        List<Student> getAll();
        Student getById(int id);
        Student getByNAme(string Name);
        List<Student> getSudentByDEptID(int deptID);
        int Update(int id, Student student);
    }

}