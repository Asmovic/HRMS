using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_LeaveType : System.Web.UI.Page
{
    private static string mdeduct="";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Leave_Tab, AppFields.Leave_Fld1a, TxtCode.Text, "string");
        mdeduct = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Leave_Tab, AppFields.Leave_Fld1a, TxtCode.Text, "string");
        if (mdeduct != "" && mdeduct == "Y")
            chyes.Checked = true;
        else if (mdeduct != "" && mdeduct == "N")
            chno.Checked = true;

        lblsuccess.Text = "";
        lbldanger.Text = "";
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
       if (TxtCode.Text!=string.Empty && TxtName.Text!=string.Empty &&mdeduct!=string.Empty)
       {
           SaveRecord.Save_LeaveType(TxtCode.Text, TxtName.Text, mdeduct);
           lblsuccess.Text = "Record Saved Successfully";
           lbldanger.Text = "";
           clear_controls();
       }
        
        
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Leave_Type(TxtCode.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        clear_controls();
        
    }

    protected void chno_CheckedChanged(object sender, EventArgs e)
    {
        if (chno.Checked == true)
        {
            chyes.Checked = false;
            mdeduct = "N";
        }
            

    }
    protected void chyes_CheckedChanged(object sender, EventArgs e)
    {
        if (chyes.Checked == true)
        { 
            chno.Checked = false;
             mdeduct = "Y";
        }
    }

    private void clear_controls()
    {
        TxtCode.Text = "";
        TxtName.Text = "";
        chyes.Checked = false;
        chno.Checked = false;
    }
}