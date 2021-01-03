using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Data;
using System.Data.SqlClient;
public partial class uza_chart : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter adp;
    DataSet ds;
    void getConnection()
    {
        con = new SqlConnection();

        con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30";
        con.Open();
    }
    public void GetData()
    {
        // String a = TextBox1.Text;
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select RoomNo,count(RoomNo) from StudentReg group by RoomNo";
        cmd.CommandType = CommandType.Text;
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet("ds_roomChart");
        adp.Fill(ds, "StudentReg");
    }

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
    protected void Button1_Click(object sender, EventArgs e)
    {
        getConnection();
        GetData();
        //ds.WriteXml(Server.MapPath("~") + "\\App_Code\\roomChart.xml");
        //ds.WriteXmlSchema(Server.MapPath("~") + "\\App_Code\\roomChart.xsd");
        ReportViewer1.SizeToReportContent = true;
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/uza/uza/roomChart.rdlc");
        ReportViewer1.LocalReport.DataSources.Clear();
        DataTable dt = ds.Tables[0];
        ReportDataSource rsource = new ReportDataSource("ds_roomChart", dt);
        ReportViewer1.LocalReport.DataSources.Add(rsource);
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    Session.RemoveAll();
    //    Session.Abandon();

    //    Response.Redirect("userLogin.aspx");
    //}
}