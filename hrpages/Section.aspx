<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Section.aspx.cs" Inherits="hrpages_Section" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    	 <asp:UpdatePanel runat="server">
                 <ContentTemplate>
    <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Section Setup</h4>
        
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Dept Code</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbdept" AutoPostBack ="true" OnSelectedIndexChanged="cmbdept_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbdept" CssClass="text-danger" ErrorMessage="This field is required." />
                
            </div>
             </div>
    
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Section Code</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="TxtCode" runat="server" CssClass="form-control" MaxLength="2" OnTextChanged="TxtCode_TextChanged" AutoPostBack="true"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtCode" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    
    
        
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Section Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtName" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
        
    
    

    <div class="form-group">
            <div class="col-md-offset-4 col-md-8">
                <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />
                <asp:Button ID="deleteButton" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />
            </div>
                 </div>
                     </ContentTemplate></asp:UpdatePanel>
</asp:Content>

