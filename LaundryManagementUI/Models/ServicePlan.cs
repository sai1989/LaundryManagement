using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagement.Models
{
    public class ServicePlan
    {
        public int ServicePlanId { get; set; }
        public string PlanName { get; set; }
        public int NoOfWashes { get; set; }
        public string ValidityDate { get; set; }
        public decimal Amount { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public bool IsActive { get; set; }
    }
}
