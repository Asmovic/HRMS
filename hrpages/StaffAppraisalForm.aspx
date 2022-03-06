<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeFile="StaffAppraisalForm.aspx.cs" Inherits="hrpages_StaffAppraisalForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    	<%-- <asp:UpdatePanel runat="server">
                 <ContentTemplate>--%>
        <div>
            <asp:Label ID="lbldanger" runat="server" CssClass="text-danger"></asp:Label><br />
            <asp:Label ID="lblsuccess" runat="server" CssClass="text-success"></asp:Label>
        </div>
      <div class="row">
        <div class="col-sm-10">

    <div style="margin-left:5px">
        <div class="page-header">
    <h2 style="font-family:Britannic; color:darkgoldenrod; margin-left:15%;"><b>STAFF PERFORMANCE APPRAISAL FORM</b></h2></div>
    
     <div class="form-group" >
         <div class="row">
             <div class="col-xs-4">
                 <asp:Label runat="server" ID="lblstid"  CssClass="col-lg-3 control-label"><b>Staff Id</b></asp:Label>
                     <div class="col-xs-9">
                        <asp:TextBox ID="txtstid"  runat="server" AutoPostBack="true" OnTextChanged="txtstid_TextChanged" CssClass="form-control"></asp:TextBox>
                     </div> 
             </div>
             <div class="col-xs-8">
                <asp:Label runat="server" ID="lblname" CssClass="col-lg-3 control-label"><b>Name</b></asp:Label>
                   <div class="col-xs-9">
                       <asp:TextBox ID="txtname"  runat="server" CssClass="form-control"></asp:TextBox>
                   </div> 
             </div>
         </div>

     </div>


       <div class="form-group" >
         <div class="row">
             <div class="col-xs-4">
                 <asp:Label runat="server" ID="lbldept"  CssClass="col-lg-3 control-label"><b>Dept:</b></asp:Label>
                     <div class="col-xs-9">
                        <asp:TextBox ID="txtdept"  runat="server" CssClass="form-control"></asp:TextBox>
                     </div> 
             </div>
             <div class="col-sm-8">
                <asp:Label runat="server" ID="lblclass" CssClass="col-lg-3 control-label"><b>Classificaton Title</b></asp:Label>
                   <div class="col-xs-9">
                       <asp:TextBox ID="txtclass"  runat="server" CssClass="form-control"></asp:TextBox>
                   </div> 
             </div>
         </div>

     </div>

    <div class="form-group">
        <asp:Label runat="server" ID="lblapptype" CssClass="col-lg-2 control-label"><b>Type of Appraisal:</b></asp:Label>
        <div class="col-sm-10">
            <asp:UpdatePanel runat="server">
                    <ContentTemplate>
            <div class="row">
                <div class="col-xs-2">
                    
            <asp:CheckBox ID="Chk1" runat="server" Text=" Anniversary" TextAlign="Left" AutoPostBack="true" OnCheckedChanged="Chk1_CheckedChanged" />
                </div>
           <div class="col-xs-10">
            <asp:CheckBox ID="Chk2" runat="server" Text=" Special" TextAlign="Left" AutoPostBack="true" OnCheckedChanged="Chk2_CheckedChanged" />
               </div>

        </div>
           </ContentTemplate></asp:UpdatePanel>             
                        </div>
    </div>

        <div class="form-group">
        <asp:Label runat="server" ID="lblappper" CssClass="col-lg-2 control-label"><b>Appraisal Period:</b></asp:Label>
        <div class="col-sm-10">
            <div class="row">
            <div class="col-xs-4">
                <asp:Label runat="server" CssClass="col-lg-2 control-label"><b>From:</b></asp:Label>
                <div class="col-xs-10">
                <asp:TextBox runat="server" ID="txtfrom" CssClass="form-control"></asp:TextBox>
                    </div>
            </div>
            <div class="col-xs-8">
                <asp:Label runat="server" CssClass="col-lg-1 control-label"><b>To:</b></asp:Label>
                <div class="col-xs-11">
                <asp:TextBox runat="server" ID="txtto" AutoPostBack="true" OnTextChanged="txtto_TextChanged" CssClass="form-control"></asp:TextBox>
                    <br />
                    </div>
            </div>
        </div></div>
    </div>

    <div class="form-group">
        <p class="text-danger">This form must be returned to the Division of Human Resources by <span><asp:TextBox runat="server" ID="txtret"></asp:TextBox></span> . If the form
            is not received by this date,rating will<br /> automatically default to Achieves Performance Standards.
        </p>

    </div>


    <div class ="form-group">
        <asp:UpdatePanel runat="server">
                    <ContentTemplate>
     <table runat="server" class="table-responsive table-hover table-condensed">
         <tr>
             <th style="padding-left:2px;">INSTRUCTIONS:<small>This appraisal form must be<br /> completed by the immediate  Superviser
                  based on <br />performance standards previously established. 
                              </small></th>
             <th style="text-align:center">EXCELLENT<br /><small>(80%-Above)<br />(8-Above)</small></th>
             <th style="text-align:center">VERY-GOOD<br /><small>(70% - 79%)<br />(7 -7.9)</small></th>
             <th style="text-align:center">__GOOD__<br /><small>(60% - 69%)<br />(6 -6.9)</small></th>
             <th style="text-align:center">AVERAGE<br /><small>(50% - 59%)<br />(5 -5.9)</small></th>
             <th style="text-align:center">BELOW-AVG<br /><small>(49% Below)<br />(4.9 Below)</small></th>
         </tr>
         <tr>
             
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc1"></asp:Label></strong><br />
                 <asp:TextBox ID="txtdesc1" runat="server" CssClass="form-control" BackColor="LemonChiffon" ></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkj1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkj1_CheckedChanged" /></td>
             <td>
                  <asp:CheckBox ID="Chkj2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkj2_CheckedChanged" />
                 
             </td>
             <td>
                 <asp:CheckBox ID="Chkj3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkj3_CheckedChanged" />
             </td>
             <td>
                 <asp:CheckBox ID="Chkj4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkj4_CheckedChanged" />
             </td>

             <td>
                 <asp:CheckBox ID="Chkj5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkj5_CheckedChanged" />
             </td>
             
         </tr>

             <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc2"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc2" CssClass="form-control" BackColor="Wheat"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkq1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkq1_CheckedChanged" /></td>
             <td>
                  <asp:CheckBox ID="Chkq2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkq2_CheckedChanged" />
                 
             </td>

                 <td>
                     <asp:CheckBox ID="Chkq3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkq3_CheckedChanged" />

                 </td>
             <td>
                 <asp:CheckBox ID="Chkq4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkq4_CheckedChanged" />
             </td>
                 <td>
                     <asp:CheckBox ID="Chkq5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkq5_CheckedChanged" />
                 </td>
         </tr>

           <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc3"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc3" CssClass="form-control" BackColor="Turquoise"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkp1_CheckedChanged" /></td>
             <td>
                  <asp:CheckBox ID="Chkp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkp5_CheckedChanged" />
               </td>
         </tr>

           <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc4"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc4" CssClass="form-control" BackColor="BurlyWood"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkd1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkd1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkd2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkd2_CheckedChanged" />
               
             </td>

               <td>
                     <asp:CheckBox ID="Chkd3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkd3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkd4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkd4_CheckedChanged"  />
             </td>
               <td>
                     <asp:CheckBox ID="Chkd5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkd5_CheckedChanged" />
               </td>
         </tr>

           <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc5"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc5" CssClass="form-control" BackColor="Plum"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chka1" runat="server" AutoPostBack="true" OnCheckedChanged="Chka1_CheckedChanged" /></td>
             <td>
                  <asp:CheckBox ID="Chka2" runat="server" AutoPostBack="true" OnCheckedChanged="Chka2_CheckedChanged" />
                 
             </td>
               <td>
                   <asp:CheckBox ID="Chka3" runat="server" AutoPostBack="true" OnCheckedChanged="Chka3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chka4" runat="server" AutoPostBack="true" OnCheckedChanged="Chka4_CheckedChanged"  />
             </td>
               <td>
                   <asp:CheckBox ID="Chka5" runat="server" AutoPostBack="true" OnCheckedChanged="Chka5_CheckedChanged" />
               </td>
         </tr>

           <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc6"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc6" CssClass="form-control" BackColor="Gold"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkr1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkr1_CheckedChanged" /></td>
             <td>
                  <asp:CheckBox ID="Chkr2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkr2_CheckedChanged" />
                 
             </td>
               <td>
                   <asp:CheckBox ID="Chkr3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkr3_CheckedChanged"/>
               </td>
             <td>
                 <asp:CheckBox ID="Chkr4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkr4_CheckedChanged" />
             </td>
               <td>
                   <asp:CheckBox ID="Chkr5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkr5_CheckedChanged"/>
               </td>
         </tr>

           <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc7"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc7" CssClass="form-control" BackColor="LightCoral"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkc1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkc1_CheckedChanged" /></td>
             <td>
                  <asp:CheckBox ID="Chkc2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkc2_CheckedChanged" />
                 
             </td>
               <td>
                   <asp:CheckBox ID="Chkc3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkc3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkc4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkc4_CheckedChanged" />
             </td>
               <td>
                   <asp:CheckBox ID="Chkc5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkc5_CheckedChanged" />
               </td>
         </tr>

           <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc8"></asp:Label></strong><mark>(applicable only to designated supervisor positions)</mark><br />
                 <asp:TextBox runat="server" ID="txtdesc8" CssClass="form-control" BackColor="LightSkyBlue"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chks1" runat="server" AutoPostBack="true" OnCheckedChanged="Chks1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chks2" runat="server" AutoPostBack="true" OnCheckedChanged="Chks2_CheckedChanged" />
                 
             </td>
               <td>
                   <asp:CheckBox ID="Chks3" runat="server" AutoPostBack="true" OnCheckedChanged="Chks3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chks4" runat="server" AutoPostBack="true" OnCheckedChanged="Chks4_CheckedChanged"  />
             </td>
               <td>
                   <asp:CheckBox ID="Chks5" runat="server" AutoPostBack="true" OnCheckedChanged="Chks5_CheckedChanged" />
               </td>
         </tr>

           <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc9"></asp:Label></strong><mark>(one CATEGORY must be CHECKED)</mark><br />
                 <asp:TextBox runat="server" ID="txtdesc9" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chko1" runat="server" AutoPostBack="true" OnCheckedChanged="Chko1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chko2" runat="server" AutoPostBack="true" OnCheckedChanged="Chko2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chko3" runat="server" AutoPostBack="true" OnCheckedChanged="Chko3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chko4" runat="server" AutoPostBack="true" OnCheckedChanged="Chko4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chko5" runat="server" AutoPostBack="true" OnCheckedChanged="Chko5_CheckedChanged" />
               </td>
         </tr>
                <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc10"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc10" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkap1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkap1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkap2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkap2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkap3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkap3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkap4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkap4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkap5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkap5_CheckedChanged" />
               </td>
         </tr>

             <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc11"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc11" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkbp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkbp1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkbp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkbp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkbp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkbp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkbp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkbp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkbp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkbp5_CheckedChanged" />
               </td>
         </tr>

         <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc12"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc12" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkcp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkcp1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkcp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkcp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkcp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkcp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkcp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkcp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkcp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkcp5_CheckedChanged" />
               </td>
         </tr>
              <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc13"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc13" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkdp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkdp1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkdp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkdp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkdp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkdp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkdp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkdp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkdp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkdp5_CheckedChanged" />
               </td>
         </tr>

             <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc14"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc14" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkep1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkep1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkep2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkep2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkep3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkep3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkep4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkep4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkep5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkep5_CheckedChanged" />
               </td>
         </tr>

            <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc15"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc15" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkfp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkfp1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkfp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkfp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkfp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkfp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkfp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkfp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkfp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkfp5_CheckedChanged" />
               </td>
         </tr>

             <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc16"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc16" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkgp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkgp1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkgp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkgp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkgp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkgp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkgp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkgp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkgp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkgp5_CheckedChanged" />
               </td>
         </tr>

              <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc17"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc17" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkhp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkhp1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkhp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkhp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkhp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkhp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkhp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkhp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkhp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkhp5_CheckedChanged" />
               </td>
         </tr>

              <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc18"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc18" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkip1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkip1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkip2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkip2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkip3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkip3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkip4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkip4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkip5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkip5_CheckedChanged" />
               </td>
         </tr>
         

                <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc19"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc19" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkjp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkjp1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkjp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkjp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkjp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkjp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkjp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkjp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkjp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkjp5_CheckedChanged" />
               </td>
         </tr>

                       <tr>
             <td style="text-align:left"><strong><asp:Label runat="server" CssClass="text-info" ID="lbldesc20"></asp:Label></strong><br />
                 <asp:TextBox runat="server" ID="txtdesc20" CssClass="form-control" BackColor="Beige"></asp:TextBox>
             </td>
             <td> <asp:CheckBox ID="Chkkp1" runat="server" AutoPostBack="true" OnCheckedChanged="Chkkp1_CheckedChanged"  /></td>
             <td>
                  <asp:CheckBox ID="Chkkp2" runat="server" AutoPostBack="true" OnCheckedChanged="Chkkp2_CheckedChanged" />
                
             </td>
               <td>
                    <asp:CheckBox ID="Chkkp3" runat="server" AutoPostBack="true" OnCheckedChanged="Chkkp3_CheckedChanged" />
               </td>
             <td>
                 <asp:CheckBox ID="Chkkp4" runat="server" AutoPostBack="true" OnCheckedChanged="Chkkp4_CheckedChanged"  />
             </td>
               <td>
                    <asp:CheckBox ID="Chkkp5" runat="server" AutoPostBack="true" OnCheckedChanged="Chkkp5_CheckedChanged" />
               </td>
         </tr>
     </table>



</ContentTemplate>
            </asp:UpdatePanel>







    </div>

    <style>
        table,th,td { width:85%;
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



        #Chkj2 {
            margin-right:50px;
        }
         #Chkj3 {
            margin-left:50px;
        }
         td {
             text-align:center;
             padding:2px;
         }
         tr:hover{
             color:hotpink;
         }

         #txtstid:hover {
             color:palegreen;
         }
         
         
        

    </style>


        
            <div class="container">

<button type="button" class="btn btn-success btn-lg" data-toggle="modal" data-target="#myModal">You can View Staff Activities Here!!!</button>

<div class="modal fade" id="myModal" role="dialog">
<div class="modal-dialog">
<div class="modal-content">
<div class="modal-header">
<button type="button" class="close" data-dismiss="modal">&times;</button>
<h3 class="modal-title">Staff Activities</h3>
    <h4><strong>NAME:&nbsp</strong><asp:label runat="server" id="lblmn" CssClass="text-success"></asp:label></h4>
    <h4><strong>Dept:&nbsp</strong><asp:label runat="server" id="lblmd" CssClass="text-success"></asp:label></h4>
     <h4><strong>From:&nbsp</strong><asp:label runat="server" id="lblfr" ForeColor="CornflowerBlue"> </asp:label>
         <strong>To:&nbsp</strong><asp:label runat="server" id="lblto" ForeColor="MediumTurquoise"> </asp:label>
     </h4>

</div>
<div class="modal-body">
     <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <LayoutTemplate>
                <table id="Tablez" runat="server" class="TableCss" rules="all" frame="box" style="text-align:center; width:40%; color:forestgreen; border-color:ButtonShadow; border-radius:10px" >
                    <tr id="Tr1" runat="server" class="TableHeader">
                        <td id="Td1" runat="server" ><strong>Activity Code</strong></td>
                     
                        <td id="Td2" runat="server" ><strong>Activity Name</strong></td>
                           <td id="Td9" runat="server" ><strong>No of Times</strong></td>
                    </tr>
                   <tr id="ItemPlaceholder" runat="server"></tr>
                    <tr id="Tr2" runat="server">
                       
                    </tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr class="TableData" runat="server">
                    <td runat="server">
                        <asp:Label ID="Label1"  runat="server" Text='<%#Eval("Act_Code") %>'></asp:Label>
                    </td>
                   
                    <td runat="server">
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Act_Name") %>'></asp:Label>
                    </td>
                    
                     <td runat="server">
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("No_Of_Times") %>'></asp:Label>
                    </td>
                   
                 
                                       
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
<div class="modal-footer">
<button type="button" class="btn btn-primary" data-dismiss="modal">OK</button>
</div></div></div></div></div>

        
            <div class="form-group">
            <div style="text-align:center">
                <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="submitButton_Click" />
                <asp:Button ID="deleteButton" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="deleteButton_Click" />
            </div>
                 </div>

        </div>
            </div>
        <div class="col-sm-2">
               <br /><br /><br /><br /><br /><br />

             <asp:Image ID="Image1" CssClass="img-thumbnail" runat="server" height="150px" Width="150px"/>
                   
            </div>
           </div>

      <script src="../Scripts/jquery-ui-1.12.1.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $("[id$=txtfrom]").datepicker(
            {
                dateFormat: 'dd-mm-yy'
            });
        $("[id$=txtto]").datepicker({
            dateFormat: 'dd-mm-yy'
        });

        $("[id$=txtret]").datepicker({
            dateFormat: 'dd-mm-yy'
        });



    });
</script>
                     <%--</ContentTemplate></asp:UpdatePanel>--%>


</asp:Content>

