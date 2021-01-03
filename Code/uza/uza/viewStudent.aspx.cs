using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_viewStudent : System.Web.UI.Page
{
    StringBuilder table = new StringBuilder();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Warden"] != null)
        {
            Label1.Text = Session["Warden"].ToString();
        }
        else
        {
            Response.Redirect("userLogin.aspx");
        }
    }
    protected void Button_viewAll_Click(object sender, EventArgs e)
    {
        //string mainconn = DBConnection.DBPath(Server.MapPath("~"));
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");
        con.Open();

        SqlCommand cmd = new SqlCommand("select Name,Email,Contact,Address,City,Stream,Percentage,CollegeYear,RoomNo,startDate,endDate from StudentReg");
        cmd.Connection = con;
        SqlDataReader sdr = cmd.ExecuteReader();
        table.Append("<table border=1>");
        table.Append("<tr><th>Name</th><th>Email</th><th>Contact</th><th>Address</th><th>City</th><th>Stream</th><th>BoardPercentage</th><th>Year</th><th>RoomNumber</th><th>JoinDate</th><th>EndDate</th>");
        table.Append("</tr>");

        if (sdr.HasRows)
        {
            while (sdr.Read())
            {
                table.Append("<tr>");
                table.Append("<td>" + sdr[0] + "</td>"); //name
                table.Append("<td>" + sdr[1] + "</td>"); //email
                table.Append("<td>" + sdr[2] + "</td>"); //contact
                table.Append("<td>" + sdr[3] + "</td>"); //address
                table.Append("<td>" + sdr[4] + "</td>"); //city
                table.Append("<td>" + sdr[5] + "</td>"); //stream
                table.Append("<td>" + sdr[6] + "</td>"); //percentage
                table.Append("<td>" + sdr[7] + "</td>");//year
                table.Append("<td>" + sdr[8] + "</td>");//room
                table.Append("<td>" + sdr[9] + "</td>");//startDate
                table.Append("<td>" + sdr[10] + "</td>");//endDate
                table.Append("</tr>");
            }
        }
        table.Append("</table>");
        PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
        sdr.Close();
        sdr.Dispose();
        con.Close();
    }
    protected void Button_viewRoomWise_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewRoomWise.aspx");
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}