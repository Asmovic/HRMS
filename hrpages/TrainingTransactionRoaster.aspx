<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TrainingTransactionRoaster.aspx.cs" Inherits="hrpages_TrainingTransactionRoaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

<%--     <asp:UpdatePanel runat="server">
                 <ContentTemplate>--%>

        <br />
    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
     <div style="background-image:url(/img/co.jpg) ">
    <div class="header">

        <h3>Training Transaction Roaster</h3>
    </div>
   
    <div class="row" >
        
<div class="col-md-6">
    
   <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Training Transaction Ref No.</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtttrefno" runat="server" CssClass="form-control" MaxLength="15" AutoPostBack="true" OnTextChanged="txtttrefno_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtttrefno" CssClass="text-danger" ErrorMessage="This field is required." />
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
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Training Transaction Year</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txttyear" runat="server" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txttyear" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>

  

      <div class="form-group">
            <asp:Label runat="server" ID="Label1" Visible="false" CssClass="col-md-4 control-label">Checked By:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtchkby" Visible="false" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
             </div>

          <div class="form-group">
            <asp:Label runat="server" Visible="false"  CssClass="col-md-4 control-label">Checked Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtchkd" Visible="false" runat="server" Enabled="false" CssClass="form-control"  ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtchkd" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>


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

    </div>








<div class="col-md-6">

    



      <div class="form-group">
            <asp:Label runat="server" Visible="false" ID="lblapprby"  CssClass="col-md-4 control-label">Approved By:</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtapprby" Visible="false" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
             </div>

          <div class="form-group">
            <asp:Label runat="server" Visible="false" CssClass="col-md-4 control-label">Approved Date</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtentd" Visible="false" runat="server" Enabled="false" OnTextChanged="txtentd_TextChanged" CssClass="form-control"  ></asp:TextBox>
                
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
                <asp:RadioButton runat ="server" Visible="false" ID="txtyes" Enabled="false" Text="Yes" AutoPostBack="true" OnCheckedChanged="txtyes_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server" Visible="false" ID="txtno" Enabled="false" Text="No" AutoPostBack="true" OnCheckedChanged="txtno_CheckedChanged"></asp:RadioButton>  
                  </ContentTemplate>
                    </asp:UpdatePanel> 
               </div></div>


    </div>
      </div>  
    <br />
    <br />

         <div style="background-image:url(/img/co.jpg) ">
             <div class="row">
                 <div class="col-md-6">
     <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Staff Id</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="txtstid" runat="server" CssClass="form-control"  AutoPostBack="true" OnTextChanged="txtstid_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstid" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
                     
                <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Staff Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox Enabled="false" ID="txtname" runat="server" CssClass="form-control" MaxLength="15" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtname" CssClass="text-danger" ErrorMessage="This field is required." />
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
                <asp:TextBox ID="traindate" runat="server" CssClass="form-control"  ></asp:TextBox>
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
                <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />
                <asp:Button ID="Button2" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />
            </div>
                 
             </div>
            </div>

         <style>
             table {

             }

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

        $("[id$=traindate]").datepicker({
            dateFormat: 'dd-mm-yy'
        });



    });
</script>
                   <%--  </ContentTemplate></asp:UpdatePanel>--%>

</asp:Content>

