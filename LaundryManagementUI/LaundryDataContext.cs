using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagement.Models
{
    public class LaundryDataContext : DbContext
    {
        public LaundryDataContext() : base("con")
        {
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ServicePlan> ServicePlans { get; set; }
        public DbSet<StudentInfo> StudentInfos { get; set; }
        public DbSet<Transaction> Tranasactions { get; set; }
    }

}

  