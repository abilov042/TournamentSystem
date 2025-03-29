using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal) 
        {
            _userDal = userDal;
        }

        public User FindByUsername(string username)
        {
            return _userDal.Get((user) => user.Username == username);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Save(User user)
        {
            _userDal.Add(user);
        }
    }
}
