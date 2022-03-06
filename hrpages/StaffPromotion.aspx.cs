using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class hrpages_StaffPromotion : System.Web.UI.Page
{
    private static string chs,pst,datega;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        var msur = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        var mfirst = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        var mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        lblname.Text = msur +" "+ mfirst +" "+ mlast;
        lblgrade.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(16, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");

    }
    protected void gridview1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        var msno = gridview1.SelectedRow.Cells[1].Text;
        var mystid = gridview1.SelectedRow.Cells[2].Text;
        var msur = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystid, "string");
        var mfirst = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystid, "string");
        var mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystid, "string");
        txtstid.Text = mystid;
        lblname.Text = msur + " " + mfirst + " " + mlast;
        txtnstep.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(7, AppTables.StPromotemp_Tab, AppFields.StProhead_Fld1a, txtprefno.Text,AppFields.Emphis_Fld1a,mystid, "string");

       txtngrade.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(6, AppTables.StPromotemp_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, AppFields.Emphis_Fld1a, mystid, "string");


   lblgrade.Text  = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(4, AppTables.StPromotemp_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, AppFields.Emphis_Fld1a, mystid, "string");

   string mgd = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(9, AppTables.StPromotemp_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
   DateTime pok = DateTime.Parse(mgd);
   datega = pok.ToShortDateString();
   // datega = DateTime.ParseExact(mgd, "dd/MM/yyyy", new System.Globalization.DateTimeFormatInfo()).ToString();
    txtpdate.Text = datega;



   txtsno.Text = msno;

    }
    protected void txtprefno_TextChanged(object sender, EventArgs e)
    {
        pst = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");

        if (pst != "" && pst == "Y")
        {
            txtyes.Checked = true;
            txtno.Checked = false;
        }

        else if (pst != "" && pst == "N")
        {
            txtno.Checked = true;
            txtyes.Checked = false;
        }

        else
        {
            txtyes.Checked = false;
            txtno.Checked = true;
        }


        chs = RetrieveFields.retrieveByFieldIndex_HasOneKey(10, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");

        if (chs != "" && chs == "Y")
        {
            txtyc.Checked = true;
            txtnc.Checked = false;
        }

        else if (chs != "" && chs == "N")
        {
            txtnc.Checked = true;
            txtyc.Checked = false;
        }

        else
        {
            txtyc.Checked = false;
            txtnc.Checked = true;
        }
        txtpyear.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");
        txtapprby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");
        txtchkby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");
        txtremark.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");
        txtremarkc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");

       string hg = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");
        if(hg == string.Empty)
        {
            txtentd.Text = "";
        }
        else
        {
            DateTime ch = DateTime.Parse(hg);
            txtentd.Text = ch.ToShortDateString();
        }
        
       string sd = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");
       if (sd == string.Empty)
       {
           txtchkd.Text = "";
       }
       else
       {
           DateTime cu = DateTime.Parse(sd);
           txtchkd.Text = cu.ToShortDateString();
       }
    
        txtsno.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");
        txtsno.Text = SaveRecord.Retrieve_Detail(txtprefno.Text, gridview1);


    }
    protected void txtpyear_TextChanged(object sender, EventArgs e)
    {

    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.save_promo_detail(txtprefno.Text, txtsno.Text, txtstid.Text, lblgrade.Text, txtngrade.Text, txtnstep.Text, datega, lblstep.Text, txtpyear.Text, txtentd.Text);
        txtsno.Text = SaveRecord.Count_promo_Detail(txtprefno.Text);
        SaveRecord.Save_Promo_Head(txtprefno.Text, txtpyear.Text, txtsno.Text, txtapprby.Text, txtentd.Text, txtremark.Text, pst, txtchkby.Text, txtchkd.Text,txtremarkc.Text,chs);
        txtsno.Text = SaveRecord.Retrieve_Detail(txtprefno.Text, gridview1);

        lblsuccess.Text = "Record save Successfully";
        lbldanger.Text = "";

        txtstid.Text = "";
        lblname.Text = "";
        lblgrade.Text = "";
        lblstep.Text = "";
        txtngrade.Text = "";
        txtnstep.Text = "";
        txtpdate.Text = "";
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Promotion_Details_Temp(txtprefno.Text, txtsno.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        txtstid.Text = "";
        lblname.Text = "";
        lblgrade.Text = "";
        lblstep.Text = "";
        txtngrade.Text = "";
        txtnstep.Text = "";
        txtpdate.Text = "";
    }

    protected void txtyes_CheckedChanged(object sender, EventArgs e)
    {
        if (txtyes.Checked == true)
        {
            txtno.Checked = false;
            pst = "Y";
        }

    }
    protected void txtno_CheckedChanged(object sender, EventArgs e)
    {
        if (txtno.Checked == true)
        {
            txtyes.Checked = false;
            pst = "N";
        }
    }

    protected void txtyc_CheckedChanged(object sender, EventArgs e)
    {
        if (txtyc.Checked == true)
        {
            txtnc.Checked = false;
            chs = "Y";
        }

    }
    protected void txtnc_CheckedChanged(object sender, EventArgs e)
    {
        if (txtnc.Checked == true)
        {
            txtyc.Checked = false;
            chs = "N";
        }
    }

    protected void txtpdate_TextChanged(object sender, EventArgs e)
    {
        if (txtpdate.Text != string.Empty)
        {
         // datega = DateTime.ParseExact(txtpdate.Text, "dd/MM/yyyy", new System.Globalization.DateTimeFormatInfo()).ToString();
            DateTime pnk = HR_Report.myconvdate(txtpdate.Text);
            datega = pnk.ToShortDateString();
            txtpdate.Text = datega;
        }
    }
}