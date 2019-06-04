using LaundryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementUI.CRUD
{
    public class RoleCRUD
    {
        private readonly LaundryDataContext _context;

        public RoleCRUD(LaundryDataContext context)
        {
            this._context = context;
        }
        public ICollection<Role> GetAllRoles()
        {
            return _context.Roles.Where(x => x.IsActive).ToList();
        }
        public bool Update(Role role)
        {
            var fetchedRole = _context.Roles.FirstOrDefault(x => x.RoleId == role.RoleId);
            if (fetchedRole != null)
            {
                fetchedRole.RoleName = role.RoleName;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int RoleId)
        {
            var fetchedRole = _context.Roles.FirstOrDefault(x => x.RoleId == RoleId);
            if (fetchedRole != null)
            {
                fetchedRole.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(Role Role)
        {
            var fetchedRole = _context.Roles.FirstOrDefault(x => x.RoleName.ToLowerInvariant() == Role.RoleName.ToLowerInvariant());
            if (fetchedRole != null)
            {
                return false;
            }
            _context.Roles.Add(Role);
            _context.SaveChanges();
            return true;
        }
    }
}
