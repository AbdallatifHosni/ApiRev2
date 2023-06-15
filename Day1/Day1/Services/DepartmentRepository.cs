using Day1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Day1.Services
{
    //CRUD DEpartment
    public class DepartmentRepository : IDepartmentRepository
    {
        ITIEnitities context;// = new ITIEnitities();
        //REadall
        public DepartmentRepository(ITIEnitities _context)
        {
            context = _context;
        }
        public List<Department> getAll()
        {
            return context.Department.ToList();
        }
        //readone
        public Department getById(int id)
        {
            return context.Department.FirstOrDefault(s => s.Id == id);
        }
        //Create
        public int Create(Department dept)
        {
            context.Department.Add(dept);
            int raw = context.SaveChanges();
            return raw;
            //insert context
        }
        //Update
        public int Update(int id, Department dept)
        {
            Department oldDEpt = context.Department.FirstOrDefault(s => s.Id == id);
            oldDEpt.Name = dept.Name;
            oldDEpt.ManagerName = dept.ManagerName;
            int raw = context.SaveChanges();
            return raw;

        }
        //Delete
        public int Delete(int id)
        {
            Department dept =
                context.Department.FirstOrDefault(s => s.Id == id);
            context.Department.Remove(dept);
            int raw = context.SaveChanges();
            return raw;
        }
    }
}
