using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using СontrolOfPersonalFinances.Logic.Enums;
using СontrolOfPersonalFinances.Logic.Models;



namespace СontrolOfPersonalFinances.Logic.Model
{

    public class PersonalFinanceAccountingSystem
    {
        public Dictionary<int, TransactionModel> _transactions;
        public Dictionary<int, AccountModel> _accounts;
        public Dictionary<int,CategoryModel> _categories;
       

        public int _transactionsCategoriesLastId;// перечисление категории
        public int _transactoinsLastId;// перечисленные транзакции
        public int _accountsLastId;// учетные записи
        public PersonalFinanceAccountingSystem() 
        {
            _transactions=new Dictionary<int,TransactionModel>();
            _accounts = new Dictionary<int,AccountModel>();
            _categories = new Dictionary<int,CategoryModel>();

             _transactionsCategoriesLastId = 1;
            _transactoinsLastId = 1;
            _accountsLastId = 1;
        }
        public void SaveAll()// сохранить все 
        {
            string json = JsonSerializer.Serialize(this);
            using (StreamWriter writer = new StreamWriter("File.json", false))
            {
                writer.Write(json);
                writer.Close();
            }
        }
        public void LoadAll()//прочитать все 
        {
            string json;
            using (StreamReader reader = new StreamReader("File.json"))
            {
                json = reader.ReadToEnd();
                reader.Close();
            }

        }
        public void AddCategory(CategoryModel category)
        {
            category.Id = _transactionsCategoriesLastId;
            _categories.Add(_transactionsCategoriesLastId, category);
            _transactionsCategoriesLastId++;
        }
        public void DeleteCategoryById(int id)
        {
            _categories.Remove(id);
        }
        public CategoryModel GetCategoryModelById(int id)
        {
            return _categories[id];
        }
        public List<CategoryModel> GetAllCategoryModels()//вернуть 
        {
            return _categories.Values.ToList();
        }
        public void WithdrawMoney(AccountModel accountModel, int ammount)// снятие
        {
            accountModel.Balance -= ammount;
        }
        public void AddMomey(AccountModel accountModel,int ammount)
        {
            accountModel.Balance += ammount;
        }
       public void AddTransaction(TransactionModel transaction)
        {
            transaction.Id = _transactoinsLastId;
            _transactions.Add(_transactoinsLastId, transaction);
             _transactoinsLastId++;
        }
        public void DeleteTransactionById(int id)
        {
            _transactions.Remove(id);
        }
        public TransactionModel GetTransactionModelById(int id)
        {
            return _transactions[id];
        }
        public List<TransactionModel> GetAllTransactionModels()
        {
            return _transactions.Values.ToList();
        }
        public void AddFinanse(AccountModel finanse)
        {
            finanse.Id = _accountsLastId;
            _accounts.Add(_accountsLastId, finanse);
            _accountsLastId++;
        }
        public void DeleteFinanseById(int id)
        {
            _accounts.Remove(id);
        }
        public AccountModel GetFinanseById(int id)
        {
            return _accounts[id];
        }
        public List<AccountModel> GetAllFinanses()
        {
            return _accounts.Values.ToList();
        }
    }
}
