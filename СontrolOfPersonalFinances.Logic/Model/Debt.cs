using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public class Debt//долг
    {
        public string DebtID { get; set; }
        public int AmountDebt { get; set; }
        public int DebtStartDate { get; }
        public int DebtEndDate { get; }
    }
}
