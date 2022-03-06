<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="EmploymentHistory.aspx.cs" Inherits="hrpages_EmploymentHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    	

       <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Employment History</h4>
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
                <asp:TextBox Enabled="false" ID="txtname" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
     
 
         <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Organisation Worked</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtorg" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtorg" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

            <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Positon Held</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" CssClass="form-control" ID="cmbposition"  OnSelectedIndexChanged="cmbposition_SelectedIndexChanged"></asp:DropDownList>
                    <br />       
            </div>
             </div>

    
        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Start Year</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtstarty" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstarty" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

            
        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">End Year</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtendy" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtendy" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Start Salary</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtstsal" runat="server" CssClass="form-control" MaxLength="15" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstsal" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Leaving Salary</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtendsal" runat="server" CssClass="form-control" MaxLength="15" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtendsal" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

            <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Reason For Leaving</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtreason" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtreason" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

                <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Contact Person</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtcontact" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtcontact" CssClass="text-danger" ErrorMessage="This field is required." />
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


</asp:Content>

