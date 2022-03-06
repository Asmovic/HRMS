using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_Qualification : System.Web.UI.Page
{
    private static string qualt;
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Qual_Tab, AppFields.Qual_Fld1a, TxtCode.Text, "string");
        qualt = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Qual_Tab, AppFields.Qual_Fld1a, TxtCode.Text, "string");
        if (qualt != "" && qualt == "A")
            txta.Checked = true;
        else if (qualt != "" && qualt == "P")
            txtp.Checked = true;

        lblsuccess.Text = "";
        lbldanger.Text = "";
    }

    protected void txta_CheckedChanged(object sender, EventArgs e)
    {
        if (txta.Checked == true)
        {
            txtp.Checked = false;
            qualt = "A";
        }
    }
    protected void txtp_CheckedChanged(object sender, EventArgs e)
    {
        if (txtp.Checked == true)
        {
            txta.Checked = false;
            qualt = "P";


        }
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_Qualification(TxtCode.Text, TxtName.Text,qualt);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        TxtCode.Text = "";
        TxtName.Text = "";
        txta.Checked = false;
        txtp.Checked = false;
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Qualification(TxtCode.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        TxtCode.Text = "";
        TxtName.Text = "";
        txta.Checked = false;
        txtp.Checked = false;
    }
   
}