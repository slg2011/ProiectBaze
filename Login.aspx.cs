using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication3.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=(local);Initial Catalog=ProiectBaze;Integrated Security=SSPI;Packet Size=3500;Connection Timeout=60 ");
            connect.Open();
            string checkuser = "select count(*) from LogInn where username='" + TextBoxUser.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, connect);

            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            connect.Close();

            if (temp == 1)
            {

                connect.Open();
                string checkpass = "select parola from LogInn where username='" +TextBoxUser.Text + "'";
                SqlCommand passCom = new SqlCommand(checkpass, connect);
                string password = passCom.ExecuteScalar().ToString().Replace(" ", "");
                if (temp == 1)
                {
                    Response.Write(password);
                }
                if (password == TextBoxPassword.Text)
                {
                    Session["New"] = TextBoxUser.Text;
                    Response.Write("Password is corect");
                }
                else
                {
                    Response.Write("Password is not corect");
                }

            }
            else
            {
                Response.Write("Username is NOT corect");
            }

        }

 
      
    }
}