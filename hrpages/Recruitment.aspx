<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Recruitment.aspx.cs" Inherits="hrpages_Recruitment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    	

      <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h3>Recruitment</h3>
   
     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Surname</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtsurname" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtsurname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">First Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtfname" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtfname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Other Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtoname" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtoname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Date Of Birth</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtdob" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdob" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Gender</asp:Label>
            <div class="col-md-8">
                <asp:RadioButton runat ="server"  ID="txtmale" Text="Male" AutoPostBack="true" OnCheckedChanged="txtmale_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server"  ID="txtfemale" Text="Female" AutoPostBack="true" OnCheckedChanged="txtfemale_CheckedChanged"></asp:RadioButton>    
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Academic Qualification</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbaq"  OnSelectedIndexChanged="cmbaq_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Field Of Study</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbfs"  OnSelectedIndexChanged="cmbfs_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Class Honour</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbch"  OnSelectedIndexChanged="cmbch_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
             </div>

    
     
        
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Qualification Year</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtqy" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtqy" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Other Academic Qualification</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbaq2"  OnSelectedIndexChanged="cmbaq2_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Field Of Study</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbfs2"  OnSelectedIndexChanged="cmbfs2_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Class Honour</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbch2"  OnSelectedIndexChanged="cmbch2_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
             </div>

    
     
        
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Qualification Year</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtqy2" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtqy2" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
       
          <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Professional Certificate</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbpc"  OnSelectedIndexChanged="cmbpc_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
             </div>    
     
        
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Year Of certification</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtyoc" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtyoc" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Institute Of certificate</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtinsoc" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtinsoc" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

  <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Other Professional Certificate</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbpc2"  OnSelectedIndexChanged="cmbpc2_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
             </div>    
     
        
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Year Of certification</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtyoc2" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtyoc2" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Institute Of certificate</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtinsoc2" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtinsoc2" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Email:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtemail" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtemail" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Telephone No:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txttell" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txttell" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
       
     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Position Appointed For</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbposition"  OnSelectedIndexChanged="cmbposition_SelectedIndexChanged"></asp:DropDownList>
                  <br />
            </div>
             </div>

         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Department Appointed To</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbdept"  OnSelectedIndexChanged="cmbdept_SelectedIndexChanged"></asp:DropDownList>
                  <br />
            </div>
             </div>
    
    <div class="form-group">
            <div class="col-md-offset-4 col-md-8">
                <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />
                <asp:Button ID="deleteButton" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />
            </div>
        </div>

                      <style>

                          table,th,td { width:40%; 
                border-collapse:collapse;
                border:3px solid black;

        }
         tr:nth-child(even) {
             background-color: white;
         }
         tr:nth-child(odd) {
             background-color: aliceblue;
         }

        
        
        th {
            background-color:#05c4ad;
            color:white;
            border-color:black;
        }

           td,th {
             text-align:center;
             padding:2px;
         }
         tr:hover{
             color:hotpink;
         }
                    </style>

    
             <script src="../Scripts/jquery-ui-1.12.1.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $("[id$=txtdob]").datepicker(
            {
                dateFormat: 'dd-mm-yy'
            });




    });
</script>

</asp:Content>

