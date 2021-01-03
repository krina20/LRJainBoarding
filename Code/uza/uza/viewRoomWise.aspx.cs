using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_viewRoomWise : System.Web.UI.Page
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string roomno = TextBox1.Text.Trim();

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");
        con.Open();

        SqlCommand cmd = new SqlCommand("select Name,Contact,City,CollegeYear from StudentReg where RoomNo=" + roomno + " group by RoomNo,Name,Contact,City,CollegeYear;");
        cmd.Connection = con;
        SqlDataReader sdr = cmd.ExecuteReader();
        table.Append("<table border=1>");
        table.Append("<tr><th>Names</th><th>Contact</th><th>City</th><th>CollegeYear</th><tr>");
        table.Append("</tr>");

        if (sdr.HasRows)
        {
            while (sdr.Read())
            {
                table.Append("<tr>");
                table.Append("<td>" + sdr[0] + "</td>"); //name
                table.Append("<td>" + sdr[1] + "</td>"); //contact
                table.Append("<td>" + sdr[2] + "</td>"); //city
                table.Append("<td>" + sdr[3] + "</td>"); //year
                table.Append("</tr>");
            }
        }
        table.Append("</table>");
        PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
        sdr.Close();
        sdr.Dispose();

    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}