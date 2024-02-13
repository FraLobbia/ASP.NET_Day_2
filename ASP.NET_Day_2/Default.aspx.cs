using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Day_2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


            protected void handleLogIn(object sender, EventArgs e)
            {
                // istanziamo http cookie che ci permetterà di gestire il cookie
                HttpCookie cookie = new HttpCookie("ASPNET_COOKIE");	
                //inseriamo all'interno del cookie la chiave nome 
                // con il valore che prendiamo dal campo
                cookie.Values["username"] = UsernameField.Text;
                cookie.Values["password"] = PasswordField.Text;
                //diciamo che il cookie e valido 10 giorni
                cookie.Expires = DateTime.Now.AddDays(10);
                // Con response inviamo indietro i cookie al client
                Response.Cookies.Add(cookie);

                Response.Redirect("About");
        }
       
    }
}