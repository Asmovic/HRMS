<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="TrainingReport.aspx.cs" Inherits="hrpages_TrainingReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <h2>HR MANAGER</h2>
    <h4> No 4 Adebolu Street Ibeche Titun Ikorodu Lagos State</h4>
    
    <h3>Training Report</h3>

     <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <LayoutTemplate>
                <table id="Table1" runat="server" class="TableCss" rules="all" frame="box" style="text-align:center; width:50%; color:forestgreen; border-color:ButtonShadow; border-radius:10px" >
                    <tr id="Tr1" runat="server" class="TableHeader">
                        <th id="Td1" runat="server" ><strong>Staff Id</strong></th>
                        <th id="Td2" runat="server" ><strong>Name</strong></th>
                        <th id="Td3" runat="server" ><strong>Training Name</strong></th>
                        <th id="Td4" runat="server" ><strong>Institution Name</strong></th>
                        <th id="Td5" runat="server" ><strong>Certificate Obtained</strong></th>
                        <th id="Td6" runat="server" ><strong>Duration</strong></th>
                        <th id="Td7" runat="server" ><strong>Date</strong></th>
                        
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
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Training_Name") %>'></asp:Label>
                    </td>
                    
                     <td runat="server">
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("Institution_Name") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label6" runat="server" Text='<%#Eval("Certificate_Obtained") %>'></asp:Label>
                    </td>
                  <td runat="server">
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("Duration") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label7" runat="server" Text='<%#Eval("Date") %>'></asp:Label>
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

