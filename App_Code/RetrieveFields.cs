using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

/// <summary>
/// Summary description for Class1
/// </summary>
public class RetrieveFields
{
    public static string result;

    public static string retrieveByFieldIndex_HasOneKey(int fieldindex, string myTable, string myField, string myCode, string type)
    {
        //
        // TODO: Add constructor logic here
        //
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from " + myTable + " where " + myField + "='" + myCode + "'";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                    if (type == "string")
                    {
                        result = dr.GetValue(fieldindex).ToString();
                    }
                    else if (type == "date")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    else if (type == "time")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                    }
                    else if (type == "datetime")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                    }
                }
                else
                    result = "";
            }
        }
        return result;
    }

    public static string retrieveByFieldIndex_HasTwoKeys(int fieldindex, string myTable, string myField1, string myCode1, string myField2, string myCode2, string type)
    {
        //
        // TODO: Add constructor logic here
        //
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from " + myTable + " where " + myField1 + "='" + myCode1 + "'" + " and " + myField2 + "='" + myCode2 + "'";
                SqlDataReader dr = sqlcmd.ExecuteReader();

                if (dr.Read())
                {
                    if (type == "string")
                    {
                        result = dr.GetValue(fieldindex).ToString();
                    }
                    else if (type == "date")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    else if (type == "time")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                    }
                    else if (type == "datetime")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                    }
                }
                else
                    result = "";
            }
        }
        return result;
    }

    public static string retrieveByFieldIndex_HasThreeKeys(int fieldindex, string myTable, string myField1, string myCode1, string myField2, string myCode2, string myField3, string myCode3, string type)
    {
        //
        // TODO: Add constructor logic here
        //
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from " + myTable + " where " + myField1 + "='" + myCode1 + "'" + " and " + myField2 + "='" + myCode2 + "' and " + myField3 + "='" + myCode3 + "'";
                SqlDataReader dr = sqlcmd.ExecuteReader();

                if (dr.Read())
                {
                    if (type == "string")
                    {
                        result = dr.GetValue(fieldindex).ToString();
                    }
                    else if (type == "date")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    else if (type == "time")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                    }
                    else if (type == "datetime")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                    }
                }
                else
                    result = "";
            }
        }
        return result;
    }

    public static string retrieveByFieldIndex_HasFourKeys(int fieldindex, string myTable, string myField1, string myCode1, string myField2, string myCode2, string myField3, string myCode3, string myField4, string myCode4, string type)
    {
        //
        // TODO: Add constructor logic here
        //
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from " + myTable + " where " + myField1 + "='" + myCode1 + "'" + " and " + myField2 + "='" + myCode2 + "' and " + myField3 + "='" + myCode3 + "' and " + myField4 + "='" + myCode4 + "'";
                SqlDataReader dr = sqlcmd.ExecuteReader();

                if (dr.Read())
                {
                    if (type == "string")
                    {
                        result = dr.GetValue(fieldindex).ToString();
                    }
                    else if (type == "date")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    else if (type == "time")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                    }
                    else if (type == "datetime")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                    }
                }
                else
                    result = "";
            }
        }
        return result;
    }

    public static string retrieveByFieldIndex_HasFiveKeys(int fieldindex, string myTable, string myField1, string myCode1, string myField2, string myCode2, string myField3, string myCode3, string myField4, string myCode4, string myField5, string myCode5, string type)
    {
        //
        // TODO: Add constructor logic here
        //
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from " + myTable + " where " + myField1 + "='" + myCode1 + "'" + " and " + myField2 + "='" + myCode2 + "' and " + myField3 + "='" + myCode3 + "' and " + myField4 + "='" + myCode4 + "' and " + myField5 + "='" + myCode5 + "'";
                SqlDataReader dr = sqlcmd.ExecuteReader();

                if (dr.Read())
                {
                    if (type == "string")
                    {
                        result = dr.GetValue(fieldindex).ToString();
                    }
                    else if (type == "date")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    else if (type == "time")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("hh:mm tt", CultureInfo.InvariantCulture);
                    }
                    else if (type == "datetime")
                    {
                        DateTime mydate;
                        mydate = DateTime.Parse(dr.GetValue(fieldindex).ToString());
                        result = mydate.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                    }
                }
                else
                    result = "";
            }
        }
        return result;
    }

    //public static string retrievegltrans(string myCode)
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //    using (SqlConnection objConn = DBConnection.Connect())
    //    {
    //        using (SqlCommand sqlcmd = new SqlCommand())
    //        {
    //            sqlcmd.Connection = objConn;
    //            SqlDataReader dr;
    //            sqlcmd.CommandText = "select * from GL_BATCH_HEAD  where Batch_No='" + myCode + "'";
    //            dr = sqlcmd.ExecuteReader();
    //            return dr;
    //        }

    //    }
    //}

}