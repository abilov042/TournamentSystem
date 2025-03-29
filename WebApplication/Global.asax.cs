using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;


namespace WebApplication
{
    public class Global : System.Web.HttpApplication
    {

        //public static IServiceCollection _serviceCollection;

        protected void Application_Start(object sender, EventArgs e)
        {
            //_serviceCollection = new ServiceCollection();
            //_serviceCollection.AddScoped<IUserService, UserManager>();
            //_serviceCollection.AddScoped<IUserDal, EfUserDal>();

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}