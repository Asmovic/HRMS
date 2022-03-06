<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReportOption.aspx.cs" Inherits="hrpages_ReportOption" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Report Option Page</h4>
          
    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Report Option</asp:Label>
            <div class="col-md-8">
               <asp:DropDownList runat="server" CssClass="form-control" ID="cmbrepoption" AutoPostBack="true" OnSelectedIndexChanged="cmbrepoption_SelectedIndexChanged">
                   <asp:ListItem Enabled="true" Text="Select Option" Value="-1"></asp:ListItem>
                   <asp:ListItem Text="All" Value="A"></asp:ListItem>
                   <asp:ListItem Text="Single Staff" Value="S"></asp:ListItem>
                   <asp:ListItem Text="By Location" Value="L"></asp:ListItem>
                   <asp:ListItem Text="By Department" Value="D"></asp:ListItem>
                 

               </asp:DropDownList>
                <br />
            </div>
             </div>

     <div class="form-group" >
            <asp:Label runat="server" ID="lblcode" Visible="false"  CssClass="col-md-4 control-label">Staff Id</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="TxtCode"  Visible="false" runat="server" CssClass="form-control" MaxLength="15" AutoPostBack="true" OnTextChanged="TxtCode_TextChanged"></asp:TextBox>
             <%--   <asp:TextBox runat="server" ID="Txtname" Visible="false" Enabled="false" CssClass="form-control"></asp:TextBox>--%>
               <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtCode" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

        <div class="form-group" style="clear:both">
             <asp:Label runat="server" ID="lblloc" Visible="false"  CssClass="col-md-4 control-label">Location</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbloc"  Visible="false" runat="server" CssClass="form-control"  AutoPostBack="true" OnSelectedIndexChanged="cmbloc_SelectedIndexChanged"></asp:DropDownList>
               <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbloc" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group" style="clear:both">
            <asp:Label runat="server" ID="lbldept" Visible="false"  CssClass="col-md-4 control-label">Department</asp:Label>
            <div class=" col-md-8">
                <asp:DropDownList ID="cmbdept"  Visible="false" runat="server" CssClass="form-control"  AutoPostBack="true" OnSelectedIndexChanged="cmddept_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbdept" CssClass="text-danger" ErrorMessage="This field is required." />
               <br />
            </div>
             </div>
    
 

       

     <div class="form-group">
            <div class="col-md-offset-4 col-md-8">
                <asp:Button ID="submitButton" runat="server" Text="Search" CssClass="btn btn-success" OnClick="submitButton_Click" />
   <br />
                <br />
            </div>
        </div>
   

</asp:Content>

