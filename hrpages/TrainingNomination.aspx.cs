using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_TrainingNomination : System.Web.UI.Page
{
    private static string nomcode;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            FillCombo.DropDownListItems(1, cmbname, AppTables.Traint_Tab);
    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {

        txtname.Text = HR_Report.Return_StaffName(txtstid.Text);

        var mloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(12, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtoloc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, mloc, "string");
        var mdept = RetrieveFields.retrieveByFieldIndex_HasOneKey(13, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtodept.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, mdept, "string");
        var msec = RetrieveFields.retrieveByFieldIndex_HasOneKey(14, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtosec.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, msec, "string");

        string ky = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.Trainnom_Tab, AppFields.Trainnom_Fld1a, txtstid.Text, "string");
        if(ky != string.Empty)
        { 
        DateTime df = HR_Report.myconvdate(ky);
        traindate.Text = df.ToShortDateString();
        }
        else
        {
            traindate.Text = "";
        }
        traindur.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.Trainnom_Tab, AppFields.Trainnom_Fld1a, txtstid.Text, "string");
        orgname.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.Trainnom_Tab, AppFields.Trainnom_Fld1a, txtstid.Text, "string");
        orgadd.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.Trainnom_Tab, AppFields.Trainnom_Fld1a, txtstid.Text, "string");
        nomcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.Trainnom_Tab, AppFields.Trainnom_Fld1a, txtstid.Text, "string");
        cmbname.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Traint_Tab, AppFields.Traint_Fld1a, nomcode, "string");

        Image1.ImageUrl = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
    }
    protected void txtoloc_TextChanged(object sender, EventArgs e)
    {

    }
    protected void submitButton_Click(object sender, EventArgs e)
    {

        SaveRecord.Save_TrainingNomination(txtstid.Text, txtoloc.Text, txtodept.Text, txtosec.Text, nomcode, traindate.Text, traindur.Text, orgname.Text,orgadd.Text);
        lbldanger.Text = "";
        lblsuccess.Text = "Record Saved Successfully";
        clear_controls();
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Training_Nomination(txtstid.Text);
        lblsuccess.Text = "";
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        clear_controls();
    }
    protected void txtodept_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtosec_TextChanged(object sender, EventArgs e)
    {

    }
    protected void cmbname_SelectedIndexChanged(object sender, EventArgs e)
    {
        nomcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Traint_Tab, AppFields.Traint_Fld1b, cmbname.SelectedItem.Text, "string");
    }
    protected void traindate_TextChanged(object sender, EventArgs e)
    {
        DateTime df = HR_Report.myconvdate(traindate.Text);
        traindate.Text = df.ToShortDateString();
    }

    private void clear_controls()
    {
        txtstid.Text = "";
        traindate.Text = "";
        cmbname.SelectedItem.Text = "";
        traindur.Text = "";
        orgname.Text = "";
        orgadd.Text = "";
        Image1.ImageUrl = "";
        txtname.Text = "";
        txtoloc.Text = "";
        txtodept.Text = "";
        txtosec.Text = "";
    }
}