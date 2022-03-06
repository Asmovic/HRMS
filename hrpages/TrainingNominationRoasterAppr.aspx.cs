using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_TrainingNominationRoasterAppr : System.Web.UI.Page
{
    public static string dloc, dsec, oloc, odept, osec, ddept, msur, mfst, mlast, ggrade = "", gt = "", mypost, chs, pst;
    public static DateTime tdate;
    private static string nomcode;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbname, AppTables.Traint_Tab);
        }
    }

    protected void txttnrefno_TextChanged(object sender, EventArgs e)
    {
        pst = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");

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


        chs = RetrieveFields.retrieveByFieldIndex_HasOneKey(10, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");

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

        txtapprby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");
        txtchkby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");
        txtremark.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");
        txtremarkc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");



        txttyear.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");


        string hg = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");
        if (hg == string.Empty)
        {
            txtentd.Text = "";
        }
        else
        {
            DateTime ch = DateTime.Parse(hg);
            txtentd.Text = ch.ToShortDateString();
        }

        string sd = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.StTrNomHead_Tab, AppFields.StTrNom_Fld1a, txttnrefno.Text, "string");
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

        int sb = int.Parse(SaveRecord.Retrieve_DetailtNom(txttnrefno.Text, gridview2)) - 1;
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
            SaveRecord.Save_TrNomDet(txttnrefno.Text, txttyear.Text, txtsno.Text, txtstid.Text, oloc, odept, osec, nomcode, traindate.Text, traindur.Text, orgname.Text, orgadd.Text);
            SaveRecord.Delete_TrNom_Details_Temp(txttnrefno.Text, txtsno.Text);
        }
        else
        {
            SaveRecord.Save_TrNomDet_Temp(txttnrefno.Text, txttyear.Text, txtsno.Text, txtstid.Text, oloc, odept, osec, nomcode, traindate.Text, traindur.Text, orgname.Text, orgadd.Text);

        }
        SaveRecord.Save_TrNom_Head(txttnrefno.Text, txttyear.Text, txtsno.Text, txtapprby.Text, txtentd.Text, txtremark.Text, pst, txtchkby.Text, txtchkd.Text, txtremarkc.Text, chs);
        // txtsno.Text = SaveRecord.Count_Transfer_Detail(txttrefno.Text, txttyear.Text);

        SaveRecord.Retrieve_DetailtNom(txttnrefno.Text, gridview2);
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


        oloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.StTrNomDettemp_Tab, AppFields.TrNomDet_Fld1a, txtstid.Text, "string");
        txtoloc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, oloc, "string");
        odept = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.StTrNomDettemp_Tab, AppFields.TrNomDet_Fld1a, txtstid.Text, "string");
        txtodept.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, odept, "string");
        osec = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.StTrNomDettemp_Tab, AppFields.TrNomDet_Fld1a, txtstid.Text, "string");
        txtosec.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, osec, "string");

        string ky = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.StTrNomDettemp_Tab, AppFields.TrNomDet_Fld1a, txtstid.Text, "string");
        if (ky != string.Empty)
        {
            DateTime df = HR_Report.myconvdate(ky);
            traindate.Text = df.ToShortDateString();
        }
        else
        {
            traindate.Text = "";
        }
        traindur.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.StTrNomDettemp_Tab, AppFields.TrNomDet_Fld1a, txtstid.Text, "string");
        orgname.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(10, AppTables.StTrNomDettemp_Tab, AppFields.TrNomDet_Fld1a, txtstid.Text, "string");
        orgadd.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(11, AppTables.StTrNomDettemp_Tab, AppFields.TrNomDet_Fld1a, txtstid.Text, "string");
        nomcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.StTrNomDettemp_Tab, AppFields.TrNomDet_Fld1a, txtstid.Text, "string");
        cmbname.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Traint_Tab, AppFields.Traint_Fld1a, nomcode, "string");

    }



    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_TrNom_Details_Temp(txttnrefno.Text, txtsno.Text);
        lblsuccess.Text = "";
        clear_controls();
        lbldanger.Text = "Record Deleted Successfully";
        // SaveRecord.Count_Leave_Detail(txtlrefno.Text, txtlyear.Text);

        SaveRecord.Retrieve_DetailtNom(txttnrefno.Text, gridview2);
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



    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        oloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(12, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtoloc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, oloc, "string");
        odept = RetrieveFields.retrieveByFieldIndex_HasOneKey(13, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtodept.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, odept, "string");
        osec = RetrieveFields.retrieveByFieldIndex_HasOneKey(14, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtosec.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, osec, "string");
        txtname.Text = HR_Report.Return_StaffName(txtstid.Text);
        SaveRecord.Retrieve_DetailtNom(txttnrefno.Text, gridview2);
        txtsno.Text = SaveRecord.Retrieve_DetailtNom(txttnrefno.Text, gridview2);
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
    private void clear_controls()
    {
        txtstid.Text = "";
        traindate.Text = "";
        cmbname.SelectedItem.Text = "";
        traindur.Text = "";
        orgname.Text = "";
        orgadd.Text = "";
        txtremark.Text = "";
        txtremarkc.Text = "";
        txtname.Text = "";
        txtoloc.Text = "";
        txtodept.Text = "";
        txtosec.Text = "";
    }

    protected void cmbname_SelectedIndexChanged(object sender, EventArgs e)
    {
        nomcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Traint_Tab, AppFields.Traint_Fld1b, cmbname.SelectedItem.Text, "string");
    }
}