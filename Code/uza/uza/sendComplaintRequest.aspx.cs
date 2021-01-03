using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_sendComplaintRequest : System.Web.UI.Page
{
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

        Label2.Text = DateTime.Now.ToShortDateString();
    }
    protected void Button_send_Click(object sender, EventArgs e)
    {

        string message = TextBox_message.Text.Trim();
        string email = Session["Email"].ToString();
       // string cr_date = DateTime.Now.ToShortDateString();

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");

        SqlCommand cmd = new SqlCommand("insert into ComplaintRequest(CR_details,studentEmail,date) values (@CR_details,@studentEmail,@date)");
        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@CR_details", message);
        cmd.Parameters.AddWithValue("@studentEmail", email);
        cmd.Parameters.AddWithValue("@date",Label2.Text.Trim());
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox_message.Text = "";

        Response.Write("<script language='javascript'>window.alert('Your message has been sent!');window.location='studentHome.aspx';</script>");
        
    }

    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("studentLogin.aspx");
    //}
}