<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LeaveRoaster.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="hrpages_LeaveRoaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    	 

        <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
     <div style="background-image:url(/img/co.jpg) ">
    <div class="header">

        <h3> Leave Roaster</h3>
    </div>
   
    <div class="row" >
        
<div class="col-md-6">
    
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Leave Ref No.</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtlrefno" runat="server" CssClass="form-control" MaxLength="15" AutoPostBack="true" OnTextChanged="txtlrefno_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtlrefno" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     
     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">SNO</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtsno" runat="server" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtsno" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Leave Year</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtlyear" runat="server" CssClass="form-control" OnTextChanged="txtlyear_TextChanged"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtlyear" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Location</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbloc" runat="server" CssClass="form-control" AutoPostBack="true"  OnSelectedIndexChanged="cmbloc_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbloc" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

            <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Department</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList ID="cmbdept" runat="server" CssClass="form-control" AutoPostBack="true"  OnSelectedIndexChanged="cmbdept_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbdept" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

      <div class="form-group">
            <asp:Label runat="server" Visible="false" ID="Label1"  CssClass="col-md-4 control-label">Checked By:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtchkby" Visible="false" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
             </div>

          <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Checked Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtchkd" Visible="false" runat="server" Enabled="false" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtentd" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    </div>








<div class="col-md-6">

    

     <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Remark</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtremarkc" Visible="false" Enabled="false"  TextMode="MultiLine" runat="server" CssClass="form-control"  ></asp:TextBox>
                
            </div>
             </div>

            <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Checked ?( YES / NO )</asp:Label>
           <div class="col-md-8">
                 <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                <asp:RadioButton runat ="server" Visible="false" ID="txtyc" Text="Yes" AutoPostBack="true" OnCheckedChanged="txtyc_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server" Visible="false" ID="txtnc" Text="No" AutoPostBack="true" OnCheckedChanged="txtnc_CheckedChanged"></asp:RadioButton>  
                  </ContentTemplate>
                    </asp:UpdatePanel> 
    </div>
      </div>

      <div class="form-group">
            <asp:Label runat="server" ID="lblapprby" Visible="false" CssClass="col-md-4 control-label">Approved By:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtapprby" Enabled="false" Visible="false" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
             </div>

          <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Approved Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtentd" Visible="false" runat="server" Enabled="false" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtentd" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Remark</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtremark" Visible="false" Enabled="false" TextMode="MultiLine" runat="server" CssClass="form-control"  ></asp:TextBox>
               
            </div>
             </div>


          <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Approved ?( YES / NO )</asp:Label>
           <div class="col-md-8">
                 <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                <asp:RadioButton runat ="server" Visible="false" Enabled="false"  ID="txtyes" Text="Yes" AutoPostBack="true" OnCheckedChanged="txtyes_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server" Visible="false" ID="txtno" Enabled="false" Text="No" AutoPostBack="true" OnCheckedChanged="txtno_CheckedChanged"></asp:RadioButton>  
                  </ContentTemplate>
                    </asp:UpdatePanel> 
               </div></div>


<%--          <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Entry Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtentd" runat="server" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtentd" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


          <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Posted ?( YES/NO )</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtposted" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtposted" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>--%>
    </div>
      </div>  
    <br />
    <br />

         <div style="background-image:url(/img/co.jpg) ">
             <div class="row">
                 <div class="col-md-6">
    <div class="form-group" >
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Staff Id</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtstid" runat="server" AutoPostBack="true" OnTextChanged="txtstid_TextChanged" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstid" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Staff Name:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtname" runat="server" Enabled="false" CssClass ="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

        

         <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Start Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtstart" runat="server" AutoPostBack="true" CssClass="form-control" OnTextChanged="txtstart_TextChanged1" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstart" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">No of Days</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtdays" AutoPostBack="true" Enabled="false" runat="server" CssClass="form-control" MaxLength="4" OnTextChanged="txtdays_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdays" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
     


       <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">No of Days Spent</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtdspent" runat="server" Enabled="false" OnTextChanged="txtdspent_TextChanged" CssClass ="form-control"></asp:TextBox>
               <br />
            </div>
             </div>


        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">No of Days Left</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtdleft" runat="server" Enabled="false" OnTextChanged="txtdleft_TextChanged" CssClass ="form-control"></asp:TextBox>
               <br />
            </div>
             </div>

             <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">End Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtend" AutoPostBack="true" runat="server" CssClass="form-control" MaxLength="15" ></asp:TextBox>
              <br />
            </div>
             </div>
                     <br />
              
           
   
             </div>
                 <div class="col-md-6" style="height:300px; overflow:auto">
                 <div style="height:250px; overflow:auto;">
                  <asp:GridView runat="server" ID="gridview2" AutoGenerateSelectButton="true" 
                      style="position:absolute;" BackColor="#ffffcc" GridLines="Both" EditRowStyle-Font-Bold="true" FooterStyle-ForeColor="White"
                       OnSelectedIndexChanged="gridview2_SelectedIndexChanged"></asp:GridView>
                     </div>
                     </div>
             </div>
         </div>


    <div class="form-group">
            <div class="col-md-offset-4 col-md-8">
                <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />
                <asp:Button ID="deleteButton" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />
            </div>
                 </div>
      </div>
                

      <style>

                          table,th,td { width:40%; 
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
                    </style>

    
             <script src="../Scripts/jquery-ui-1.12.1.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $("[id$=txtchkd]").datepicker(
            {
                dateFormat: 'dd-mm-yy'
            });
        $("[id$=txtentd]").datepicker({
            dateFormat: 'dd-mm-yy'
        });

        $("[id$=txtstart]").datepicker({
            dateFormat: 'dd-mm-yy'
        });



    });
</script>
</asp:Content>

