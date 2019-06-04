using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagement.Models
{
    public class StudentInfo
    {
        public int StudentInfoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string EmailId  { get; set; }
        public byte[] Barcode { get; set; }
        public string BarcodeID { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public bool IsActive { get; set; }

    }
}
