using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        public string DeptName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
