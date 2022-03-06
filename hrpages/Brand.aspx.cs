using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient ;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MediaPages_Brand : System.Web.UI.Page
{
    public static string gcustcode;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            using (SqlConnection objConn = DBConnection.Connect())
            {
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = objConn;
                    cmbcustomer.Items.Clear();
                    cmbcustomer.Items.Add("---Select From List---");
                    sqlcmd.CommandText = "select * from CUSTOMER";
                    using (SqlDataReader dr = sqlcmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbcustomer.Items.Add(dr["cust_NAME"].ToString());
                        }
                    }
                    cmbcustomer.Items.Add("---Select From List---");
                }
            }
        }
    }
    protected void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
           gcustcode  = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, "Customer", "Cust_Name", cmbcustomer.SelectedItem.Text , "string");

        
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
       // MediaCreate.Save_Brand(TxtCode.Text, TxtName.Text, gcustcode);
        lblsuccess.Text = "Record Successfully Saved";
        TxtCode.Text = "";
        TxtName.Text = "";
        cmbcustomer.SelectedIndex = cmbcustomer.Items.Count - 1;
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
       // MediaCreate.Delete_Brand(TxtCode.Text);
        lblsuccess.Text = "Record Successfully Deleted";
        TxtCode.Text = "";
        TxtName.Text = "";
        cmbcustomer.SelectedIndex = cmbcustomer.Items.Count - 1;
    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, "Brand", "Brand_code", TxtCode.Text, "string");
        gcustcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, "Brand", "Brand_code", TxtCode.Text, "string");
        if (gcustcode != "")
        {
            cmbcustomer.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, "customer", "cust_code", gcustcode, "string");
        }
        else
            cmbcustomer.SelectedIndex = cmbcustomer.Items.Count - 1;
    }
}