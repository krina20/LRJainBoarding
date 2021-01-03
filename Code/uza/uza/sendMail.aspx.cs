using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_sendMail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
        {
            Response.Redirect("userLogin.aspx");
        }
        else
        {
            Label4.Text = Session["Admin"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in GridView1.Rows)
        {
            CheckBox status = (row.Cells[2].FindControl("CheckBox1") as CheckBox);
            String emailadd = row.Cells[1].Text;
            if (status.Checked)
            {
                sendcustomermail(emailadd);
            }

        }
    }

    private void sendcustomermail(String emailadd1)
    {
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("krinashah.1203@gmail.com", "Krina123123");
        smtp.EnableSsl = true;
        MailMessage msg = new MailMessage();
        msg.Subject = TextBox_subject.Text;
        msg.Body = TextBox_message.Text + "\n\n\nThanks & Regards.\nL.R. Jain Boarding,\nRaju Shah\nDirector.";
        string toaddress = emailadd1;
        msg.To.Add(toaddress);
        string fromaddress = "L.R. Jain Boarding <krinashah.1203@gmail.com>";
        msg.From = new MailAddress(fromaddress);
        try
        {
            smtp.Send(msg);
        }
        catch
        {
            throw;
        }
        Response.Write("<script language='javascript'>window.alert('Email has been sent');window.location='adminHome.aspx';</script>");
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}