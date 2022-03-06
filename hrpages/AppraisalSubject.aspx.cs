using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_AppraisalSubject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
        if(!IsPostBack)
        txtsno.Text = SaveRecord.Count_Appr_Subj();

    }

    protected void txtsno_TextChanged(object sender, EventArgs e)
    { 
       
       
      
    }
    protected void TxtCode_TextChanged(object sender, EventArgs e)
    {
        txtsno.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Apprsubj_Tab, AppFields.Apprsubj_Fld1a, TxtCode.Text, "string");
        TxtName.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, AppFields.Apprsubj_Fld1a, TxtCode.Text, "string");

        if (txtsno.Text == string.Empty)
        { 
        var mb = SaveRecord.Count_Appr_Subj();
        txtsno.Text = mb.ToString();
        }
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        
        lbldanger.Text = "";

       
        if(int.Parse(txtsno.Text.ToString()) <= 20 )
        {

            SaveRecord.Save_Appr_Subj(txtsno.Text, TxtCode.Text, TxtName.Text);
            lblsuccess.Text = "Record Saved Successfully";
     
      
        }
        else
        {
            lblsuccess.Text = "";
            lbldanger.Text = "YOU ARE ABOVE THE MAX !!!";
            
        }

        TxtCode.Text = "";
        TxtName.Text = "";
        var mb = SaveRecord.Count_Appr_Subj();
        txtsno.Text = mb.ToString();

    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Appr_Subj(TxtCode.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        TxtCode.Text = "";
        TxtName.Text = "";
        txtsno.Text = SaveRecord.Count_Appr_Subj();
    }

}