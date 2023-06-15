using Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1.Services
{
    public class StudentFRomMEmeoryRepository:IStudentRepository
    {
        List<Student> std = new List<Student>();
        public StudentFRomMEmeoryRepository()
        {
            std.Add(new Student() { ID=1,Name="Mohamed",Age=13,Address="sdsd",Dept=1});
            std.Add(new Student() { ID = 1, Name = "Mohamed", Age = 13, Address = "sdsd", Dept = 1 });
        }

        public Guid id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Create(Student std)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Student> getAll()
        {
            return std;
        }
        public Student getById(int id)
        {
            return std.FirstOrDefault();
        }

        public Student getByNAme(string Name)
        {
            throw new System.NotImplementedException();
        }

        public List<Student> getSudentByDEptID(int deptID)
        {
            throw new System.NotImplementedException();
        }

        public int Update(int id, Student student)
        {
            throw new System.NotImplementedException();
        }
    }
}
