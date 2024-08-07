using final1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace final1
{
    internal class Invoices
    {
        public int InvoicesID {  get; set; }
        int PatientID {  get; set; }
        int TotalPrice { get; set; }
        Currency Currency { get; set; }
        DateTime date { get; set; }
        public Invoices( int InvoicesId , int PatientID , int TotalPrice ,DateTime date ,Currency Currency ) {
            this.InvoicesID = InvoicesID;
            this.PatientID = PatientID;
            this.TotalPrice = TotalPrice;
            this.date = date;
            this.Currency = Currency;
        }
        
    }
}
