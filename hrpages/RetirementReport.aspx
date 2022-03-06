﻿ <%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RetirementReport.aspx.cs" Inherits="hrpages_RetirementReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    
     <h2>HR MANAGER</h2>
    <h4> No 4 Adebolu Street Ibeche Titun Ikorodu Lagos State</h4>
    
     <h3 id="mn" runat="server" Visible="false">Retirement Report for <asp:label runat="server"  id="lblsel" CssClass="text-success"></asp:label> Staff.

    </h3>

       <h3 id="mm" runat="server" Visible="false">Retirement Report for <asp:label runat="server"  id="lblsell" CssClass="text-success"></asp:label>.

    </h3>

     <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <LayoutTemplate>
                <table id="Table1" runat="server" class="TableCss" rules="all" frame="box" style="text-align:center; color:forestgreen; border-color:ButtonShadow; border-radius:10px" >
                    <tr id="Tr1" runat="server" class="TableHeader">
                        <th id="Td1" runat="server" ><strong>Staff Id</strong></th>
                        <th id="Td9" runat="server" ><strong>Staff Name</strong></th>
                        <th id="Td2" runat="server" ><strong>Location</strong></th>
                        <th id="Td3" runat="server" ><strong>Department</strong></th>
                         <th id="Td6" runat="server"><strong>Age</strong></th>  
                        <th id="Td4" runat="server"><strong>Years Served</strong></th>  
                        <th id="Td5" runat="server"><strong>Years Left</strong></th>  
                        
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
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("Dept") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label6" runat="server" Text='<%#Eval("Age") %>'></asp:Label>
                    </td>
                      <td runat="server">
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("Years_Served") %>'></asp:Label>
                    </td>
                      <td runat="server">
                        <asp:Label ID="Label7" runat="server" Text='<%#Eval("Years_Left") %>'></asp:Label>
                    </td>
                 
          
                                       
                </tr>
            </ItemTemplate>
        </asp:ListView>

              <style>

                          table,th,td { width:70%;
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

