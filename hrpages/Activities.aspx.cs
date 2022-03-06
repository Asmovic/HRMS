using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_Activities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Act_Tab, AppFields.Act_Fld1a, TxtCode.Text, "string");
        lblsuccess.Text = "";
        lbldanger.Text = "";
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_Act(TxtCode.Text, TxtName.Text);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        TxtCode.Text = "";
        TxtName.Text = "";
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Act(TxtCode.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        TxtCode.Text = "";
        TxtName.Text = "";
    }

}