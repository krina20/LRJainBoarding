<%@ Page Language="C#" AutoEventWireup="true" CodeFile="scholarshipReportWeb.aspx.cs" Inherits="scholarshipReportWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 345px;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style7 {
            height: 170px;
        }
        .auto-style8 {
            width: 174px;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            text-align: center;
        }
        </style>
</head>
<body style="height: 408px">
        <form id="form1" runat="server">
            Name: <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
            <asp:Button ID="Button_dwnld" runat="server" Text="Download Letter" OnClick="Button_dwnld_Click" />
            <br />
            <br />
            <br />
            <br />
        <div>
        
            <asp:Panel ID="Panel1" runat="server" Height="389px">
            
                <table class="auto-style1" style="border-style:outset">
                <tr>
                    <td style="font-family:Eras Demi ITC;color:#000000;font-size:14pt;font-weight:700;font-style:normal;text-decoration:none;">L.R. JAIN BOARDING</td>
                    <td style="text-align: right" class="auto-style7">
                        <%--<asp:Image ID="Image1" runat="server" Height="22px" ImageUrl="~/WebImages/phone-outline.png" Width="22px"/> &nbsp;&nbsp;--%>
                            <span style="font-family:Eras Demi ITC;color:#000000;font-size:13pt;font-weight:400;font-style:normal;text-decoration:none;">P: 079-26858926</span><p class="auto-style3" style="padding: 0pt; TextIndent: 0pt;"> 
                        <%--<asp:Image ID="Image2" runat="server" Height="22px" ImageUrl="~/WebImages/img_459181.png" Width="22px"/>--%>&nbsp;&nbsp;
                        <span style="font-family: Eras Demi ITC; color: #000000; font-size: 13pt; font-weight: 400; font-style: normal; text-decoration: none; text-align: right;">lrjainhostel@gmail.com</span></p>&nbsp;&nbsp;&nbsp; &nbsp;
                       
                            <span style="font-family:Eras Demi ITC;color:#000000;font-size:13pt;font-weight:400;font-style:normal;text-decoration:none;">L.R. Jain Boarding,
                      <br />Drive-In Road,Thaltej,<br /> Ahmedabad, 380054</span>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="font-family: Baskerville Old Face; color: #000000; font-size: 13pt; font-weight: 700; font-style: normal; text-decoration: underline; " class="auto-style3">
                        <div class="auto-style9">
                            Date: <asp:Label ID="Label_date" runat="server" Text=""></asp:Label><br />
                            <br />
                            <br />

                        </div>
                            </td>
                    </tr>
                <tr>
                    <td colspan="2" style="font-family: Baskerville Old Face; color: #000000; font-size: 13pt; font-weight: 700; font-style: normal; text-decoration: underline; text-align:center " class="auto-style3" >
                        <div class="auto-style10">
                            TO WHOM IT MAY CONCERN<br />
                            <br />
                            <br />

                        </div>
                            </td>
                    </tr>
                <tr>
                    <td colspan="2">
                            <span style="font-family:Arial;color:#000000;font-size:13pt;font-weight:400;font-style:normal;text-decoration:none;">This is to certify that Mr.<asp:Label ID="Label_name" runat="server" Text=""></asp:Label>&nbsp;got excellent marks&nbsp;in his last semeseter and has been qualified our Scholarship program. He is initiative, creative and curious to learn new things.</span>
                        <p style="padding: 0pt; TextIndent:0pt;" class="auto-style9">
                            
                            <span style="font-family:Arial;color:#000000;font-size:13pt;font-weight:400;font-style:normal;text-decoration:none;">His ambition to succeed against all odd holds him in good stead in future. We wish him all the best for all his future endevors.</span></p>
                            <p class="auto-style9" style="padding: 0pt; TextIndent:0pt;">
                                &nbsp;</p>
                    </td>
                </tr>
                <tr>
                    <td style="font-family:Eras Demi ITC;color:#000000;font-size:13pt;font-weight:400;font-style:normal;text-decoration:none;" class="auto-style8">Regrads,<br/>Raju Shah,<br />Director.</td>
                    <td style="font-family: Eras Demi ITC; color: #000000; font-size: 13pt; font-weight: 400; font-style: normal; text-decoration: none; text-align:right;" class="auto-style3"> www.lrjainboarding.com</td>
                </tr>
            </table>

        </asp:Panel>
   </div>
    </form>
</body>
</html>
