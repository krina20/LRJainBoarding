using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_scholarshipSelection : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd, cmd1;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Warden"] != null)
        {
            Label1.Text = Session["Warden"].ToString();
        }
        else
        {
            Response.Redirect("userLogin.aspx");

            if (Page.IsPostBack == false)
            {
                getConnection();
                getData();
            }
        }
    }
    void getConnection()
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        con.Open();
    }

    void getData()
    {
        getConnection();
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from scholarshipApplication";

        dr = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(dr);
        if (dt.Rows.Count > 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        con.Close();
    }
   
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Accept")
        {
            getConnection();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into scholarshipStudents select Id,Name,Email,Address,Contact,Pname,Pcontact,College,Score,Income from scholarshipApplication where Id=" + e.CommandArgument;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Delete from scholarshipApplication where Id=" + e.CommandArgument;
            cmd.ExecuteNonQuery();

            Response.Redirect("scholarshipSelection.aspx");
        }

        else if (e.CommandName == "Decline")
        {
            getConnection();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from scholarshipApplication where Id=" + e.CommandArgument;
            cmd.ExecuteNonQuery();


            Response.Redirect("scholarshipSelection.aspx");
        }
    }

    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}