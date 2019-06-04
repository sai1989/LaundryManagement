using LaundryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementUI.CRUD
{
    public class TransactionsCRUD
    {
        private readonly LaundryDataContext _context;

        public TransactionsCRUD(LaundryDataContext context)
        {
            this._context = context;
        }
        public ICollection<Transaction> GetAllTransactions(string startDate,string endDate)
        {
            if (string.IsNullOrEmpty(startDate)&&string.IsNullOrEmpty(endDate))
            {
                return _context.Tranasactions.Where(x => x.IsActive && x.TransactionDate==System.DateTime.Now.ToLongDateString()).ToList();
            }
            else if (string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate))
            {
                return null;
            }
            return _context.Tranasactions.Where(x => x.IsActive && 
            Convert.ToDateTime( x.TransactionDate) >= Convert.ToDateTime(startDate) &&
            Convert.ToDateTime(x.TransactionDate) <= Convert.ToDateTime(endDate)).ToList();
        }
        public Transaction GetTransaction(int transactionId)
        {
            return _context.Tranasactions.FirstOrDefault(x => x.TransactionId == transactionId);
        }
        public bool Update(Transaction transaction)
        {
            var fetchedtransaction = GetTransaction(transaction.TransactionId);
            if (fetchedtransaction != null)
            {
                fetchedtransaction.TransactionDate = System.DateTime.Now.ToLongDateString();
                fetchedtransaction.EmployeeId = transaction.EmployeeId;
                fetchedtransaction.ServicePlanId = transaction.ServicePlanId;
                fetchedtransaction.StudentInfoId = transaction.StudentInfoId;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int TransactionId)
        {
            var fetchedTransaction = GetTransaction(TransactionId);
            if (fetchedTransaction != null)
            {
                fetchedTransaction.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(Transaction transaction)
        {
            transaction.TransactionDate = System.DateTime.Now.ToLongDateString();
            _context.Tranasactions.Add(transaction);
            _context.SaveChanges();
            return true;
        }
    }
}
