using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hrpages_ReportOption : System.Web.UI.Page
{
    private string code="";
    private string myopt = "";
    protected void Page_Load(object sender, EventArgs e)
    {
    
        if (!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbloc, AppTables.Loc_Tab);
            FillCombo.DropDownListItems(1, cmbdept, AppTables.Dept_Tab);
        }

    }
    

    
   
    
    protected void cmbrepoption_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbrepoption.SelectedItem.Value=="A")
        {
            code = "A";
            myopt = "A";
           Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" + code);
        }
        else if (cmbrepoption.SelectedItem.Value=="S")
        {
            lblcode.Visible = true;
            TxtCode.Visible = true;
            lblloc.Visible = false;
            cmbloc.Visible = false;
            lbldept.Visible = false;
            cmbdept.Visible = false;
            myopt = "S";
        }
        else if (cmbrepoption.SelectedItem.Value=="L")
        {
            lblcode.Visible = false;
            TxtCode.Visible = false;
            lblloc.Visible = true;
            cmbloc.Visible = true;
            lbldept.Visible = false;
            cmbdept.Visible = false;
            myopt = "L";
        }
        else if (cmbrepoption.SelectedItem.Value == "D")
        {
            lblcode.Visible = false;
            TxtCode.Visible = false;
            lbldept.Visible = true;
            cmbdept.Visible = true;
            lblloc.Visible = false;
            cmbloc.Visible = false;
            myopt = "D";
        }



    }
    protected void cmbloc_SelectedIndexChanged(object sender, EventArgs e)
    {
        code = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Loc_Tab, AppFields.Loc_Fld1b, cmbloc.SelectedItem.Text, "string");
        myopt = "L";
        Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" +code);
    }
    protected void cmddept_SelectedIndexChanged(object sender, EventArgs e)
    {
        code = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, cmbdept.SelectedItem.Text, "string");
        myopt = "D";
        Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" + code);
    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
       var msur = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, TxtCode.Text, "string");
       var mfst = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, TxtCode.Text, "string");
       var mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, TxtCode.Text, "string");
    //    Txtname.Text = msur + " " + mfst + " " + mlast;
        code = TxtCode.Text;
        myopt = "S";
        Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" + code);
       
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" + code);
    }
}