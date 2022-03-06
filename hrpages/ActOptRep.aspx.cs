using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_ActOptRep : System.Web.UI.Page
{
    private static string code = "";
    private static string gstart="",gend="";
    private static string myopt = "";
  

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
        if (cmbrepoption.SelectedItem.Value == "A")
        {
            lblstdate.Visible = true;
            txtstdate.Visible = true;
            lblenddate.Visible = true;
            txtenddate.Visible = true;
            lblloc.Visible = false;
            cmbloc.Visible = false;
            lbldept.Visible = false;
            cmbdept.Visible = false;
            lblcode.Visible = false;
            TxtCode.Visible = false;
            code = "A";
            myopt = "A";

            //        Response.Redirect("~/hrpages/RetirementReport.aspx?option_para=" + myopt + "&keyval=" + code);
        }
        else if (cmbrepoption.SelectedItem.Value == "S")
        {
            lblstdate.Visible = true;
            txtstdate.Visible = true;
            lblenddate.Visible = true;
            txtenddate.Visible = true;
            lblcode.Visible = true;
            TxtCode.Visible = true;
            lblloc.Visible = false;
            cmbloc.Visible = false;
            lbldept.Visible = false;
            cmbdept.Visible = false;
            myopt = "S";
        }
        else if (cmbrepoption.SelectedItem.Value == "L")
        {
            lblstdate.Visible = true;
            txtstdate.Visible = true;
            lblenddate.Visible = true;
            txtenddate.Visible = true;
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
            lblstdate.Visible = true;
            txtstdate.Visible = true;
            lblenddate.Visible = true;
            txtenddate.Visible = true;
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
        //Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" +code);
    }
    protected void cmddept_SelectedIndexChanged(object sender, EventArgs e)
    {
        code = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, cmbdept.SelectedItem.Text, "string");
        myopt = "D";
        //Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" + code);
    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        
        code = TxtCode.Text;
        myopt = "S";
        //    Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" + code);
   //     dt = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.Stm_Tab, AppFields.Stm_Fld1a, TxtCode.Text, "string");
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        // Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" + code);

         Response.Redirect("~/hrpages/ActivitiesReport.aspx?option_para=" + myopt + "&keyval=" + code + "&keyst=" + gstart + "&keyend=" + gend);
    }

   protected void txtstdate_TextChanged(object sender, EventArgs e)
{
    gstart = txtstdate.Text;
}
   protected void txtenddate_TextChanged(object sender, EventArgs e)
{
   gend = txtenddate.Text;

     
}

        //HR_Report.GetRecords_Ret(myopt, code, myret);
        //Response.Redirect("~/hrpages/RetirementReport.aspx?option_para=" + myopt + "&keyval=" + code);






 
}