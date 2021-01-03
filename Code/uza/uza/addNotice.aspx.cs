using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_addNotice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
        {
            Response.Redirect("userLogin.aspx");
        }
        else
        {
            Label1.Text = Session["Admin"].ToString();
        }
    }
    protected void Button_upload_Click(object sender, EventArgs e)
    {
        string title = TextBox_title.Text.Trim();
        string notice = TextBox_notice.Text.Trim();

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");

        SqlCommand cmd = new SqlCommand("insert into Notice(Title,Message) values (@Title,@Message)");

        cmd.Connection = con;

        cmd.Parameters.AddWithValue("@Title", title);
        cmd.Parameters.AddWithValue("@Message", notice);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox_title.Text = "";
        TextBox_notice.Text = "";

        Response.Write("<script language='javascript'>window.alert('Notice uploaded!');window.location='adminHome.aspx';</script>");

        
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}