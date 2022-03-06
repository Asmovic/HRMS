<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TransferAppr.aspx.cs" Inherits="hrpages_TransferAppr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

      
        <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
     <div style="background-image:url(/img/co.jpg) ">
    <div class="header">

        <h3>Transfer Approval</h3>
    </div>
   
    <div class="row" >
        
<div class="col-md-6">
    
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Transfer Ref No.</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txttrefno" runat="server" CssClass="form-control" MaxLength="15" AutoPostBack="true" OnTextChanged="txttrefno_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txttrefno" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     
     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">SNO</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtsno" Enabled="false" runat="server" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtsno" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Transfer Year</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txttyear" runat="server" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txttyear" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

  

      <div class="form-group">
            <asp:Label runat="server" ID="Label1"  CssClass="col-md-4 control-label">Checked By:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtchkby" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
             </div>

          <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Checked Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtchkd" runat="server" Enabled="false" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtchkd" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


         <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Remark</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtremarkc" Enabled="false"  TextMode="MultiLine" runat="server" CssClass="form-control"  ></asp:TextBox>
                
            </div>
             </div>

            <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Checked ?( YES / NO )</asp:Label>
           <div class="col-md-8">
                 <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                <asp:RadioButton runat ="server" Enabled="false"  ID="txtyc" Text="Yes" AutoPostBack="true" OnCheckedChanged="txtyc_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server" Enabled="false"  ID="txtnc" Text="No" AutoPostBack="true" OnCheckedChanged="txtnc_CheckedChanged"></asp:RadioButton>  
                  </ContentTemplate>
                    </asp:UpdatePanel> 
    </div>
      </div>

    </div>








<div class="col-md-6">

    



      <div class="form-group">
            <asp:Label runat="server" ID="lblapprby"  CssClass="col-md-4 control-label">Approved By:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtapprby" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
             </div>

          <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Approved Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtentd" runat="server" OnTextChanged="txtentd_TextChanged" CssClass="form-control"  ></asp:TextBox>
                
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Remark</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtremark" TextMode="MultiLine" runat="server" CssClass="form-control"  ></asp:TextBox>
               
            </div>
             </div>


          <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Approved ?( YES / NO )</asp:Label>
           <div class="col-md-8">
                 <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                <asp:RadioButton runat ="server" ID="txtyes" Text="Yes" AutoPostBack="true" OnCheckedChanged="txtyes_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server"  ID="txtno" Text="No" AutoPostBack="true" OnCheckedChanged="txtno_CheckedChanged"></asp:RadioButton>  
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
                <asp:TextBox ID="txtstid" runat="server" Enabled="false" AutoPostBack="true" OnTextChanged="txtstid_TextChanged" CssClass="form-control" ></asp:TextBox>
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
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Original Location</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtoloc" runat="server" CssClass="form-control" OnTextChanged="txtoloc_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtoloc" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
     
        
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Original Department</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtodept" runat="server" CssClass="form-control" OnTextChanged="txtodept_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtodept" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

  <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Original Section</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtosec" runat="server" CssClass="form-control" OnTextChanged="txtosec_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtosec" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Destination Location</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" Enabled="false" CssClass="form-control" ID="cmbdloc"  OnSelectedIndexChanged="cmbdloc_SelectedIndexChanged"></asp:DropDownList>
                
               
            </div>
             </div>

       <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Destination Department</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" Enabled="false" CssClass="form-control" ID="cmbddept" AutoPostBack="true" OnSelectedIndexChanged="cmbddept_SelectedIndexChanged"></asp:DropDownList>
                
                
            </div>
             </div>

     <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Destination Section</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat ="server" Enabled="false" CssClass="form-control" ID="cmbdsect"  OnSelectedIndexChanged="cmbdsect_SelectedIndexChanged"></asp:DropDownList>
                
               
            </div>
             </div>
    

            <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Transfer Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txttransdate" Enabled="false" runat="server" CssClass="form-control" MaxLength="15" OnTextChanged="txttransdate_TextChanged" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" Enabled="false" ControlToValidate="txttransdate" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
    
        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Transfer Reason</asp:Label>
            <div class="col-md-8">
                <asp:TextBox TextMode="MultiLine" Enabled="false"  ID="txttreason" runat="server" CssClass="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txttreason" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

                    
</div>
           
   
          <div class="col-md-6" style="height:400px; overflow:auto">
                 <div style="height:250px; overflow:auto">
                  <asp:GridView runat="server" ID="gridview2" AutoGenerateSelectButton="true" 
                      style="position:absolute;" BackColor="#ffffcc" GridLines="Both" EditRowStyle-Font-Bold="true" FooterStyle-ForeColor="White"
                       OnSelectedIndexChanged="gridview2_SelectedIndexChanged"></asp:GridView>
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

        $("[id$=txttransdate]").datepicker({
            dateFormat: 'dd-mm-yy'
        });



    });
</script>

</asp:Content>

