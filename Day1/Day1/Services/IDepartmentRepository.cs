using Day1.Models;
using System.Collections.Generic;

namespace Day1.Services
{
    public interface IDepartmentRepository
    {
        int Create(Department dept);
        int Delete(int id);
        List<Department> getAll();
        Department getById(int id);
        int Update(int id, Department dept);
    }
}