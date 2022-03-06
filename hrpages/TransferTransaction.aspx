<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="TransferTransaction.aspx.cs" Inherits="hrpages_TransferTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    	 <asp:UpdatePanel runat="server">
                 <ContentTemplate>
    
      <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Transfer Transaction Setup</h4>
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
            <asp:Label runat="server" CssClass="col-md-4 control-label">Transfer Type</asp:Label>
           <div class="col-md-8">
                <asp:RadioButton runat ="server" ID="txtttype1" Text="Location" AutoPostBack="true" OnCheckedChanged="txtttype1_CheckedChanged"></asp:RadioButton> 
                <asp:RadioButton runat ="server" ID="txtttype2" Text="Department" AutoPostBack="true" OnCheckedChanged="txtttype2_CheckedChanged"></asp:RadioButton> 
                <asp:RadioButton runat ="server" ID="txtttype3" Text="Section" AutoPostBack="true" OnCheckedChanged="txtttype3_CheckedChanged"></asp:RadioButton>    
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
            <asp:Label runat="server" CssClass="col-md-4 control-label">Destination Location</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbdloc"  OnSelectedIndexChanged="cmbdloc_SelectedIndexChanged"></asp:DropDownList>
                
               
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Destination Department</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbddept" AutoPostBack="true" OnSelectedIndexChanged="cmbddept_SelectedIndexChanged"></asp:DropDownList>
                
                
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Destination Section</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbdsect"  OnSelectedIndexChanged="cmbdsect_SelectedIndexChanged"></asp:DropDownList>
                
               
            </div>
             </div>

         <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Transfer Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txttransdate" runat="server" CssClass="form-control" MaxLength="15" OnTextChanged="txttransdate_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txttransdate" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    
        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Transfer Reason</asp:Label>
            <div class="col-md-8">
                <asp:TextBox TextMode="MultiLine"  ID="txttreason" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txttreason" CssClass="text-danger" ErrorMessage="This field is required." />
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
               

             <asp:Image ID="Image1" runat="server" height="150px" Width="150px"/>
                   
            </div>
                 </div>
      </ContentTemplate>
             </asp:UpdatePanel>
</asp:Content>

