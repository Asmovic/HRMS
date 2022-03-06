using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class hrpages_LeaveTransactions : System.Web.UI.Page
{
   
    private static string msur,mfst,mlast,gleavetype,hb,kj,pl;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            FillCombo.DropDownListItems(1, cmbleavetype, AppTables.Leave_Tab);
        txtapply.Text = DateTime.Now.ToShortDateString();
    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        txtname.Text = HR_Report.Return_StaffName(txtstid.Text);

        Image1.ImageUrl = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");

        //var cmblt = RetrieveFields.retrieveByFieldIndex_HasOneKey(1,AppTables.LeaveTrans_Tab,AppFields.LeaveTrans_Fld1a, txtstid.Text,"string");
        //cmbleavetype.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1,AppTables.Leave_Tab,AppFields.LeaveTrans_Fld1b,cmblt,"string");
        //txtstart.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, "string");
        //txtend.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, "string");
        //txtdays.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, "string");
        //txtapply.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, "string");
     //   mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.L_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");

    }
    protected void cmbleavetype_SelectedIndexChanged(object sender, EventArgs e)
    {
        gleavetype = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Leave_Tab, AppFields.Leave_Fld1b, cmbleavetype.SelectedItem.Text, "string");

         hb = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(2, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, AppFields.LeaveTrans_Fld1b, gleavetype, "string");
        DateTime vc = HR_Report.myconvdate(hb);
        txtstart.Text = vc.ToShortDateString();
         kj = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(3, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, AppFields.LeaveTrans_Fld1b, gleavetype, "string");
        DateTime ol = HR_Report.myconvdate(kj);
        txtend.Text = ol.ToShortDateString();
          txtdays.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(4, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text,AppFields.LeaveTrans_Fld1b,gleavetype, "string");
          pl = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(5, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, AppFields.LeaveTrans_Fld1b, gleavetype, "string");
         DateTime ty = HR_Report.myconvdate(pl);
         txtapply.Text = ty.ToShortDateString();
  
    }
    protected void txtdays_TextChanged(object sender, EventArgs e)
    {
        compute_enddate();
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_LeaveTransactions(txtstid.Text,gleavetype,txtstart.Text,txtend.Text,txtdays.Text,txtapply.Text);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        txtstid.Text = "";
        txtname.Text = "";
        cmbleavetype.SelectedItem.Text = "";
        txtstart.Text = "";
        txtend.Text = "";
        txtdays.Text = "";
        txtapply.Text = "";


    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Leave_Transactions(txtstid.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        txtstid.Text = "";
        cmbleavetype.SelectedItem.Text = "";
        txtstart.Text = "";
        txtend.Text = "";
        txtdays.Text = "";
        txtapply.Text = "";
        txtname.Text = "";
    }


    private void compute_enddate()
    {
        //DateTime mydate = DateTime.ParseExact(txtstart.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //DateTime myenddate = mydate.AddDays(int.Parse(txtdays.Text));
        //txtend.Text = myenddate.ToString("dd/MM/yyy",CultureInfo.InvariantCulture);

        DateTime mydate = HR_Report.myconvdate(txtstart.Text);
        DateTime myenddate = mydate.AddDays(int.Parse(txtdays.Text));
        txtend.Text = myenddate.ToShortDateString();
    }
}