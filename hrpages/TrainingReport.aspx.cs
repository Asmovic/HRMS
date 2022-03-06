using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hrpages_TrainingReport : System.Web.UI.Page
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

                sqlcmd.CommandText = "delete from Training_Temp_Report";
                sqlcmd.ExecuteNonQuery();


                sqlcmd.CommandText = "Select Staff_id  from staff_master";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        Retrievetrain(dr["staff_id"].ToString());
                    }
                    // ListView1.DataSource = ds;
                    // ListView1.DataBind();
                }
            }
        }
    }





    protected void Retrievetrain(string mystaff)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select * from TrTrans_Roaster_Details_Temp where staff_id ='" + mystaff + "'";

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
                        myname = myname +" "+ myname1 + " " + myname2;
                        var mytrname = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Traint_Tab, AppFields.Traint_Fld1a, db["Training_Code"].ToString(), "string");
                        var insname = db["Institution_Of_Training"].ToString();
                        var certob = db["Certificate_Obtained"].ToString();
                        var duration = db["Duration"].ToString();
                        var date = db["Training_Date"].ToString();
                        Insertintotrainrep(mystaff, myname, mytrname, insname,certob,duration, date);
                    }
                    // ListView1.DataSource = ds;
                    // ListView1.DataBind();
                }


            }
        }
    }



    private void Insertintotrainrep(string mystaff, string myname, string mytrname, string insname, string certob, string duration, string date)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Training_Temp_Report (staff_id,Name,Training_Name,Institution_Name,Certificate_Obtained,Duration,Date)values ('" + mystaff + "', '" + myname + "','" + mytrname + "','" + insname + "','" + certob + "','" + duration + "','"+date+"')";


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
                sqlcmd.CommandText = "select * from Training_Temp_Report ";
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