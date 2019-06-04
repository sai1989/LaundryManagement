using LaundryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementUI.CRUD
{
    public class StudentInfoCRUD
    {
        private readonly LaundryDataContext _context;

        public StudentInfoCRUD(LaundryDataContext context)
        {
            this._context = context;
        }
        public ICollection<StudentInfo> GetAllStudentsInfo()
        {
            return _context.StudentInfos.Where(x => x.IsActive).ToList();
        }
        public StudentInfo GetStudentInfo(int studentId)
        {
            return _context.StudentInfos.FirstOrDefault(x => x.StudentInfoId == studentId);
        }
        public bool Update(StudentInfo studentInfo)
        {
            var fetchedStudent = GetStudentInfo(studentInfo.StudentInfoId);
            if (fetchedStudent != null)
            {
                fetchedStudent.ContactNo = studentInfo.ContactNo;
                fetchedStudent.FirstName = studentInfo.FirstName;
                fetchedStudent.LastName = studentInfo.LastName;
                fetchedStudent.Barcode= studentInfo.Barcode;
                fetchedStudent.BarcodeID = studentInfo.BarcodeID;
                fetchedStudent.EmailId = studentInfo.EmailId;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int studentId)
        {
            var fetchedStudent = GetStudentInfo(studentId);
            if (fetchedStudent != null)
            {
                fetchedStudent.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(StudentInfo student)
        {
            _context.StudentInfos.Add(student);
            _context.SaveChanges();
            return true;
        }
    }
}
