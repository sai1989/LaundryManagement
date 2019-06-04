using LaundryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagement.CRUD
{
    public class EmployeeCRUD
    {
        private readonly LaundryDataContext _context;

        public EmployeeCRUD(LaundryDataContext context)
        {
            this._context = context;
        }
        public ICollection<Employee> GetAllEmployees()
        {
            return _context.Employees.Where(x => x.IsActive).ToList();
        }
        public Employee GetEmployee(int employeeId)
        {
            return _context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
        }
        public bool Update(Employee employee)
        {
            var fetchedEmp = GetEmployee(employee.EmployeeId);
            if (fetchedEmp != null)
            {
                fetchedEmp.ContactNo = employee.ContactNo;
                fetchedEmp.EmailAddress = employee.EmailAddress;
                fetchedEmp.FirstName = employee.FirstName;
                fetchedEmp.JoiningDate = employee.JoiningDate;
                fetchedEmp.LastName = employee.LastName;
                fetchedEmp.RoleId = employee.RoleId;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int EmployeeId)
        {
            var fetchedEmployee = GetEmployee(EmployeeId);
            if (fetchedEmployee  != null)
            {
                fetchedEmployee.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return true;
        }
    }
}
