using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concretes;
using System;

namespace WebApplication
{
    public partial class Register : System.Web.UI.Page
    {
        private IUserService _userService;

        protected void Page_Load(object sender, EventArgs e)
        {
            _userService = new UserManager(new EfUserDal());
        }
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            
            User user = new User
            {
                Username= txtNewUsername.Text,
                Email = txtNewEmail.Text,
                Password = txtNewPassword.Text
            };

            _userService.Save(user);

        }
    }
}