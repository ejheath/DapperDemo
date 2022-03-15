using System;
using System.Collections.Generic;

namespace DapperDemo
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
