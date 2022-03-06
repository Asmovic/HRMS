<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="StaffMaster.aspx.cs" Inherits="hrpages_StaffMaster" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     


    <h3><%:Page.Title %></h3>
    

                      
     
  <script src="../Scripts/jquery-ui-1.12.1.js"></script>
<script type="text/javascript">
        $(document).ready(function () {
            $("[id$=dfa]").datepicker(
                  {
                      dateFormat: 'dd-mm-yy'
                  });
              $("[id$=dob]").datepicker(
              {
                  dateFormat: 'dd/mm/yy'
              });


          });
      </script>

    <%-- <script src="../Scripts/jquery-ui-1.12.4.js"></script>
     <link rel="stylesheet" href="jquery-ui.css">
    <script src="jquery-ui.js"></script>--%>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#dfa").datepicker(
                      {
                          appendText: 'mm/dd/yyyy',
                          showOn: 'both',
                          buttonText: 'Calendar',
                          dateFormat: 'dd/mm/yy',
                          numberOfMonths: 2,
                          changeMonth: true,
                          changeYear: true,
                          minDate: new Date(2000, 1, 1),
                          maxDate: new Date(2017, 12, 31),

                      });
        });
   </script>
    <br />
          
    <div>
        
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        
        </div>
      <div style="text-align:center; color:hotpink"> <h2><b>STAFF REGISTRATION</b></h2></div> 
   
                         <%--  <asp:UpdatePanel runat="server">
                    <ContentTemplate>--%>
     <div class="row" style="background-image:url(/img/co.jpg) ">
  

        <div class="col-xs-8">
                           
              
    <div>
		   
		<ul class="nav nav-tabs">
		<li class="active"><a href="#home" data-toggle="tab">Personal Information</a></li>
		<li><a href="#men1" data-toggle="tab">Company Information </a></li>
		</ul>
		
		<div class="tab-content">  
		<div id="home" class="tab-pane fade in active">
	
                                <%--           <asp:UpdatePanel runat="server">
                    <ContentTemplate>--%>
            <div class="col-md-offset-4 col-md-8">
               
                    
            <asp:CheckBox ID="Chk1" runat="server" Text=" NEW" TextAlign="Left" AutoPostBack="true" OnCheckedChanged="Chk1_CheckedChanged" />
               
       
            <asp:CheckBox ID="Chk2" runat="server" Text=" EXISTING" TextAlign="Left" AutoPostBack="true" OnCheckedChanged="Chk2_CheckedChanged" />
            

        </div>
          <%-- </ContentTemplate></asp:UpdatePanel>  --%>
     
                    
		 <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Staff Id</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="stid" Enabled="false" AutoPostBack ="true" OnTextChanged="stid_TextChanged" ></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="stid" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
                         
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Surname</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="surn" MaxLength="15" OnTextChanged="surn_TextChanged"></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="surn" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">First Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="fn" MaxLength="15" OnTextChanged="fn_TextChanged"></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="fn" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Last Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="ln" MaxLength="15" OnTextChanged="ln_TextChanged"></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ln" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Gender</asp:Label>
            <div class="col-md-8">
                 <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                <asp:RadioButton runat ="server"  ID="txtmale" Text="Male" AutoPostBack="true" OnCheckedChanged="txtmale_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server"  ID="txtfemale" Text="Female" AutoPostBack="true" OnCheckedChanged="txtfemale_CheckedChanged"></asp:RadioButton>  
                  </ContentTemplate>
                    </asp:UpdatePanel>  
            </div>
             </div>

      <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Marital Status</asp:Label>
            <div class="col-md-8">
                
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                <asp:RadioButton runat ="server"  ID="txtmar1" Text="Single" AutoPostBack="true" OnCheckedChanged="txtmar1_CheckedChanged"></asp:RadioButton> 
                <asp:RadioButton runat ="server" ID="txtmar2" Text="Married" AutoPostBack="true" OnCheckedChanged="txtmar2_CheckedChanged"></asp:RadioButton> 
                <asp:RadioButton runat ="server" ID="txtmar3" Text="Divorce" AutoPostBack="true" OnCheckedChanged="txtmar3_CheckedChanged"></asp:RadioButton>    
                        </ContentTemplate>
                    </asp:UpdatePanel>
            </div>
             </div>
                                      
     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Date of Birth </asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" onselect ="dob()" placeholder="select date"  ID="dob" OnTextChanged="dob_TextChanged"></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="dob" CssClass="text-danger" ErrorMessage="This field is required." />
             </div>
         </div>
           
            <asp:UpdatePanel runat="server">
                <ContentTemplate>

            
     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">State of Origin</asp:Label>
            <div class="col-md-8">
               
                <asp:DropDownList runat ="server" CssClass="form-control" ID="soo"  AutoPostBack ="true" OnSelectedIndexChanged="soo_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="soo" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

               

     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Local Government of Origin</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="lgo"   OnSelectedIndexChanged="lgo_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="lgo" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
                  </ContentTemplate>
            </asp:UpdatePanel>     

           

     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">HomeAddress</asp:Label>
            <div class="col-md-8">
                <asp:textbox  runat ="server" TextMode="MultiLine"   CssClass="form-control" ID="stadd" OnTextChanged="stadd_TextChanged"></asp:textbox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="stadd" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Telephone</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="tell"></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tell" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Email</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="email" OnTextChanged="email_TextChanged"></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="email" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
                <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Tribe</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="tribe" OnSelectedIndexChanged="tribe_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tribe" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    

  

    <div class="container" style="clear:both">

<button type="button" class="btn btn-success btn-lg" data-toggle="modal" data-target="#myModal">Next of Kin</button>

<div class="modal fade" id="myModal" role="dialog">
<div class="modal-dialog">
<div class="modal-content">
<div class="modal-header">
<button type="button" class="close" data-dismiss="modal">&times;</button>
<h4 class="modal-title">Next of Kin Information</h4></div>
<div class="modal-body">
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Next of Kin</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="nokn" ></asp:TextBox>
                </div>
                <asp:Label runat="server" CssClass="col-md-4 control-label">Relationship</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="nokrel" ></asp:TextBox>
                </div>
                <asp:Label runat="server" CssClass="col-md-4 control-label">Home Address</asp:Label>
            <div class="col-md-8">
                <asp:textbox TextMode="MultiLine" runat ="server"  CssClass="form-control" ID="nokadd" ></asp:textbox>
               </div>
                 <asp:Label runat="server" CssClass="col-md-4 control-label">Email</asp:Label>
            <div class="col-md-8">
                
                <asp:TextBox runat ="server" CssClass="form-control" ID="nokemail"></asp:TextBox>
                </div>
                <asp:Label runat="server" CssClass="col-md-4 control-label">Telephone</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="noktell"></asp:TextBox>
               
            </div>
             </div>
</div>
<div class="modal-footer">
<button type="button" class="btn btn-primary" data-dismiss="modal">OK</button>
</div></div></div></div></div>

</div>

            <br />
            <br />
   

    
		
		<div ID="men1" class="tab-pane fade">
		
		  <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Date of First Appointment</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" placeholder="select date" OnTextChanged="dfa_TextChanged" ID="dfa" ></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="dfa" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
            
           


            <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Location of First Appointment</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="lfa"  OnSelectedIndexChanged="lfa_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="lfa" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
             <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Department of First Appointment</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="depfa"  OnSelectedIndexChanged="depfa_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="depfa" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

             <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Present Location</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="loc"  OnSelectedIndexChanged="loc_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="loc" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
           
             <asp:UpdatePanel runat="server">
                <ContentTemplate>


                <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Department</asp:Label>
            <div class="col-md-8" >
                
                <asp:DropDownList runat="server"  CssClass="form-control" ID="dept" AutoPostBack="true" OnSelectedIndexChanged="dept_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="dept" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Section</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="sect"  OnSelectedIndexChanged="sect_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="sect" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

                    </ContentTemplate>
                 </asp:UpdatePanel>
               <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Designation</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="desig" OnSelectedIndexChanged="desig_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="desig" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
               <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Grade Level of First Appointment</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="glfa"  OnSelectedIndexChanged="glfa_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="glfa" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    
               <div class="form-group">
           <asp:Label runat="server" CssClass="col-md-4 control-label">Present Grade Level</asp:Label>
            <div class="col-md-8">
               
                <asp:DropDownList runat ="server" CssClass="form-control" ID="pgl" OnSelectedIndexChanged="pgl_SelectedIndexChanged" ></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="pgl" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

                 <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Highest Qualification</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="highq" OnSelectedIndexChanged="highq_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="highq" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

               <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Year Obtained</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="yob" MaxLength="4"></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="yob" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

                <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">PFA Code</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="pfac"  OnSelectedIndexChanged="pfac_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="pfac" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

              <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">PFA No</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat ="server" CssClass="form-control" ID="pfan" MaxLength="20"></asp:TextBox>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="pfan" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


            <div class="form-group">
            <div class="col-md-offset-4 col-md-8">
                <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />
                <asp:Button ID="deleteButton" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />
            </div>
                 </div>

            </div>
            </div>
             </div>
                      
            </div>
        
         <div class="col-xs-4">
                     <br />
                     <br />
                     <br />
                    <asp:Image ID="Image1" CssClass="thumbnail" runat="server" height="150px" Width="150px"/>
                    <asp:fileupload ID="fileupload" runat="server">
                    </asp:fileupload>
                    <asp:Button ID="preview" runat="server" OnClick="preview_Click" Text="Preview" />
                </div>
        
    
      
                        
         
    </div>
            
       <%--     </ContentTemplate></asp:UpdatePanel>--%>

  


           
		
            
                 
                      
   <%-- 
    <script>
        $('#dfa').datepicker();
    </script>
        --%>
    <%-- end of container --%>
    
     
</asp:Content>

