using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_EmploymentHistory : System.Web.UI.Page
{
    private static string gpost,msur,mfst,mlast;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbposition, AppTables.Desig_Tab);
        }
    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        msur = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        mfst = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtname.Text = msur + " " + mfst + " " + mlast;

        gpost = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Emphis_Tab, AppFields.Emphis_Fld1a, txtstid.Text, "string");
        cmbposition.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Desig_Tab, AppFields.Desig_Fld1a, gpost, "string");

        txtorg.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Emphis_Tab, AppFields.Emphis_Fld1a, txtstid.Text, "string");
       txtstarty.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Emphis_Tab, AppFields.Emphis_Fld1a, txtstid.Text, "string");

       

        txtendy.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.Emphis_Tab, AppFields.Emphis_Fld1a, txtstid.Text, "string");
        
        txtstsal.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.Emphis_Tab, AppFields.Emphis_Fld1a, txtstid.Text, "string");
        txtendsal.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.Emphis_Tab, AppFields.Emphis_Fld1a, txtstid.Text, "string");
        txtreason.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.Emphis_Tab, AppFields.Emphis_Fld1a, txtstid.Text, "string");
        txtcontact.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.Emphis_Tab, AppFields.Emphis_Fld1a, txtstid.Text, "string");

        Image1.ImageUrl = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");


    }
    protected void cmbposition_SelectedIndexChanged(object sender, EventArgs e)
    {
        gpost = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Desig_Tab, AppFields.Desig_Fld1b,cmbposition.SelectedItem.Text, "string");
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_EmploymentHistory(txtstid.Text, txtorg.Text, gpost,txtstarty.Text,txtendy.Text,txtstsal.Text,txtendsal.Text,txtreason.Text,txtcontact.Text);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        clear_controls();
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Employment_History(txtstid.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        clear_controls();
 
    }


    private void clear_controls()
    {
        txtstid.Text = "";
        txtorg.Text = "";
        cmbposition.SelectedItem.Text = "";
        txtstarty.Text = "";
        txtendy.Text = "";
        txtstsal.Text = "";
        txtendsal.Text = "";
        txtreason.Text = "";
        txtcontact.Text = "";
        txtname.Text = "";
        Image1.ImageUrl = "";

        
    }

}