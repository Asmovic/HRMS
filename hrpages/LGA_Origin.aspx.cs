using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_LGA_Origin : System.Web.UI.Page
{
    private static string gcode;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillCombo.DropDownListItems(1, cmbstate, AppTables.STA_Tab);
             
    }
    protected void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        gcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.STA_Tab, AppFields.STA_Fld1b, cmbstate.SelectedItem.Text, "string");
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        if (TxtCode.Text != string.Empty && TxtName.Text != string.Empty && gcode != string.Empty)
        { 
        SaveRecord.Save_LGA(gcode, TxtCode.Text, TxtName.Text);
        TxtCode.Text = "";
        TxtName.Text = "";
        cmbstate.SelectedIndex = -1;
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        }
        else
        {
            lbldanger.Text = "Pls select a State!!!";
        }
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_LGA(TxtCode.Text);
        lblsuccess.Text = "";
        cmbstate.SelectedIndex = -1;
        cmbstate.SelectedItem.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        TxtCode.Text = "";
        TxtName.Text = "";
        
    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        //TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(2, AppTables.LGA_Tab, AppFields.STA_Fld1a, gcode,AppFields.LGA_Fld1a,TxtCode.Text, "string");

        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.LGA_Tab, AppFields.LGA_Fld1a, TxtCode.Text, "string");
        gcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.LGA_Tab, AppFields.LGA_Fld1a, TxtCode.Text, "string");
             cmbstate.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.STA_Tab, AppFields.STA_Fld1a, gcode, "string");

             lbldanger.Text = "";
             lblsuccess.Text = "";
    }
    protected void TxtName_TextChanged(object sender, EventArgs e)
    {

    }
}