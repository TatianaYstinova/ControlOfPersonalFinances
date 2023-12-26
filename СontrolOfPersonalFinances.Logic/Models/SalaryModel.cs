using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СontrolOfPersonalFinances.Logic.Model;

namespace СontrolOfPersonalFinances.Logic.Models
{
    public class SalaryModel
    {// зарплата
        public string NumberAccount {  get; set; }
        public decimal Summ {  get; set; }
        public DataSetDateTime dateTime { get; set; }
         
    }
}
