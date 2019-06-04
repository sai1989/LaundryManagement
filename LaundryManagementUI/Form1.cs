using LaundryManagement;
using LaundryManagement.CRUD;
using LaundryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestCode_Click(object sender, EventArgs e)
        {
            EmployeeCRUD empCRUD = new EmployeeCRUD(new LaundryManagement.Models.LaundryDataContext());
            //empCRUD.Create(CreateNewEmployeeDummyData());
            //empCRUD.Update(UpdateEmployeeDummyData());
           // List<Employee> res =(List<Employee>) empCRUD.GetAllEmployees();
            //empCRUD.Delete(1);
            MessageBox.Show("wait");
            }
        private Employee UpdateEmployeeDummyData()
        {
            Employee emp = new Employee
            {
                EmployeeId = 1,
                ContactNo = "6303059155",
                EmailAddress = "sai@anicalls.com",
                FirstName = "Sai",
                LastName = "Patibandla",
                IsActive = true,
                JoiningDate = "02-12-2018",
                RoleId = 1
            };
            return emp;
        }
        private Employee CreateNewEmployeeDummyData()
        {
            Employee emp = new Employee
            {
                ContactNo = "9182451469",
                EmailAddress = "",
                FirstName = "Sai",
                LastName = "Patibandla",
                IsActive = true,
                JoiningDate = "02-12-2018",
                RoleId = 1
            };
            return emp;
        }
    }
}
