using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_AcceptedRejectedCR : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd,cmd1;
    SqlDataReader dr,dr1;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Email"] == null)
        {
            Response.Redirect("studentLogin.aspx");
        }
        else
        {
            Label1.Text = Session["Email"].ToString();

            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select CR_details as 'Accepted Complaints and Requests',date as 'Date' from ComplaintRequest where Status=1 and studentEmail= '" + Label1.Text + "';";
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

            con.Close();

            //con.Open();
            //cmd1 = new SqlCommand();
            //cmd1.Connection = con;
            //cmd1.CommandType = CommandType.Text;
            //cmd1.CommandText = "select CR_details as 'Pending Complaints and Requests' from ComplaintRequest where status IS NULL and studentEmail= '" + Label1.Text + "';";
            //dr1 = cmd1.ExecuteReader();
            //DataTable dt1 = new DataTable();
            //dt1.Load(dr1);
            //if (dt1.Rows.Count > 0)
            //{
            //    GridView2.DataSource = dt1;
            //    GridView2.DataBind();
            //}

            //con.Close();
        }
        
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("studentLogin.aspx");
    //}
}