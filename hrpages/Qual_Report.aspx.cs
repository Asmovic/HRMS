using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class hrpages_Qual_Report : System.Web.UI.Page
{
    //private string myqualcode,qt;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Request.QueryString["Qual_Code"] != "")
        //{
        //    myqualcode = Request.QueryString["Qual_Code"];
        //}

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

                sqlcmd.CommandText = "delete from qualification_temp_report";
                sqlcmd.ExecuteNonQuery();


                sqlcmd.CommandText = "Select Staff_id  from staff_master";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        Retrievequal(dr["staff_id"].ToString());
                    }
                   // ListView1.DataSource = ds;
                   // ListView1.DataBind();
                }
            }
        }
    }


    


    protected void Retrievequal(string mystaff)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select * from Qualification_Transaction where staff_id ='" + mystaff + "'";
                
                using (SqlDataAdapter dq = new SqlDataAdapter(sqlcmd))
                {
                    dq.SelectCommand = sqlcmd;
                    DataTable dt = new DataTable();
                    dq.Fill(dt);
                    foreach (DataRow db  in dt.Rows)
                    {

                        var myname = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        var myname1 = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        var myname2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystaff, "string");
                        myname1 =  myname1 + " " + myname2;
                        var myqul = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Qual_Tab, AppFields.Qual_Fld1a, db["qual_code"].ToString(), "string");
                        var myfield = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.FS_Tab, AppFields.FS_Fld1a, db["fs_code"].ToString(), "string");
                        var myyear = db["year_obtained"].ToString();
                         Insertintoqualrep(mystaff,myname,myname1,myqul,myfield,myyear);
                    }
                   // ListView1.DataSource = ds;
                   // ListView1.DataBind();
                }
                
                
            }
        }
    }

    
    
    private void Insertintoqualrep(string mystaff, string myname, string myname1,string myqul, string myfield, string myyear)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into qualification_temp_report (staff_id,staff_surname,staff_othernames,qualification,field_of_study,year_obtained)values ('"+ mystaff +"', '"+myname+"','"+myname1+"','"+myqul+"','"+myfield+"','"+myyear+"')";


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
                sqlcmd.CommandText = "select * from qualification_temp_report ";
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

    protected void txta_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void txtp_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {

    }
   
}