using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public abstract class ADebt : AAccount
    {//долг
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
