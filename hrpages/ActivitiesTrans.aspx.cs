using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_ActivitiesTrans : System.Web.UI.Page
{
    private static string gact,msur,mfst,mlast,gdate;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            FillCombo.DropDownListItems(1, cmbactname, AppTables.Act_Tab);
        
    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
       txtname.Text = HR_Report.Return_StaffName(txtstid.Text);

        Image1.ImageUrl = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        string hg = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Act_Trans_Tab, AppFields.Act_Trans_Fld1a, txtstid.Text, "string");
        DateTime kj = HR_Report.myconvdate(hg);
        txtdate.Text = kj.ToShortDateString();
        gdate = txtdate.Text;
        
      
        gact = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(1, AppTables.Act_Trans_Tab, AppFields.Act_Trans_Fld1a, txtstid.Text,
            "Act_Date", gdate,"string");
        gact = RetrieveFields.retrieveByFieldIndex_HasThreeKeys(1, AppTables.Act_Trans_Tab, AppFields.Act_Fld1a, gact, AppFields.Act_Trans_Fld1a, txtstid.Text, "Act_Date", gdate, "string");
        cmbactname.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Act_Tab, AppFields.Act_Fld1a, gact, "string");
    
      
        txtremarks.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Act_Trans_Tab, AppFields.Act_Trans_Fld1a, txtstid.Text, "string");

        //var cmblt = RetrieveFields.retrieveByFieldIndex_HasOneKey(1,AppTables.LeaveTrans_Tab,AppFields.LeaveTrans_Fld1a, txtstid.Text,"string");
        //cmbleavetype.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1,AppTables.Leave_Tab,AppFields.LeaveTrans_Fld1b,cmblt,"string");
        //txtstart.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, "string");
        //txtend.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, "string");
        //txtdays.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, "string");
        //txtapply.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.LeaveTrans_Tab, AppFields.LeaveTrans_Fld1a, txtstid.Text, "string");
        //   mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.L_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");

    }
   
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_ActivitiesTransactions(txtstid.Text, gact, txtdate.Text, txtremarks.Text);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        txtstid.Text = "";
        txtname.Text = "";
        cmbactname.SelectedItem.Text = "";
        txtdate.Text = "";
        txtremarks.Text = "";
        Image1.ImageUrl = "";


    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Activities_Transactions(txtstid.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        txtstid.Text = "";
        cmbactname.SelectedItem.Text = "";
        txtdate.Text = "";
        txtremarks.Text = "";
        txtname.Text = "";
        Image1.ImageUrl = "";
    }



    protected void cmbactname_SelectedIndexChanged(object sender, EventArgs e)
    {
        gact = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Act_Tab, AppFields.Act_Fld1b, cmbactname.SelectedItem.Text, "string");
    }
    protected void txtdate_TextChanged(object sender, EventArgs e)
    {
        DateTime hn = HR_Report.myconvdate(txtdate.Text);
         txtdate.Text = hn.ToShortDateString();
       
    }
}