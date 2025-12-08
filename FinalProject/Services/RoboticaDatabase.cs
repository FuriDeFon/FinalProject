using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Models;

namespace FinalProject.Services
{
    public class RoboticaDatabase
    {
        SQLiteAsyncConnection? database;

        public RoboticaDatabase()
        {
            
        }

        async Task Init()
        {
            if (database is not null)
                return;

            database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await database.CreateTableAsync<Robot>();
        }

        public async Task<List<Robot>> GetItemsAsync()
        {
            await Init();
            return await database.Table<Robot>().ToListAsync();
        }

        public async Task<Robot> GetItemAsync(int id)
        {
            await Init();
            return await database.Table<Robot>().Where(i => i.RobotID == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(Robot item)
        {
            await Init();
            if (item.RobotID != 0)
                return await database.UpdateAsync(item);
            else
                return await database.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(Robot item)
        {
            await Init();
            return await database.DeleteAsync(item);
        }
    }
}
