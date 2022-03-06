using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_Grade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Grade_Tab, AppFields.Grade_Fld1a, TxtCode.Text, "string");
        TxtLeave.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Grade_Tab, AppFields.Grade_Fld1a, TxtCode.Text, "string");
        lblsuccess.Text = "";
        lbldanger.Text = "";
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_Grade(TxtCode.Text, TxtName.Text,TxtLeave.Text);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        TxtCode.Text = "";
        TxtName.Text = "";
        TxtLeave.Text = "";
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Grade(TxtCode.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        TxtCode.Text = "";
        TxtName.Text = "";
        TxtLeave.Text = "";
    }
}