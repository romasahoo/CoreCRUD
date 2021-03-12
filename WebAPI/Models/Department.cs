using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Department
    {
        public int DeptId { get; set; }

        public string DeptName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
