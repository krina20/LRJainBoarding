using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uza_uza_wardenHome : System.Web.UI.Page
{
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
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}