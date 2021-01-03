using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_changePassword : System.Web.UI.Page
{
    string str = null;
    SqlCommand com;
    byte up;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Email"] == null)
        {
            Response.Redirect("studentLogin.aspx");
        }
        else
        {
            Label1.Text = Session["Email"].ToString();
        }
    }

    protected void Button_pwd_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");

        con.Open();
        str = "select * from StudentReg ";
        com = new SqlCommand(str, con);
        SqlDataReader sdr = com.ExecuteReader();
        while (sdr.Read())
        {
            if (TextBox_old.Text == sdr["Password"].ToString())
            {
                if (TextBox_new.Text == TextBox_confirm_new.Text)
                { 
                    up = 1;
                }
            }
        }
        sdr.Close();
        con.Close();
        if (up == 1)
        {
            con.Open();
            str = "update StudentReg set Password=@Password where Email='" + Session["Email"].ToString() + "'";
            com = new SqlCommand(str, con);
            com.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
            com.Parameters["@Password"].Value = TextBox_new.Text;
            com.ExecuteNonQuery();
            con.Close();
            Label2.Text = "Password changed Successfully";
        }
        else
        {
            Label2.Text = "Please enter correct Current password";
        }
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("studentLogin.aspx");
    //}
}