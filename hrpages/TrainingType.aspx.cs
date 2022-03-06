using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_TrainingType : System.Web.UI.Page
{
    private static string gtraint;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Traint_Tab, AppFields.Traint_Fld1a, TxtCode.Text, "string");
        gtraint = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Traint_Tab, AppFields.Traint_Fld1a, TxtCode.Text, "string");
        if (gtraint != "" && gtraint == "INT")
            intt.Checked = true;
        else if (gtraint != "" && gtraint == "EXT")
            extt.Checked = true;

        lblsuccess.Text = "";
        lbldanger.Text = "";
    }
    protected void TxtName_TextChanged(object sender, EventArgs e)
    {

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
    protected void submitButton_Click(object sender, EventArgs e)
    {
        if (intt.Checked == false && extt.Checked == false)
        {
            lbldanger.Text = "Pls select Inservice or External Training";
        }

        if (TxtCode.Text != string.Empty && TxtName.Text != string.Empty && gtraint != string.Empty)
        {
            SaveRecord.Save_TrainingType(TxtCode.Text, TxtName.Text, gtraint);
            lblsuccess.Text = "Record Saved Successfully";
            lbldanger.Text = "";
            clear_controls();
        }
       
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {

        SaveRecord.Delete_Training_Type(TxtCode.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        clear_controls();
        

    }

    private void clear_controls()
    {
        TxtCode.Text = "";
        TxtName.Text = "";
        intt.Checked = false;
        extt.Checked = false;
    }
}