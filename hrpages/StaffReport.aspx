<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StaffReport.aspx.cs" Inherits="hrpages_StaffReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <h2>HR MANAGER</h2>
    <h4> No 4 Adebolu Street Ibeche Titun Ikorodu Lagos State</h4>
    
    <h3 id="mn" runat="server" Visible="false">Report for <asp:label runat="server"  id="lblsel" CssClass="text-success"></asp:label> Staff.

    </h3>

       <h3 id="mm" runat="server" Visible="false">Report for <asp:label runat="server"  id="lblsell" CssClass="text-success"></asp:label>.

    </h3>

     <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <LayoutTemplate>
                <table id="Table1" runat="server" class="TableCss" rules="all" frame="box" style="text-align:center; color:forestgreen; border-color:ButtonShadow; border-radius:10px" >
                    <tr id="Tr1" runat="server" class="TableHeader">
                        <th id="Td1" runat="server" ><strong>Staff Id</strong></th>
                        <th id="Td9" runat="server" ><strong>Staff Name</strong></th>
                        <th id="Td2" runat="server" ><strong>Location</strong></th>
                        <th id="Td3" runat="server" ><strong>Department</strong></th>
                         <th id="Td6" runat="server"><strong>Section</strong></th>
                         <th id="Th1" runat="server" ><strong>Grade</strong></th>
                         <th id="Th2" runat="server"><strong>Step</strong></th>
                        <th id="Td4" runat="server" ><strong>State</strong></th>
                        <th id="Td5" runat="server" ><strong>LGA</strong></th>  
                        
                    </tr>
                   <tr id="ItemPlaceholder" runat="server"></tr>
                    <tr id="Tr2" runat="server">
                       
                    </tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr class="TableData" runat="server">
                    <td runat="server">
                        <asp:Label ID="Label1"  runat="server" Text='<%#Eval("Staff_Id") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label2"  runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Location") %>'></asp:Label>
                    </td>
                    
                     <td runat="server">
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("Department") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label6" runat="server" Text='<%#Eval("Section") %>'></asp:Label>
                    </td>

                      <td runat="server">
                        <asp:Label ID="Label8" runat="server" Text='<%#Eval("Grade") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label9" runat="server" Text='<%#Eval("Step") %>'></asp:Label>
                    </td>
                  <td runat="server">
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("State_Of_Origin") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label7" runat="server" Text='<%#Eval("LGA") %>'></asp:Label>
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
         #label1 {
             width:8px;
         }
                    </style>
</asp:Content>

