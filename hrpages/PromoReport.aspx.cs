using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hrpages_PromoReport : System.Web.UI.Page
{
    private static string gopt, gval,loc,dept,stid;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            if (Request.QueryString["option_para"] != null && Request.QueryString["keyval"] != null)
            {
                gopt = Request.QueryString["option_para"];
                gval = Request.QueryString["keyval"];

            }
        }

        GetRecords(gopt,gval);
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
    protected void GetRecords(string gopt,string gval)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Promo_Temp_Report";
                sqlcmd.ExecuteNonQuery();


                if (gopt == "A" && gval == "A")
                {
                    sqlcmd.CommandText = "Select Staff_id  from staff_master";
                    lblall.Text = "Report for all Staff.";
                }
                else if (gopt == "S" && gval != "")
                {
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where staff_id='" + gval + "'";
                    stid = HR_Report.Return_StaffName(gval);
                    lblstid.Text = "Report for " + stid + ".";

                }
                else if (gopt == "L" && gval != "")
                {
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where LOCATION='" + gval + "'";
                    loc = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, gval, "string");
                    lblloc.Text = "Report for " + loc + ".";

                }
                else if (gopt == "D" && gval != "")
                { 
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where department='" + gval + "'";
                    dept = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, gval, "string");
                    lbldept.Text = "Report for Department of " + dept + ".";
                }

        //        sqlcmd.CommandText = "Select Staff_id  from staff_master";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        Retrievepromo(dr["staff_id"].ToString());
                    }
                    // ListView1.DataSource = ds;
                    // ListView1.DataBind();
                }
            }
        }
    }





    protected void Retrievepromo(string mystaff)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select * from Staff_Promotion_Details_Temp where staff_id ='" + mystaff + "'";

                using (SqlDataAdapter dq = new SqlDataAdapter(sqlcmd))
                {
                    dq.SelectCommand = sqlcmd;
                    DataTable dt = new DataTable();
                    dq.Fill(dt);
                    foreach (DataRow db in dt.Rows)
                    {

                      var myname =  HR_Report.Return_StaffName(mystaff);

                      
                        var sno = db["S_No"].ToString();
                        var yopromo = db["Promo_Year"].ToString();
                        var stid = db["Staff_Id"].ToString();
                        var prgrade = db["Old_Grade"].ToString();
                        var ngrade = db["New_Grade"].ToString();
                        var nstep = db["New_Step"].ToString();
                        var date = db["Promo_Date"].ToString();
                        
                        Insertintopromorep(sno,yopromo,stid,myname,prgrade,ngrade,nstep,date);
                    }
                    // ListView1.DataSource = ds;
                    // ListView1.DataBind();
                }


            }
        }
    }



    private void Insertintopromorep(string sno, string yopromo, string stid, string myname, string prgrade, string ngrade, string nstep, string date)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Promo_Temp_Report (S_No,Promo_Year,Staff_Id,Staff_Name,Old_Grade,New_Grade,New_Step,Promo_Date) values ('" + sno + "','" + yopromo + "','" + stid + "','" + myname + "','" + prgrade + "','" + ngrade + "','" + nstep + "','" + date + "')";


                sqlcmd.ExecuteNonQuery();

            }
        }

    }


    private void BindData()
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from Promo_Temp_Report ";
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