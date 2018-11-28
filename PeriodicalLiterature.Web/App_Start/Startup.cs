using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using PeriodicalLiterature.DAL;
using PeriodicalLiterature.Servises.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(PeriodicalLiterature.Web.App_Start.Startup))]
namespace PeriodicalLiterature.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            app.CreatePerOwinContext<ApplicationContext>(ApplicationContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationRoleManager>(ApplicationRoleManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),//path where will be unauthorized user 
            });

        }
    }
}