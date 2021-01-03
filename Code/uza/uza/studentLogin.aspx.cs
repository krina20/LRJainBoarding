using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_studentLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void login_btn_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from StudentReg where Email=@Email and Password=@Password", con);
        cmd.Parameters.AddWithValue("Email", TextBox_email.Text);
        cmd.Parameters.AddWithValue("Password", TextBox_password.Text);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        cmd.ExecuteNonQuery();
        con.Close();
        if (dt.Rows.Count > 0)
        {
            Session["Email"] = TextBox_email.Text;

            Response.Write("<script language='javascript'>window.alert('Welcome to LR Jain Boarding');window.location='studentHome.aspx';</script>");
            //Session.RemoveAll();
        }
        else if (dt.Rows.Count == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter email and password first');", true);
        }
        else
        {
            Response.Write("<script language='javascript'>window.alert('Email or Password is wrong.');window.location='studentLogin.aspx';</script>");
        }
    }
}