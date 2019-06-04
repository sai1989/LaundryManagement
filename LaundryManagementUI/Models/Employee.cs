using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string JoiningDate { get; set; }
        public Role Roles { get; set; }
        public int RoleId { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public bool IsActive { get; set; }
    }
}
