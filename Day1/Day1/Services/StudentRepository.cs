using Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1.Services
{
    //services Student Model CRUD
    public class StudentRepository : IStudentRepository
    {
        ITIEnitities context;//= new ITIEnitities();//ioc solid
        public StudentRepository(ITIEnitities _context)
        {
            context= _context;
        }
        public Guid id { get; set; }
        public StudentRepository()
        {
            id = Guid.NewGuid();
        }

        //REadall
        public List<Student> getAll()
        {
            return context.Student.ToList();
        }
        //readone
        public Student getById(int id)
        {
            return context.Student.FirstOrDefault(s => s.ID == id);
        }
        public Student getByNAme(string Name)
        {
            return context.Student.FirstOrDefault(s => s.Name == Name);
        }

        public List<Student> getSudentByDEptID(int deptID)
        {
            return context.Student.Where(s => s.Dept == deptID).ToList();
        }
        //Create
        public int Create(Student std)
        {
            context.Student.Add(std);
            int raw = context.SaveChanges();
            return raw;
            //insert context
        }
        //Update
        public int Update(int id, Student student)
        {
            Student oldStudent = context.Student.FirstOrDefault(s => s.ID == id);
            oldStudent.Name = student.Name;
            oldStudent.Age = student.Age;
            oldStudent.Dept = student.Dept;
            oldStudent.Image = student.Image;
            oldStudent.Address = student.Address;
            int raw = context.SaveChanges();
            return raw;

        }
        //Delete
        public int Delete(int id)
        {
            Student std =
                context.Student.FirstOrDefault(s => s.ID == id);

            context.Student.Remove(std);
            int raw = context.SaveChanges();
            return raw;
        }
    }
}
