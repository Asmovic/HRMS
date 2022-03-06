<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="TrainingTransaction.aspx.cs" Inherits="hrpages_TrainingTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    	 <asp:UpdatePanel runat="server">
                 <ContentTemplate>

     <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Training Transaction Setup</h4>

      <div class="row" style="background-image:url(/img/MN.jpg) ">
        <div class="col-sm-6">
        
    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Staff Id</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtstid" runat="server" CssClass="form-control" MaxLength="3" AutoPostBack="true" OnTextChanged="txtstid_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstid" CssClass="text-danger" ErrorMessage="This field is required." />
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
            <asp:Label runat="server" CssClass="col-md-4 control-label">Training Name</asp:Label>
            <div class="col-md-8">
               <asp:DropDownList  ID="cmbname" runat="server" CssClass="form-control" OnSelectedIndexChanged="cmbname_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Training Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="traindate" runat="server" CssClass="form-control" OnTextChanged="traindate_TextChanged" ></asp:TextBox>
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
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Institution Of Training</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="trainins" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="trainins" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Certificate Obtained</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="certob" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="certob" CssClass="text-danger" ErrorMessage="This field is required." />
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
</ContentTemplate></asp:UpdatePanel>
</asp:Content>

