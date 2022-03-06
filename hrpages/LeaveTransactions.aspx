<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="LeaveTransactions.aspx.cs" Inherits="hrpages_LeaveTransactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server" >
    	 <asp:UpdatePanel runat="server">
                 <ContentTemplate>

      <h3><%:Page.Title %></h3>
    <br />
    <div >
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Leave Transaction Setup</h4>
   
    <div class="row" style="background-image:url(/img/hrl.jpg) ">
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
                <asp:TextBox Enabled="false" ID="txtname" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
     
        
    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Leave Code</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbleavetype" runat="server" CssClass="form-control"  AutoPostBack="true" OnSelectedIndexChanged="cmbleavetype_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbleavetype" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
         <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Start Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtstart" runat="server" CssClass="form-control" MaxLength="15" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstart" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">No of Days</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtdays" AutoPostBack="true" runat="server" CssClass="form-control" MaxLength="4" OnTextChanged="txtdays_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdays" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">End Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtend" runat="server" CssClass="form-control" MaxLength="15" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtend" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Date Applied</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtapply" runat="server" CssClass="form-control" MaxLength="15" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtapply" CssClass="text-danger" ErrorMessage="This field is required." />
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
               

             <asp:Image ID="Image1" runat="server" CssClass="thumbnail" height="150px" Width="150px"/>
                   
            </div>
        
           </div>
</ContentTemplate></asp:UpdatePanel>
</asp:Content>

