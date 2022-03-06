using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hrpages_RetirementReport : System.Web.UI.Page
{
    private static string gopt, gval, lengthyr, gyear;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

           
          
                if (Request.QueryString["option_para"] != null && Request.QueryString["keyval"] != null && Request.QueryString["keyyear"] != null)
                {
                    gopt = Request.QueryString["option_para"];
                    gval = Request.QueryString["keyval"];
                    lengthyr = Request.QueryString["keyyear"];
                }
                
                if (Request.QueryString["option_para"] != null && Request.QueryString["keyval"] != null)
                {
                    gopt = Request.QueryString["option_para"];
                    gval = Request.QueryString["keyval"];

                }
            

        }
          if(gopt == "S")
          {
              HR_Report.GetRecords_Rets(gopt, gval);
          }
        else
          {
              HR_Report.GetRecords_Ret(gopt, gval, lengthyr);
          }
        
        BindData();
        if (gval == "A")
        {
            mm.Visible = false;
            mn.Visible = true;
            lblsel.Text = "ALL";
        }
        else if (gopt == "S")
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
   

    private void BindData()
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from Retirement_Report ";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();

            }
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