using LaundryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementUI.CRUD
{
    public class ServicePlanCRUD
    {
        private readonly LaundryDataContext _context;

        public ServicePlanCRUD(LaundryDataContext context)
        {
            this._context = context;
        }
        public ICollection<ServicePlan> GetAllServiceplans()
        {
            return _context.ServicePlans.Where(x => x.IsActive).ToList();
        }
        public ServicePlan GetServiceplan(int serviceplanId)
        {
            return _context.ServicePlans.FirstOrDefault(x => x.ServicePlanId == serviceplanId);
        }
        public bool Update(ServicePlan servicePlan)
        {
            var fetchedServiceplan = GetServiceplan(servicePlan.ServicePlanId);
            if (fetchedServiceplan != null)
            {
                fetchedServiceplan.Amount = servicePlan.Amount;
                fetchedServiceplan.NoOfWashes = servicePlan.NoOfWashes;
                fetchedServiceplan.PlanName = servicePlan.PlanName;
                fetchedServiceplan.ValidityDate = servicePlan.ValidityDate;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int servicePlanId)
        {
            var fetchedServiceplan = GetServiceplan(servicePlanId);
            if (fetchedServiceplan != null)
            {
                fetchedServiceplan.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(ServicePlan servicePlan)
        {
            _context.ServicePlans.Add(servicePlan);
            _context.SaveChanges();
            return true;
        }
    }
}
