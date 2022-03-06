<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="ActivitiesTrans.aspx.cs" Inherits="hrpages_ActivitiesTrans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

      <h3><%:Page.Title %></h3>
    <br />
    <div >
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h4>Activities Transaction Setup</h4>
   
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
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Activity Name</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbactname" runat="server" CssClass="form-control"  AutoPostBack="true" OnSelectedIndexChanged="cmbactname_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbactname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
         <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Activity Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtdate" runat="server" CssClass="form-control" OnTextChanged="txtdate_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdate" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
   

       <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Remarks</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtremarks" TextMode="MultiLine" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtremarks" CssClass="text-danger" ErrorMessage="This field is required." />
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
        $("[id$=txtdate]").datepicker(
            {
                dateFormat: 'dd-mm-yy'
            });

    });
</script>
</asp:Content>

