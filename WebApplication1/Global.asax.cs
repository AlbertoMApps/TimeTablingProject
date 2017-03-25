using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using TimeTabling.CORE;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        const string RolAdmin = "Admin";
        const string RolUser = "User";
        const string UserAdmin = "admin@admin.com";
        const string Password = "123As@";


        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Configuracion de seguridad
            TimeTabling.DAL.ApplicationDbContext context = new TimeTabling.DAL.ApplicationDbContext();
            RoleManager <IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole> (context) );
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists(RolAdmin))
                roleManager.Create(new IdentityRole(RolAdmin));
            if(!roleManager.RoleExists(RolUser))
                roleManager.Create(new IdentityRole(RolUser));
             ApplicationUser user = userManager.FindByName(UserAdmin);
            if(user == null )
            {
                user = new ApplicationUser();
                user.UserName = UserAdmin;
                user.Email = UserAdmin;
                IdentityResult identityResult = userManager.Create(user, Password);
                if(identityResult.Succeeded)
                {
                    userManager.AddToRole(user.Id, RolAdmin);
                } else
                {
                    throw new Exception("Usuario no creado");
                }
            } else
            {
                //usuario creado pero, esta en el rol admin?
                if(userManager.IsInRole(user.Id, RolAdmin))
                {
                    userManager.AddToRole(user.Id, RolAdmin);
                }
            }

        }
    }
}