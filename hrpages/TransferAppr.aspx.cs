using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_TransferAppr : System.Web.UI.Page
{
    public static string dloc, dsec, oloc, odept, osec, ddept, msur, mfst, mlast, ggrade = "", gt = "", mypost, chs, pst;
    public static DateTime tdate;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbddept, AppTables.Dept_Tab);
            FillCombo.DropDownListItems(1, cmbdloc, AppTables.Loc_Tab);
            FillCombo.DropDownListItems(2, cmbdsect, AppTables.Sec_Tab);
            txttransdate.Text = DateTime.Now.Date.ToShortDateString();
        }
    }

    protected void txttrefno_TextChanged(object sender, EventArgs e)
    {
        pst = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");

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


        chs = RetrieveFields.retrieveByFieldIndex_HasOneKey(10, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");

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

        txtapprby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");
        txtchkby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");
        txtremark.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");
        txtremarkc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");
        


        txttyear.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");


        string hg = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");
        if (hg == string.Empty)
        {
            txtentd.Text = "";
        }
        else
        {
            DateTime ch = DateTime.Parse(hg);
            txtentd.Text = ch.ToShortDateString();
        }

        string sd = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.StTransferHead_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, "string");
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



        //   txtsno.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");


        int sb = int.Parse(SaveRecord.Retrieve_Detailt(txttrefno.Text, gridview2)) - 1;
         txtsno.Text = sb.ToString();

         if (txtsno.Text == "0")
         {
             txtsno.Text = "1";
         }
    }






    protected void submitButton_Click(object sender, EventArgs e)
    {
 


        if (pst == "Y")
        {
            SaveRecord.save_TransferRoaster_detailapp(txttrefno.Text, txttyear.Text, txtsno.Text, txtstid.Text, oloc, odept, osec, dloc, ddept, dsec, txttransdate.Text, txttreason.Text);
            SaveRecord.Delete_Transfer_Roaster_Details_Temp(txttrefno.Text, txtsno.Text);
        }
        else
        {
            SaveRecord.save_TransferRoaster_detail(txttrefno.Text, txttyear.Text, txtsno.Text, txtstid.Text, oloc, odept, osec, dloc, ddept, dsec, txttransdate.Text, txttreason.Text);
        }


        SaveRecord.Save_Transfer_Head(txttrefno.Text, txttyear.Text, txtsno.Text, txtapprby.Text, txtentd.Text, txtremark.Text, pst, txtchkby.Text, txtchkd.Text, txtremarkc.Text, chs);
        // txtsno.Text = SaveRecord.Count_Transfer_Detail(txttrefno.Text, txttyear.Text);

        SaveRecord.Retrieve_Details(txttrefno.Text, gridview2);
        txtsno.Text = (int.Parse(gridview2.Rows[gridview2.Rows.Count - 1].Cells[1].Text) + 1).ToString();

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
        oloc = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(4, AppTables.StTransferDettemp_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        txtoloc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, oloc, "string");
        odept = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(5, AppTables.StTransferDettemp_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        txtodept.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, odept, "string");
        osec = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(6, AppTables.StTransferDettemp_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        txtosec.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, osec, "string");

        dloc = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(7, AppTables.StTransferDettemp_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        cmbdloc.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, dloc, "string");
        ddept = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(8, AppTables.StTransferDettemp_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        cmbddept.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, ddept, "string");
        dsec = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(9, AppTables.StTransferDettemp_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        cmbdsect.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, dsec, "string");
        txttreason.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(11, AppTables.StTransferDettemp_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");

        string hn = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(10, AppTables.StTransferDettemp_Tab, AppFields.StTransferhead_Fld1a, txttrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        if (hn != string.Empty)
        {
            tdate = DateTime.Parse(hn);
            txttransdate.Text = tdate.ToShortDateString();
        }

        else
        {
            txttransdate.Text = "00/00/0000";
        }

        //  SaveRecord.Retrieve_Details(txtlrefno.Text, gridview2);


    }



    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Transfer_Roaster_Details_Temp(txttrefno.Text, txtsno.Text);
        lblsuccess.Text = "";
        txtstid.Text = "";
        cmbdsect.SelectedItem.Text = "";
        cmbdloc.SelectedItem.Text = "";
        cmbddept.SelectedItem.Text = "";
        txttreason.Text = "";
        txttransdate.Text = "";
        txtodept.Text = "";
        txtoloc.Text = "";
        txtosec.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        // SaveRecord.Count_Leave_Detail(txtlrefno.Text, txtlyear.Text);

        SaveRecord.Retrieve_Detailz(txttrefno.Text, gridview2);
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
    protected void txtoloc_TextChanged(object sender, EventArgs e)
    {
        oloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(12, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
    }
    protected void txtodept_TextChanged(object sender, EventArgs e)
    {
        odept = RetrieveFields.retrieveByFieldIndex_HasOneKey(13, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
    }
    protected void txtosec_TextChanged(object sender, EventArgs e)
    {
        osec = RetrieveFields.retrieveByFieldIndex_HasOneKey(14, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
    }
    protected void txttransdate_TextChanged(object sender, EventArgs e)
    {
        tdate = HR_Report.myconvdate(txttransdate.Text);
    }

    protected void cmbdloc_SelectedIndexChanged(object sender, EventArgs e)
    {
        dloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Loc_Tab, AppFields.Loc_Fld1b, cmbdloc.SelectedItem.Text, "string");
    }
    protected void cmbddept_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddept = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, cmbddept.SelectedItem.Text, "string");
        if (ddept != "")
        {
            FillCombo.DropDownListItems_HasOneKey(2, cmbdsect, AppTables.Sec_Tab, AppFields.Dept_Fld1a, ddept);
        }
    }
    protected void cmbdsect_SelectedIndexChanged(object sender, EventArgs e)
    {
        dsec = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(1, AppTables.Sec_Tab, AppFields.Dept_Fld1a, ddept, AppFields.Sec_Fld1b, cmbdsect.SelectedItem.Text, "string");
    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        oloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(12, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtoloc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, oloc, "string");
        odept = RetrieveFields.retrieveByFieldIndex_HasOneKey(13, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtodept.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, odept, "string");
        osec = RetrieveFields.retrieveByFieldIndex_HasOneKey(14, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtosec.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, osec, "string");
        txtname.Text = HR_Report.Return_StaffName(txtstid.Text);
        SaveRecord.Retrieve_Details(txttrefno.Text, gridview2);
        txtsno.Text = SaveRecord.Retrieve_Details(txttrefno.Text, gridview2);
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