using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace СontrolOfPersonalFinances.Logic.Model
{
    public  class Account//счет
    {
        public string TypeBank { get; set; }
        public string Name { get; set; }
        public int AccountBalance { get; set; }
    }
}
