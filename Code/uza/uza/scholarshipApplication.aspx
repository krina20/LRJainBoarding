<%@ Page Language="C#" AutoEventWireup="true" CodeFile="scholarshipApplication.aspx.cs" Inherits="uza_uza_scholarshipApplication" %>

<!DOCTYPE html>

<head>
	<meta charset="UTF-8">
	<meta name="description" content="uza - Model Agency HTML5 Template">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

	<!-- Title -->
	<title> LR Jain Boarding </title>

	<script>
		function display(event) {
			var output = document.getElementById('Image1');
			output.src = URL.createObjectURL(event.target.files[0]);
		}

		function display1(event) {
			var output = document.getElementById('Image2');
			output.src = URL.createObjectURL(event.target.files[0]);
		}
	</script>

	<!-- Favicon -->
	<link rel="icon" href="./img/core-img/hostelLogo.png" />

	<!-- Core Stylesheet -->
	<link rel="stylesheet" href="style.css">

</head>

<body>
	<!-- Preloader -->
	<div id="Div1">
		<div class="wrapper">
			<div class="cssload-loader"></div>
		</div>
	</div>

	<!-- ***** Top Search Area Start ***** -->
	<div class="top-search-area">
		<!-- Search Modal -->
		<div class="modal fade" id="Div2" tabindex="-1" role="dialog" aria-hidden="true">
			<div class="modal-dialog modal-dialog-centered" role="document">
				<div class="modal-content">
					<div class="modal-body">
						<!-- Close Button -->
						<button type="button" class="btn close-btn" data-dismiss="modal"><i class="fa fa-times"></i></button>
						<!-- Form -->
						<form action="studentHome.aspx" method="post">
							<input type="search" name="top-search-bar" class="form-control" placeholder="Search and hit enter...">
							<button type="submit">Search</button>
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- ***** Top Search Area End ***** -->

	<!-- ***** Header Area Start ***** -->
	<header class="header-area">
		<!-- Main Header Start -->
		<div class="main-header-area">
			<div class="classy-nav-container breakpoint-off">
				<!-- Classy Menu -->
				<nav class="classy-navbar justify-content-between" id="Nav1">

					<!-- Logo -->
					<a class="nav-brand" href="studentHome.aspx"><img src="./img/core-img/hostelLogo.png" width="60px" height="70px" alt=""></a>

					<!-- Navbar Toggler -->
					<div class="classy-navbar-toggler">
						<span class="navbarToggler"><span></span><span></span><span></span></span>
					</div>

					<!-- Menu -->
					<div class="classy-menu">
						<!-- Menu Close Button -->
						<div class="classycloseIcon">
							<div class="cross-wrap"><span class="top"></span><span class="bottom"></span></div>
						</div>

						<!-- Nav Start -->
						<div class="classynav">
							<ul id="Ul1">
								<li><a href="studentHome.aspx"> Home </a></li>
								<li><a href="viewNotice.aspx"> View Notice </a></li>
								<li><a href="roomDetails.aspx"> Room Detail </a></li>
								<li><a href="scholarshipApplication.aspx"> Scholarship Application </a></li>
								<li><a href="gallery.aspx"> Gallery </a></li>
								<li><a href="updateDetails.aspx"> Profile </a></li>
								<li><a href="changePassword.aspx"> Change Password </a></li>
								<li><a href="sendComplaintRequest.aspx">Send Complain/Request</a></li>
								<li><a href="AcceptedRejectedCR.aspx">Previous Complaint/Request</a></li>
								<li><%--<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Log Out</asp:LinkButton>--%></li>                  
							</ul>

							
							<!-- Get A Quote -->
							<div class="get-a-quote ml-4 mr-3">
								<a href="#" class="btn uza-btn"> Student </a>
							</div> 
						</div>
						<!-- Nav End -->

					</div>
				</nav>
			</div>
		</div>
	</header>
	<!-- ***** Header Area End ***** -->

	<!-- ***** Breadcrumb Area Start ***** -->
	<div class="breadcrumb-area">
		<div class="container h-100">
			<div class="row h-100 align-items-end">
				<div class="col-12">
					<div class="breadcumb--con">
						<h2 class="title">Scholarship Application</h2>
						<nav aria-label="breadcrumb">
							<ol class="breadcrumb">
								<li class="breadcrumb-item"><a href="studentLogin.aspx"><i class="fa fa-home"></i>Login</a></li>
								<li class="breadcrumb-item"><a href="studentHome.aspx"><i class="fa fa-home"></i> Home</a></li>
								<li class="breadcrumb-item active" aria-current="page"> Scholarship Application </li>
							</ol>
						</nav>
					</div>
				</div>
			</div>
		</div>

		<!-- Background Curve -->
		<div class="breadcrumb-bg-curve">
			<img src="./img/core-img/curve-5.png" alt="">
		</div>
	</div>
	<!-- ***** Breadcrumb Area End ***** -->

	<!-- ***** Contact Area Start ***** -->
	<section class="uza-contact-area section-padding-80">
		<div class="container">
			<div class="row justify-content-between">
				<!-- Contact Form -->
			   <div class="col-12 col-lg-8">
					<div class="uza-contact-form mb-80">
						
						<form id="form1" runat="server">
						
							<div class="row">
								<div  class="form-group">
									<div class="col-form-label-lg">
										<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
									</div>
								</div>
							</div>

							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:TextBox ID="TextBox_name" runat="server" placeholder="Enter Name" class="form-control mb-30" AutoComplete="off" ></asp:TextBox>
										<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_name" CssClass="rfv" ErrorMessage="Enter Name first."></asp:RequiredFieldValidator>
									
									</div>
								</div>
							</div>
								
							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">    
										<asp:TextBox ID="TextBox_address" runat="server" placeholder="Enter Address" class="form-control mb-30" AutoComplete="off" ></asp:TextBox>
									</div>
								</div>
							</div>

							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:TextBox ID="TextBox_contact" runat="server" placeholder="Enter Contact" class="form-control mb-30" AutoComplete="off" ></asp:TextBox>
									<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox_contact" CssClass="rfv" ErrorMessage="Enter contact first."></asp:RequiredFieldValidator>
									
									</div>
								</div>
							</div>
								
							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:TextBox ID="TextBox_parentsName" runat="server" placeholder="Enter Parents' Name" class="form-control mb-30"></asp:TextBox>
									<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox_parentsName" CssClass="rfv" ErrorMessage="Enter parents name first."></asp:RequiredFieldValidator>
							
									</div>
								</div>
							  </div>
							
							<div class="row">  
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:TextBox ID="TextBox_parentsContact" runat="server" placeholder="Enter Parent's contact" class="form-control mb-30" AutoComplete="off"></asp:TextBox>
									<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox_parentsContact" CssClass="rfv" ErrorMessage="Enter parents contact number first."></asp:RequiredFieldValidator>
							
									</div>
								</div>
							</div>

							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:TextBox ID="TextBox_college" runat="server" placeholder="Enter college name" class="form-control mb-30" AutoComplete="off"></asp:TextBox>
									<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox_college" CssClass="rfv" ErrorMessage="Enter college name first."></asp:RequiredFieldValidator>
							
									</div>
								</div>
							</div>

							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:TextBox ID="TextBox_score" runat="server" placeholder="Enter score of last semester" class="form-control mb-30" AutoComplete="off" ></asp:TextBox>
									<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox_score" CssClass="rfv" ErrorMessage="Enter score first."></asp:RequiredFieldValidator>
							
									</div>
								</div>
							</div>

							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:TextBox ID="TextBox_income" runat="server" placeholder="Enter yearly total income" class="form-control mb-30" AutoComplete="off"></asp:TextBox>
									<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox_income" CssClass="rfv" ErrorMessage="Enter yearly income first."></asp:RequiredFieldValidator>
							
									</div>
								</div>
							</div>
								
							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<div class="col-form-label-lg">
										<asp:Label ID="Label2" runat="server" Text="Marksheet"></asp:Label>
									</div>
										<asp:FileUpload ID="FileUpload1" runat="server" onchange="display(event);"/>
									</div>
								</div>
							</div>
							
							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:Image ID="Image1" runat="server" width="100px" Height="100px"/>
										<br /><br />
									</div>
								</div>
							</div>

							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<div class="col-form-label-lg">
											<asp:Label ID="Label3" runat="server" Text="Income Document"></asp:Label>
										</div>
										<asp:FileUpload ID="FileUpload2" runat="server" onchange="display1(event);"/><br /><br />
									</div>
								</div>
							</div>

							<div class="row">
								<div  class="col-lg-6">
									<div class="form-group">
										<asp:Image ID="Image2" runat="server" width="100px" Height="100px"/>
									<br /><br />
								</div>
							</div>
							</div>

							
							
						
							<div class="col-12">
								<asp:Button ID="Button_apply" runat="server" Text="Apply" class="btn uza-btn btn-3 mt-15" OnClick="Button_apply_Click" />
							</div>
						</form>
					</div>
				</div>                                                                          

			</div>
		</div> 
	</section> 
	<!-- ***** Contact Area End ***** -->
   
	 <!-- ***** Footer Area Start ***** -->
	<footer class="footer-area section-padding-80-0">
		<div class="container">
			<div class="row justify-content-between">

				<!-- Single Footer Widget -->
				<div class="col-12 col-sm-6 col-lg-3">
					<div class="single-footer-widget mb-80">
						<!-- Widget Title -->
						<h4 class="widget-title" style="text-align:center">Contact Us</h4>

						<!-- Footer Content -->
						<div class="footer-content mb-15" style="text-align:center">
							<h6>Phone : 079-26858926</h6>
							<!--<p> LR Jain boarding, Nr Goyal InterCity 'C' block, Drive-In road <br> Thaltej, Ahmedabad-380054 </p>-->
						</div>
						<p class="mb-0" style="text-align:center">Mon to Sat : 10AM to 6PM <br>
							Closed on Sundays</p>
						<br />
						<!-- Social Info -->
						<div class="footer-social-info" style="text-align:center">
							<a href="https://www.facebook.com/pages/LRJain-Boarding/532109880214089?eid=ARA7Dl7CxvKLVQAUnYt0QyZztEAbBjadnsMX3eADGBEno49J5HZAdm3wWo8F3SEG2PLqAtFCAU6g60Fy&timeline_context_item_type=intro_card_work&timeline_context_item_source=1453848314&fref=tag" class="facebook" data-toggle="tooltip" data-placement="top" title="Facebook"><i class="fa fa-facebook"></i></a>
						</div>
					</div>
				</div>

				<!-- Single Footer Widget -->
				<div class="col-12 col-sm-6 col-lg-3">
					<div class="single-footer-widget mb-80">
						<!-- Widget Title -->
						<h4 class="widget-title" style="text-align:center">Location          </h4>
						<div class="footer-content mb-15">
							<a href="https://goo.gl/maps/u2W26o5t57MYkZuA7" style="text-align:center"> LR Jain Boarding, Near Goyal InterCity 'C' block, Drive-In road, <br> Thaltej, Ahmedabad-380054 </a>
						
						</div>
							<!-- Nav -->
						<nav>
							<ul class="our-link">
							</ul>
						</nav>
					</div>
				</div>


				<!-- Single Footer Widget -->
				<div class="col-12 col-sm-6 col-lg-3">
					<div class="single-footer-widget mb-80">
						<!-- Widget Title -->
						<h4 class="widget-title" style="text-align:center">About Us</h4>
						<p style="text-align:center">LR Jain Boarding is a private hostel for full-time undergraduate and post graduate boys of Univerties and Colleges in Ahmedabad and Gandhinagar.</p>


					</div>
				</div>

			</div>

 <div class="row" style="margin-bottom: 30px;">
				
<!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved to Shaily, Krina & Nidhi |
			</div>
			
		</div>
		</footer>
	<!-- ***** Footer Area End ***** -->

	<!-- ******* All JS Files ******* -->
	<!-- jQuery js -->
	<script src="js/jquery.min.js"></script>
	<!-- Popper js -->
	<script src="js/popper.min.js"></script>
	<!-- Bootstrap js -->
	<script src="js/bootstrap.min.js"></script>
	<!-- All js -->
	<script src="js/uza.bundle.js"></script>
	<!-- Active js -->
	<script src="js/default-assets/active.js"></script>

</body>

</html>

