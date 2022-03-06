using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hrpages_Recruitment : System.Web.UI.Page
{
    private static string gen, gaq, gfs, gch, gaq2, gfs2, gch2, gpc, gpc2, gpos, gdept, name ;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            FillCombo.DropDownListItems(1, cmbaq, AppTables.Qual_Tab);
            FillCombo.DropDownListItems(1, cmbfs, AppTables.FS_Tab);
            FillCombo.DropDownListItems(1, cmbch, AppTables.QC_Tab);
            FillCombo.DropDownListItems(1, cmbaq2, AppTables.Qual_Tab);
            FillCombo.DropDownListItems(1, cmbfs2, AppTables.FS_Tab);
            FillCombo.DropDownListItems(1, cmbch2, AppTables.QC_Tab);
            FillCombo.DropDownListItems(1, cmbpc, AppTables.Qual_Tab);
            FillCombo.DropDownListItems(1, cmbpc2, AppTables.Qual_Tab);
            FillCombo.DropDownListItems(1, cmbposition, AppTables.Desig_Tab);
            FillCombo.DropDownListItems(1, cmbdept, AppTables.Dept_Tab);
           
        }
    }
    protected void txtmale_CheckedChanged(object sender, EventArgs e)
    {
        if (txtmale.Checked == true)
        {
            txtfemale.Checked = false;
            gen = "M";
        }
    }
    protected void txtfemale_CheckedChanged(object sender, EventArgs e)
    {
        if (txtfemale.Checked == true)
        {
            txtmale.Checked = false;
            gen = "F";
        }
    }
    protected void cmbaq_SelectedIndexChanged(object sender, EventArgs e)
    {
        gaq = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Qual_Tab, AppFields.Qual_Fld1b, cmbaq.SelectedItem.Text, "string");
    }
    protected void cmbfs_SelectedIndexChanged(object sender, EventArgs e)
    {
        gfs = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.FS_Tab, AppFields.FS_Fld1b, cmbfs.SelectedItem.Text, "string");
    }
    protected void cmbch_SelectedIndexChanged(object sender, EventArgs e)
    {
        gch = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.QC_Tab, AppFields.QC_Fld1b, cmbch.SelectedItem.Text, "string");
    }
    protected void cmbaq2_SelectedIndexChanged(object sender, EventArgs e)
    {
        gaq2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Qual_Tab, AppFields.Qual_Fld1b, cmbaq2.SelectedItem.Text, "string");
    }
    protected void cmbfs2_SelectedIndexChanged(object sender, EventArgs e)
    {
        gfs2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.FS_Tab, AppFields.FS_Fld1b, cmbfs2.SelectedItem.Text, "string");
    }
    protected void cmbch2_SelectedIndexChanged(object sender, EventArgs e)
    {
        gch2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.QC_Tab, AppFields.QC_Fld1b, cmbch2.SelectedItem.Text, "string");
    }
    protected void cmbpc_SelectedIndexChanged(object sender, EventArgs e)
    {
        gpc = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Qual_Tab, AppFields.Qual_Fld1b, cmbpc.SelectedItem.Text, "string");
    }
    protected void cmbpc2_SelectedIndexChanged(object sender, EventArgs e)
    {
        gpc2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Qual_Tab, AppFields.Qual_Fld1b, cmbpc2.SelectedItem.Text, "string");
    }
    protected void cmbposition_SelectedIndexChanged(object sender, EventArgs e)
    {
        gpos = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Desig_Tab, AppFields.Desig_Fld1b, cmbposition.SelectedItem.Text, "string");
    }
    protected void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
    {
        gdept = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, cmbdept.SelectedItem.Text, "string");
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        name = txtsurname.Text +" "+ txtfname.Text + " "+txtoname.Text;
        SaveRecord.Save_Recruitment(txtsurname.Text, txtfname.Text, txtoname.Text, txtdob.Text, gen, gaq, gfs, gch, txtqy.Text, gaq2, gfs2, gch2,txtqy2.Text, gpc, txtyoc.Text, txtinsoc.Text, gpc2, txtyoc2.Text, txtinsoc2.Text, txtemail.Text, txttell.Text, gpos, gdept,name);

        txtsurname.Text = "";
        txtfname.Text = "";
        txtoname.Text = "";
        txtdob.Text = "";
        txtmale.Checked = false;
        txtfemale.Checked = false;
        cmbaq.SelectedItem.Text = "";
        cmbfs.SelectedItem.Text = "";
        cmbch.SelectedItem.Text = "";
        cmbaq2.SelectedItem.Text = "";
        cmbfs2.SelectedItem.Text = "";
        cmbch2.SelectedItem.Text = "";
        cmbpc.SelectedItem.Text = "";
        cmbpc2.SelectedItem.Text = "";
        cmbposition.SelectedItem.Text = "";
        cmbdept.SelectedItem.Text = "";
        txtqy.Text = "";
        txtqy2.Text = "";
        txtyoc.Text = "";
        txtyoc2.Text = "";
        txtinsoc.Text = "";
        txtinsoc2.Text = "";
        txtemail.Text = "";
        txttell.Text = "";
        lbldanger.Text = "";
        lblsuccess.Text = "Record Saved Successfully";


    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Recruitment(name);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";

        txtsurname.Text = "";
        txtfname.Text = "";
        txtoname.Text = "";
        txtdob.Text = "";
        txtmale.Checked = false;
        txtfemale.Checked = false;
        cmbaq.SelectedItem.Text = "";
        cmbfs.SelectedItem.Text = "";
        cmbch.SelectedItem.Text = "";
        cmbaq2.SelectedItem.Text = "";
        cmbfs2.SelectedItem.Text = "";
        cmbch2.SelectedItem.Text = "";
        cmbpc.SelectedItem.Text = "";
        cmbpc2.SelectedItem.Text = "";
        cmbposition.SelectedItem.Text = "";
        cmbdept.SelectedItem.Text = "";
        txtqy.Text = "";
        txtqy2.Text = "";
        txtyoc.Text = "";
        txtyoc2.Text = "";
        txtinsoc.Text = "";
        txtinsoc2.Text = "";
        txtemail.Text = "";
        txttell.Text = "";
       
    }
}