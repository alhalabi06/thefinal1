using final1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Transaction
    {
        public int TransactionID { get; set; }
        int ResultID { get; set; }
        Ledgers LedgersID { get; set; }
        int Account { get; set; }
        string Description { get; set; }
        int Amount { get; set; }
        string CreditOrDebit { get; set; }
        Currency Currency { get; set; }
        DateTime Date { get; set; }
        public Transaction(int transactionID,Currency Currency, int resultID, int receiptID, Ledgers ledgersID, int invoicesID, int account, string description, int amount, string creditOrDebit, DateTime date)
        {
            this.TransactionID = transactionID;
            this.ResultID = resultID;
            this.LedgersID = ledgersID;
            this.Account = account;
            this.Description = description;
            this.Amount = amount;
            this.CreditOrDebit = creditOrDebit;
            this.Currency = Currency;
            this.Date = date;
        }
    }

}