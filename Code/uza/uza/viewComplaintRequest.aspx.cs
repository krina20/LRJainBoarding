using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_viewComplaintRequest : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;
    DataTable dt;
    SqlDataAdapter adp;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Warden"] != null)
        {
            Label2.Text = Session["Warden"].ToString();
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
        cmd.CommandText = "select * from ComplaintRequest where status IS NULL";

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
            cmd.CommandText = "Update ComplaintRequest set Status='1' where Id=" + e.CommandArgument;
            cmd.ExecuteNonQuery();

            Response.Redirect("viewComplaintRequest.aspx");
        }

        else if (e.CommandName == "Decline")
        {
            getConnection();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update ComplaintRequest set Status='0' where Id=" + e.CommandArgument;
            cmd.ExecuteNonQuery();

            Response.Redirect("viewComplaintRequest.aspx");

        }
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}