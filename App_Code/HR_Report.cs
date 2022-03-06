using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
/// <summary>
/// Summary description for HR_Report
/// </summary>
public class HR_Report
{
    private static string stid;
	public HR_Report()
	{
		//
		// TODO: Add constructor logic here
		//
	}




    public static  void GetRecords(string gopt, string gval)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Staff_Temp_Report";
                sqlcmd.ExecuteNonQuery();


                if (gopt == "A" && gval == "A")
                {
                    sqlcmd.CommandText = "Select Staff_id  from staff_master" + " order by Present_Grade_Level DESC, Date_Of_First_Appt DESC";
                   
                }
                else if (gopt == "S" && gval != "")
                {
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where staff_id='" + gval + "'" + " order by Present_Grade_Level DESC, Date_Of_First_Appt DESC";
                   
                   
                }
                else if (gopt == "L" && gval != "")

                {
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where LOCATION='" + gval + "'" + " order by Present_Grade_Level DESC, Date_Of_First_Appt DESC";

                }
                else if (gopt == "D" && gval != "")
                {
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where department='" + gval + "'" + " order by Present_Grade_Level DESC, Date_Of_First_Appt DESC";

                }


                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        Retrievestaff(dr["staff_id"].ToString());
                    }

                }
            }
        }
    }


    private static void Retrievestaff(string mystaff)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select * from Staff_Master where staff_id ='" + mystaff + "'";

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

                        var dept = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, db["Department"].ToString(), "string");
                        var loc = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, db["Location"].ToString(), "string");

                        var sec = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, db["Section"].ToString(), "string");
                        var state = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.STA_Tab, AppFields.STA_Fld1a, db["State_Of_Origin"].ToString(), "string");
                        var lga = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.LGA_Tab, AppFields.LGA_Fld1a, db["LGA_Of_Origin"].ToString(), "string");

                        var Grade = db["Present_Grade_Level"].ToString();
                        var Step = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.StPromotemp_Tab, AppFields.Stm_Fld1a, db["Staff_Id"].ToString(), "string");

                        var stid = db["Staff_Id"].ToString();


                        Insertintostaffrep(stid, myname, loc, dept, sec, Grade, Step, state, lga);
                    }

                }


            }
        }
    }

    private static void Insertintostaffrep(string stid, string myname, string loc, string dept, string sec, string grade,string step, string state, string lga)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Staff_Temp_Report (Staff_Id,Name,Location,Department,Section,Grade,Step,State_Of_Origin,LGA) values ('" + stid + "','" + myname + "','" + loc + "','" + dept + "','" + sec + "','" + grade + "','" + step + "','" + state + "','" + lga + "')";


                sqlcmd.ExecuteNonQuery();

            }
        }

    }

    public static void BindData(ListView ListView1)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from Staff_Temp_Report ";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();

            }
        }
    }



    public static void GetRecords_Ret(string gopt, string gval, string lengthyr)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Retirement_Report";
                sqlcmd.ExecuteNonQuery();


                if (gopt == "A" && gval == "A")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master";
                else if (gopt == "S" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where staff_id='" + gval + "'";
                else if (gopt == "L" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where LOCATION='" + gval + "'";
                else if (gopt == "D" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where department='" + gval + "'";


                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        Retrieve_Ret(dr["staff_id"].ToString(),lengthyr);
                    }

                }
            }
        }
    }


    private static void Retrieve_Ret(string mystaff, string lengthyr)
    {
         string ln="";

        int myage=0;
        int mylenyr=0;
        DateTime mydate, myfrstdate;
        DateTime mydob, mydob1;
                    
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                //sqlcmd.CommandText = "Select Date_of_Birth,Date_of_First_Appt,department,location from Staff_Master where staff_id ='" + mystaff + "'";

                sqlcmd.CommandText = "Select * from Staff_Master where staff_id ='" + mystaff + "'";

                SqlDataReader dq =  sqlcmd.ExecuteReader();
                if (dq.Read())
                {
                    
                    if (DateTime.TryParse( dq["Date_of_Birth"].ToString(),out mydob1))
                    {
                        mydob = mydob1;
                        myage = DateTime.Now.Year - mydob.Year;
                   
                    }
                    
                    if (DateTime.TryParse(dq["Date_of_First_Appt"].ToString(),out mydate))
                    {
                        myfrstdate = mydate;
                        mylenyr = DateTime.Now.Year - myfrstdate.Year;
                    }
                        
                    
                    // DateTime myfrstdate = DateTime.ParseExact(dq["Date_of_First_Appt"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                     var   myname=Return_StaffName(mystaff); 
                                            var dept = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, dq["Department"].ToString(), "string");
                        var loc = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, dq["Location"].ToString(), "string");
                     
                    
                        
                        myage = myage + int.Parse(lengthyr);
                        mylenyr = mylenyr + int.Parse(lengthyr);

                        ln = lengthyr;
                    
                    if (myage >=60 || mylenyr == 35)
                       
                        
                            Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr,ln,dq["Date_of_Birth"].ToString(),dq["Date_of_First_Appt"].ToString());
                        //else if (lengthyr == "2" && (myage >= 58 || mylenyr >= 33))
                        //    Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr, lengthyr);
                        //else if (lengthyr == "3" && (myage >= 57 || mylenyr >= 32))
                        //    Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr, lengthyr);
                        //else if (lengthyr == "4" && (myage >= 56 || mylenyr >= 31))
                        //    Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr, lengthyr);
                        //else if (lengthyr == "5" && (myage >= 55 || mylenyr >= 30))
                        //    Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr, lengthyr);

                }


            }
        }
    }

    private static void Insertintoretrep(string mystaff, string myname, string loc, string dept, int age, int yearsv,string yearlt, string mydob,string dfapp)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Retirement_Report (Staff_Id,Name,Location,Dept,Age,Years_Served,Years_Left,Date_Of_Birth,Date_Of_First_Appt) values ('" + mystaff + "','" + myname + "','" + loc + "','" + dept + "','" + age + "','" + yearsv + "','" + yearlt + "','" + mydob + "','" + dfapp + "')";


                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static void GetRecords_Rets(string gopt, string gval)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Retirement_Report";
                sqlcmd.ExecuteNonQuery();


                if (gopt == "A" && gval == "A")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master";
                else if (gopt == "S" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where staff_id='" + gval + "'";
                else if (gopt == "L" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where LOCATION='" + gval + "'";
                else if (gopt == "D" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where department='" + gval + "'";


                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        Retrieve_Rets(dr["staff_id"].ToString());
                    }

                }
            }
        }
    }


    private static void Retrieve_Rets(string mystaff)
    {
        string ln = "";

        int myage = 0;
        int mylenyr = 0;
        DateTime mydate, myfrstdate;
        DateTime mydob, mydob1;

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                //sqlcmd.CommandText = "Select Date_of_Birth,Date_of_First_Appt,department,location from Staff_Master where staff_id ='" + mystaff + "'";

                sqlcmd.CommandText = "Select * from Staff_Master where staff_id ='" + mystaff + "'";

                SqlDataReader dq = sqlcmd.ExecuteReader();
                if (dq.Read())
                {

                    if (DateTime.TryParse(dq["Date_of_Birth"].ToString(), out mydob1))
                    {
                        mydob = mydob1;
                        myage = DateTime.Now.Year - mydob.Year;

                    }

                    if (DateTime.TryParse(dq["Date_of_First_Appt"].ToString(), out mydate))
                    {
                        myfrstdate = mydate;
                        mylenyr = DateTime.Now.Year - myfrstdate.Year;
                    }


                    // DateTime myfrstdate = DateTime.ParseExact(dq["Date_of_First_Appt"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    var myname = Return_StaffName(mystaff);
                    var dept = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, dq["Department"].ToString(), "string");
                    var loc = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, dq["Location"].ToString(), "string");



                 
                   

                    ln = (35 - mylenyr).ToString();

                    if (myage >= 60 || mylenyr == 35)


                        Insertintoretreps(mystaff, myname, loc, dept, myage, mylenyr, ln, dq["Date_of_Birth"].ToString(), dq["Date_of_First_Appt"].ToString());
                    //else if (lengthyr == "2" && (myage >= 58 || mylenyr >= 33))
                    //    Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr, lengthyr);
                    //else if (lengthyr == "3" && (myage >= 57 || mylenyr >= 32))
                    //    Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr, lengthyr);
                    //else if (lengthyr == "4" && (myage >= 56 || mylenyr >= 31))
                    //    Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr, lengthyr);
                    //else if (lengthyr == "5" && (myage >= 55 || mylenyr >= 30))
                    //    Insertintoretrep(mystaff, myname, loc, dept, myage, mylenyr, lengthyr);

                }


            }
        }
    }

    private static void Insertintoretreps(string mystaff, string myname, string loc, string dept, int age, int yearsv, string yearlt, string mydob, string dfapp)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Retirement_Report (Staff_Id,Name,Location,Dept,Age,Years_Served,Years_Left,Date_Of_Birth,Date_Of_First_Appt) values ('" + mystaff + "','" + myname + "','" + loc + "','" + dept + "','" + age + "','" + yearsv + "','" + yearlt + "','" + mydob + "','" + dfapp + "')";


                sqlcmd.ExecuteNonQuery();

            }
        }
    }

    public static string Return_StaffName (string staffid)
{
     var myname = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, staffid, "string");
                        var myname1 = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, staffid, "string");
                        var myname2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, staffid, "string");
                        myname = myname + " " + myname1 + " " + myname2;
                        return myname;

}

    public static DateTime myconvdate(string mydate)
    {
        DateTime myretdate;
        if (mydate != string.Empty)
        {

            DateTime mn = DateTime.Parse(mydate);
           
            mydate = mn.ToShortDateString();

            if (DateTime.TryParse(mydate, out myretdate))
            {
                
                return myretdate;
            }

            else
            {

                mydate = "01/01/0001";
                DateTime md = DateTime.Parse(mydate);
                mydate = md.ToShortDateString();
                DateTime.TryParse(mydate, out myretdate);

            }
        }
        else
        {
            mydate = "01/01/0001";
            DateTime md = DateTime.Parse(mydate);
            mydate = md.ToShortDateString();
            DateTime.TryParse(mydate, out myretdate);
        }
        
        return myretdate;
     
    }

    public static void GetRecords_Leave(string gopt, string gval)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Leave_Roaster_Temp_Report";
                sqlcmd.ExecuteNonQuery();


                if (gopt == "A" && gval == "A")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master";
                else if (gopt == "S" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where staff_id='" + gval + "'";
                else if (gopt == "L" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where LOCATION='" + gval + "'";
                else if (gopt == "D" && gval != "")
                    sqlcmd.CommandText = "Select Staff_id  from staff_master where department='" + gval + "'";


                using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                {
                    da.SelectCommand = sqlcmd;
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Rows)
                    {
                        RetrieveLeaveRep(dr["staff_id"].ToString());
                    }

                }
            }
        }
    }


    private static void RetrieveLeaveRep(string mystaff)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select * from Leave_Roaster_Details_Temp where staff_id ='" + mystaff + "'";

                using (SqlDataAdapter dq = new SqlDataAdapter(sqlcmd))
                {
                    dq.SelectCommand = sqlcmd;
                    DataTable dt = new DataTable();
                    dq.Fill(dt);
                    foreach (DataRow db in dt.Rows)
                    {
                      var myname =  HR_Report.Return_StaffName(mystaff);

                      var noofdays = RetrieveFields.retrieveByFieldIndex_HasOneKey(4,AppTables.StLeaveDettemp_Tab,AppFields.LeaveRoaster_Fld1a, db["Staff_Id"].ToString(),"string");

                       var startdate = RetrieveFields.retrieveByFieldIndex_HasOneKey(5,AppTables.StLeaveDettemp_Tab,AppFields.LeaveRoaster_Fld1a, db["Staff_Id"].ToString(),"string");

                       var enddate = RetrieveFields.retrieveByFieldIndex_HasOneKey(6,AppTables.StLeaveDettemp_Tab,AppFields.LeaveRoaster_Fld1a, db["Staff_Id"].ToString(),"string");

                       var daysspent = RetrieveFields.retrieveByFieldIndex_HasOneKey(7,AppTables.StLeaveDettemp_Tab,AppFields.LeaveRoaster_Fld1a, db["Staff_Id"].ToString(),"string");

                        var daysleft = RetrieveFields.retrieveByFieldIndex_HasOneKey(8,AppTables.StLeaveDettemp_Tab,AppFields.LeaveRoaster_Fld1a, db["Staff_Id"].ToString(),"string");


                        var stid = db["Staff_Id"].ToString();


                        Insertintolroastrep(stid, myname,noofdays,daysspent,daysleft,startdate,enddate);
                    }

                }


            }
        }
    }

    private static void Insertintolroastrep(string stid, string myname, string days, string dayssp, string dayslt, string stdate, string enddate)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Leave_Roaster_Temp_Report (Staff_Id,Name,No_Of_Days,No_Of_Days_Spent,No_Of_Days_Left,Start_Date,End_Date) values ('" + stid + "','" + myname + "','" + days + "','" + dayssp + "','" + dayslt + "','" + stdate + "','" + enddate + "')";


                sqlcmd.ExecuteNonQuery();

            }
        }

    }

    public static void BindDatalr(ListView ListView1)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from Leave_Roaster_Temp_Report";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();

            }
        }
    }

    public static void BindDataact(ListView ListView1)
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

    public static void BindDataMod(ListView ListView1)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select Act_Code,Act_Name,No_Of_Times from Appr_Modal ";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();

            }
        }
    }

    //public static void GetRecords_Modal(string staffid, DateTime stdate, DateTime enddate)
    //{
        
    //    using (SqlConnection objConn = DBConnection.Connect())
    //    {
    //        using (SqlCommand sqlcmd = new SqlCommand())
    //        {
    //            sqlcmd.Connection = objConn;

    //            sqlcmd.CommandText = "delete from Appr_Modal";
    //            sqlcmd.ExecuteNonQuery();



    //            sqlcmd.CommandText = "Select Staff_id  from Activities_Transaction";

              


    //            using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
    //            {
    //                da.SelectCommand = sqlcmd;
    //                DataTable ds = new DataTable();
    //                da.Fill(ds);
    //                foreach (DataRow dr in ds.Rows)
    //                {
    //                    RetrieveModal(dr["staff_id"].ToString(), stdate,enddate);
    //                }

    //            }
    //        }
    //    }
    //}

   public static void RetrieveModal(string mystaff,DateTime mystartdate, DateTime myenddate)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "delete from Appr_Modal";
                sqlcmd.ExecuteNonQuery();
                sqlcmd.CommandText = "Select Distinct (Act_Code) from Activities_Transaction where staff_id ='" + mystaff + "'" + " and act_date>='" + mystartdate.ToShortDateString() + "'" + "and act_date<='" + myenddate.ToShortDateString() + "'";

                using (SqlDataAdapter dq = new SqlDataAdapter(sqlcmd))
                {
                    dq.SelectCommand = sqlcmd;
                    DataTable dt = new DataTable();
                    dq.Fill(dt);
                    foreach (DataRow db in dt.Rows)
                    {

                        var myactcode = db["act_code"].ToString();
                        Activity_Count(myactcode,mystaff, mystartdate,  myenddate);

                        
                    }

                }


            }
        }
    }



    private static void Activity_Count(string mycode ,string mystaff, DateTime mystartdate, DateTime myenddate)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select count(*) as mytot from Activities_Transaction where staff_id ='" + mystaff + "'" + " and act_code='" + mycode + "'" + " and act_date >= '" + mystartdate.ToShortDateString() + "'" + "and act_date <='" + myenddate.ToShortDateString() + "'";

                int myfig=0;
                SqlDataReader dr =  sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                    myfig= int.Parse(dr["mytot"].ToString());
                }

                var name = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, "Activities", "Act_Code", mycode, "string");
                  Insert(mystaff, mycode, name,myfig);
                    }

                }


            }

    public static int count()
    {
        int count = 0;
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select count(*) as mycount from Staff_Master";
                SqlDataReader dm = sqlcmd.ExecuteReader();

                if (dm.Read())
                {
                    count = int.Parse(dm["mycount"].ToString());
                    count = count + 1;
                }
            }
            return count;
        }

    }

    private static void Insert(string stid, string code, string name, int nooftimes)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;



                sqlcmd.CommandText = "insert into Appr_Modal (Staff_Id,Act_Code,Act_Name,No_Of_Times) values ('" + stid + "','" + code + "','" + name + "','" + nooftimes + "')";


                sqlcmd.ExecuteNonQuery();

            }
        }

    }


}