using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_QualificationTransaction : System.Web.UI.Page
{

    private static string qualn, fsn, qualc, qualt,msur,mfst,mlast,qtype,kj;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbqname, AppTables.Qual_Tab);
            FillCombo.DropDownListItems(1, cmbfs, AppTables.FS_Tab);
            FillCombo.DropDownListItems(1, cmbqc, AppTables.QC_Tab);
        }
    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        msur = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        mfst = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        mlast = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtname.Text = msur + " " + mfst + " " + mlast;

        qualn = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.QualTrans_Tab, AppFields.Qualtrans_Fld1a, txtstid.Text, "string");
        cmbqname.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Qual_Tab, AppFields.Qual_Fld1a, qualn, "string");

        fsn = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.QualTrans_Tab, AppFields.Qualtrans_Fld1a, txtstid.Text, "string");
        cmbfs.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.FS_Tab, AppFields.FS_Fld1a, fsn, "string");


        qualc = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.QualTrans_Tab, AppFields.Qualtrans_Fld1a, txtstid.Text, "string");
        cmbqc.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.QC_Tab, AppFields.QC_Fld1a, qualc, "string");
        Image1.ImageUrl = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtins.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.QualTrans_Tab, AppFields.Qualtrans_Fld1a, txtstid.Text, "string");
        txtyob.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.QualTrans_Tab, AppFields.Qualtrans_Fld1a, txtstid.Text, "string");
        qualt = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.QualTrans_Tab, AppFields.Qualtrans_Fld1a, txtstid.Text, "string");

        if (qualt != "" && qualt == "A")
            txta.Checked = true;
        else if (qualt != "" && qualt == "P")
            txtp.Checked = true;
      kj = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.QualTrans_Tab, AppFields.Qualtrans_Fld1a, txtstid.Text, "string");
       
        DateTime ol = HR_Report.myconvdate(kj);
        txtapply.Text = ol.ToShortDateString();
    }
    protected void cmbqname_SelectedIndexChanged(object sender, EventArgs e)
    {
        qualn = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Qual_Tab, AppFields.Qual_Fld1b, cmbqname.SelectedItem.Text, "string");
       qualt = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Qual_Tab, AppFields.Qual_Fld1b, cmbqname.SelectedItem.Text, "string");
        if (qualt == "A")
        {
            txta.Enabled = true;
            txta.Checked = true;
            txtp.Enabled = false;
        }
        else
        {
             txta.Enabled = false;
             txtp.Enabled = true;
            txtp.Checked = true;
        }
    }
    protected void cmbfs_SelectedIndexChanged(object sender, EventArgs e)
    {
        fsn = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.FS_Tab, AppFields.FS_Fld1b, cmbfs.SelectedItem.Text, "string");
    }
    protected void txta_CheckedChanged(object sender, EventArgs e)
    {
        if(txta.Checked == true)
        {
            txtp.Checked = false;
            qualt = "A";
        }
    }
    protected void txtp_CheckedChanged(object sender, EventArgs e)
    {
        if (txtp.Checked == true)
        {
            txta.Checked = false;
            qualt = "P";
          
            
        }
    }
    protected void cmbqc_SelectedIndexChanged(object sender, EventArgs e)
    {
        qualc = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.QC_Tab, AppFields.QC_Fld1b, cmbqc.SelectedItem.Text, "string");
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_QualificationTransaction(txtstid.Text, qualn, fsn, txtins.Text, txtyob.Text,qualt,qualc,txtapply.Text);
        lblsuccess.Text = "Record Saved Successfully";
        lbldanger.Text = "";


        FillCombo.DropDownListItems(1, cmbqname, AppTables.Qual_Tab);
        FillCombo.DropDownListItems(1, cmbfs, AppTables.FS_Tab);
        FillCombo.DropDownListItems(1, cmbqc, AppTables.QC_Tab);

        cmbqname.SelectedItem.Text = "";
        cmbfs.SelectedItem.Text = "";
        cmbqc.SelectedItem.Text = "";
        txtins.Text = "";
        txtyob.Text = "";
        txtname.Text = "";
        txtapply.Text = "";
        txtstid.Text = "";
        txta.Checked = false;
        txtp.Checked = false;
        Image1.ImageUrl = "";


    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Qualification_Transaction(txtstid.Text);
       
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        lblsuccess.Text = "";

        FillCombo.DropDownListItems(1, cmbqname, AppTables.Qual_Tab);
        FillCombo.DropDownListItems(1, cmbfs, AppTables.FS_Tab);
        FillCombo.DropDownListItems(1, cmbqc, AppTables.QC_Tab);

        cmbqname.SelectedItem.Text = "";
        cmbfs.SelectedItem.Text = "";
        cmbqc.SelectedItem.Text = "";
        txtins.Text = "";
        txtapply.Text = "";
        txtyob.Text = "";
        txtstid.Text = "";
        txtname.Text = "";
        txta.Checked = false;
        txtp.Checked = false;
        Image1.ImageUrl = "";

        FillCombo.DropDownListItems(1, cmbqname, AppTables.Qual_Tab);
        FillCombo.DropDownListItems(1, cmbfs, AppTables.FS_Tab);
        FillCombo.DropDownListItems(1, cmbqc, AppTables.QC_Tab);

    }

    protected void txtapply_TextChanged(object sender, EventArgs e)
    {
        DateTime dt = HR_Report.myconvdate(txtapply.Text);
        txtapply.Text = dt.ToShortDateString();
       
    }
}