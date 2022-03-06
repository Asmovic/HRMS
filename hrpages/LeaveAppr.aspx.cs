using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_LeaveAppr : System.Web.UI.Page
{
    public static string gloc, gloc2, gdept2, gdept, msur, mfst, mlast, ggrade = "", gt = "", mypost, chs, pst;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbdept, AppTables.Dept_Tab);
            FillCombo.DropDownListItems(1, cmbloc, AppTables.Loc_Tab);

            txtentd.Text = DateTime.Now.ToShortDateString();
        }
    }

    protected void txtdspent_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtlrefno_TextChanged(object sender, EventArgs e)
    {
        pst = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");

        if (pst != "" && pst == "Y")
        {
         //   txtyes.Checked = true;
        //    txtno.Checked = false;
            txtno.Checked = true;
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


        chs = RetrieveFields.retrieveByFieldIndex_HasOneKey(12, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");

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

        txtapprby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");
        txtchkby.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");
        txtremark.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");
        txtremarkc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(11, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");

        string hg = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");
        if (hg == string.Empty)
        {
            txtentd.Text = "";
        }
        else
        {
            DateTime ch = DateTime.Parse(hg);
            txtentd.Text = ch.ToShortDateString();
        }

        string sd = RetrieveFields.retrieveByFieldIndex_HasOneKey(10, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");
        if (sd == string.Empty)
        {
            txtchkd.Text = "";
        }
        else
        {
            DateTime cu = DateTime.Parse(sd);
            txtchkd.Text = cu.ToShortDateString();
        }


        txtlyear.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");

        //   txtsno.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");
        gloc2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");
        cmbloc.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, gloc2, "string");
        gdept2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.StLeaveHead_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, "string");
        cmbdept.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, gdept2, "string");

     //   SaveRecord.Retrieve_Details(txtlrefno.Text, gridview2);
     //     txtsno.Text = (int.Parse(gridview2.Rows[gridview2.Rows.Count - 1].Cells[1].Text)).ToString();
        int sb = int.Parse( SaveRecord.Retrieve_Details(txtlrefno.Text, gridview2)) - 1;
        txtsno.Text = sb.ToString();

        if(txtsno.Text == "0")
        {
            txtsno.Text = "1";
        }
    }



    protected void txtdays_TextChanged(object sender, EventArgs e)
    {
        compute_enddate();


        //DateTime mydd, dat;

        //DateTime.TryParse((txtstart.Text).ToString(), out mydd);
        //int sd = int.Parse(txtdays.Text);
        //dat = mydd;
        //DateTime bs = dat.AddDays(sd);
        //txtend.Text = bs.ToString();

    }

    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        txtname.Text = HR_Report.Return_StaffName(txtstid.Text);

        ggrade = RetrieveFields.retrieveByFieldIndex_HasOneKey(17, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        gt = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Grade_Tab, AppFields.Grade_Fld1a, ggrade, "string");

        if (gt == "")
        {
            gt = "0";
        }
        txtdays.Text = gt;

        //  DateTime mydate = DateTime.ParseExact(txtstart.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);


    }
    protected void submitButton_Click(object sender, EventArgs e)
    {

        if(pst == "Y")
        {
            SaveRecord.save_LeaveRoaster_detailp(txtlrefno.Text, txtlyear.Text, txtsno.Text, gloc, gdept, txtstid.Text, txtdays.Text, txtstart.Text, txtend.Text, txtdspent.Text, txtdleft.Text);
            SaveRecord.Delete_Leave_Roaster_Details_Temp(txtlrefno.Text, txtsno.Text);
        }
        else
        {
            SaveRecord.save_LeaveRoaster_detail(txtlrefno.Text, txtlyear.Text, txtsno.Text, gloc, gdept, txtstid.Text, txtdays.Text, txtstart.Text, txtend.Text, txtdspent.Text, txtdleft.Text);
        }

       
        SaveRecord.Save_Leave_Head(txtlrefno.Text, txtlyear.Text, txtsno.Text, gloc2, gdept2, txtapprby.Text, txtentd.Text, txtremark.Text, pst, txtchkby.Text, txtchkd.Text, txtremarkc.Text, chs);
        // txtsno.Text = SaveRecord.Count_Leave_Detail(txtlrefno.Text, txtlyear.Text);

        SaveRecord.Retrieve_Details(txtlrefno.Text, gridview2);
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
 
        //txtstart.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(5, AppTables.StLeaveDettemp_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        //txtend.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(6, AppTables.StLeaveDettemp_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");

        string khg = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(5, AppTables.StLeaveDettemp_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        DateTime pok = DateTime.Parse(khg);
        txtstart.Text = pok.ToShortDateString();

        string fgt = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(6, AppTables.StLeaveDettemp_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        DateTime lk = DateTime.Parse(fgt);
        txtend.Text = lk.ToShortDateString();

        txtdays.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(4, AppTables.StLeaveDettemp_Tab, AppFields.Stleavehead_Fld1a,

            txtlrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        txtdspent.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(7, AppTables.StLeaveDettemp_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");
        txtdleft.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(8, AppTables.StLeaveDettemp_Tab, AppFields.Stleavehead_Fld1a, txtlrefno.Text, AppFields.Emphis_Fld1a, mystid, "string");

        //  SaveRecord.Retrieve_Details(txtlrefno.Text, gridview2);


    }



    protected void cmbloc_SelectedIndexChanged(object sender, EventArgs e)
    {
        gloc2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Loc_Tab, AppFields.Loc_Fld1b, cmbloc.SelectedItem.Text, "string");
    }
    protected void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
    {
        gdept2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, cmbdept.SelectedItem.Text, "string");
    }
    protected void txtlyear_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtdleft_TextChanged(object sender, EventArgs e)
    {

    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Leave_Roaster_Details_Temp(txtlrefno.Text, txtsno.Text);
        lblsuccess.Text = "";
        txtstid.Text = "";
        txtstart.Text = "";
        txtend.Text = "";
        txtdspent.Text = "";
        txtdays.Text = "";
        txtdleft.Text = "";
        txtname.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        // SaveRecord.Count_Leave_Detail(txtlrefno.Text, txtlyear.Text);

        SaveRecord.Retrieve_Detailz(txtlrefno.Text, gridview2);
        txtsno.Text = (int.Parse(gridview2.Rows[gridview2.Rows.Count - 1].Cells[1].Text) + 1).ToString();

    }
    protected void txtend_TextChanged(object sender, EventArgs e)
    {


    }

    protected void txtstart_TextChanged1(object sender, EventArgs e)
    {
        string sum = SaveRecord.Compute_Leave(txtlrefno.Text, txtlyear.Text, txtstid.Text);
        if (sum == "")
        {
            txtdspent.Text = "0";
        }
        else
        {
            txtdspent.Text = sum;
        }
        txtdleft.Text = (int.Parse(txtdays.Text) - int.Parse(txtdspent.Text)).ToString();
        compute_enddate();



    }
    private void compute_enddate()
    {
        DateTime mydate = HR_Report.myconvdate(txtstart.Text);
        if (gt != string.Empty)
        {
            DateTime myenddate = mydate.AddDays(int.Parse(txtdleft.Text));
            txtend.Text = myenddate.ToString("dd/MM/yyy", System.Globalization.CultureInfo.InvariantCulture);
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

}