using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_addStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Warden"] != null)
        {
            Label4.Text = Session["Warden"].ToString();
        }
        else
        {
            Response.Redirect("userLogin.aspx");
        }
    }
    protected void Button_add_Click(object sender, EventArgs e)
    {
        string name = TextBox_name.Text.Trim();
        string email = TextBox_email.Text.Trim();
        string contact = TextBox_contact.Text.Trim();
        string gender = string.Empty;
        string password = TextBox_password.Text.Trim();
        string address = TextBox_address.Text.Trim();
        string city = TextBox_city.Text.Trim();
        string stream = string.Empty;
        string filename = Path.GetFileName(FileUpload_marksheet.FileName);
        string percentage = TextBox_percentage.Text.Trim();
        string collegeYear = TextBox_year.Text.Trim();
        string roomno = DropDownList1.SelectedValue;
        Label2.Text = DateTime.Now.ToShortDateString();
        Label3.Text = DateTime.Now.AddYears(4).ToShortDateString();

        if (TextBox_password.Text == TextBox_confpassword.Text)
        {
            if (RadioButton_science.Checked)
            {
                stream = "Science";
            }
            else if (RadioButton_commerce.Checked)
            {
                stream = "Commerce";
            }
 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand cmd = new SqlCommand("insert into StudentReg(Name,Email,Contact,Password,Address,City,Stream,Marksheet,Percentage,CollegeYear,RoomNo,startDate,endDate) values (@Name,@Email,@Contact,@Password,@Address,@City,@Stream,@Marksheet,@Percentage,@CollegeYear,@RoomNo,@startDate,@endDate)");

            cmd.Connection = con;

            FileUpload_marksheet.SaveAs(Server.MapPath("~/Marksheets/" + filename));

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Contact", contact);
            cmd.Parameters.AddWithValue("@Password", password.Trim());
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Stream", stream);
            cmd.Parameters.AddWithValue("@Marksheet", "Marksheets/" + filename);
            cmd.Parameters.AddWithValue("@Percentage", percentage);
            cmd.Parameters.AddWithValue("@CollegeYear", collegeYear);
            cmd.Parameters.AddWithValue("@RoomNo", roomno);
            cmd.Parameters.AddWithValue("@startDate",Label2.Text.Trim());
            cmd.Parameters.AddWithValue("@endDate", Label3.Text.Trim());

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            TextBox_name.Text = "";
            TextBox_email.Text = "";
            TextBox_contact.Text = "";
            TextBox_password.Text = "";
            TextBox_confpassword.Text = "";
            TextBox_address.Text = "";
            TextBox_city.Text = "";
            RadioButton_science.Checked = false;
            RadioButton_commerce.Checked = false;
            TextBox_year.Text = "";
            
            Response.Write("<script language='javascript'>window.alert('New Student added!');window.location='wardenHome.aspx';</script>");

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Passwords do not match');", true);
        }
    
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}