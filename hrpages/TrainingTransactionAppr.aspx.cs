using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_TrainingTransactionAppr : System.Web.UI.Page
{
    private static string gtraint, gcmbn, kj, chs, pst;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbname, AppTables.Traint_Tab);
        }
    }

    protected void txtttrefno_TextChanged(object sender, EventArgs e)
    {
        pst = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");

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


        chs = RetrieveFields.retrieveByFieldIndex_HasOneKey(10, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");

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

        txtapprby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");
        txtchkby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");
        txtremark.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");
        txtremarkc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");



        txttyear.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");


        string hg = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");
        if (hg == string.Empty)
        {
            txtentd.Text = "";
        }
        else
        {
            DateTime ch = DateTime.Parse(hg);
            txtentd.Text = ch.ToShortDateString();
        }

        string sd = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.StTrTransHead_Tab, AppFields.StTrTrans_Fld1a, txtttrefno.Text, "string");
        if (sd == string.Empty)
        {
            DateTime ht = DateTime.Now;
            txtchkd.Text = ht.ToShortDateString();
        }
        else
        {
            DateTime cu = DateTime.Parse(sd);
            txtchkd.Text = cu.ToShortDateString();
        }

        int sb = int.Parse(SaveRecord.Retrieve_DetailtTrTrans(txtttrefno.Text, gridview2)) - 1;
        txtsno.Text = sb.ToString();

        if (txtsno.Text == "0")
        {
            txtsno.Text = "1";
        }

        //   txtsno.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");

        // SaveRecord.Retrieve_Details(txtlrefno.Text, gridview2);
        //  txtsno.Text = (int.Parse(gridview2.Rows[gridview2.Rows.Count - 1].Cells[1].Text) + 1).ToString();
        //txtsno.Text = SaveRecord.Retrieve_DetailtTrTrans(txtttrefno.Text, gridview2);
    }






    protected void submitButton_Click(object sender, EventArgs e)
    {


        if (pst == "Y")
        {
            SaveRecord.Save_TrTransDetapp(txtttrefno.Text, txttyear.Text, txtsno.Text, txtstid.Text, gtraint, gcmbn, traindate.Text, traindur.Text, trainins.Text, certob.Text);
            SaveRecord.Delete_TrainingTrans_Details_Temp(txtttrefno.Text, txtsno.Text);
        }
        else
        {
            SaveRecord.Save_TrTransDet(txtttrefno.Text, txttyear.Text, txtsno.Text, txtstid.Text, gtraint, gcmbn, traindate.Text, traindur.Text, trainins.Text, certob.Text);
        }

     
        SaveRecord.Save_TrTrans_Head(txtttrefno.Text, txttyear.Text, txtsno.Text, txtapprby.Text, txtentd.Text, txtremark.Text, pst, txtchkby.Text, txtchkd.Text, txtremarkc.Text, chs);
        // txtsno.Text = SaveRecord.Count_Transfer_Detail(txttrefno.Text, txttyear.Text);
        SaveRecord.Retrieve_Details(txtttrefno.Text, gridview2);
        txtsno.Text = (int.Parse(gridview2.Rows[gridview2.Rows.Count - 1].Cells[1].Text) + 1).ToString();


       
        // txtsno.Text = (int.Parse(gridview2.Rows[gridview2.Rows.Count - 1].Cells[1].Text) + 1).ToString();

        clear_controls();
        lbldanger.Text = "";
        lblsuccess.Text = "Record Save Successfully";
    }
    protected void gridview2_SelectedIndexChanged(object sender, EventArgs e)
    {

        var msno = gridview2.SelectedRow.Cells[1].Text;
        var mystid = gridview2.SelectedRow.Cells[2].Text;

        //var msur = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystid, "string");
        //var mfirst = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystid, "string");
        //var mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, mystid, "string");
        txtstid.Text = mystid;
        txtname.Text = HR_Report.Return_StaffName(mystid);
        txtsno.Text = msno;


        kj = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.StTrTransDettemp_Tab, AppFields.TrTransDet_Fld1a, txtstid.Text, "string");
        if (kj != string.Empty)
        {
            DateTime ol = HR_Report.myconvdate(kj);
            traindate.Text = ol.ToShortDateString();
        }
        else
        {
            traindate.Text = "";
        }

        traindur.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.StTrTransDettemp_Tab, AppFields.TrTransDet_Fld1a, txtstid.Text, "string");
        trainins.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.StTrTransDettemp_Tab, AppFields.TrTransDet_Fld1a, txtstid.Text, "string");
        certob.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.StTrTransDettemp_Tab, AppFields.TrTransDet_Fld1a, txtstid.Text, "string");
        gcmbn = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.StTrTransDettemp_Tab, AppFields.TrTransDet_Fld1a, txtstid.Text, "string");
        cmbname.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Traint_Tab, AppFields.Traint_Fld1a, gcmbn, "string");
        gtraint = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.StTrTransDettemp_Tab, AppFields.TrTransDet_Fld1a, txtstid.Text, "string");
        if (gtraint != "" && gtraint == "INT")
            intt.Checked = true;
        else if (gtraint != "" && gtraint == "EXT")
            extt.Checked = true;

    }



    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_TrainingTrans_Details_Temp(txtttrefno.Text, txtsno.Text);
        lblsuccess.Text = "";
        clear_controls();
        lbldanger.Text = "Record Deleted Successfully";
        // SaveRecord.Count_Leave_Detail(txtlrefno.Text, txtlyear.Text);

        SaveRecord.Retrieve_DetailtTrTrans(txtttrefno.Text, gridview2);
        txtsno.Text = (int.Parse(gridview2.Rows[gridview2.Rows.Count - 1].Cells[1].Text) + 1).ToString();

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




    protected void txtstid_TextChanged(object sender, EventArgs e)
    {

        txtname.Text = HR_Report.Return_StaffName(txtstid.Text);
        SaveRecord.Retrieve_DetailtTrTrans(txtttrefno.Text, gridview2);
        txtsno.Text = SaveRecord.Retrieve_DetailtTrTrans(txtttrefno.Text, gridview2);
    }
    protected void intt_CheckedChanged(object sender, EventArgs e)
    {
        if (intt.Checked == true)
        {
            extt.Checked = false;
            gtraint = "INT";
        }
    }
    protected void extt_CheckedChanged(object sender, EventArgs e)
    {
        if (extt.Checked == true)
        {
            intt.Checked = false;
            gtraint = "EXT";
        }
    }
    private void clear_controls()
    {
        txtstid.Text = "";
        traindate.Text = "";
        cmbname.SelectedItem.Text = "";
        traindur.Text = "";
        trainins.Text = "";
        certob.Text = "";
        txtremark.Text = "";
        txtremarkc.Text = "";
        txtname.Text = "";
        intt.Checked = false;
        extt.Checked = false;
    }
    protected void cmbname_SelectedIndexChanged(object sender, EventArgs e)
    {
        gcmbn = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Traint_Tab, AppFields.Traint_Fld1b, cmbname.SelectedItem.Text, "string");
    }

    protected void txtentd_TextChanged(object sender, EventArgs e)
    {
        if (txtentd.Text != string.Empty)
        {
            DateTime tn = DateTime.Parse(txtentd.Text);
            txtentd.Text = tn.ToShortDateString();
        }

        else
        {
            txtentd.Text = "00/00/0000";
        }
    }
}