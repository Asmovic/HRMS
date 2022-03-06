<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TrainingType.aspx.cs" Inherits="hrpages_TrainingType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Training Type Setup</h4>
        
    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Training Code</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="TxtCode" runat="server" CssClass="form-control" MaxLength="2" AutoPostBack="true" OnTextChanged="TxtCode_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtCode" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
        
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Training Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control" MaxLength="40" OnTextChanged="TxtName_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtName" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

      <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Training Type</asp:Label>
            <div class="col-md-8">
                
                <asp:RadioButton ID="intt" Text="Inservice Training" runat="server" AutoPostBack="true" OnCheckedChanged="intt_CheckedChanged" />
                <asp:RadioButton runat="server" ID="extt" Text="External Training" AutoPostBack="true"  OnCheckedChanged="extt_CheckedChanged" /> 
               
            </div>
             </div>
        
    
    

    <div class="form-group">
            <div class="col-md-offset-4 col-md-8">
                <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />
                <asp:Button ID="deleteButton" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />
            </div>
                 </div>

</asp:Content>

