using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public abstract class ADebt : AAccount
    {//долг
        public string DataToStart { get;  }
        public string DataToEnd { get; }

    }
}
