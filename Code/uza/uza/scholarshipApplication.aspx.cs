using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_scholarshipApplication : System.Web.UI.Page
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
    }
    protected void Button_apply_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");

        string name = TextBox_name.Text.Trim();
        Label1.Text = Session["Email"].ToString();
        string address = TextBox_address.Text.Trim();
        string contact = TextBox_contact.Text.Trim();
        string parent = TextBox_parentsName.Text.Trim();
        string parent_contact = TextBox_parentsContact.Text.Trim();
        string college = TextBox_college.Text.Trim();
        string marksheet = Path.GetFileName(FileUpload1.FileName);
        string score = TextBox_score.Text.Trim();
        string income_photo = Path.GetFileName(FileUpload2.FileName);
        string income = TextBox_income.Text.Trim();

        SqlCommand cmd = new SqlCommand("insert into scholarshipApplication(Name,email,Address,Contact,Pname,Pcontact,College,Score,Income,Marksheet,IncomeDoc) values (@Name,@email,@Address,@Contact,@Pname,@Pcontact,@College,@Score,@Income,@Marksheet,@IncomeDoc)");

        cmd.Connection = con;

        FileUpload1.SaveAs(Server.MapPath("~/ScholarshipDoc/Marksheet/" + marksheet));
        FileUpload2.SaveAs(Server.MapPath("~/ScholarshipDoc/IncomeDoc/" + income_photo));

        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@email", Label1.Text);
        cmd.Parameters.AddWithValue("@Address", address);
        cmd.Parameters.AddWithValue("@Contact", contact);
        cmd.Parameters.AddWithValue("@Pname", parent);
        cmd.Parameters.AddWithValue("@Pcontact", parent_contact);
        cmd.Parameters.AddWithValue("@College", college);
        cmd.Parameters.AddWithValue("@Marksheet", "ScholarshipDoc/Marksheets/" + marksheet);
        cmd.Parameters.AddWithValue("@IncomeDoc", "ScholarshipDoc/IncomeDoc/" + income_photo);
        cmd.Parameters.AddWithValue("@Score", score);
        cmd.Parameters.AddWithValue("@Income", income);


        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox_name.Text = "";
        //TextBox_email.Text = "";
        TextBox_contact.Text = "";
        TextBox_parentsName.Text = "";
        TextBox_parentsContact.Text = "";
        TextBox_address.Text = "";
        TextBox_college.Text = "";
        TextBox_score.Text = "";

        Response.Write("<script language='javascript'>window.alert('Thank you applying for scholarship!');window.location='studentHome.aspx';</script>");
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("studentLogin.aspx");
    //}
}