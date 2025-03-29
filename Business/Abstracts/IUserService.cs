using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.Abstracts
{
    public interface IUserService
    {
        void Save(User user);
        List<User> GetAll();

        User FindByUsername(string username);
    }
}
