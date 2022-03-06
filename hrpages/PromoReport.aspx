<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PromoReport.aspx.cs" Inherits="hrpages_PromoReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    
     <h2>HR MANAGER</h2>
    <h4> No 4 Adebolu Street Ibeche Titun Ikorodu Lagos State</h4>
    
       <h3 id="mn" runat="server" Visible="false">Promotion Report for <asp:label runat="server"  id="lblsel" CssClass="text-success"></asp:label> Staff.

    </h3>

       <h3 id="mm" runat="server" Visible="false">Promotion Report for <asp:label runat="server"  id="lblsell" CssClass="text-success"></asp:label>.

    </h3>

        <div>
             <h4><asp:Label ID="lblall" runat="server" CssClass="text-info"></asp:Label>
             <asp:Label ID="lblstid" runat="server" CssClass="text-info"></asp:Label>
            <asp:Label ID="lblloc"  runat="server" CssClass="text-info"></asp:Label>
            <asp:Label ID="lbldept" runat="server" CssClass="text-info"></asp:Label></h4>
        </div>

     <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <LayoutTemplate>
                <table id="Table1" runat="server" class="TableCss" rules="all" frame="box" style="text-align:center; color:forestgreen; border-color:ButtonShadow; border-radius:10px" >
                    <tr id="Tr1" runat="server" class="TableHeader" >
                       
                        <th id="Td9" runat="server"><strong>S/No</strong></th>
                        <th id="Td2" runat="server"><strong>Year of Promo</strong></th>
                        <th id="Td3" runat="server"><strong>Staff Id</strong></th>
                        <th id="Td4" runat="server"><strong>Staff Name</strong></th>
                        <th id="Td5" runat="server"><strong>Previous Grade</strong></th>
                        <th id="Td6" runat="server"><strong>New Grade</strong></th>
                        <th id="Td7" runat="server"><strong>New Step</strong></th>
                        <th id="Td8" runat="server"><strong>Promotion Date</strong></th>
                       
                        
                    </tr>  
                   <tr id="ItemPlaceholder" runat="server" ></tr>
                    <tr id="Tr2" runat="server">
                       
                    </tr>
                </table>
                
            </LayoutTemplate>
        
            <ItemTemplate>
                
                <tr class="TableData" runat="server">
                 
                    

                    <td runat="server">
                        <asp:Label ID="Label2"  runat="server" Text='<%#Eval("S_No") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Promo_Year") %>'></asp:Label>
                    </td>
                    
                     <td runat="server">
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("Staff_Id") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label6" runat="server" Text='<%#Eval("Staff_Name") %>'></asp:Label>
                    </td>
                  <td runat="server">
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("Old_Grade") %>'></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="Label7" runat="server" Text='<%#Eval("New_Grade") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label8" runat="server" Text='<%#Eval("New_Step") %>'></asp:Label>
                    </td>
                     <td runat="server">
                        <asp:Label ID="Label9" runat="server" Text='<%#Eval("Promo_Date") %>'></asp:Label>
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

