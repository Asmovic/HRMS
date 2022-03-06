<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="false" CodeFile="StaffPromotion.aspx.cs" Inherits="hrpages_StaffPromotion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    	 
     <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
     <div style="background-image:url(/img/co.jpg) ">
    <div class="header">

        <h3> Staff Promotion</h3>
    </div>
   
    <div class="row" >
        
<div class="col-md-6">
    
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Promotion Ref No.</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtprefno" runat="server" CssClass="form-control" MaxLength="15" AutoPostBack="true" OnTextChanged="txtprefno_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtprefno" CssClass="text-danger" ErrorMessage="This field is required." />
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
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Year Of Promotion</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtpyear" runat="server" CssClass="form-control" OnTextChanged="txtpyear_TextChanged"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtpyear" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

           <div class="form-group">
            <asp:Label runat="server" ID="Label1" Visible="false" CssClass="col-md-4 control-label">Checked By:</asp:Label>
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

     <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Remark</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtremarkc" Enabled="false" Visible="false" TextMode="MultiLine" runat="server" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtremarkc" CssClass="text-danger" ErrorMessage="This field is required." />
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


    </div>








<div class="col-md-6">

    
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
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtremark" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


          <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Approved ?( YES / NO )</asp:Label>
           <div class="col-md-8">
                 <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                <asp:RadioButton runat ="server" Visible="false" Enabled="false"  ID="txtyes" Text="Yes" AutoPostBack="true" OnCheckedChanged="txtyes_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server" Visible="false"  ID="txtno" Enabled="false" Text="No" AutoPostBack="true" OnCheckedChanged="txtno_CheckedChanged"></asp:RadioButton>  
                  </ContentTemplate>
                    </asp:UpdatePanel> 
               </div></div></div>
    <br />
    <br />

         <div style="background-image:url(/img/co.jpg) ">
             <div class="row">
                 <div class="col-md-7">
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
                <asp:TextBox ID="lblname" runat="server" Enabled="false" CssClass ="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="lblname" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Current Grade:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="lblgrade" runat="server" Enabled="false" CssClass ="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="lblgrade" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

      <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Current Step:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="lblstep" runat="server" Enabled="false" CssClass ="form-control" ></asp:TextBox>
                <br />
           <%--     <asp:RequiredFieldValidator runat="server" ControlToValidate="lblstep" CssClass="text-danger" ErrorMessage="This field is required." />--%>
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">New Grade:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtngrade" runat="server" CssClass ="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtngrade" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">New Step:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtnstep" runat="server" CssClass ="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtnstep" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Promotion Date:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtpdate" runat="server" OnTextChanged="txtpdate_TextChanged" CssClass ="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtpdate" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

           
   
             </div>
                 <div class="col-md-5" style="height:300px; overflow:auto">
                      <div style="height:250px; overflow:auto">
                  <asp:GridView runat="server" ID="gridview1" AutoGenerateSelectButton="true" 
                      style="position:absolute;" BackColor="#ffffcc" GridLines="Both" EditRowStyle-Font-Bold="true" FooterStyle-ForeColor="White"
                       OnSelectedIndexChanged="gridview1_SelectedIndexChanged"></asp:GridView>
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

        $("[id$=txtpdate]").datepicker({
            dateFormat: 'dd-mm-yy'
        });



    });
</script>

          

    

</asp:Content>

