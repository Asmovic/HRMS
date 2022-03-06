using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hrpages_StaffReport : System.Web.UI.Page
{
    private static string gopt,gval,stid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack )
        {
            if (Request.QueryString["option_para"] != null && Request.QueryString["keyval"] != null )
            {
                gopt = Request.QueryString["option_para"];
                gval = Request.QueryString["keyval"];
               
            }
         
        }
         

        
        HR_Report.GetRecords(gopt,gval);
        HR_Report.BindData(ListView1);
        if (gval == "A")
        {
            mm.Visible = false;
            mn.Visible = true;
            lblsel.Text = "ALL";
        }
        else if ( gopt == "S")
        {
            mn.Visible = false;
            mm.Visible = true;
           lblsell.Text = HR_Report.Return_StaffName(gval);

        }
        else if (gopt == "L")
        {
            mm.Visible = false;
            mn.Visible = true;
            lblsel.Text = Return_Loc(gval);

        }

        else if (gopt == "D")
        {
            mm.Visible = false;
            mn.Visible = true;
            lblsel.Text = Return_Dept(gval);

        }
           
    }
    


    
    protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    public static string Return_Loc(string loc)
    {
        var myloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, loc, "string");
        return myloc;

    }

    public static string Return_Dept(string dept)
    {
        var mydept = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, dept, "string");
        return mydept;

    }

}