using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    internal class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.FullName, inputModel.Email, inputModel.BirthDate);
            _dbContext.Users.Add(user);
            return user.Id;
        }

        public UserDetailViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);
            
            if(user == null)
            {
                return null;
            }

            var userDetailViewModel = new UserDetailViewModel(user.FullName, user.Email);

            return userDetailViewModel;
        }

        public void Update(UpdateUserInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
