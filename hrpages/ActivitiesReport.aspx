<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ActivitiesReport.aspx.cs" Inherits="hrpages_ActivitiesReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <h2>HR MANAGER</h2>
    <h4> No 4 Adebolu Street Ibeche Titun Ikorodu Lagos State</h4>
    
    <h3>Activities Report</h3>

    <div>
             <h4><asp:Label ID="lblall" runat="server" CssClass="text-info"></asp:Label>
             <asp:Label ID="lblstid" runat="server" CssClass="text-info"></asp:Label>
            <asp:Label ID="lblloc"  runat="server" CssClass="text-info"></asp:Label>
            <asp:Label ID="lbldept" runat="server" CssClass="text-info"></asp:Label></h4>
        </div>

     <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <LayoutTemplate>
                <table id="Table1" runat="server" class="TableCss" rules="all" frame="box" style="text-align:center; color:forestgreen; border-color:ButtonShadow; border-radius:10px" >
                    <tr id="Tr1" runat="server" class="TableHeader">
                        <th id="Td1" runat="server" ><strong>Staff Id</strong></th>
                        <th id="Td9" runat="server" ><strong>Staff Name</strong></th>
                        <th id="Td2" runat="server" ><strong>Activity Name</strong></th>
                        <th id="Td3" runat="server" ><strong>Date</strong></th>
                         <th id="Td6" runat="server"><strong>Remarks</strong></th>  
                        
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
                        <asp:Label ID="Label2"  runat="server" Text='<%#Eval("Staff_Name") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Act_Name") %>'></asp:Label>
                    </td>
                    
                     <td runat="server">
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("Act_Date") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label6" runat="server" Text='<%#Eval("Remark") %>'></asp:Label>
                    </td>
                 
                                       
                </tr>
            </ItemTemplate>
        </asp:ListView>

     <style>

                          table,th,td { width:50%;
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

