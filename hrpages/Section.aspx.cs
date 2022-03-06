using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_Section : System.Web.UI.Page
{
    private static string gcode;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillCombo.DropDownListItems(1, cmbdept,AppTables.Dept_Tab);

    }
    protected void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
    {
        gcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, cmbdept.SelectedItem.Text, "string");
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        if(TxtCode.Text != string.Empty && TxtName.Text != string.Empty && gcode != string.Empty)
        {
        
        SaveRecord.Save_Section(gcode, TxtCode.Text, TxtName.Text);
        TxtCode.Text = "";
        TxtName.Text = "";
        cmbdept.SelectedIndex = -1;
        lbldanger.Text = "";
        lblsuccess.Text = "Record Saved Successfully";
        }
        else
        {
            lbldanger.Text = "Pls make sure you select a Department!!!";
        }
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Section(TxtCode.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        TxtCode.Text = "";
        TxtName.Text = "";
        cmbdept.SelectedItem.Text = "";
    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        //TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(2, AppTables.Sec_Tab, AppFields.Dept_Fld1a, gcode, AppFields.Sec_Fld1a, TxtCode.Text, "string");
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, TxtCode.Text, "string");
        
        gcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Sec_Tab, AppFields.Sec_Fld1a, TxtCode.Text, "string");
        cmbdept.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, gcode, "string");
        lbldanger.Text = "";
        lblsuccess.Text = "";
    }
   
}