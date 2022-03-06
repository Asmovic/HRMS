using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_Role : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
           

    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.ROL_Tab, AppFields.ROL_Fld1a, TxtCode.Text, "string");
        txtver.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.ROL_Tab, AppFields.ROL_Fld1a, TxtCode.Text, "string");
        lbldanger.Text = "";
        lblsuccess.Text = "";
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_Role(TxtCode.Text, TxtName.Text,txtver.Text);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        TxtCode.Text = "";
        TxtName.Text = "";
        txtver.Text = "";
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Role(TxtCode.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        TxtCode.Text = "";
        TxtName.Text = "";
        txtver.Text = "";
    }
}