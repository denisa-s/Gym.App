using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1.Models;
using SQLite;
namespace Proiect1.Database
{
    public class LoginDatabase
    {
        readonly SQLiteAsyncConnection database;

        public LoginDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<LoginModel>().Wait();
        }

        public Task<LoginModel> GetLoginDataAsync(string userName)
        {
            return database.Table<LoginModel>()
                            .Where(i => i.UserName == userName)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveLoginDataAsync(LoginModel loginData)
        {
            return database.InsertAsync(loginData);
        }
    }
}
