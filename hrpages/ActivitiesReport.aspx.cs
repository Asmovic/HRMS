using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class hrpages_ActivitiesReport : System.Web.UI.Page
{
    private static string gopt, gval, gstart, gend,loc,dept,stid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["option_para"] != null && Request.QueryString["keyval"] != null && Request.QueryString["keyst"] != null
                 && Request.QueryString["keyend"] != null)
            {
                gopt = Request.QueryString["option_para"];
                gval = Request.QueryString["keyval"];
                gstart = Request.QueryString["keyst"];
                gend = Request.QueryString["keyend"];
            }
        }


        GetRecords();
        BindData();

    }
    protected void GetRecords()
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Activities_Report";
                sqlcmd.ExecuteNonQuery();

                if (gopt == "A" && gval == "A")
                {
                    sqlcmd.CommandText = "Select Staff_Id from Staff_Master";
                    lblall.Text = "Report for all Staff between " + gstart.ToString() + " and " + gend.ToString() + ".";
                }
                else if (gopt == "L" && gval != "")
                {
                    sqlcmd.CommandText = "Select Staff_Id from Staff_Master where Location = '" + gval + "'";
                    loc = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, gval, "string");
                    lblloc.Text = "Report for " + loc + " between " + gstart.ToString() + " and " + gend.ToString()+".";
                         }
                else if (gopt == "D" && gval != "")
                {
                    sqlcmd.CommandText = "Select Staff_Id from Staff_Master where Department = '" + gval + "'";
                    dept = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, gval, "string");
                    lbldept.Text = "Report for Department of " + dept + " between " + gstart.ToString() + " and " + gend.ToString() + ".";
                }
                else if (gopt == "S" && gval !="")
                { 
                    sqlcmd.CommandText = "Select Staff_Id from Staff_Master where Staff_Id = '" +gval+ "'";
                    stid = HR_Report.Return_StaffName(gval);
                    lblstid.Text = "Report for " + stid + " between " + gstart.ToString() + " and " + gend.ToString() + ".";
                }

             //   sqlcmd.CommandText = "Select Staff_id  from staff_master";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        Retrieveact(dr["staff_id"].ToString(),gstart,gend);
                    }
                    // ListView1.DataSource = ds;
                    // ListView1.DataBind();
                }
            }
        }
    }





    protected void Retrieveact(string mystaff,string gstart,string gend)
    {

        DateTime mydate,stdate,enddate;

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select * from Activities_Transaction where staff_id ='" + mystaff + "'";

                //using (SqlDataAdapter dq = new SqlDataAdapter(sqlcmd))
                //{
                //    dq.SelectCommand = sqlcmd;
                //    DataTable dt = new DataTable();
                //    dq.Fill(dt);
                //    foreach (DataRow db in dt.Rows)
                //    {
                
                SqlDataReader dq =  sqlcmd.ExecuteReader();
                if (dq.Read())
                {
                    DateTime.TryParse( dq["Act_Date"].ToString(),out mydate);

                        DateTime.TryParse(gstart.ToString(), out stdate);

                        DateTime.TryParse(gend.ToString(), out enddate);

                        var myname = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        var myname1 = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        var myname2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        myname = myname + " " + myname1 + " " + myname2;

                        var actcode = dq["Act_Code"].ToString();
                        var actname = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Act_Tab, AppFields.Act_Fld1a,actcode, "string");
                        var actdate = dq["Act_Date"].ToString();
                        var actrem = dq["Act_Remark"].ToString();
                        var stid = dq["Staff_Id"].ToString();
                       
                      if(mydate >= stdate && mydate <= enddate)
                      //if(mydate2 between stadate && enddate2)

                        Insertintoactrep(stid,myname,actname,actdate,actrem);
                    }
                    // ListView1.DataSource = ds;
                    // ListView1.DataBind();
                


            }
        }
    }



    private void Insertintoactrep(string stid, string myname, string actcode, string actdate, string actrem)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Activities_Report (Staff_Id,Staff_Name,Act_Name,Act_Date,Remark) values ('" + stid + "', '" + myname + "','" + actcode + "','" + actdate + "','" + actrem + "')";


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
                sqlcmd.CommandText = "select * from Activities_Report ";
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

}