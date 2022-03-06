using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_TrainingTransaction : System.Web.UI.Page
{
    private static string gtraint,gcmbn,kj;
    protected void Page_Load(object sender, EventArgs e)
    {
           if (!IsPostBack)

            FillCombo.DropDownListItems(1, cmbname, AppTables.Traint_Tab);
      
    }
    
    protected void cmbname_SelectedIndexChanged(object sender, EventArgs e)
    {
        gcmbn = RetrieveFields.retrieveByFieldIndex_HasOneKey(0,AppTables.Traint_Tab,AppFields.Traint_Fld1b,cmbname.SelectedItem.Text,"string");
    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        kj = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Traintrans_Tab, AppFields.Traintrans_Fld1a, txtstid.Text, "string");
        if (kj != string.Empty)
        {
            DateTime ol = HR_Report.myconvdate(kj);
            traindate.Text = ol.ToShortDateString();
        }
        else
        {
            traindate.Text = "";
        }

        traindur.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.Traintrans_Tab, AppFields.Traintrans_Fld1a, txtstid.Text, "string");
        trainins.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.Traintrans_Tab, AppFields.Traintrans_Fld1a, txtstid.Text, "string");
        certob.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.Traintrans_Tab, AppFields.Traintrans_Fld1a, txtstid.Text, "string");
        gcmbn = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Traintrans_Tab, AppFields.Traintrans_Fld1a, txtstid.Text, "string");
        cmbname.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Traint_Tab, AppFields.Traint_Fld1a, gcmbn, "string");
        gtraint = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Traintrans_Tab, AppFields.Traintrans_Fld1a, txtstid.Text, "string");
        if (gtraint != "" && gtraint == "INT")
            intt.Checked = true;
        else if (gtraint != "" && gtraint == "EXT")
            extt.Checked = true;

        Image1.ImageUrl = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
    }
    protected void intt_CheckedChanged(object sender, EventArgs e)
    {
        if (intt.Checked == true)
        {
            extt.Checked = false;
            gtraint = "INT";
        }
    }
    protected void extt_CheckedChanged(object sender, EventArgs e)
    {
        if (extt.Checked == true)
        {
            intt.Checked = false;
            gtraint = "EXT";
        }
    }
    protected void traindate_TextChanged(object sender, EventArgs e)
    {

    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
       
            SaveRecord.Save_TrainingTransaction(txtstid.Text,gtraint,gcmbn, traindate.Text,traindur.Text,trainins.Text,certob.Text);
            lblsuccess.Text = "Record Saved Successfully";
            lbldanger.Text = "";
            clear_controls();
        
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {

        SaveRecord.Delete_Training_Transaction(txtstid.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        clear_controls();
    }
    private void clear_controls()
    {
        txtstid.Text = "";
        traindate.Text = "";
        cmbname.SelectedItem.Text = "";
        traindur.Text = "";
        trainins.Text = "";
        certob.Text = "";
        intt.Checked = false;
        extt.Checked = false;
    }
}