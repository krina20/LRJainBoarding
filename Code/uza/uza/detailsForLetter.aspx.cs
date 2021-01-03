using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class detailsForLetter : System.Web.UI.Page
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
    protected void Button_get_Click(object sender, EventArgs e)
    {
        Response.Redirect("scholarshipReportWeb.aspx?Name="+ TextBox_name.Text);
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}