using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hrpages_TransferReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

                sqlcmd.CommandText = "delete from Transfer_Temp_Report";
                sqlcmd.ExecuteNonQuery();


                sqlcmd.CommandText = "Select Staff_id  from staff_master";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        Retrievetrans(dr["staff_id"].ToString());
                    }
                    // ListView1.DataSource = ds;
                    // ListView1.DataBind();
                }
            }
        }
    }





    protected void Retrievetrans(string mystaff)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select * from Transfer_Roaster_Details_Temp where staff_id ='" + mystaff + "'";

                using (SqlDataAdapter dq = new SqlDataAdapter(sqlcmd))
                {
                    dq.SelectCommand = sqlcmd;
                    DataTable dt = new DataTable();
                    dq.Fill(dt);
                    foreach (DataRow db in dt.Rows)
                    {

                        var myname = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        var myname1 = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        var myname2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        myname = myname + " " + myname1 + " " + myname2;

                        var orgloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, db["Original_Loc"].ToString(), "string");
                        var orgdept = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, db["Original_Dept"].ToString(), "string");
                        var orgsec = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, db["Original_Section"].ToString(), "string");
                        var destloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, db["Dest_Loc"].ToString(), "string");
                        var destdept = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, db["Dest_Dept"].ToString(), "string");
                        var destsec = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, db["Dest_Sec"].ToString(), "string");
                        var date = db["Trans_Date"].ToString();
                        var treason = db["Trans_Reason"].ToString();
                        Insertintotransrep(mystaff, myname, orgloc,orgdept,orgsec,destloc,destdept,destsec, date, treason);
                    }
                    // ListView1.DataSource = ds;
                    // ListView1.DataBind();
                }


            }
        }
    }



    private void Insertintotransrep(string mystaff, string myname, string orgloc, string orgdept, string orgsec,string destloc,string destdept,string destsec,string date,string treason )
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Transfer_Temp_Report (staff_id,Name,Original_Loc,Original_Dept,Original_Sec,Dest_Loc,Dest_Dept,Dest_Sec,Trans_Date,Trans_Reason) values ('" + mystaff + "', '" + myname + "','" + orgloc + "','" + orgdept + "','" + orgsec + "','" + destloc + "','" + destdept + "','" + destsec + "','" + date + "','"+ treason + "')";


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
                sqlcmd.CommandText = "select * from Transfer_Temp_Report ";
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