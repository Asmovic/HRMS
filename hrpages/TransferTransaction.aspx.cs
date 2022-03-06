using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class hrpages_TransferTransaction : System.Web.UI.Page
{

    private static string gloc,gdept,gsec,gttype,msur,mfst,mlast, datestring, format,oloc,odept,osec;
    private static DateTime tdate;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbddept, AppTables.Dept_Tab);
            FillCombo.DropDownListItems(1, cmbdloc, AppTables.Loc_Tab);
            FillCombo.DropDownListItems(1, cmbdsect, AppTables.Sec_Tab);
            txttransdate.Text = DateTime.Now.Date.ToShortDateString();
        }
    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {

        txtttype1.Checked = false;
        txtttype2.Checked = false;
        txtttype3.Checked = false;
       oloc =RetrieveFields.retrieveByFieldIndex_HasOneKey(12, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
       txtoloc.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, oloc, "string");
       odept = RetrieveFields.retrieveByFieldIndex_HasOneKey(13, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtodept.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, odept, "string");
        osec = RetrieveFields.retrieveByFieldIndex_HasOneKey(14, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtosec.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a,osec, "string");

       
           string hn = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.TransferTrans_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
           if (hn!=string.Empty)
           {
           tdate = DateTime.Parse(hn);
            txttransdate.Text = tdate.ToShortDateString();
        }
     
        else
        {
            txttransdate.Text = "00/00/0000";
        }
       
         gloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.TransferTrans_Tab, AppFields.Transtype_Fld1a, txtstid.Text, "string");
        cmbdloc.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, gloc, "string");
        gdept = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.TransferTrans_Tab, AppFields.Transtype_Fld1a, txtstid.Text, "string");
        cmbddept.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, gdept, "string");
        gsec = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.TransferTrans_Tab, AppFields.Transtype_Fld1a, txtstid.Text, "string");
        cmbdsect.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Sec_Tab, AppFields.Sec_Fld1a, gsec, "string");
        txttreason.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.TransferTrans_Tab, AppFields.Transtype_Fld1a, txtstid.Text, "string");
        Image1.ImageUrl = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");

        gttype = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.TransferTrans_Tab, AppFields.Transtype_Fld1a, txtstid.Text, "string");

        if (gttype != "" && gttype == "L")
            txtttype1.Checked = true;
        else if (gttype != "" && gttype == "D")
            txtttype2.Checked = true;
        else if (gttype != "" && gttype == "S")
            txtttype3.Checked = true;


        //Convert.ToDateTime(txttransdate.Text);
        //CultureInfo MyCultureInfo = new CultureInfo("de-DE");

        //string MyString = txttransdate.Text;
        //DateTime newDate = DateTime.Parse(MyString, MyCultureInfo);

        //DateTime res;
        //CultureInfo provider = CultureInfo.InvariantCulture;
        //datestring = txttransdate.Text;
        //format = "d";
        //try
        //{
        //    res = DateTime.ParseExact(datestring, format, provider);
        //}

        //catch(FormatException)
        //{
            
        //}

        txtname.Text = HR_Report.Return_StaffName(txtstid.Text);
    }

        
     protected void txtoloc_TextChanged(object sender, EventArgs e)
    {
        oloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Loc_Tab, AppFields.Loc_Fld1b, txtoloc.Text, "string");
    }

    protected void txtodept_TextChanged(object sender, EventArgs e)
    {
        odept = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, txtodept.Text, "string");
    }
    protected void txtosec_TextChanged(object sender, EventArgs e)
    {
        osec = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Sec_Tab, AppFields.Sec_Fld1b, txtosec.Text, "string");
    }
    protected void cmbdloc_SelectedIndexChanged(object sender, EventArgs e)
    {
        gloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Loc_Tab, AppFields.Loc_Fld1b, cmbdloc.SelectedItem.Text, "string");
    }
    protected void cmbddept_SelectedIndexChanged(object sender, EventArgs e)
    {
        gdept = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, cmbddept.SelectedItem.Text, "string");
        if (gdept != "")
        {
            FillCombo.DropDownListItems_HasOneKey(2, cmbdsect, AppTables.Sec_Tab, AppFields.Dept_Fld1a, gdept);
        }
    }
    protected void cmbdsect_SelectedIndexChanged(object sender, EventArgs e)
    {
        gsec = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(1, AppTables.Sec_Tab, AppFields.Dept_Fld1a, gdept, AppFields.Sec_Fld1b, cmbdsect.SelectedItem.Text, "string");
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_TransferTransaction(txtstid.Text, gttype, oloc, odept, osec, gloc,gdept,gsec,tdate,txttreason.Text);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";
        txtstid.Text = "";
        txtoloc.Text = "";
        cmbdsect.SelectedItem.Text = "";
        cmbdloc.SelectedItem.Text = "";
        cmbddept.SelectedItem.Text = "";
        txtodept.Text = "";
        txtosec.Text = "";
        txtname.Text = "";
        txttransdate.Text = "";
        txttreason.Text = "";
        txtttype1.Checked = false;
        txtttype2.Checked = false;
        txtttype3.Checked = false;
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Transfer_Transaction(txtstid.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        txtstid.Text = "";
        txtoloc.Text = "";
        cmbdsect.SelectedItem.Text = "";
        cmbdloc.SelectedItem.Text = "";
        cmbddept.SelectedItem.Text = "";
        txtodept.Text = "";
        txtosec.Text = "";
        txtname.Text = "";
        txttransdate.Text = "";
        txttreason.Text = "";
        txtttype1.Checked = false;
        txtttype2.Checked = false;
        txtttype3.Checked = false;
    }
    protected void txtttype1_CheckedChanged(object sender, EventArgs e)
    {
        if (txtttype1.Checked == true)
        {
            txtttype2.Checked = false;
            txtttype3.Checked = false;
           gttype = "L";
           if (gttype == "L")
               cmbdloc.Enabled = true;
           cmbddept.Enabled = false;
           cmbdsect.Enabled = false;
        }
    }
    protected void txtttype2_CheckedChanged(object sender, EventArgs e)
    {
        if (txtttype2.Checked == true)
        {
            txtttype1.Checked = false;
            txtttype3.Checked = false;
            gttype = "D";
            if (gttype == "D")
                cmbdloc.Enabled = false;
            cmbddept.Enabled = true;
            cmbdsect.Enabled = true;
        }
    }
    protected void txtttype3_CheckedChanged(object sender, EventArgs e)
    {
        if(txtttype3.Checked == true)
        {
            txtttype1.Checked = false;
            txtttype2.Checked = false;
            gttype = "S";
            if (gttype == "S")
                cmbdsect.Enabled = true;
               cmbddept.Enabled = true;
               cmbdloc.Enabled = false;
        }
    }
    protected void txttransdate_TextChanged(object sender, EventArgs e)
    {
      tdate = HR_Report.myconvdate(txttransdate.Text);
         
    }
}