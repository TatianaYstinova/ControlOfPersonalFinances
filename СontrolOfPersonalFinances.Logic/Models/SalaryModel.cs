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
         
        public void SendingASalary(AccountModel account,int ammount)
        {
            DateTime currentDate = DateTime.Now;
            SalaryModel salary = new SalaryModel();

            // Проверяем, является ли текущая дата 15 числом месяца
            if (currentDate.Day == 15)
            {
                salary.NumberAccount= "Работодатель";
                salary.Summ = ammount;
            };
            account.Balance += salary.Summ;
            ShowAccountsList.Items.Add($"Баланс пополнен на {salary.Summ} рублей.");

        }
    }

}
