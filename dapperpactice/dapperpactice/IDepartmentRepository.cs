using System;
using System.Collections.Generic;
using System.Text;

namespace DapperInClass
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments();
    }
}
