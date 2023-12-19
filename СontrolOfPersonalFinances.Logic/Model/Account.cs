using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public  class Account//счет
    {
        public string AccountID { get; set; }
        public string Name { get; set; }
        public int AccountBalance { get; set; }
    }
    public class Debt//долг
    {
        public string DebtID { get; set; }
        public int AmountDebt { get; set;}
        public int DebtStartDate { get;}
        public int DebtEndDate { get;}
    }
    public class Income//доход
    {
        public string IncomeID { get; set; }
        public int AmountIncome { get; set;}
        public int DateReceiptOfIncome { get; set; }
    }
    public class Expenditure//расход
    {
        public string ExpenditureID { get; set; }
        public int AmountExpenditure { get; set; }
        public int DateExpenditure { get;set; }
        public int ExpenseCategory { get;}
    }
}
