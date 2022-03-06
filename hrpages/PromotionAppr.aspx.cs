using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_PromotionAppr : System.Web.UI.Page
{
    private static string pst,chs;
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        var msur = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        var mfirst = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        var mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        lblname.Text = msur + " " + mfirst + " " + mlast;
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
        txtnstep.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(7, AppTables.StPromotemp_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, AppFields.Emphis_Fld1a, mystid, "string");

        txtngrade.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(6, AppTables.StPromotemp_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, AppFields.Emphis_Fld1a, mystid, "string");


        lblgrade.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(4, AppTables.StPromotemp_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, AppFields.Emphis_Fld1a, mystid, "string");

        txtpdate.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(9, AppTables.StPromotemp_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        txtsno.Text = msno;

    }
    protected void txtprefno_TextChanged(object sender, EventArgs e)
    {
        lbldanger.Text = "";
        lblsuccess.Text = "";

        txtentd.Text = DateTime.Now.ToShortDateString();

        txtpyear.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");

        txtchkby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");

        txtremarkc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");


        txtchkd.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");

        int sb = int.Parse(SaveRecord.Retrieve_Detail(txtprefno.Text, gridview1)) - 1;
        txtsno.Text = sb.ToString();

        if (txtsno.Text == "0")
        {
            txtsno.Text = "1";
        }

        txtchkd.Text = DateTime.Now.ToShortDateString();
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

        if(chs == "Y")
        {
            txtapprby.Visible = true;
            lblapprby.Visible = true;
            txtentd.Visible = true;
            lblapprd.Visible = true;
            txtremark.Visible = true;
            lblrem.Visible = true;
            lblappr.Visible = true;
            txtno.Visible = true;
            txtyes.Visible = true;
            txtapprby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");
            txtentd.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");

         

            txtremark.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.StPromHead_Tab, AppFields.StProhead_Fld1a, txtprefno.Text, "string");


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

        }
        else
        {
            lbldanger.Text = "You cannot Approve this Batch because it is not checked yet";
            txtapprby.Visible = false;
            lblapprby.Visible = false;
            txtentd.Visible = false;
            lblapprd.Visible = false;
            txtremark.Visible = false;
            lblrem.Visible = false;
            lblappr.Visible = false;
            txtno.Visible = false;
            txtyes.Visible = false;

            pst = "N";
        }


      



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
 
    protected void txtpyear_TextChanged(object sender, EventArgs e)
    {

    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.save_promo_detail(txtprefno.Text, txtsno.Text, txtstid.Text, lblgrade.Text, txtngrade.Text, txtnstep.Text, txtpdate.Text, lblstep.Text, txtpyear.Text, txtentd.Text);
        txtsno.Text = SaveRecord.Count_leave_Detail(txtprefno.Text);
        SaveRecord.Save_Promo_Head(txtprefno.Text, txtpyear.Text, txtsno.Text, txtapprby.Text, txtentd.Text,txtremark.Text,pst, txtchkby.Text,txtchkd.Text, txtremarkc.Text,chs);
        txtsno.Text = SaveRecord.Retrieve_Detail(txtprefno.Text, gridview1);
        lblsuccess.Text = "Record save Successfully";
        lbldanger.Text = "";
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {

    }


}