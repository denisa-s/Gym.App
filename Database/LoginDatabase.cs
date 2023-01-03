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
            database.CreateTableAsync<GymInfo>().Wait();
            database.CreateTableAsync<TrainerInfo>().Wait();
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
        public Task<List<GymInfo>> GetGymInfosAsync()
        {
            return database.Table<GymInfo>().ToListAsync();
        }
        public Task<GymInfo> GetGymInfoAsync(int id)
        {
            return database.Table<GymInfo>()
            .Where(i => i.GymId == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveGymInfoAsync(GymInfo slist)
        {
            if (slist.GymId != 0)
            {
                return database.UpdateAsync(slist);
            }
            else
            {
                return database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteGymInfoAsync(GymInfo slist)
        {
            return database.DeleteAsync(slist);
        }

        public Task<List<TrainerInfo>> GetTrainerInfosAsync()
        {
            return database.Table<TrainerInfo>().ToListAsync();
        }
        public Task<TrainerInfo> GetTrainerInfoAsync(int id)
        {
            return database.Table<TrainerInfo>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveTrainerInfoAsync(TrainerInfo slist)
        {
            if (slist.ID != 0)
            {
                return database.UpdateAsync(slist);
            }
            else
            {
                return database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteTrainerInfoAsync(TrainerInfo slist)
        {
            return database.DeleteAsync(slist);
        }
    }

}