using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagement.Models
{
    public class Transaction
    {
        public int TransactionId{ get; set; }
        public string TransactionDate { get; set; }
        public StudentInfo StudentInfo { get; set; }
        public int StudentInfoId { get; set; }
        public ServicePlan ServicePlan { get; set; }
        public int ServicePlanId { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public bool IsActive { get; set; }
    }
}
