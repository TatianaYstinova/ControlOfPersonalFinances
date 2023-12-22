using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class Transaction
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Summ { get; set; }
        public DateTime time { get; set; }
        public Account Account { get; set; }
        public DateTime Date { get; set; }
        public TraceEventType type { get; set; }
        public bool IsApproved {  get; set; }
        public int СategoriesId {  get; set; } 
    }
}
