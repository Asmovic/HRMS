using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web;

/// <summary>
/// Summary description for GeneralLedger_Create
/// </summary>
public class SaveRecord
{
    public static string result;
	public SaveRecord()
	{
		//
		// TODO: Add constructor logic here
		//
	}





    public static string Save_State(string mycode, string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mcode", mycode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mname", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                
                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_State";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_State(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from State where State_Code='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Role(string mycode, string myname, string myver)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mcode", mycode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mname", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mver", myver);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Role";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Role(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Role where Role_Code='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Field(string mycode, string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mcode", mycode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mname", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Field";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Field(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Field_Of_Study where FS_Code='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Dept(string mycode, string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mcode", mycode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mname", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Dept";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Dept(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Dept where Dept_Code='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Appr_Subj(string sno,string mycode, string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];


                objParam[0] = new SqlParameter("@msno", sno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mcode", mycode);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mname", myname);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Appr_Subj";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Appr_Subj(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Appraisal_Subject where APPR_SUBJ_CODE ='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Act(string mycode, string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mcode", mycode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mname", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Act";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Act(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Activities where Act_Code='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }

    public static string Save_LGA(string mystcode, string mylgcode,string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mcode", mystcode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mname", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mlga", mylgcode);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;



                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_LG";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }

    public static void Delete_LGA(string mylgcode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from LGA where LGA_Code='" + mylgcode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }

    public static string Save_Section(string mydeptcode, string myseccode, string mysecname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mdeptcode", mydeptcode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@msecname", mysecname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mseccode", myseccode);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;



                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Section";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }

    public static void Delete_Section(string myseccode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Section where Section_Code='" + myseccode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Designation(string mydescode, string mydesname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mdescode", mydescode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mdesname", mydesname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Designation";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Designation(string mydescode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Designation where Desig_Code='" + mydescode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_StaffMaster(string stid, string surn, string fn, string ln, string gen, string marst, string dob, string soo, string lgo, string dfa, string lfa, string depfa, string loc, string dept, string sect, string desig, string glfa, string pgl, string stadd, string email, string tell, string nokn, string nokrel, string nokemail, string nokadd, string noktell, string highq, string yob, string pfac, string pfan, string tribe,string filepath )
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[32];

                objParam[0] = new SqlParameter("@mstid", stid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@msurn", surn);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mfn", fn);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mln", ln);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mgen", gen);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mmarst", marst);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mdob", dob); 
                objParam[6].DbType = DbType.DateTime;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@msoo", soo);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mlgo", lgo);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mdfa", dfa);
                objParam[9].DbType = DbType.DateTime;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mlfa", lfa);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@mdepfa", depfa);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;

                objParam[12] = new SqlParameter("@mloc", loc);
                objParam[12].DbType = DbType.String;
                objParam[12].Direction = ParameterDirection.Input;

                objParam[13] = new SqlParameter("@mdept", dept);
                objParam[13].DbType = DbType.String;
                objParam[13].Direction = ParameterDirection.Input;

                objParam[14] = new SqlParameter("@msect", sect);
                objParam[14].DbType = DbType.String;
                objParam[14].Direction = ParameterDirection.Input;

                objParam[15] = new SqlParameter("@mdesig", desig);
                objParam[15].DbType = DbType.String;
                objParam[15].Direction = ParameterDirection.Input;

                objParam[16] = new SqlParameter("@mglfa", glfa);
                objParam[16].DbType = DbType.String;
                objParam[16].Direction = ParameterDirection.Input;

                objParam[17] = new SqlParameter("@mpgl", pgl);
                objParam[17].DbType = DbType.String;
                objParam[17].Direction = ParameterDirection.Input;

                objParam[18] = new SqlParameter("@mstadd", stadd);
                objParam[18].DbType = DbType.String;
                objParam[18].Direction = ParameterDirection.Input;

                objParam[19] = new SqlParameter("@memail", email);
                objParam[19].DbType = DbType.String;
                objParam[19].Direction = ParameterDirection.Input;

                objParam[20] = new SqlParameter("@mtell", tell);
                objParam[20].DbType = DbType.String;
                objParam[20].Direction = ParameterDirection.Input;

                objParam[21] = new SqlParameter("@mnokn", nokn);
                objParam[21].DbType = DbType.String;
                objParam[21].Direction = ParameterDirection.Input;

                objParam[22] = new SqlParameter("@mnokrel", nokrel);
                objParam[22].DbType = DbType.String;
                objParam[22].Direction = ParameterDirection.Input;

                objParam[23] = new SqlParameter("@mnokemail", nokemail);
                objParam[23].DbType = DbType.String;
                objParam[23].Direction = ParameterDirection.Input;

                objParam[24] = new SqlParameter("@mnokadd", nokadd);
                objParam[24].DbType = DbType.String;
                objParam[24].Direction = ParameterDirection.Input;

                objParam[25] = new SqlParameter("@mnoktell", noktell);
                objParam[25].DbType = DbType.String;
                objParam[25].Direction = ParameterDirection.Input;

                objParam[26] = new SqlParameter("@mhighq", highq);
                objParam[26].DbType = DbType.String;
                objParam[26].Direction = ParameterDirection.Input;

                objParam[27] = new SqlParameter("@myob", yob);
                objParam[27].DbType = DbType.String;
                objParam[27].Direction = ParameterDirection.Input;

                objParam[28] = new SqlParameter("@mpfac", pfac);
                objParam[28].DbType = DbType.String;
                objParam[28].Direction = ParameterDirection.Input;

                objParam[29] = new SqlParameter("@mpfan", pfan);
                objParam[29].DbType = DbType.String;
                objParam[29].Direction = ParameterDirection.Input;

                objParam[30] = new SqlParameter("@mtribe", tribe);
                objParam[30].DbType = DbType.String;
                objParam[30].Direction = ParameterDirection.Input;


                objParam[31] = new SqlParameter("@mphoto", filepath);
                objParam[31].DbType = DbType.String;
                objParam[31].Direction = ParameterDirection.Input;



                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_StaffMaster2";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }




    public static void Delete_Staff_Master(string stid)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from StaffMaster2 where Staff_Id='" + stid + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_Recruitment(string surn, string fn, string on, string dob, string gen, string aq, string fs, string ch, string qy, string aq2, string fs2, string ch2, string qy2, string pc, string yc, string insc, string pc2, string yc2, string insc2, string email, string tell, string posapp, string deptapp, string name)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[24];

                    objParam[23] = new SqlParameter("@mname", name);
                objParam[23].DbType = DbType.String;
                objParam[23].Direction = ParameterDirection.Input;

               
                objParam[0] = new SqlParameter("@msurn", surn);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mfn", fn);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mon", on);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                objParam[3] = new SqlParameter("@mdob", dob);
                objParam[3].DbType = DbType.DateTime;
                objParam[3].Direction = ParameterDirection.Input;
            
                objParam[4] = new SqlParameter("@mgen", gen);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@maq", aq);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mfs", fs);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mch", ch);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mqy", qy);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@maq2", aq2);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mfs2", fs2);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@mch2", ch2);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;

                objParam[12] = new SqlParameter("@mqy2", qy2);
                objParam[12].DbType = DbType.String;
                objParam[12].Direction = ParameterDirection.Input;

                objParam[13] = new SqlParameter("@mpc", pc);
                objParam[13].DbType = DbType.String;
                objParam[13].Direction = ParameterDirection.Input;

                objParam[14] = new SqlParameter("@myc", yc);
                objParam[14].DbType = DbType.String;
                objParam[14].Direction = ParameterDirection.Input;

                objParam[15] = new SqlParameter("@minsc", insc);
                objParam[15].DbType = DbType.String;
                objParam[15].Direction = ParameterDirection.Input;

                objParam[16] = new SqlParameter("@mpc2", pc2);
                objParam[16].DbType = DbType.String;
                objParam[16].Direction = ParameterDirection.Input;

                objParam[17] = new SqlParameter("@myc2", yc2);
                objParam[17].DbType = DbType.String;
                objParam[17].Direction = ParameterDirection.Input;

                objParam[18] = new SqlParameter("@minsc2", insc2);
                objParam[18].DbType = DbType.String;
                objParam[18].Direction = ParameterDirection.Input;

                objParam[19] = new SqlParameter("@memail", email);
                objParam[19].DbType = DbType.String;
                objParam[19].Direction = ParameterDirection.Input;

                objParam[20] = new SqlParameter("@mtell", tell);
                objParam[20].DbType = DbType.String;
                objParam[20].Direction = ParameterDirection.Input;

                objParam[21] = new SqlParameter("@mposapp", posapp);
                objParam[21].DbType = DbType.String;
                objParam[21].Direction = ParameterDirection.Input;

                objParam[22] = new SqlParameter("@mdeptapp", deptapp);
                objParam[22].DbType = DbType.String;
                objParam[22].Direction = ParameterDirection.Input;

                objParam[23] = new SqlParameter("@mname", name);
                objParam[23].DbType = DbType.String;
                objParam[23].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Recruitment";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }




    public static void Delete_Recruitment(string name)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from  where Surname + First_Name + Other_Name ='" + name + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Grade(string mygracode, string mygrades, string myleave)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mgracode", mygracode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mgrades", mygrades);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mgraleave", myleave);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Grade";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Grade(string mygracode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Grade_Level where Grade_Code='" + mygracode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_LeaveTransactions(string stid, string Leavecode, string stdate,string enddate, string noofdays, string applydate )
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[6];

                objParam[0] = new SqlParameter("@mstid", stid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mleavecode", Leavecode);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mstdate", HR_Report.myconvdate(stdate));
                objParam[2].DbType = DbType.DateTime;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@menddate",HR_Report.myconvdate(enddate));
                objParam[3].DbType = DbType.DateTime;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mnoofdays", noofdays);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mapplydate", HR_Report.myconvdate(applydate));
                objParam[5].DbType = DbType.DateTime;
                objParam[5].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_LeaveTransactions";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Leave_Transactions(string ltrans)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Leave_Transactions where Staff_Id='" + ltrans + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_ActivitiesTransactions(string stid, string actcode, string actdate, string remarks)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[4];

                objParam[0] = new SqlParameter("@mstid", stid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mactcode", actcode);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mactdate", HR_Report.myconvdate(actdate));
                objParam[2].DbType = DbType.DateTime;
                objParam[2].Direction = ParameterDirection.Input;       

                objParam[3] = new SqlParameter("@mremarks", remarks);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                
                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_ActivitiesTransactions";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Activities_Transactions(string ltrans)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Activities_Transactions where Staff_Id='" + ltrans + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_QualificationTransaction(string stid, string qname, string fsname, string ins, string yob, string qualt, string qualc,string dapply)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[8];

                objParam[0] = new SqlParameter("@mstid", stid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mqname", qname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mfsname", fsname);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mins", ins);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;


            
                objParam[4] = new SqlParameter("@myob", yob);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mqualt", qualt);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mqualc", qualc);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mdapply", dapply);
                objParam[7].DbType = DbType.DateTime;
                objParam[7].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_QualificationTransaction";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Qualification_Transaction(string qtrans)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Qualification_Transaction where Staff_Id='" + qtrans + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_EmploymentHistory(string stid, string org, string posth, string sty, string endy, string stsal, string lsal, string lreason, string contact)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[9];

                objParam[0] = new SqlParameter("@mstid", stid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@morg", org);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mposh", posth);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@msty", sty);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;



                objParam[4] = new SqlParameter("@mendy", endy);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mstsal", stsal);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;


                objParam[6] = new SqlParameter("@mlsal", lsal);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mlreason", lreason);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mcontact", contact);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_EmploymentHistory";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Employment_History(string stid)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Employment_History where Staff_Id='" + stid + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_TransferTransaction(string stid, string ttype, string oloc, string odept, string osec, string dloc, string ddept, string dsec, DateTime tdate, string treason)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[10];

                objParam[0] = new SqlParameter("@mstid", stid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mttype", ttype);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@moloc", oloc);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                objParam[3] = new SqlParameter("@modept", odept);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;


                objParam[4] = new SqlParameter("@mosec", osec);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@mdloc", dloc);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;


                objParam[6] = new SqlParameter("@mddept", ddept);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;


                objParam[7] = new SqlParameter("@mdsec", dsec);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mtdate",tdate.ToShortDateString());
                objParam[8].DbType = DbType.DateTime;
                objParam[8].Direction = ParameterDirection.Input;

               

                objParam[9] = new SqlParameter("@mtreason", treason);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_TransferTransaction";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Transfer_Transaction(string ttrans)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Transfer_Transaction where Staff_Id='" + ttrans + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_Qualification(string myqualcode, string myqualname, string myqualtype)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mqualcode", myqualcode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mqualname", myqualname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mqualtype", myqualtype);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Qualification";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Qualification(string myqualcode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Qualification where Qual_Code='" + myqualcode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_Category(string mystgra, string myendgra, string mycatname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mstgra", mystgra);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mendgra", myendgra);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mcatname", mycatname);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Category";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Category(string mystgra)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Category where Start_Grade ='" + mystgra + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_LeaveType(string mytypcode, string mytypname, string mydeduc)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mltypcode", mytypcode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mltypname", mytypname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mdeduc", mydeduc);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_LeaveType";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Leave_Type(string mytypcode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Leave_Type where Type_Code='" + mytypcode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_TrainingType(string trainc, string trainn, string traint)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mtrainc", trainc);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtrainn", trainn);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mtraint", traint);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_TrainingType";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Training_Type(string trainc)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Training_Type where Training_Code='" + trainc + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_TrainingTransaction(string stid, string traint, string trainn, string traindate, string traindur, string trainins, string certob)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[7];

                objParam[0] = new SqlParameter("@mstid", stid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtraint", traint);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mtrainn", trainn);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mtraindate", traindate);
                objParam[3].DbType = DbType.DateTime;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mtraindur", traindur);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mtrainins", trainins);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mcertob", certob);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_TrainingTransaction";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Training_Transaction(string stid)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Training_Transaction where Staff_Id ='" + stid + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }



    public static string Save_TrainingNomination(string stid, string loc, string dept,string sec, string nomcode, string traindate, string traindur, string orgname, string orgadd)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[9];

                objParam[0] = new SqlParameter("@mstid", stid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mloc", loc);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@mdept", dept);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@msec", sec);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mcode", nomcode);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mtraindate", traindate);
                objParam[5].DbType = DbType.DateTime;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mtraindur", traindur);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@morgname", orgname);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@morgadd", orgadd);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_TrainingNomination";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Training_Nomination(string stid)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Training_Nomination where Staff_Id ='" + stid + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Tribe(string mycode, string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mtrbcode", mycode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtrbname", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Tribe";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Tribe(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Tribe where Trb_Code='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_PFA(string mycode, string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mpfacode", mycode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mpfano", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_PFA";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_PFA(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from PFA where PFA_Code='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Save_Location(string mycode, string myname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mloccode", mycode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mlocname", myname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Location";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static void Delete_Location(string mycode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Location where Loc_Code='" + mycode + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }




    public static string  SavePaymentVoucher(string PVNO, string gpayeetype, string gpayee, string gbank, string AcctNo, string SortCode, string EntryDate, string PayDetail, string Amt, string TWtaxRate, string WtaxAmt, string VatRate, string VatAmt, string NetAmt)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[14];

                objParam[0] = new SqlParameter("@mpvno", PVNO);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mptype", gpayeetype);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mpayee", gpayee);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                objParam[3] = new SqlParameter("@mbank", gbank);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@macctno", AcctNo);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@msortcode", SortCode);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                  

              //  objParam[6] = new SqlParameter("@mdate", DateTime.ParseExact (EntryDate,"dd/MM/yyyy",System.Globalization.DateTimeFormatInfo);
                
                
                objParam[6] = new SqlParameter("@mdate",  DateTime.ParseExact (EntryDate,"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture) );
                objParam[6].DbType = DbType.DateTime ;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mdetail", PayDetail);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mamt", decimal.Parse (Amt));
                objParam[8].DbType = DbType.Decimal;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mwtaxrate", decimal.Parse (TWtaxRate));
                objParam[9].DbType = DbType.Decimal;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mwtaxamt", decimal.Parse (WtaxAmt));
                objParam[10].DbType = DbType.Decimal;
                objParam[10].Direction = ParameterDirection.Input;


                objParam[11] = new SqlParameter("@mvatrate", decimal.Parse (VatRate));
                objParam[11].DbType = DbType.Decimal;
                objParam[11].Direction = ParameterDirection.Input;

                objParam[12] = new SqlParameter("@mvatamt", decimal.Parse (VatAmt));
                objParam[12].DbType = DbType.Decimal;
                objParam[12].Direction = ParameterDirection.Input;

                objParam[13] = new SqlParameter("@mNet", decimal.Parse (NetAmt));
                objParam[13].DbType = DbType.Decimal;
                objParam[13].Direction = ParameterDirection.Input;





                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_PV";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static string Save_GLChart(string accode, string accname, string maingroup, string subgroup, string agrp, string gtype, string glcontrol)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[7];

                objParam[0] = new SqlParameter("@accode", accode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@acname", accname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@maingroup", maingroup);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@subgroup", subgroup);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@agrp", agrp);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mactpe", gtype);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;


                objParam[6] = new SqlParameter("@mcontrol", glcontrol);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;
                
                
                

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_GLChart_save";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }

    public static string Save_Bank(string xcode, string xname, string xsort)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@bcode", xcode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@bname", xname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@csc", xsort);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Bank";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }

    }



    public static void Delete_Bank( string bcode)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[1];

                objParam[0] = new SqlParameter("@mcode", bcode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Del_Bank";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();

            }
        }
    }




    public static void Save_GLBatch_Head(string sno, string batchno, string posted, string batchdiff, string postdate, string branch, string natstatcode, string entrydate, string debit, string credit, string mbtype)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[11];

                objParam[0] = new SqlParameter("@batchno", batchno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@posted", posted);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@batchdiff", batchdiff);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@postdate", postdate);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@branch", branch);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@entrydate", entrydate);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@natstatcode", natstatcode);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@credit", credit);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@debit", debit);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@sno", sno);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@btype", mbtype);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;
                               

                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_GLBatch_Head_save";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();

            }
        }
    }

    public static void Delete_GLTrans(string sno, string batchno)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@batchno", batchno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@sno", sno);
                objParam[1].DbType = DbType.Int32 ;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Del_GLTrans";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();

            }
        }
    }

    public static DataSet populateGrid(string batchno)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select a.Trans_no, a.trans_ref, a.acct_code, b.acct_name, a.trans_details, a.debit, a.credit, a.trans_date from GLTrans a, GLCHART b where a.batch_no='" + batchno + "'" + " and a.acct_code=b.acct_code "+ " order by a.Trans_no";

                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.SelectCommand = sqlcmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }


    public static DataSet populateGrid_Staff_Ledger(string batchno)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
               
                
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select a.Trans_no as [Trans No], a.STAFF_NO as [Staff No], b.SURNAME_OTHERS as [Staff Name],a.PV_ADV_NO as [Voucher No], a.ADV_TYPE_CODE_GL_DR as [Advance GL Code], a.TRANS_AMOUNT as [Trans Amount], a.TRANS_DETAILS as [Transaction Details], a.BANK_CODE_GL_CR [Bank/Cash Acct], a.TRANS_DATE as [Trans Date] from GL_STAFF_LEDGER_DETAILS a, HR_STAFF_MASTER b where a.ADV_REF_NO='" + batchno + "'" + " and a.staff_no=b.staff_no "+  " order by a.Trans_no";

                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.SelectCommand = sqlcmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }



    public static DataSet populateGrid_Staff_Ledger_Advance(string gadtype,string gstaffno)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {


                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select a.Trans_no as [Trans No], a.PV_ADV_NO as [Voucher No],a.STAFF_NO as [Staff No], b.SURNAME_OTHERS as [Staff Name], a.ADV_TYPE_CODE_GL_DR as [Advance GL Code], a.TRANS_AMOUNT as [Trans Amount], a.TRANS_DETAILS as [Transaction Details], a.BANK_CODE_GL_CR [Bank/Cash Acct], a.TRANS_DATE as [Trans Date] from GL_STAFF_LEDGER_DETAILS a, HR_STAFF_MASTER b where a.ADV_TYPE_CODE='" + gadtype + "'" + " and a.staff_no=b.staff_no" + " and a.staff_no='"+gstaffno+"'"+ " and a.RETIRE_FLAG='N'  and a.posted_flag='Y'" + " order by a.Trans_no";

                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.SelectCommand = sqlcmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }



    public static DataSet populateGrid_Staff_Ledger_Retire(string gbatch)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {


                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "Select a.Trans_no as [Trans No], a.STAFF_NO as [Staff No], b.SURNAME_OTHERS as [Staff Name],a.RET_PV_NO as [Voucher No], a.ADV_RET_GL_CR as [Adv.GL CR Code], a.RET_AMOUNT as [Retired Amount], a.RET_DETAILS as [Transaction Details], a.RET_CODE_GL_DR [GL Debit Acct], a.RET_DATE as [Retiremt Date] from GL_STAFF_RETIREMENT_DETAILS a, HR_STAFF_MASTER b where a.RET_BATCH_NO='" + gbatch + "'" + " and a.staff_no=b.staff_no " + " order by a.Trans_no";

                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.SelectCommand = sqlcmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }




    public static void Save_GLTrans(string batchno, string sno, string transref, string acctp, string branch, string glacctcode, string natstatcode, string transdet, string transdate, string debit, string credit, string glacctname)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[12];

                objParam[0] = new SqlParameter("@batchno", batchno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@sno", sno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@transref", transref);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@acctp", acctp);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@branch", branch);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@glacctcode", glacctcode);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@natstatcode", natstatcode);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@transdet", transdet);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@transdate", transdate);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@debit", debit);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@credit", credit);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@glacctname", glacctname);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;


                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_GLTrans_save";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }
    }

    public static string Sum_credit(string mybatchno)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select sum(credit) as mysum from GLTrans where batch_no='" + mybatchno + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader();
                
                if (dr.Read() )
                    return dr["mysum"].ToString();
                else
                    return "0.00";
            }
        }
    }

    public static string Sum_debit(string mybatchno)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select sum(debit) as mysum from GLTrans where batch_no='" + mybatchno + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader();;
                
                if (dr.Read())
                    return dr["mysum"].ToString();
                else
                    return "0.00";
            }
        }
    }


    public static string Sum_credit_SL_Ledger(string mybatch)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select sum(TRANS_AMOUNT) as mysum from GL_STAFF_LEDGER_DETAILS where ADV_REF_NO='" + mybatch + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader();;
                
                if (dr.Read())
                    return dr["mysum"].ToString();
                else
                    return "0.00";
            }
        }
    }


    public static string Sum_credit_SL_Ledger_Retire(string mybatch)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select sum(RET_AMOUNT) as mysum from GL_STAFF_RETIREMENT_DETAILS where RET_BATCH_NO='" + mybatch + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader(); ;

                if (dr.Read())
                    return dr["mysum"].ToString();
                else
                    return "0.00";
            }
        }
    }



    public static string Sum_count_batch(string mybatchno, string mytable, string myfield)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select count(*) as mycount from " + mytable + " where " + myfield + " ='" + mybatchno + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                    return dr["mycount"].ToString();
                else
                    return "0.00";
            }
        }
    }


    public static string Sum_count_batch_SL_Ledger(string mybatch)
    {
           using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select count(*) as mycount from GL_STAFF_LEDGER_DETAILS where ADV_REF_NO='" + mybatch + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader();;
                
                if (dr.Read())
                    return dr["mycount"].ToString();
                else
                    return "0.00";
            }
        }

    }


    public static void Save_GL_Notes_Head(string gnoteno, string gnotedesc,string gnotetype )
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mnoteno", gnoteno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mnotedesc", gnotedesc );
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mtype", gnotetype);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                       

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Note_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                
            }
        }

    }


    public static void Save_Staff_Ledger_Code(string gcode, string gname, string gledger )
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mcode", gcode);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mname", gname);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mgl", gledger);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;



                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Staff_Ledger_Code";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();

            }
        }

    }

public static void Save_Staff_LG_Trans(string gbatchno, string gtranno, string gstaffno , string gperiod, string gpvadvno, string gadvtype   , string  gGLDrcode  , string gGLCRcode, string gamt , string gdetail, string gmydate )    
{

    using (SqlConnection objConn = DBConnection.Connect())
    {
        using (SqlCommand sqlcmd = new SqlCommand())
        {
            sqlcmd.Connection = objConn;
            SqlTransaction ststrans;
            ststrans = objConn.BeginTransaction();

            SqlParameter[] objParam = new SqlParameter[13];

            objParam[0] = new SqlParameter("@madvref", gbatchno);
            objParam[0].DbType = DbType.String;
            objParam[0].Direction = ParameterDirection.Input;

            objParam[1] = new SqlParameter("@mtranno", gtranno);
            objParam[1].DbType = DbType.String;
            objParam[1].Direction = ParameterDirection.Input;

            objParam[2] = new SqlParameter("@mstaff", gstaffno);
            objParam[2].DbType = DbType.String;
            objParam[2].Direction = ParameterDirection.Input;

            objParam[3] = new SqlParameter("@mperiod", int.Parse (gperiod));
            objParam[3].DbType = DbType.Int32;
            objParam[3].Direction = ParameterDirection.Input;

            objParam[4] = new SqlParameter("@mpvno", gpvadvno);
            objParam[4].DbType = DbType.String;
            objParam[4].Direction = ParameterDirection.Input;

            objParam[5] = new SqlParameter("@madvtype", gadvtype);
            objParam[5].DbType = DbType.String;
            objParam[5].Direction = ParameterDirection.Input;

            objParam[6] = new SqlParameter("@mgldr", gGLDrcode);
            objParam[6].DbType = DbType.String;
            objParam[6].Direction = ParameterDirection.Input;

            objParam[7] = new SqlParameter("@mglcr", gGLCRcode);
            objParam[7].DbType = DbType.String;
            objParam[7].Direction = ParameterDirection.Input;

            objParam[8] = new SqlParameter("@mamt", double.Parse (gamt));
            objParam[8].DbType = DbType.Double;
            objParam[8].Direction = ParameterDirection.Input;

            objParam[9] = new SqlParameter("@mdetail", gdetail);
            objParam[9].DbType = DbType.String;
            objParam[9].Direction = ParameterDirection.Input;

            objParam[10] = new SqlParameter("@mdate", gmydate);
            objParam[10].DbType = DbType.String;
            objParam[10].Direction = ParameterDirection.Input;

            objParam[11] = new SqlParameter("@mcoy", AppGlobal.coycode);
            objParam[11].DbType = DbType.String;
            objParam[11].Direction = ParameterDirection.Input;

            objParam[12] = new SqlParameter("@mbrch", AppGlobal.brchcode);
            objParam[12].DbType = DbType.Double;
            objParam[12].Direction = ParameterDirection.Input;




            sqlcmd.Connection = ststrans.Connection;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "stp_Save_SL_Detail";
            sqlcmd.Parameters.AddRange(objParam);
            sqlcmd.Transaction = ststrans;

            int intResult = sqlcmd.ExecuteNonQuery();
            ststrans.Commit();

        }
    }

}










    public static void Save_Staff_LG_Head( string gBatch, string gTSno, string mypost, string gBatchdiff, string  gmydate1, string gTotdr, string gTotcr,string gperiod)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[11];

                objParam[0] = new SqlParameter("@madvref", gBatch);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtranno", gTSno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mpost", mypost);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mbdiff", double.Parse(gBatchdiff));
                objParam[3].DbType = DbType.Double ;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mdate", gmydate1);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mdramt", double.Parse (gTotdr));
                objParam[5].DbType = DbType.Double;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mcramt", double.Parse(gTotcr));
                objParam[6].DbType = DbType.Double;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mofficer", AppGlobal.gusername);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mcoy", AppGlobal.coycode );
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mbrch", AppGlobal.brchcode );
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mperiod", gperiod);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;



                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_SL_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();

            }
        }



    }


    public static void Save_Staff_LG_Retire_Head(string gBatch, string gTSno, string mypost, string gBatchdiff, string gmydate1, string gTotdr, string gTotcr, string gperiod)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[11];

                objParam[0] = new SqlParameter("@madvref", gBatch);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtranno", gTSno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mpost", mypost);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mbdiff", double.Parse(gBatchdiff));
                objParam[3].DbType = DbType.Double;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mdate", gmydate1);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mdramt", double.Parse(gTotdr));
                objParam[5].DbType = DbType.Double;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mcramt", double.Parse(gTotcr));
                objParam[6].DbType = DbType.Double;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mofficer", AppGlobal.gusername);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mcoy", AppGlobal.coycode);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mbrch", AppGlobal.brchcode);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mperiod", gperiod);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;



                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_SL_Retire_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();

            }
        }



    }

    public static void Save_Staff_LG_Retire_Trans(string gbatchno, string gtranno, string gstaffno, string gperiod, string gpvadvno, string gadvtype, string gGLDrcode, string gGLCRcode, string gamt, string gdetail, string gmydate, string gretamt)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[14];

                objParam[0] = new SqlParameter("@madvref", gbatchno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtranno", gtranno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mstaff", gstaffno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mperiod", int.Parse(gperiod));
                objParam[3].DbType = DbType.Int32;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mpvno", gpvadvno);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@madvtype", gadvtype);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mgldr", gGLDrcode);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mglcr", gGLCRcode);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mamt", double.Parse(gamt));
                objParam[8].DbType = DbType.Double;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mdetail", gdetail);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mdate", gmydate);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@mcoy", AppGlobal.coycode);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;

                objParam[12] = new SqlParameter("@mbrch", AppGlobal.brchcode);
                objParam[12].DbType = DbType.Double;
                objParam[12].Direction = ParameterDirection.Input;

                objParam[13] = new SqlParameter("@mretamt", double.Parse(gretamt));
                objParam[13].DbType = DbType.Double;
                objParam[13].Direction = ParameterDirection.Input;





                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_SL_Retire_Detail";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();

            }
        }

    }





    public static void Del_Staff_LG_Trans(string gBatchno, string gSno,string lgtype)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@batchno", gBatchno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@sno", gSno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@mlg", lgtype);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Del_Staff_LDG_Trans";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }

    }



    public static void Delete_Staff_LG_Trans(string gSno, string gBatch)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@batchno", gBatch);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@sno", gSno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Del_Staff_LDG_Entry";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }



    }



    public static void Save_Staff_LG_Debit(string gBatchno, string gSno, string gStaffNo, string gAcctPeriod, string gAdvNo, string gadvcode, string gGLDr, string gdramt,string gcramt, string gTransDet, string mydate,string gcoy, string gbranch, string ADVTYPE)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[14];

                objParam[0] = new SqlParameter("@batchno", gBatchno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@sno", gSno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@transref", gStaffNo);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                
                objParam[3] = new SqlParameter("@branch", gbranch);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@glacctcode", gGLDr);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@natstatcode", gcoy);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@transdet", gTransDet);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@transdate", mydate);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@debit", gdramt);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@credit", gcramt);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@acctp", gAcctPeriod);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                int k = mydate.LastIndexOf("/");
                var myear = mydate.Substring(k + 1, 4);

                objParam[11] = new SqlParameter("@myr", myear );
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;


                objParam[12] = new SqlParameter("@madtype", gadvcode);
                objParam[12].DbType = DbType.String;
                objParam[12].Direction = ParameterDirection.Input;

                objParam[13] = new SqlParameter("@madsource", ADVTYPE);
                objParam[13].DbType = DbType.String;
                objParam[13].Direction = ParameterDirection.Input;

                


                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_SL_Debit";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }

    }


    public static void Save_Note_Details(string gnoteno, string glacct, string glname)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[3];

                objParam[0] = new SqlParameter("@mnote", gnoteno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@macct", glacct);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@mname", glname);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;




                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Note_Detail";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }



    }


    public static void Delete_Note_Details(string gnoteno, string glacct)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@mnote", gnoteno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@macct", glacct);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Del_Note_Detail";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }

    }


    public static DataSet populateGrid_Purchase_Order(string gpono,string mytable, string myfield, string gtype)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {


                sqlcmd.Connection = objConn;

                if (gtype=="ORD")
                   sqlcmd.CommandText = "Select a.SNO as [Trans No], a.ITEM_CODE as [Item Code], a.ITEM_DESC as [Item Description],a.QTY as [Qty. Ordered], a.UNIT_PRICE as [Unit Price], a.VALUE as [Value], b.po_no as [Order No] from " + mytable + " a, SUPP_PO_HEADER b "+ " where a."+ myfield + "='" + gpono + "'" + " and b.po_no='"+gpono +"'" + " and b.posted_flag <>'Y'" + " order by a.sno";
                else if (gtype=="SUP")
                    sqlcmd.CommandText = "Select SNO as [Trans No], ITEM_CODE as [Item Code], ITEM_DESC as [Item Description],QTY_ORDER as [Qty Ordered], QTY as [Qty. Rcvd], UNIT_PRICE as [Unit Price], VALUE as [Value] from " + mytable + " where " + myfield + "='" + gpono + "'" + " order by sno";
                
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.SelectCommand = sqlcmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }


    public static void Save_Supp_PO_Detail(string gmpono , string gsno, string gitcode , string gitdesc , string gqty , string guprice , string gvalue )
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[7];

                objParam[0] = new SqlParameter("@mpono", gmpono);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@msno", gsno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@mitcode", gitcode);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mitdesc", gitdesc);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mqty", double.Parse (gqty));
                objParam[4].DbType = DbType.Double;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@muprice", double.Parse(guprice));
                objParam[5].DbType = DbType.Double;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mvalue", double.Parse(gvalue));
                objParam[6].DbType = DbType.Double;
                objParam[6].Direction = ParameterDirection.Input;

                
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Supp_PO_Detail";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }



    }

    public static void Save_Supp_PO_Head(string gmpono, string gsno, string gamt, string mydate, string  mydate1, string gcoy, string gbranch,string guser ,string gsupp )
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[9];

                objParam[0] = new SqlParameter("@mpono", gmpono);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@msno", gsno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@mamt", double.Parse (gamt));
                objParam[2].DbType = DbType.Double;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mpodate", mydate);
                objParam[3].DbType = DbType.DateTime;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mentdate", mydate1);
                objParam[4].DbType = DbType.DateTime;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mcoy", gcoy);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mbranch", gbranch );
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@muser", guser);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;


                objParam[8] = new SqlParameter("@msupp", gsupp);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;
                              
                
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Supp_PO_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }


    }

    public static string Sum_Supp_PO(string mypono)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select sum(VALUE) as mysum from SUPP_PO_DETAILS where PO_NO='" + mypono + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader(); 

                if (dr.Read())
                    return dr["mysum"].ToString();
                else
                    return "0.00";
            }
        }
    }


    public static string Sum_Supp_GRN_Detail(string mygrn)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select sum(VALUE) as mysum from SUPP_GRN_DETAILS where GRN_NO='" + mygrn + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader();

                if (dr.Read())
                    return dr["mysum"].ToString();
                else
                    return "0.00";
            }
        }
    }




    public static string Sum_Count_Supp_PO(string mypono)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select count(*) as mycount from SUPP_PO_DETAILS where PO_NO='" + mypono + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader();

                if (dr.Read())
                    return dr["mycount"].ToString();
                else
                    return "0.00";
            }
        }
    }



    public static string Sum_Count_Supp_GRN_Detail(string mygrn)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select count(*) as mycount from SUPP_GRN_DETAILS where GRN_NO='" + mygrn + "'";

                SqlDataReader dr = sqlcmd.ExecuteReader();

                if (dr.Read())
                    return dr["mycount"].ToString();
                else
                    return "0.00";
            }
        }
    }

    public static void Delete_Supp_PO_Trans(string gSno, string gPONO )
    {


        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "delete from SUPP_PO_DETAILS where PO_NO='" + gPONO + "'" + " and SNO="+int.Parse(gSno);
                sqlcmd.ExecuteNonQuery();
            }
        }
    }



    public static void Save_Supp_Purchase_Detail(string gmpono , string gsno, string gitcode , string gitdesc , string gqty , string guprice , string gvalue,string gqtyrcv )
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[8];

                objParam[0] = new SqlParameter("@mpono", gmpono);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@msno", gsno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@mitcode", gitcode);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mitdesc", gitdesc);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mqty", double.Parse (gqty));
                objParam[4].DbType = DbType.Double;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@muprice", double.Parse(guprice));
                objParam[5].DbType = DbType.Double;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mvalue", double.Parse(gvalue));
                objParam[6].DbType = DbType.Double;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mqtyrcv", double.Parse(gqtyrcv));
                objParam[7].DbType = DbType.Double;
                objParam[7].Direction = ParameterDirection.Input;



            

                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Goods_Rcvd_Detail";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }



    }



    public static void PV_Print( string gpvno)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from PAYMENT_VOUCHER_PRINT";
                sqlcmd.ExecuteNonQuery();


                //SqlParameter[] objParam = new SqlParameter[2];

                //objParam[0] = new SqlParameter("@startdate", string.Format(date1.ToShortDateString(), "dd/MM/yyyy"));
                //objParam[0].DbType = DbType.DateTime;
                //objParam[0].Direction = ParameterDirection.Input;

                //objParam[1] = new SqlParameter("@enddate", string.Format(date2.ToShortDateString(), "dd/MM/yyyy"));
                //objParam[1].DbType = DbType.DateTime;
                //objParam[1].Direction = ParameterDirection.Input;

                //sqlcmd.Parameters.AddRange(objParam);





                sqlcmd.CommandText = "select * from PAYMENT_VOUCHER where PV_NO='" + gpvno + "'";
                

                
                SqlDataReader   dr = sqlcmd.ExecuteReader();
                    if (dr.Read())
                    {

                        int i = 0;
                    //foreach (int i =1; i <=3; i++)
                    {
                    
                       string mydate,mydetail,myacct,myamount;

                        if (i==1 && dr["TRANS_AMT"].ToString()!=string.Empty)                             
                        {
                         mydate  = dr["VOUCHER_DATE"].ToString();
                         mydetail = dr["TRANS_DETAIL"].ToString();
                         myacct = dr["ACCT_CODE"].ToString();
                         myamount = dr["AMOUNT"].ToString();
                            InsertPVPrint(gpvno,mydate, mydetail,myacct,myamount );
                        }
                        
                        if (i==2 && dr["WHT_TAX_AMT"].ToString()!=string.Empty)                             
                        {
                         mydate  = "-";
                         mydetail = "LESS W/TAX";
                         myacct = "824";
                         myamount = dr["WHT_TAX_AMT"].ToString();
                         InsertPVPrint(gpvno,mydate, mydetail,myacct,myamount );
                            
                        } 


                        if (i==3 && dr["VAT_AMT"].ToString()!=string.Empty)                             
                        {
                         mydate  = "-";
                         mydetail = "LESS VAT ";
                         myacct = "825";
                         myamount = dr["VAT_AMT"].ToString();
                        InsertPVPrint(gpvno,mydate, mydetail,myacct,myamount );

                        }



                        //string bkdate = System.Convert.ToDateTime(rw["booking_date"].ToString()).ToShortDateString();
                        //string bkdate =string.Format(rw["booking_date"].ToString(),"dd/MM/yyyy");
                        //string ostat = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, Tables.station, Field.stationcode, rw["ORIG_STATION"].ToString(), GlobalVar.mystring);
                        //string destat = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, Tables.station, Field.stationcode, rw["DEST_STATION"].ToString(), GlobalVar.mystring);
                        // string lddate = string.Format(rw["loading_date"].ToString(), "dd/MM/yyyy");
                        //string lddate = System.Convert.ToDateTime(rw["loading_date"].ToString()).ToShortDateString();
                        //string goodtype = rw["RATE_GRP_DESC"].ToString();

                       // Insertintobooking(custname, custaddr, custphone, custemail, bkdate, ostat, destat, lddate, goodtype);
                    }


                }
            }
        }
    }

    
    public static void InsertPVPrint(string gpvno,string mydate, string mydetail, string myacct, string myamount)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[5];

                objParam[0] = new SqlParameter("@mdate", mydate);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mdetail", mydetail);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@macct", myacct);
                objParam[2].DbType = DbType.Double;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mamt", myamount);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;


                objParam[4] = new SqlParameter("@mpvno", gpvno);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;



                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_PV_Report";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }


    }





    public static void Save_Supp_Purchase_Head(string ggrno, string gsno, string gamt, string mydate, string  mydate1, string gcoy, string gbranch,string guser ,string gpono,string gsupp,string gacccr,string gaccdr, string gperiod, string gtype )
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[14];

                objParam[0] = new SqlParameter("@mgrn", ggrno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@msno", gsno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@mamt", double.Parse (gamt));
                objParam[2].DbType = DbType.Double;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mpodate", mydate);
                objParam[3].DbType = DbType.DateTime;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mentdate", mydate1);
                objParam[4].DbType = DbType.DateTime;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mcoy", gcoy);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mbranch", gbranch );
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@muser", guser);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;
                
                objParam[8] = new SqlParameter("@msupp", gsupp);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mglcr", gacccr);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mgldr", gaccdr);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@mpono", gpono);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;

                objParam[12] = new SqlParameter("@mprd", gperiod);
                objParam[12].DbType = DbType.String;
                objParam[12].Direction = ParameterDirection.Input;

                objParam[13] = new SqlParameter("@mtype", gtype);
                objParam[13].DbType = DbType.String;
                objParam[13].Direction = ParameterDirection.Input;





                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Goods_Rcvd_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }


    }


    public static void Save_GL_Purch_Journal(string gBatchno, string gSno, string gStaffNo, string gAcctPeriod, string gAdvNo, string gadvcode, string gGLDr, string gdramt, string gcramt, string gTransDet, string mydate, string gcoy, string gbranch, string ADVTYPE)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[14];

                objParam[0] = new SqlParameter("@batchno", gBatchno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@sno", gSno);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@transref", gStaffNo);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                objParam[3] = new SqlParameter("@branch", gbranch);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@glacctcode", gGLDr);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@natstatcode", gcoy);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@transdet", gTransDet);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@transdate", mydate);
                objParam[7].DbType = DbType.DateTime;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@debit", gdramt);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@credit", gcramt);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@acctp", gAcctPeriod);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                int k = mydate.LastIndexOf("/");
                var myear = mydate.Substring(k+1, 4);


                objParam[11] = new SqlParameter("@myr", myear);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;


                objParam[12] = new SqlParameter("@madtype", gadvcode);
                objParam[12].DbType = DbType.String;
                objParam[12].Direction = ParameterDirection.Input;

                objParam[13] = new SqlParameter("@madsource", ADVTYPE);
                objParam[13].DbType = DbType.String;
                objParam[13].Direction = ParameterDirection.Input;




                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_GL_Purch_Journal";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }

    }

    public static void Del_Purch_Journal(string gGRNNO)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from SUPP_PURCH_JOURNAL where Batch_No='" + gGRNNO + "'";
                sqlcmd.ExecuteNonQuery();
            
            }
        }


    }


    public static void Delete_Good_Rcvd_Detail(string gGRNNO, string gsno)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from SUPP_GRN_DETAILS where GRN_NO='" + gGRNNO + "'" + " and SNO="+int.Parse(gsno);
                sqlcmd.ExecuteNonQuery();
            
            }
        }


    }



    public static DataSet populateGrid_General_OpBal(string gpono, string mytable, string myfield)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {


                sqlcmd.Connection = objConn;


                sqlcmd.CommandText = "Select a.SNO as [Trans No], a.SUPP_CODE as [Supplier Code], b.Supp_name as [Supplier Name],a.OP_BAL_AMOUNT as [Opening Bal.], a.OP_BAL_DATE as [Op. Bal Date] from " + mytable + " a, SUPPLIER b " + " where a." + myfield + "='" + gpono + "'" + " and b.SUPP_CODE=a.SUPP_CODE"  + " order by a.sno";
                
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.SelectCommand = sqlcmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }



public static void  Save_Supp_OPBal_Detail(String pOPREF, String pSno, string psupcode, String pOpBal, string mydate)
{
    using (SqlConnection objConn = DBConnection.Connect())
    {
        using (SqlCommand sqlcmd = new SqlCommand())
        {
            sqlcmd.Connection = objConn;
            SqlTransaction objTrans;
            objTrans = objConn.BeginTransaction();

            SqlParameter[] objParam = new SqlParameter[5];

            objParam[0] = new SqlParameter("@mref", pOPREF);
            objParam[0].DbType = DbType.String;
            objParam[0].Direction = ParameterDirection.Input;

            objParam[1] = new SqlParameter("@msno", pSno);
            objParam[1].DbType = DbType.String;
            objParam[1].Direction = ParameterDirection.Input;

            objParam[2] = new SqlParameter("@msuppcode", psupcode);
            objParam[2].DbType = DbType.String;
            objParam[2].Direction = ParameterDirection.Input;


            objParam[3] = new SqlParameter("@mopbal", pOpBal);
            objParam[3].DbType = DbType.String;
            objParam[3].Direction = ParameterDirection.Input;

            objParam[4] = new SqlParameter("@mdate", mydate);
            objParam[4].DbType = DbType.String;
            objParam[4].Direction = ParameterDirection.Input;
            
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "stp_Save_Supp_OPBal_Detail";
            sqlcmd.Parameters.AddRange(objParam);
            sqlcmd.Transaction = objTrans;
            sqlcmd.ExecuteNonQuery();
            objTrans.Commit();
        }
    }


}


public static string Sum_Supp_OP_Bal(string mypono)
{
    using (SqlConnection objConn = DBConnection.Connect())
    {
        using (SqlCommand sqlcmd = new SqlCommand())
        {
            sqlcmd.Connection = objConn;
            sqlcmd.CommandText = "Select sum(OP_BAL_AMOUNT) as mysum from SUPP_OP_BAL_DETAIL where OP_REF='" + mypono + "'";

            SqlDataReader dr = sqlcmd.ExecuteReader();

            if (dr.Read())
                return dr["mysum"].ToString();
            else
                return "0.00";
        }
    }
}


public static string Sum_Count_OPbal_Detail(string mygrn)
{
    using (SqlConnection objConn = DBConnection.Connect())
    {
        using (SqlCommand sqlcmd = new SqlCommand())
        {
            sqlcmd.Connection = objConn;
            sqlcmd.CommandText = "Select count(*)  as mycount from SUPP_OP_BAL_DETAIL where OP_REF='" + mygrn + "'";

            SqlDataReader dr = sqlcmd.ExecuteReader();

            if (dr.Read())
                return dr["mycount"].ToString();
            else
                return "0.00";
        }
    }
}


   public static void Save_Supp_OPBAL_Head( string pPREF, string pSno, string pAmt, string pGLDR, string pGLCR , string pmydate1, string pcoycode, string pbrchcode, string pusername)
{
    using (SqlConnection objConn = DBConnection.Connect())
    {
        using (SqlCommand sqlcmd = new SqlCommand())
        {
            sqlcmd.Connection = objConn;
            SqlTransaction objTrans;
            objTrans = objConn.BeginTransaction();

            SqlParameter[] objParam = new SqlParameter[9];

            objParam[0] = new SqlParameter("@mref", pPREF);
            objParam[0].DbType = DbType.String;
            objParam[0].Direction = ParameterDirection.Input;

            objParam[1] = new SqlParameter("@msno", pSno);
            objParam[1].DbType = DbType.String;
            objParam[1].Direction = ParameterDirection.Input;

            objParam[2] = new SqlParameter("@mamt", pAmt);
            objParam[2].DbType = DbType.String;
            objParam[2].Direction = ParameterDirection.Input;


            objParam[3] = new SqlParameter("@mgldr", pGLDR);
            objParam[3].DbType = DbType.String;
            objParam[3].Direction = ParameterDirection.Input;

            objParam[4] = new SqlParameter("@mglcr", pGLCR);
            objParam[4].DbType = DbType.String;
            objParam[4].Direction = ParameterDirection.Input;


            objParam[5] = new SqlParameter("@mdate", pmydate1);
            objParam[5].DbType = DbType.String;
            objParam[5].Direction = ParameterDirection.Input;

            objParam[6] = new SqlParameter("@mcoy", pcoycode);
            objParam[6].DbType = DbType.String;
            objParam[6].Direction = ParameterDirection.Input;

            objParam[7] = new SqlParameter("@mbrch", pbrchcode);
            objParam[7].DbType = DbType.String;
            objParam[7].Direction = ParameterDirection.Input;

            objParam[8] = new SqlParameter("@muser", pusername);
            objParam[8].DbType = DbType.String;
            objParam[8].Direction = ParameterDirection.Input;


            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "stp_Save_Supp_OPBal_Head";
            sqlcmd.Parameters.AddRange(objParam);
            sqlcmd.Transaction = objTrans;
            sqlcmd.ExecuteNonQuery();
            objTrans.Commit();
        }
    }



}

public static string Retrieve_Detail(string myrefno, GridView gridview1)
   {
       string myno="";   
    using (SqlConnection objConn = DBConnection.Connect())
       {
           using (SqlCommand sqlcmd = new SqlCommand())
           {
               
               sqlcmd.Connection = objConn;
               sqlcmd.CommandText = "select a.S_no as [S/No],a.staff_id as [Staff No], b.surname as [Surname],b.first_name as [First Name],a.old_grade as [Current Grade],a.New_grade as [New Grade],a.Promo_Date as [Promo. Date] from Staff_Promotion_Details_Temp a,Staff_master b where a.Promo_Ref_No='" + myrefno + "'" + " and a.staff_id=b.staff_id " + " order by a.S_No";
               SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
               myadapter.SelectCommand = sqlcmd;
               DataTable dt = new DataTable();
               myadapter.Fill(dt);
               gridview1.DataSource = dt;
               gridview1.DataBind();
               if (gridview1.Rows.Count == 0)
               {
                   myno = "1";
               }
               else if (gridview1.Rows.Count > 0)
               {
                   myno = (gridview1.Rows.Count + 1).ToString();

               }
              
             }
           return myno;
       }




   }


    public static void save_promo_detail(string txtprefno,string txtsno,string txtstid,string lblgrade,string txtngrade,string txtnstep,string txtpdate,string lblstep,string txtpyear,string txtentd)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[9];


             

                objParam[0] = new SqlParameter("@mpref", txtprefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mpyear", txtpyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                objParam[3] = new SqlParameter("@mstid", txtstid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@moldg", lblgrade);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@mngrade", txtngrade);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mnstep", txtnstep);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mentd", HR_Report.myconvdate(txtentd));
                objParam[7].DbType = DbType.DateTime;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mpdate",txtpdate);
                objParam[8].DbType = DbType.DateTime;
                objParam[8].Direction = ParameterDirection.Input;

               

                
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Staff_Promo_Details";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }


    }
    

    public static string Count_promo_Detail(string myrefno)
    {
               string myno="0";   
    using (SqlConnection objConn = DBConnection.Connect())
       {
           using (SqlCommand sqlcmd = new SqlCommand())
           {
               
               sqlcmd.Connection = objConn;
               sqlcmd.CommandText = "select count(*) as mycount from Staff_Promotion_Details_Temp  where Promo_Ref_No='" + myrefno + "'";
               SqlDataReader dr = sqlcmd.ExecuteReader();
               if (dr.Read())
               {
                   myno = dr["mycount"].ToString();
               }
    }

    }
    return myno;
    }


    public static string Count_transfer_Detail(string myrefno)
    {
        string myno = "0";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select count(*) as mycount from Transfer_Roaster_Details_Temp  where Transfer_Ref_No ='" + myrefno + "'";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                    myno = dr["mycount"].ToString();
                }
            }

        }
        return myno;
    }


    public static string Count_leave_Detail(string myrefno)
    {
        string myno = "0";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select count(*) as mycount from Leave_Roaster_Details_Temp  where Leave_Ref_No='" + myrefno + "'";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                    myno = dr["mycount"].ToString();
                }
            }

        }
        return myno;
    }


    public static void Save_Promo_Head(string myrefno, string pyear, string txtsno, string apprby,string txtentd, string remark, string pst, string chkby, string chkd, string remc, string chs)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[11];




                objParam[0] = new SqlParameter("@mrefno",myrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;



                objParam[1] = new SqlParameter("@mpyear", pyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;


                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mapprby", apprby);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;



                objParam[4] = new SqlParameter("@mentd", txtentd);
                objParam[4].DbType = DbType.DateTime;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mremark", remark);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mpst", pst);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mchkby", chkby);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mchkd", chkd);
                objParam[8].DbType = DbType.DateTime;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mremc", remc);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;


                objParam[10] = new SqlParameter("@mchs", chs);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

               
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Staff_Promo_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }
    }




    public static void save_LeaveRoaster_detail(string txtlrefno,string txtlyear, string txtsno,  string txtloc, string txtdept, string txtstid,string txtdays, string txtstart, string txtend,  string txtdspent,string txtdleft)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[9];




                objParam[0] = new SqlParameter("@mlref", txtlrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mlyear", txtlyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


             
                


                objParam[3] = new SqlParameter("@mstid", txtstid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;


                objParam[4] = new SqlParameter("@mtxtdays", txtdays);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@mtxtstart", HR_Report.myconvdate(txtstart));
                objParam[5].DbType = DbType.DateTime;
                objParam[5].Direction = ParameterDirection.Input;


                objParam[6] = new SqlParameter("@mtxtend", HR_Report.myconvdate(txtend));
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mtxtdspent", txtdspent);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mtxtdleft", txtdleft);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;





                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Leave_Details";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }


    }


    public static void save_LeaveRoaster_detailp(string txtlrefno, string txtlyear, string txtsno, string txtloc, string txtdept, string txtstid, string txtdays, string txtstart, string txtend, string txtdspent, string txtdleft)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[9];




                objParam[0] = new SqlParameter("@mlref", txtlrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mlyear", txtlyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;






                objParam[3] = new SqlParameter("@mstid", txtstid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;


                objParam[4] = new SqlParameter("@mtxtdays", txtdays);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@mtxtstart", HR_Report.myconvdate(txtstart));
                objParam[5].DbType = DbType.DateTime;
                objParam[5].Direction = ParameterDirection.Input;


                objParam[6] = new SqlParameter("@mtxtend", HR_Report.myconvdate(txtend));
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mtxtdspent", txtdspent);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mtxtdleft", txtdleft);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;





                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Leave_Detailsp";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }


    }


    public static string Count_Leave_Detail(string myrefno,string myleaveyear)
    {
        string myno = "0";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select count(*) as mycount from Leave_Roaster_Details_Temp  where Leave_Ref_No='" + myrefno + "'" + " and Leave_year='"+myleaveyear+"'";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {

                    myno = dr["mycount"].ToString();
                }
            }

        }
        return myno;
    }



    public static void Save_Leave_Head(string txtlrefno,string txtlyear, string txtsno,  string cmbloc, string cmbdept, string apprby, string txtentd, string remark, string pst, string chkby, string chkd, string remc, string chs)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[13];



                objParam[0] = new SqlParameter("@mlref", txtlrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mlyear", txtlyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;



                objParam[3] = new SqlParameter("@mcmbloc", cmbloc);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;


                objParam[4] = new SqlParameter("@mcmbdept", cmbdept);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mapprby", apprby);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;



                objParam[6] = new SqlParameter("@mtxtentd", txtentd);
                objParam[6].DbType = DbType.DateTime;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mremark", remark);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mpst", pst);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@machkby", chkby);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mchkd", chkd);
                objParam[10].DbType = DbType.DateTime;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@mremarkc", remc);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;


                objParam[12] = new SqlParameter("@mpstc", chs);
                objParam[12].DbType = DbType.String;
                objParam[12].Direction = ParameterDirection.Input;

                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_Leave_Roaster_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }
    }


    public static void Save_Transfer_Head(string txttrefno, string txttyear, string txtsno, string apprby, string txtentd, string remark, string pst, string chkby, string chkd, string remc, string chs)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[11];



                objParam[0] = new SqlParameter("@mtref", txttrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtyear", txttyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;



            
                objParam[3] = new SqlParameter("@mapprby", apprby);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;



                objParam[4] = new SqlParameter("@mtxtentd", HR_Report.myconvdate(txtentd));
                objParam[4].DbType = DbType.DateTime;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mremark", remark);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mpst", pst);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@machkby", chkby);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mchkd", HR_Report.myconvdate(chkd));
                objParam[8].DbType = DbType.DateTime;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mremarkc", remc);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;


                objParam[10] = new SqlParameter("@mpstc", chs);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Transfer_Roaster_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }
    }


    public static void save_TransferRoaster_detail(string txttrefno, string txttyear, string txtsno, string txtstid, string oloc, string odept, string osec, string dloc, string ddept, string dsec, string tdate, string treason)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[12];




                objParam[0] = new SqlParameter("@mtref", txttrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtyear", txttyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;






                objParam[3] = new SqlParameter("@mstid", txtstid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;


                objParam[4] = new SqlParameter("@moloc", oloc);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@modept", odept);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;


                objParam[6] = new SqlParameter("@mosec", osec);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mdloc", dloc);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mddept", ddept);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mdsec", dsec);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mtdate", tdate);
                objParam[10].DbType = DbType.DateTime;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@mtreason", treason);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;





                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Transfer_Details_Temp";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }


    }


    public static void save_TransferRoaster_detailapp(string txttrefno, string txttyear, string txtsno, string txtstid, string oloc, string odept, string osec, string dloc, string ddept, string dsec, string tdate, string treason)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[12];




                objParam[0] = new SqlParameter("@mtref", txttrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtyear", txttyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;






                objParam[3] = new SqlParameter("@mstid", txtstid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;


                objParam[4] = new SqlParameter("@moloc", oloc);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@modept", odept);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;


                objParam[6] = new SqlParameter("@mosec", osec);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mdloc", dloc);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mddept", ddept);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mdsec", dsec);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mtdate", tdate);
                objParam[10].DbType = DbType.DateTime;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@mtreason", treason);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;





                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Transfer_Details";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }


    }



    public static string Count_Transfer_Detail(string myrefno, string mytransferyear)
    {
        string myno = "0";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select count(*) as mycount from Transfer_Roaster_Details_Temp  where Transfer_Ref_No='" + myrefno + "'" + " and Transfer_year='" + mytransferyear + "'";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {

                    myno = dr["mycount"].ToString();
                }
            }

        }
        return myno;
    }



    public static void Delete_Transfer_Roaster_Details_Temp(string trefno, string sno)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from  Transfer_Roaster_Details_Temp where Transfer_Ref_No ='" + trefno + "' " + " and SNO ='" + sno + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static void Save_TrTrans_Head(string txtttrefno, string txtttyear, string txtsno, string apprby, string txtentd, string remark, string pst, string chkby, string chkd, string remc, string chs)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[11];



                objParam[0] = new SqlParameter("@mtrtref", txtttrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtrtyear", txtttyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;




                objParam[3] = new SqlParameter("@mapprby", apprby);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;



                objParam[4] = new SqlParameter("@mtxtentd", HR_Report.myconvdate(txtentd));
                objParam[4].DbType = DbType.DateTime;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mremark", remark);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mpst", pst);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@machkby", chkby);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mchkd", HR_Report.myconvdate(chkd));
                objParam[8].DbType = DbType.DateTime;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mremarkc", remc);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;


                objParam[10] = new SqlParameter("@mpstc", chs);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_TrTrans_Roaster_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }
    }




    public static string Save_TrTransDet(string txtttrefno, string txtttyear, string txtsno, string stid, string traint, string trainn, string traindate, string traindur, string trainins, string certob)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[10];

                objParam[0] = new SqlParameter("@mtrtref", txtttrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtrtyear", txtttyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                objParam[3] = new SqlParameter("@mstid", stid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mtraint", traint);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mtrainn", trainn);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mtraindate", traindate);
                objParam[6].DbType = DbType.DateTime;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mtraindur", traindur);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mtrainins", trainins);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mcertob", certob);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_TrTrans_Roaster_Details_Temp";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static string Save_TrTransDetapp(string txtttrefno, string txtttyear, string txtsno, string stid, string traint, string trainn, string traindate, string traindur, string trainins, string certob)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[10];

                objParam[0] = new SqlParameter("@mtrtref", txtttrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtrtyear", txtttyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;


                objParam[3] = new SqlParameter("@mstid", stid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mtraint", traint);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mtrainn", trainn);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mtraindate", traindate);
                objParam[6].DbType = DbType.DateTime;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mtraindur", traindur);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mtrainins", trainins);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mcertob", certob);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_TrTrans_Roaster_Details";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static string Retrieve_DetailtTrTrans(string myrefno, GridView gridview2)
    {
        string myno = "";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select a.Sno as [S/No],a.staff_id as [Staff No],b.surname as [Surname],b.first_name as [First Name],a.Training_Type as [Training Type], a.Training_Code as[Training Name],a.Training_Date as [Training Date],a.Duration as [Duration], a.Institution_Of_Training as [Institution Of Training],a.Certificate_Obtained as [Certificate Obtained] from TrTrans_Roaster_Details_Temp a,Staff_master b where a.TrTrans_Ref_No='" + myrefno + "'" + " and a.staff_id=b.staff_id " + " order by a.SNo";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                gridview2.DataSource = dt;
                gridview2.DataBind();
                if (gridview2.Rows.Count == 0)
                {
                    myno = "1";
                }
                else if (gridview2.Rows.Count > 0)
                {
                    myno = (gridview2.Rows.Count + 1).ToString();

                }

            }
            return myno;
        }

    }


    public static void Save_TrNom_Head(string txttnrefno, string txttnyear, string txtsno, string apprby, string txtentd, string remark, string pst, string chkby, string chkd, string remc, string chs)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[11];



                objParam[0] = new SqlParameter("@mtrnref", txttnrefno);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mtrnyear", txttnyear);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", txtsno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;




                objParam[3] = new SqlParameter("@mapprby", apprby);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;



                objParam[4] = new SqlParameter("@mtxtentd", HR_Report.myconvdate(txtentd));
                objParam[4].DbType = DbType.DateTime;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mremark", remark);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@mpst", pst);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@machkby", chkby);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mchkd", HR_Report.myconvdate(chkd));
                objParam[8].DbType = DbType.DateTime;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mremarkc", remc);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;


                objParam[10] = new SqlParameter("@mpstc", chs);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_TrNom_Roaster_Head";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }
    }



    public static string Save_TrNomDet( string txttrn, string txttrny, string sno, string stid, string loc, string dept, string sec, string nomcode, string traindate, string traindur, string orgname, string orgadd)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[12];

                objParam[0] = new SqlParameter("@mtrnref", txttrn);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mttnyear", txttrny);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", sno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mstid", stid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mloc", loc);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@mdept", dept);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@msec", sec);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mcode", nomcode);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mtraindate", traindate);
                objParam[8].DbType = DbType.DateTime;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mtraindur", traindur);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@morgname", orgname);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@morgadd", orgadd);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_TrNomDet";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static string Save_TrNomDet_Temp(string txttrn, string txttrny, string sno, string stid, string loc, string dept, string sec, string nomcode, string traindate, string traindur, string orgname, string orgadd)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction ststrans;
                ststrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[12];

                objParam[0] = new SqlParameter("@mtrnref", txttrn);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mttnyear", txttrny);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@msno", sno);
                objParam[2].DbType = DbType.String;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mstid", stid);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mloc", loc);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;


                objParam[5] = new SqlParameter("@mdept", dept);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;

                objParam[6] = new SqlParameter("@msec", sec);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mcode", nomcode);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mtraindate", traindate);
                objParam[8].DbType = DbType.DateTime;
                objParam[8].Direction = ParameterDirection.Input;

                objParam[9] = new SqlParameter("@mtraindur", traindur);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@morgname", orgname);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@morgadd", orgadd);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;

                sqlcmd.Connection = ststrans.Connection;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = "stp_Save_TrNomDet_Temp";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = ststrans;

                int intResult = sqlcmd.ExecuteNonQuery();
                ststrans.Commit();
                return intResult.ToString();

            }
        }
    }


    public static string Retrieve_DetailtNom(string myrefno, GridView gridview2)
    {
        string myno = "";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select a.Sno as [S/No],a.staff_id as [Staff No],b.surname as [Surname],b.first_name as [First Name],a.Location as [Location], a.Department as[Department],a.Section as [Section],a.Training_Code as [Training Name], a.Training_Date as [Training Date],a.Training_Duration as [Training Duration],a.Organisation_Name as [Organisation Name],a.Organisation_Address as [Organisation Address] from TrNom_Roaster_Details_Temp a,Staff_master b where a.TrNom_Ref_No='" + myrefno + "'" + " and a.staff_id=b.staff_id " + " order by a.SNo";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                gridview2.DataSource = dt;
                gridview2.DataBind();
                if (gridview2.Rows.Count == 0)
                {
                    myno = "1";
                }
                else if (gridview2.Rows.Count > 0)
                {
                    myno = (gridview2.Rows.Count + 1).ToString();

                }

            }
            return myno;
        }

    }

    public static void Save_Appr_Header(string txtstid, string apprt, string stdate, string enddate, string retdate)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[5];



                objParam[0] = new SqlParameter("@mstid", txtstid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

                objParam[1] = new SqlParameter("@mapprt", apprt);
                objParam[1].DbType = DbType.String;
                objParam[1].Direction = ParameterDirection.Input;

                objParam[2] = new SqlParameter("@mstd", HR_Report.myconvdate(stdate));
                objParam[2].DbType = DbType.DateTime;
                objParam[2].Direction = ParameterDirection.Input;



                objParam[3] = new SqlParameter("@mendd", HR_Report.myconvdate(enddate));
                objParam[3].DbType = DbType.DateTime;
                objParam[3].Direction = ParameterDirection.Input;


                   
                objParam[4] = new SqlParameter("@mretd", HR_Report.myconvdate(retdate));
                objParam[4].DbType = DbType.DateTime;
                objParam[4].Direction = ParameterDirection.Input;




                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Appr_Header";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }
    }


    public static void Delete_Appr_Header(string stid)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Appraisal_Header where Staff_Id ='" + stid + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }

    public static void Save_Appr_Details(string txtstid, string stdate, string enddate,string code1,string rem1, string rat1,
        string code2,string rem2, string rat2,string code3,string rem3, string rat3,string code4,string rem4, string rat4,
        string code5,string rem5, string rat5,string code6,string rem6, string rat6,string code7,string rem7, string rat7,
        string code8,string rem8, string rat8,string code9,string rem9, string rat9,string code10,string rem10, string rat10,
        string code11,string rem11, string rat11,string code12,string rem12, string rat12,string code13,string rem13, string rat13,
        string code14,string rem14, string rat14,string code15,string rem15, string rat15,string code16,string rem16, string rat16,
        string code17,string rem17, string rat17,string code18,string rem18, string rat18,string code19,string rem19, string rat19,
        string code20,string rem20, string rat20)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                SqlTransaction objTrans;
                objTrans = objConn.BeginTransaction();

                SqlParameter[] objParam = new SqlParameter[63];



                objParam[0] = new SqlParameter("@mstid", txtstid);
                objParam[0].DbType = DbType.String;
                objParam[0].Direction = ParameterDirection.Input;

               

                objParam[1] = new SqlParameter("@mstd", HR_Report.myconvdate(stdate));
                objParam[1].DbType = DbType.DateTime;
                objParam[1].Direction = ParameterDirection.Input;



                objParam[2] = new SqlParameter("@mendd", HR_Report.myconvdate(enddate));
                objParam[2].DbType = DbType.DateTime;
                objParam[2].Direction = ParameterDirection.Input;

                objParam[3] = new SqlParameter("@mcode1", code1);
                objParam[3].DbType = DbType.String;
                objParam[3].Direction = ParameterDirection.Input;

                objParam[4] = new SqlParameter("@mrem1", rem1);
                objParam[4].DbType = DbType.String;
                objParam[4].Direction = ParameterDirection.Input;

                objParam[5] = new SqlParameter("@mrat1", rat1);
                objParam[5].DbType = DbType.String;
                objParam[5].Direction = ParameterDirection.Input;


                objParam[6] = new SqlParameter("@mcode2", code2);
                objParam[6].DbType = DbType.String;
                objParam[6].Direction = ParameterDirection.Input;

                objParam[7] = new SqlParameter("@mrem2", rem2);
                objParam[7].DbType = DbType.String;
                objParam[7].Direction = ParameterDirection.Input;

                objParam[8] = new SqlParameter("@mrat2", rat2);
                objParam[8].DbType = DbType.String;
                objParam[8].Direction = ParameterDirection.Input;


                objParam[9] = new SqlParameter("@mcode3", code3);
                objParam[9].DbType = DbType.String;
                objParam[9].Direction = ParameterDirection.Input;

                objParam[10] = new SqlParameter("@mrem3", rem3);
                objParam[10].DbType = DbType.String;
                objParam[10].Direction = ParameterDirection.Input;

                objParam[11] = new SqlParameter("@mrat3", rat3);
                objParam[11].DbType = DbType.String;
                objParam[11].Direction = ParameterDirection.Input;

                objParam[12] = new SqlParameter("@mcode4", code4);
                objParam[12].DbType = DbType.String;
                objParam[12].Direction = ParameterDirection.Input;

                objParam[13] = new SqlParameter("@mrem4", rem4);
                objParam[13].DbType = DbType.String;
                objParam[13].Direction = ParameterDirection.Input;

                objParam[14] = new SqlParameter("@mrat4", rat4);
                objParam[14].DbType = DbType.String;
                objParam[14].Direction = ParameterDirection.Input;

                objParam[15] = new SqlParameter("@mcode5", code5);
                objParam[15].DbType = DbType.String;
                objParam[15].Direction = ParameterDirection.Input;

                objParam[16] = new SqlParameter("@mrem5", rem5);
                objParam[16].DbType = DbType.String;
                objParam[16].Direction = ParameterDirection.Input;

                objParam[17] = new SqlParameter("@mrat5", rat5);
                objParam[17].DbType = DbType.String;
                objParam[17].Direction = ParameterDirection.Input;

                objParam[18] = new SqlParameter("@mcode6", code6);
                objParam[18].DbType = DbType.String;
                objParam[18].Direction = ParameterDirection.Input;

                objParam[19] = new SqlParameter("@mrem6", rem6);
                objParam[19].DbType = DbType.String;
                objParam[19].Direction = ParameterDirection.Input;

                objParam[20] = new SqlParameter("@mrat6", rat6);
                objParam[20].DbType = DbType.String;
                objParam[20].Direction = ParameterDirection.Input;

                objParam[21] = new SqlParameter("@mcode7", code7);
                objParam[21].DbType = DbType.String;
                objParam[21].Direction = ParameterDirection.Input;

                objParam[22] = new SqlParameter("@mrem7", rem7);
                objParam[22].DbType = DbType.String;
                objParam[22].Direction = ParameterDirection.Input;

                objParam[23] = new SqlParameter("@mrat7", rat7);
                objParam[23].DbType = DbType.String;
                objParam[23].Direction = ParameterDirection.Input;


                objParam[24] = new SqlParameter("@mcode8", code8);
                objParam[24].DbType = DbType.String;
                objParam[24].Direction = ParameterDirection.Input;

                objParam[25] = new SqlParameter("@mrem8", rem8);
                objParam[25].DbType = DbType.String;
                objParam[25].Direction = ParameterDirection.Input;

                objParam[26] = new SqlParameter("@mrat8", rat8);
                objParam[26].DbType = DbType.String;
                objParam[26].Direction = ParameterDirection.Input;


                objParam[27] = new SqlParameter("@mcode9", code9);
                objParam[27].DbType = DbType.String;
                objParam[27].Direction = ParameterDirection.Input;

                objParam[28] = new SqlParameter("@mrem9", rem9);
                objParam[28].DbType = DbType.String;
                objParam[28].Direction = ParameterDirection.Input;

                objParam[29] = new SqlParameter("@mrat9", rat9);
                objParam[29].DbType = DbType.String;
                objParam[29].Direction = ParameterDirection.Input;


                objParam[30] = new SqlParameter("@mcode10", code10);
                objParam[30].DbType = DbType.String;
                objParam[30].Direction = ParameterDirection.Input;

                objParam[31] = new SqlParameter("@mrem10", rem10);
                objParam[31].DbType = DbType.String;
                objParam[31].Direction = ParameterDirection.Input;

                objParam[32] = new SqlParameter("@mrat10", rat10);
                objParam[32].DbType = DbType.String;
                objParam[32].Direction = ParameterDirection.Input;


                objParam[33] = new SqlParameter("@mcode11", code11);
                objParam[33].DbType = DbType.String;
                objParam[33].Direction = ParameterDirection.Input;

                objParam[34] = new SqlParameter("@mrem11", rem11);
                objParam[34].DbType = DbType.String;
                objParam[34].Direction = ParameterDirection.Input;

                objParam[35] = new SqlParameter("@mrat11", rat11);
                objParam[35].DbType = DbType.String;
                objParam[35].Direction = ParameterDirection.Input;


                objParam[36] = new SqlParameter("@mcode12", code12);
                objParam[36].DbType = DbType.String;
                objParam[36].Direction = ParameterDirection.Input;

                objParam[37] = new SqlParameter("@mrem12", rem12);
                objParam[37].DbType = DbType.String;
                objParam[37].Direction = ParameterDirection.Input;

                objParam[38] = new SqlParameter("@mrat12", rat12);
                objParam[38].DbType = DbType.String;
                objParam[38].Direction = ParameterDirection.Input;


                objParam[39] = new SqlParameter("@mcode13", code13);
                objParam[39].DbType = DbType.String;
                objParam[39].Direction = ParameterDirection.Input;

                objParam[40] = new SqlParameter("@mrem13", rem13);
                objParam[40].DbType = DbType.String;
                objParam[40].Direction = ParameterDirection.Input;

                objParam[41] = new SqlParameter("@mrat13", rat13);
                objParam[41].DbType = DbType.String;
                objParam[41].Direction = ParameterDirection.Input;


                objParam[42] = new SqlParameter("@mcode14", code14);
                objParam[42].DbType = DbType.String;
                objParam[42].Direction = ParameterDirection.Input;

                objParam[43] = new SqlParameter("@mrem14", rem14);
                objParam[43].DbType = DbType.String;
                objParam[43].Direction = ParameterDirection.Input;

                objParam[44] = new SqlParameter("@mrat14", rat14);
                objParam[44].DbType = DbType.String;
                objParam[44].Direction = ParameterDirection.Input;


                objParam[45] = new SqlParameter("@mcode15", code15);
                objParam[45].DbType = DbType.String;
                objParam[45].Direction = ParameterDirection.Input;

                objParam[46] = new SqlParameter("@mrem15", rem15);
                objParam[46].DbType = DbType.String;
                objParam[46].Direction = ParameterDirection.Input;

                objParam[47] = new SqlParameter("@mrat15", rat15);
                objParam[47].DbType = DbType.String;
                objParam[47].Direction = ParameterDirection.Input;


                objParam[48] = new SqlParameter("@mcode16", code16);
                objParam[48].DbType = DbType.String;
                objParam[48].Direction = ParameterDirection.Input;

                objParam[49] = new SqlParameter("@mrem16", rem16);
                objParam[49].DbType = DbType.String;
                objParam[49].Direction = ParameterDirection.Input;

                objParam[50] = new SqlParameter("@mrat16", rat16);
                objParam[50].DbType = DbType.String;
                objParam[50].Direction = ParameterDirection.Input;


                objParam[51] = new SqlParameter("@mcode17", code17);
                objParam[51].DbType = DbType.String;
                objParam[51].Direction = ParameterDirection.Input;

                objParam[52] = new SqlParameter("@mrem17", rem17);
                objParam[52].DbType = DbType.String;
                objParam[52].Direction = ParameterDirection.Input;

                objParam[53] = new SqlParameter("@mrat17", rat17);
                objParam[53].DbType = DbType.String;
                objParam[53].Direction = ParameterDirection.Input;


                objParam[54] = new SqlParameter("@mcode18", code18);
                objParam[54].DbType = DbType.String;
                objParam[54].Direction = ParameterDirection.Input;

                objParam[55] = new SqlParameter("@mrem18", rem18);
                objParam[55].DbType = DbType.String;
                objParam[55].Direction = ParameterDirection.Input;

                objParam[56] = new SqlParameter("@mrat18", rat18);
                objParam[56].DbType = DbType.String;
                objParam[56].Direction = ParameterDirection.Input;


                objParam[57] = new SqlParameter("@mcode19", code19);
                objParam[57].DbType = DbType.String;
                objParam[57].Direction = ParameterDirection.Input;

                objParam[58] = new SqlParameter("@mrem19", rem19);
                objParam[58].DbType = DbType.String;
                objParam[58].Direction = ParameterDirection.Input;

                objParam[59] = new SqlParameter("@mrat19", rat19);
                objParam[59].DbType = DbType.String;
                objParam[59].Direction = ParameterDirection.Input;


                objParam[60] = new SqlParameter("@mcode20", code20);
                objParam[60].DbType = DbType.String;
                objParam[60].Direction = ParameterDirection.Input;

                objParam[61] = new SqlParameter("@mrem20", rem20);
                objParam[61].DbType = DbType.String;
                objParam[61].Direction = ParameterDirection.Input;

                objParam[62] = new SqlParameter("@mrat20", rat20);
                objParam[62].DbType = DbType.String;
                objParam[62].Direction = ParameterDirection.Input;



                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.CommandText = "stp_Save_Appr_Details";
                sqlcmd.Parameters.AddRange(objParam);
                sqlcmd.Transaction = objTrans;
                sqlcmd.ExecuteNonQuery();
                objTrans.Commit();
            }
        }
    }


    public static void Delete_Appr_Details(string stid)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from Appraisal_Details where Staff_Id ='" + stid + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }
    public static string Retrieve_Details(string myrefno, GridView gridview2)
    {
        string myno = "";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select a.Sno as [S/No],a.staff_id as [Staff No],b.surname as [Surname],b.first_name as [First Name],a.No_Of_Days as [No Of Days], a.Start_Date as[Start Date],a.End_Date as [End Date],a.No_Of_Days_Spent as [Days Spent], a.No_Of_Days_Left as [Days Left] from Leave_Roaster_Details_Temp a,Staff_master b where a.Leave_Ref_No='" + myrefno + "'" + " and a.staff_id=b.staff_id " + " order by a.SNo";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                gridview2.DataSource = dt;
                gridview2.DataBind();
                if (gridview2.Rows.Count == 0)
                {
                    myno = "1";
                }
                else if (gridview2.Rows.Count > 0)
                {
                    myno = (gridview2.Rows.Count + 1).ToString();

                }

            }
            return myno;
        }

    }


    public static string Retrieve_Detailt(string myrefno, GridView gridview2)
    {
        string myno = "";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select a.Sno as [S/No],a.staff_id as [Staff No],b.surname as [Surname],b.first_name as [First Name],a.Original_Loc as [ Original Location], a.Original_Dept as[Original Dept],a.Original_Section as [Original Section],a.Dest_Loc as [Dest Loc], a.Dest_Dept as [Dest Dept], a.Dest_Sec as[Dest Sec], a.Trans_Date as [Trans Date], a.Trans_Reason as [TransReason] from Transfer_Roaster_Details_Temp a,Staff_master b where a.Transfer_Ref_No='" + myrefno + "'" + " and a.staff_id=b.staff_id " + " order by a.SNo";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                gridview2.DataSource = dt;
                gridview2.DataBind();
                if (gridview2.Rows.Count == 0)
                {
                    myno = "1";
                }
                else if (gridview2.Rows.Count > 0)
                {
                    myno = (gridview2.Rows.Count + 1).ToString();

                }

            }
            return myno;
        }

    }

    public static string Retrieve_Detailz(string myrefno, GridView gridview2)
    {
        string myno = "";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select a.Sno as [S/No],a.staff_id as [Staff No],b.surname as [Surname],b.first_name as [First Name],a.No_Of_Days as [No Of Days], a.Start_Date as[Start Date],a.End_Date as [End Date],a.No_Of_Days_Spent as [Days Spent], a.No_Of_Days_Left as [Days Left] from Leave_Roaster_Details_Temp a,Staff_master b where a.Leave_Ref_No='" + myrefno + "'" + " and a.staff_id=b.staff_id " + " order by a.SNo";
                SqlDataAdapter myadapter = new SqlDataAdapter(sqlcmd);
                myadapter.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                gridview2.DataSource = dt;
                gridview2.DataBind();
                if (gridview2.Rows.Count == 0)
                {
                    myno = "1";
                }
                else if (gridview2.Rows.Count > 0)
                {
                    myno = (gridview2.Rows.Count+1).ToString();
                  
                }

            }
            return myno;
        }




    }

    public static void Delete_Leave_Roaster_Details_Temp(string lrefno,string sno)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from  Leave_Roaster_Details_Temp where Leave_Ref_No ='" + lrefno + "' " + " and SNO ='"+ sno + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }

    public static void Delete_TrainingTrans_Details_Temp(string ttransrefno, string sno)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from  TrTrans_Roaster_Details_Temp where TrTrans_Ref_No ='" + ttransrefno + "' " + " and SNO ='" + sno + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }




    public static void Delete_Promotion_Details_Temp(string prefno, string sno)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from  Promotion_Details_Temp where Promo_Ref_No ='" + prefno + "' " + " and SNO ='" + sno + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static void Delete_TrNom_Details_Temp(string prefno, string sno)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                sqlcmd.CommandText = "delete from  TrNom_Roaster_Details_Temp where TrNom_Ref_No ='" + prefno + "' " + " and SNO ='" + sno + "'";
                sqlcmd.ExecuteNonQuery();

            }
        }
    }


    public static string Compute_Leave(string myrefno, string myleaveyear,string stid)
    {
        string mysum = "0";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select  sum(no_of_days) as mno from Leave_Transactions a, leave_type b  where a.Staff_Id='" + stid + "'" + " and a.type_code=b.TYPE_CODE and b.deductable='Y'";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                   
                    mysum = dr["mno"].ToString();
                }
            }

        }
        return mysum;
    }



    public static string Count_Appr_Subj()
    {
        string myno = "0";
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select count(*) as mycount from Appraisal_Subject";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                    myno = dr["mycount"].ToString();
                    int fn = int.Parse(myno) + 1;
                    myno = fn.ToString();

                }
            }

        }
        return myno;
    }

}



