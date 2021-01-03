using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_scss_roomDetails : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd, cmd1,cmd2;
    //SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Email"] == null)
        {
            Response.Redirect("studentLogin.aspx");
        }
        else
        {
            Label3.Text = Session["Email"].ToString();
            getData();
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
        cmd.CommandText = "select r.roomNo  from roomDetails r , StudentReg s where r.roomNo = s.RoomNo and s.Email='" + Label3.Text + "'";
        Label1.Text = cmd.ExecuteScalar().ToString();

        cmd1 = new SqlCommand();
        cmd1.Connection = con;
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select r.floorNo  from roomDetails r , StudentReg s where r.roomNo = s.RoomNo and s.Email='" + Label3.Text + "'";
        Label2.Text = cmd1.ExecuteScalar().ToString();
      

        //cmd2 = new SqlCommand();
        //cmd2.Connection = con;
        //cmd2.CommandType = CommandType.Text;
        //cmd2.CommandText = "select s.Name from roomDetails r , StudentReg s where r.roomNo = s.RoomNo";
        //Label4.Text = cmd2.ExecuteScalar().ToString();
        con.Close();
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("studentLogin.aspx");
    //}
}