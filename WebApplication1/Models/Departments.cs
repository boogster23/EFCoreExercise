using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employees>();
        }

        public int DeptUniqueId { get; set; }
        public int Capacity { get; set; }
        public string DeptName { get; set; }
        public int DeptNo { get; set; }
        public string Location { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
