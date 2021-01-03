using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_userLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void login_btn_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from TblUser where Name=@Name and Password=@Password", con);
        cmd.Parameters.AddWithValue("Name", TextBox_name.Text);
        cmd.Parameters.AddWithValue("Password", TextBox_password.Text);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        cmd.ExecuteNonQuery();
        con.Close();
        if (dt.Rows.Count > 0)
        {
            if (TextBox_name.Text == "Krina" || TextBox_name.Text == "Nidhi" || TextBox_name.Text == "Shaily")
            {
                Session["Warden"] = TextBox_name.Text;

                Response.Write("<script language='javascript'>window.alert('Hey WARDEN! Welcome to LR Jain Boarding');window.location='wardenHome.aspx';</script>");
                //Session.RemoveAll();
            }

            else if (TextBox_name.Text == "Hem" || TextBox_name.Text == "Shivam")
            {
                Session["Admin"] = TextBox_name.Text;

                Response.Write("<script language='javascript'>window.alert('Hey ADMIN! Welcome to LR Jain Boarding');window.location='adminHome.aspx';</script>");
                //Session.RemoveAll();
            }

        }
        else if (dt.Rows.Count == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter name and password first');", true);
        }
        else
        {
            Response.Write("<script language='javascript'>window.alert('Name or Password is wrong.');window.location='userLogin.aspx';</script>");
        }

    }
}