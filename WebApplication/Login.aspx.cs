using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Login : System.Web.UI.Page
    {

        private readonly IUserService _userService;
        

        public Login()
        {
            _userService = new UserManager(new EfUserDal());
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            User user = _userService.FindByUsername(txtUsername.Text);

            if (user != null && user.Password.Equals(txtPassword.Text))
            {
                Session["username"] = txtUsername.Text;
                Response.Redirect("Default.aspx");
            }
        }
    }
}