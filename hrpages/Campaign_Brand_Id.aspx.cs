using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient ;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MediaPages_Campaign_Brand_Id : System.Web.UI.Page
{
    public static string gbrand;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            using (SqlConnection objConn = DBConnection.Connect())
            {
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = objConn;
                    cmbbrand.Items.Clear();
                    cmbbrand.Items.Add("---Select From List---");
                    sqlcmd.CommandText = "select * from BRAND";
                    using (SqlDataReader dr = sqlcmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbbrand.Items.Add(dr["brand_desc"].ToString());
                        }
                    }
                    cmbbrand.Items.Add("---Select From List---");
                }
            }
        }
    }
    protected void cmbbrand_SelectedIndexChanged(object sender, EventArgs e)
    {
          gbrand  = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, "brand", "brand_desc", cmbbrand.SelectedItem.Text, "string");
       
    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        if (gbrand !="")
        {
            TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(2, "BRAND_CAMPAIGN", "brand_code", gbrand, "CAMPAIGN_ID", TxtCode.Text, "string");
          }
        
        }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        if (gbrand !="")
        {
           // MediaCreate.Save_Campaign(gbrand, TxtCode.Text, TxtName.Text);
        }
        else
        {
            lbldanger.Text = "Brand Must be Selected Please";
        }
            
        TxtCode.Text ="";
        TxtName.Text ="";
        cmbbrand.SelectedIndex = cmbbrand.Items.Count  -1;

    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        if (gbrand !="")
        {
           // MediaCreate.Delete_Campaign(gbrand, TxtCode.Text);
        }
        else
        {
            lbldanger.Text = "Brand Must be Selected Please";
        }

        TxtCode.Text ="";
        TxtName.Text ="";
        cmbbrand.SelectedIndex = cmbbrand.Items.Count - 1;
    }
}