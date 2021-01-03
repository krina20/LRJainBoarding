using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;


public partial class scholarshipReportWeb : System.Web.UI.Page
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

            if (Request.QueryString["Name"] == null)
            {
                Response.Redirect("detailsForLetter.aspx");
            }
            else
            {
                Label1.Text = Request.QueryString["Name"];
                Label_name.Text = Label1.Text;
                Label_date.Text = DateTime.Now.ToShortDateString();

                //findCollegeName(Label_clg.Text);
                //findScore(Label_score.Text);
            }
        }
    }
    protected void Button_dwnld_Click(object sender, EventArgs e)
    {
        exportpdf();
    }
    private void exportpdf()
    {
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=scholarshipLetter.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter sw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        Panel1.RenderControl(hw);
        StringReader sr = new StringReader(sw.ToString());
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        htmlparser.Parse(sr);
        pdfDoc.Close();
        Response.Write(pdfDoc);
        Response.End();
    }

    //private void findCollegeName(String Name)
    //{
    //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");
    //    String myquery = "Select College from scholarshipStudents where Name='" + Name + "'";

    //    SqlCommand cmd = new SqlCommand();
    //    cmd.CommandText = myquery;
    //    cmd.Connection = con;
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    da.SelectCommand = cmd;
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);
    //    if (ds.Tables[0].Rows.Count > 0)
    //    {

    //        Label_clg.Text = ds.Tables[0].Rows[0]["College"].ToString();

    //    }

    //    con.Close();
    //}

    //private void findScore(String Name)
    //{
    //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\New folder\SCS\Sem6\SPD\LRJainBoarding\LRJainBoardingDB.mdf;Integrated Security=True;Connect Timeout=30");
    //    String myquery = "Select Score from scholarshipStudents where Name='" + Name + "'";

    //    SqlCommand cmd = new SqlCommand();
    //    cmd.CommandText = myquery;
    //    cmd.Connection = con;
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    da.SelectCommand = cmd;
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);
    //    if (ds.Tables[0].Rows.Count > 0)
    //    {

    //        Label_score.Text = ds.Tables[0].Rows[0]["Score"].ToString();

    //    }

    //    con.Close();
    //}
}