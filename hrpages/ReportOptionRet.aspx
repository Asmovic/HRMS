<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReportOptionRet.aspx.cs" Inherits="hrpages_ReportOptionRet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

      <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Retirement Report Option Page</h4>
        
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
            <asp:Label runat="server" id="lblcode" Visible="false"  CssClass="col-md-4 control-label">Staff Id</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="TxtCode"  Visible="false" runat="server" CssClass="form-control" MaxLength="15" AutoPostBack="true" OnTextChanged="TxtCode_TextChanged"></asp:TextBox>
                <asp:TextBox runat="server" ID="Txtname" Visible="false" Enabled="false" CssClass="form-control"></asp:TextBox>
            </div>
             </div>

      

    
     <div class="form-group" style="clear:both">
            <asp:Label runat="server" ID="lblloc" Visible="false"  CssClass="col-md-4 control-label">Location</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbloc"  Visible="false" runat="server" CssClass="form-control"  AutoPostBack="true" OnSelectedIndexChanged="cmbloc_SelectedIndexChanged"></asp:DropDownList>
               
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server" ID="lbldept" Visible="false"  CssClass="col-md-4 control-label">Department</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbdept"  Visible="false" runat="server" CssClass="form-control"  AutoPostBack="true" OnSelectedIndexChanged="cmddept_SelectedIndexChanged"></asp:DropDownList>
               <br />
            </div>
             </div>
    
    
        <div class="form-group"style="clear:both">
            <asp:Label runat="server" ID="lblret" Visible="false"  CssClass="col-md-4 control-label">In how many Years?</asp:Label>
            <div class="col-md-8">
               <asp:DropDownList runat="server" Visible="false" CssClass="form-control"  ID="cmbretyer" AutoPostBack="true" OnSelectedIndexChanged="cmbretyer_SelectedIndexChanged">
                   <asp:ListItem Enabled="true" Text="Select how many Years" Value="-1"></asp:ListItem>
                   <asp:ListItem Text="1 Year" Value="1"></asp:ListItem>
                   <asp:ListItem Text="2 Years" Value="2"></asp:ListItem>
                   <asp:ListItem Text="3 Years" Value="3"></asp:ListItem>
                   <asp:ListItem Text="4 Years" Value="4"></asp:ListItem>
                   <asp:ListItem Text="5 Years" Value="5"></asp:ListItem>
                 

               </asp:DropDownList>
                <br />
            </div>
             </div>

     <div class="form-group">
            <div class="container col-md-offset-4 col-md-8">
                <%--<asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />--%>
   
                <button id="submitButton" runat="server" type="button" onclick="submitButton_Click" class="btn btn-default">
      <span class="glyphicon glyphicon-search"></span> Search
    </button>

            </div>
        </div>
   

</asp:Content>

