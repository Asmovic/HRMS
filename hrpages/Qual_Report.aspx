<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Qual_Report.aspx.cs" Inherits="hrpages_Qual_Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
        <h2>HR MANAGER</h2>
    <h4> No 4 Adebolu Street Ibeche Titun Ikorodu Lagos State</h4>

    <h3 class="text-warning">Qualification Report</h3>
        
   <%-- <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-4 control-label">Qualification Code</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="TxtCode" runat="server" CssClass="form-control" MaxLength="9" AutoPostBack="true" OnTextChanged="TxtCode_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtCode" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>
        
    <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Qualification Name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtName" CssClass="text-danger" ErrorMessage="This field is required." />
            </div>
             </div>--%>
 <%--   <div>
       <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label"><strong>Qualification Code</strong></asp:Label>
                 <div class="col-md-8">   <asp:Label ID="TxtCode" runat="server" CssClass="control-label text-success"></asp:Label></div>
                   </div> 


            <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label"><strong>Qualification Name</strong></asp:Label>
                  <div class="col-md-8">  <asp:Label ID="TxtName" runat="server" CssClass="control-label text-success"></asp:Label></div>
                   </div> 

      <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-4 control-label">Qualification Type</asp:Label>
            <div class="col-md-8">
                <asp:RadioButton runat ="server"  ID="txta" Text="Academic" AutoPostBack="true" OnCheckedChanged="txta_CheckedChanged"></asp:RadioButton>
                <asp:RadioButton runat ="server"  ID="txtp" Text="Professional" AutoPostBack="true" OnCheckedChanged="txtp_CheckedChanged"></asp:RadioButton>    
            </div>
             </div>
    </div>--%>
                 
    <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <LayoutTemplate>
                <table id="Table1" runat="server" class="TableCss" rules="all" frame="box" style="text-align:center; color:forestgreen; border-color:ButtonShadow; border-radius:10px" >
                    <tr id="Tr1" runat="server" class="TableHeader">
                        <th id="Td1" runat="server" ><strong>Staff Id</strong></th>
                        <th id="Td2" runat="server" ><strong>Surname</strong></th>
                        <th id="Td3" runat="server" ><strong>Other Names</strong></th>
                        <th id="Td4" runat="server" ><strong>Qualification</strong></th>
                        <th id="Td5" runat="server" ><strong>Field of Study</strong></th>
                        <th id="Td6" runat="server" ><strong>Year Obtained</strong></th>
                        
                    </tr>
                   <tr id="ItemPlaceholder" runat="server"></tr>
                   <%-- <tr id="Tr2" runat="server">
                       
                    </tr>--%>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr class="TableData" runat="server">
                    <td runat="server">
                        <asp:Label ID="Label1"  runat="server" Text='<%#Eval("STAFF_ID") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label2"  runat="server" Text='<%#Eval("STAFF_SURNAME") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("STAFF_OTHERNAMES") %>'></asp:Label>
                    </td>
                    
                     <td runat="server">
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("QUALIFICATION") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label6" runat="server" Text='<%#Eval("FIELD_OF_STUDY") %>'></asp:Label>
                    </td>
                  <td runat="server">
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("YEAR_OBTAINED") %>'></asp:Label>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

       <style>

                          table,th,td { width:60%;
                border-collapse:collapse;
                border:3px solid black;

        }
        tr:nth-child(even) { background-color:#F2F2F2;

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

</asp:Content>

