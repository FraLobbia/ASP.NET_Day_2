using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Day_2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ASPNET_COOKIE"] != null)
            {
                string username = Request.Cookies["ASPNET_COOKIE"]["username"];
                string password = Request.Cookies["ASPNET_COOKIE"]["password"];
                datiUtente.InnerText = $"L'utente loggato è {username}";
            }
            else { Response.Redirect("Default"); };
        }

        protected void LogOutButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("ASPNET_COOKIE");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default");
        }
    }
}