using BasicProject.Context;
using BasicProject.Interface;
using BasicProject.Models;
using System;
using System.Threading.Tasks;

namespace BasicProject.Services
{
    public class User : IUser
    {
        private readonly BaseContext _dbContext;

        public User(BaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<string> createUser(UserModel user)
        {

            try
            {
                await _dbContext.User.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


    }
}
