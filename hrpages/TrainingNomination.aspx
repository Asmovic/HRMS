<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="TrainingNomination.aspx.cs" Inherits="hrpages_TrainingNomination" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    	 <asp:UpdatePanel runat="server">
                 <ContentTemplate>
      <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Training Nomination Setup</h4>
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
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Original Location</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtoloc" runat="server" CssClass="form-control" OnTextChanged="txtoloc_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtoloc" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
     
        
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Original Department</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtodept" runat="server" CssClass="form-control" OnTextChanged="txtodept_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtodept" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

  <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Original Section</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtosec" runat="server" CssClass="form-control" OnTextChanged="txtosec_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtosec" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
        
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Training Name</asp:Label>
            <div class="col-md-8">
               <asp:DropDownList  ID="cmbname" runat="server" CssClass="form-control" OnSelectedIndexChanged="cmbname_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Training Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="traindate" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="traindate" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Training Duration</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="traindur" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="traindur" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Organisation Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="orgname" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="orgname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Organisation Address</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="orgadd" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="orgadd" CssClass="text-danger" ErrorMessage="This field is required." />
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
</ContentTemplate>
             </asp:UpdatePanel>
</asp:Content>

