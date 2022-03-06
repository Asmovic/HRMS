using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class hrpages_ReportOptionRet : System.Web.UI.Page
{
    private static string code= "";
    private static string dt = "", myret = "";
    private static string myopt = "";
    private static string lengthyr = "";

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
            lblret.Visible = true;
            cmbretyer.Visible = true;
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
        else if (cmbrepoption.SelectedItem.Value=="S")
        {
            lblret.Visible = false;
            cmbretyer.Visible = false;
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
            lblret.Visible = true;
            cmbretyer.Visible = true;
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
            lblret.Visible = true;
            cmbretyer.Visible = true;
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
       
       //Txtname.Text = HR_Report.Return_StaffName(TxtCode.Text);
         myopt = "S";
        code = TxtCode.Text;
        Response.Redirect("~/hrpages/RetirementReport.aspx?option_para=" + myopt + "&keyval=" + code);
       
    //    Response.Redirect("~/hrpages/StaffReport.aspx?option_para=" + myopt + "&keyval=" + code);
    //    dt = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.Stm_Tab, AppFields.Stm_Fld1a, TxtCode.Text, "string");
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {  
        if(myopt == "S")
        {
            Response.Redirect("~/hrpages/RetirementReport.aspx?option_para=" + myopt + "&keyval=" + code);
        }
        else
        {
            Response.Redirect("~/hrpages/RetirementReport.aspx?option_para=" + myopt + "&keyval=" + code + "&keyyear=" + lengthyr);
        }
       
        
    }

    protected void cmbretyer_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DateTime ZeroTime = new DateTime(1, 1, 1);

        //DateTime a = DateTime.ParseExact(dt, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        //DateTime b =  DateTime.Now;
        //TimeSpan span = b - a;
        //int years = (ZeroTime + span).Year - 1;

        //int serv = 35;
        //int rem = serv - years;
        

        if(cmbretyer.SelectedValue == "1")
        {
            myret = "1";
            lengthyr = "1";
        }

        else if (cmbretyer.SelectedItem.Value == "2")
        {
            myret = "2";
            lengthyr = "2";
        }
        else if (cmbretyer.SelectedValue == "3")
        {
            myret = "3";
            lengthyr = "3";
        }
        else if (cmbretyer.SelectedValue == "4")
        {
            myret = "4";
            lengthyr = "4";
        }
        else if (cmbretyer.SelectedValue == "5")
        {
            myret = "5";
            lengthyr = "5";
        }


        //HR_Report.GetRecords_Ret(myopt, code, myret);
        //Response.Redirect("~/hrpages/RetirementReport.aspx?option_para=" + myopt + "&keyval=" + code);


        
            if(myopt != "S")
            {
                Response.Redirect("~/hrpages/RetirementReport.aspx?option_para=" + myopt + "&keyval=" + code + "&keyyear=" + lengthyr);
            }
       
            
        

     

    }



     


}