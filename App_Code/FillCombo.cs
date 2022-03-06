using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for FillCombo
/// </summary>
public class FillCombo
{
	public FillCombo()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void DropDownListItems(int fieldindex, DropDownList cmbID, string mytable)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                cmbID.Items.Clear();
                cmbID.Items.Add("---Select From List---");
                sqlcmd.CommandText = "select * from " + mytable + "";
                using (SqlDataReader dr = sqlcmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbID.Items.Add(dr.GetValue(fieldindex).ToString());
                    }
                }
            }
        }
    }

    public static void DropDownListItems_HasOneKey(int fieldindex, DropDownList cmbID, string mytable, string myfield, string mycode)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                cmbID.Items.Clear();
                cmbID.Items.Add("---Select From List---");
                sqlcmd.CommandText = "select * from " + mytable + " where " + myfield + "='" + mycode + "'";
                using (SqlDataReader dr = sqlcmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbID.Items.Add(dr.GetValue(fieldindex).ToString());
                    }
                }
            }
        }
    }


    public static void DropDownListItems_HasTwoKeys(int fieldindex, DropDownList cmbID, string mytable, string myfield1, string mycode1, string myfield2, string mycode2)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                cmbID.Items.Clear();
                cmbID.Items.Add("---Select From List---");
                sqlcmd.CommandText = "select * from " + mytable + " where " + myfield1 + "='" + mycode1 + "' and " + myfield2 + "='" + mycode2 + "'";
                using (SqlDataReader dr = sqlcmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbID.Items.Add(dr.GetValue(fieldindex).ToString());
                    }
                }
            }
        }
    }



    public static void DropDownSelect(int fieldindex, DropDownList cmbID, string mytable, string myfieldname, string myfieldvalue)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                
                sqlcmd.CommandText = "select * from " + mytable + "" + " where "+ myfieldname+ "='"+myfieldvalue+"'";
                using (SqlDataReader dr = sqlcmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cmbID.SelectedItem.Text = (dr.GetValue(fieldindex).ToString());
                    }
                }
            }
        }
    }



    public static void DropDownListItemsPO(int fieldindex, DropDownList cmbID, string mytable, string mysupp)
    {
        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;

                cmbID.Items.Clear();
                cmbID.Items.Add("---Select From List---");
                sqlcmd.CommandText = "select * from " + mytable + "" + " where Supp_Code='" + mysupp +"'" + " and Posted_flag='N'";
                using (SqlDataReader dr = sqlcmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                       // cmbID.Items.Add(dr["PO_NO"].ToString() +"-"+ dr["Supp_Code"].ToString());
                        cmbID.Items.Add(dr["PO_NO"].ToString() );
                    }
                }
            }
        }
    }







}