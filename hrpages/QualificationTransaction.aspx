<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="QualificationTransaction.aspx.cs" Inherits="hrpages_QualificationTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    
      <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Qualification Transaction Setup</h4>

     <div class="row">
        <div class="col-sm-6">

     <div class="form-group">
         
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Staff Id</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtstid" runat="server" CssClass="form-control" MaxLength="15" AutoPostBack="true" OnTextChanged="txtstid_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstid" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
  
        
       <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Staff Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtname" runat="server" CssClass="form-control" MaxLength="15" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Qualification</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbqname" runat="server" CssClass="form-control" AutoPostBack="true"  OnSelectedIndexChanged="cmbqname_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbqname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

          <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Field Of Study</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbfs" runat="server" CssClass="form-control"  OnSelectedIndexChanged="cmbfs_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbfs" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Institution Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtins" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtins" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


      <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Year Obtained</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtyob" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtyob" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

      <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Qualification Type</asp:Label>
            <div class="col-md-8">
                <asp:RadioButton runat ="server" Enabled="false"  ID="txta" Text="Academic" AutoPostBack="true" OnCheckedChanged="txta_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server" Enabled="false"  ID="txtp" Text="Professional" AutoPostBack="true" OnCheckedChanged="txtp_CheckedChanged"></asp:RadioButton>    
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Date Applied</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtapply" runat="server" OnTextChanged="txtapply_TextChanged" CssClass="form-control" MaxLength="15" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtapply" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    
          <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Qualification Class</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbqc" runat="server" CssClass="form-control"  OnSelectedIndexChanged="cmbqc_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbqc" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    
    

    <div class="form-group">
            <div class="col-md-offset-4 col-md-8">
                <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />
                <asp:Button ID="deleteButton" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />
            </div>
                 </div>

             </div>
            <div class="col-sm-6">
               

             <asp:Image ID="Image1" CssClass="img-thumbnail" runat="server" height="150px" Width="150px"/>
                   
            </div>
           </div>



      <script src="../Scripts/jquery-ui-1.12.1.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $("[id$=txtapply]").datepicker(
              {
                  dateFormat: 'dd-mm-yy'
              });
     


    });
      </script>
</asp:Content>

