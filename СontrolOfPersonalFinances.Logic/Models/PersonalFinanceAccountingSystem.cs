using System;
using System.Collections.Generic;
using System.Linq;
using СontrolOfPersonalFinances.Logic.Enums;
using СontrolOfPersonalFinances.Logic.Models;


namespace СontrolOfPersonalFinances.Logic.Model
{

    public class PersonalFinanceAccountingSystem
    {
        public Dictionary<TransactionType, TransactionModel> _transactions;
        public Dictionary<AccountType, AccountModel> _accounts;
        public Dictionary<int,CategoryModel> _categories;
       

        public int _transactionsCategoriesLastId;// перечисление категории
        public PersonalFinanceAccountingSystem() 
        {
            _transactions=new Dictionary<TransactionType,TransactionModel>();
            _accounts = new Dictionary<AccountType,AccountModel>();
            _categories = new Dictionary<int,CategoryModel>();

             _transactionsCategoriesLastId = 1;
            
        }
        public void AddCategory(CategoryModel category)
        {
            category.Id = _transactionsCategoriesLastId;
            _categories.Add(_transactionsCategoriesLastId, category);
            _transactionsCategoriesLastId++;
        }
        public void DetachCategoryById(int id)
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

    }
}
