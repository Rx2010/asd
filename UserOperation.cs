using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace XF2_443_Q3
{
    public class UserOperation
    {
        readonly SQLiteAsyncConnection db;

        public UserOperation(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Users>().Wait();
        }
        //Get all Users.
        public Task<List<Users>> GetUsersAsync()
        {

            return db.Table<Users>().ToListAsync();
        }
        // Get a specific user by Id.
        public Task<Users> GetUserAsync(int id)
        {
            return db.Table<Users>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
        // Get a specific user by Username.
        public Task<Users> GetnumberAsync(int number,int code)
        {
            return db.Table<Users>().Where(i => i.Number == number && i.Code==code).FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(Users user)
        {
            if (user.Id != 0)
            {
                // Update an existing User.
                return db.UpdateAsync(user);
            }
            else
            {
                // Save a new User.
                return db.InsertAsync(user);
            }
        }
        // Delete User.
        public Task<int> DeleteUserAsync(Users user)
        {
            return db.DeleteAsync(user);
        }
    }
}