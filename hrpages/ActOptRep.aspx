<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ActOptRep.aspx.cs" Inherits="hrpages_ActOptRep" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    
      <h3><%:Page.Title %></h3>
    <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Activities Option Report</h4>
        
    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Activities Option</asp:Label>
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
             <%--   <asp:TextBox runat="server" ID="Txtname" Visible="false" Enabled="false" CssClass="form-control"></asp:TextBox>--%>
            </div>
             </div>

      

    
     <div class="form-group" style="clear:both">
          <div class="row">
              <div class="col-md-4">
            <asp:Label runat="server" ID="lblloc" Visible="false" CssClass="control-label">Location</asp:Label></div>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbloc"  Visible="false" runat="server" CssClass="form-control"  AutoPostBack="true" OnSelectedIndexChanged="cmbloc_SelectedIndexChanged"></asp:DropDownList>
               
            </div>
              </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server" ID="lbldept" Visible="false"  CssClass="col-md-4 control-label">Department</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbdept"  Visible="false" runat="server" CssClass="form-control"  AutoPostBack="true" OnSelectedIndexChanged="cmddept_SelectedIndexChanged"></asp:DropDownList>
               <br />
            </div>
             </div>
   
    
        <div class="form-group">
            <div class="row">
                <div class="col-md-6">
            <asp:Label runat="server" ID="lblstdate" Visible="false"  CssClass="col-md-2 control-label">Start Date</asp:Label>
            <div class="col-md-10">
           <asp:TextBox runat="server" ID="txtstdate" CssClass="form-control" Visible="false" OnTextChanged="txtstdate_TextChanged"></asp:TextBox>
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtstdate"></asp:RequiredFieldValidator>--%>
            </div></div>
                <div class="col-md-6">
             <asp:Label runat="server" ID="lblenddate" Visible="false"  CssClass="col-md-2 control-label">End Date</asp:Label>
            <div class="col-md-10">
           <asp:TextBox runat="server" ID="txtenddate" CssClass="form-control" Visible="false" OnTextChanged="txtenddate_TextChanged"></asp:TextBox>
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtenddate"></asp:RequiredFieldValidator>--%>
            </div></div></div>
             </div>


     <div class="form-group">
            <div class="col-md-offset-4 col-md-8">
                <asp:Button ID="submitButton" runat="server" Text="Search" CssClass="btn btn-success glyphicon glyphicon-search" OnClick="submitButton_Click" />

             <%--         <button ID="submitButton" runat="server" type="button" onclick="submitButton_Click" class="btn btn-default">
      <span class="glyphicon glyphicon-search"></span> Search
    </button--%>
   
            </div>
        </div>
   
     
   
      <style>

                          table,th,td { width:60%;
                border-collapse:collapse;
                border:3px solid black;

        }
         tr:nth-child(even) {
             background-color: white;
         }
         tr:nth-child(odd) {
             background-color: aliceblue;
         }


        
        th {
            background-color:#05c4ad;
            color:white;
            border-color:black;
        }

           td,th {
             text-align:center;
             padding:2px;
         }
         tr:hover{
             color:hotpink;
         }

         hr {
             clear:both;
             background-color:dimgrey;
             color:dimgrey;
             border-color:dimgrey;
             border-radius: 1px 1px;
             height:1px;
             width:100%;  
         }
                    </style>

    
    <script src="../Scripts/jquery-ui-1.12.1.js"></script>
    
<script type="text/javascript">
    $(document).ready(function () {
        $("[id$=txtstdate]").datepicker(
            {
                dateFormat: 'dd-mm-yy'
            });
        $("[id$=txtenddate]").datepicker({
            dateFormat: 'dd-mm-yy'
        });



    });
</script>
</asp:Content>

