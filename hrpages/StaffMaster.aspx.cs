using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class hrpages_StaffMaster : System.Web.UI.Page
{

    private static string gstate, dateob, datefa, glga, gtribe, gdept, gsec, gdesig, gloc, gpgl, gloc2, gdepfa,gpfac,ghighq, today, gl,lg,result="",dobdate,dtt,sec;
    private static string gen="";
    private static string marst = "";
    private static int rek;
    private static string filepath = "x";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillCombo.DropDownListItems(1, soo, AppTables.STA_Tab);
            FillCombo.DropDownListItems(1, tribe, AppTables.Tribe_Tab);
            FillCombo.DropDownListItems(1, lfa, AppTables.Loc_Tab);
            FillCombo.DropDownListItems(1, depfa, AppTables.Dept_Tab);
            FillCombo.DropDownListItems(1, loc, AppTables.Loc_Tab);
            FillCombo.DropDownListItems(1, dept, AppTables.Dept_Tab);
            FillCombo.DropDownListItems(1, desig, AppTables.Desig_Tab);
            FillCombo.DropDownListItems(1, glfa, AppTables.Grade_Tab);
            FillCombo.DropDownListItems(1, highq, AppTables.Qual_Tab);
            FillCombo.DropDownListItems(1, pfac, AppTables.PFA_Tab);
            FillCombo.DropDownListItems(1, pgl, AppTables.Grade_Tab);
            txtfemale.Checked = false;
            txtmale.Checked = false;
        }
    }
    protected void stid_TextChanged(object sender, EventArgs e)
    {
        clear2();
        var mstaff = stid.Text;
        surn.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        fn.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        ln.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        gen = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        
           if (gen == "")
        {
            txtfemale.Checked = false;
            txtmale.Checked = false;
        }
            
           else if (gen != "" && gen == "M")
        {
            txtmale.Checked = true;
            txtfemale.Checked = false;
        }
            
        else if (gen != "" && gen == "F")
        {
            txtfemale.Checked = true;
            txtmale.Checked = false;
        }

        marst = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        if (marst == "")
        {
            txtmar1.Checked = false;
            txtmar2.Checked = false;
            txtmar3.Checked = false;
        }
        else if (marst != "" && marst == "S")
        {
            txtmar1.Checked = true;
            txtmar2.Checked = false;
            txtmar3.Checked = false;
        }

        else if (marst != "" && marst == "M")
        {
            txtmar2.Checked = true;
            txtmar1.Checked = false;
            txtmar3.Checked = false;
        }

        else if (marst == "" && marst == "D")
        {
            txtmar3.Checked = true;
            txtmar1.Checked = false;
            txtmar2.Checked = false;
        }
            

        string dbb = RetrieveFields.retrieveByFieldIndex_HasOneKey(6, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        if (dbb != string.Empty)
        {
            DateTime smn = DateTime.Parse(dbb);

            dateob = smn.ToShortDateString();
    //      dateob = DateTime.ParseExact(dbb, "dd/MM/yyyy", new System.Globalization.DateTimeFormatInfo()).ToString();
            dob.Text = dateob;
        }

        else
        {
            dob.Text = "";
        }
        
       // dtt = DateTime.Parse("dd/MM/yyyy" System.Globalization.CultureInfo.InvariantCulture);
       //DateTime dt= DateTime.ParseExact(dobdate, "MM/dd/yyyy",System.Globalization.CultureInfo.InvariantCulture);
    //   dob.Text = string.Format(dobdate,"dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        //txtapply.Text = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

        gstate= (RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string")).ToString();
        soo.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.STA_Tab, AppFields.STA_Fld1a, gstate, "string");

        if (gstate != "")
        {
            FillCombo.DropDownListItems_HasOneKey(2, lgo, AppTables.LGA_Tab, AppFields.STA_Fld1a, gstate);
        }
       else {
           FillCombo.DropDownListItems(1, soo, AppTables.STA_Tab);
        }


      //lgo.SelectedItem.Text=local(result);


  
         glga = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        //lgo.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(8, AppTables.Stm_Tab, AppFields.Stm_Fld1b, lg, AppFields.Stm_Fld1a, stid.Text, "string");
     //   lgo.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.LGA_Tab, AppFields.LGA_Fld1a, lg, "string");
        
        string lgg = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(2, AppTables.LGA_Tab, AppFields.STA_Fld1a, gstate, AppFields.LGA_Fld1a, glga, "string");
        if(lgg != string.Empty)
        {
            lgo.SelectedItem.Text = lgg;
        }
        else
        {
            
            lgo.SelectedIndex = -1;
        }

        string vxn = RetrieveFields.retrieveByFieldIndex_HasOneKey(9, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        if (vxn != string.Empty)
        {
            DateTime vcn = HR_Report.myconvdate(vxn);

            datefa = vcn.ToShortDateString();

        //  datefa = DateTime.ParseExact(vxn, "dd/MM/yyyy", new System.Globalization.DateTimeFormatInfo()).ToString();
            dfa.Text = datefa;
     
        }
        else
        {
            dfa.Text = "";
        }

        gl = RetrieveFields.retrieveByFieldIndex_HasOneKey(10, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        lfa.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, gl, "string");
        gdepfa= RetrieveFields.retrieveByFieldIndex_HasOneKey(11, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        depfa.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, gdepfa, "string");
        gloc2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(12, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        loc.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Loc_Tab, AppFields.Loc_Fld1a, gloc2, "string");
        gdept = RetrieveFields.retrieveByFieldIndex_HasOneKey(13, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        dept.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, gdept, "string");

        if (gdept != "")
        {
            FillCombo.DropDownListItems_HasOneKey(2, sect, AppTables.Sec_Tab, AppFields.Dept_Fld1a, gdept);
        }

        gsec = RetrieveFields.retrieveByFieldIndex_HasOneKey(14, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
       string bnn = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(2, AppTables.Sec_Tab, AppFields.Dept_Fld1a, gdept, AppFields.Sec_Fld1a, gsec, "string");
        if(bnn != string.Empty)
        {
            sect.SelectedItem.Text = bnn;
        }
        else
        {
            sect.SelectedIndex = -1;
        }



        gdesig = RetrieveFields.retrieveByFieldIndex_HasOneKey(15, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        desig.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Desig_Tab, AppFields.Desig_Fld1a, gdesig, "string");
        gloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(16, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        glfa.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Grade_Tab, AppFields.Grade_Fld1a, gloc, "string");
        gpgl = RetrieveFields.retrieveByFieldIndex_HasOneKey(17, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        pgl.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Grade_Tab, AppFields.Grade_Fld1a, gpgl, "string");
        stadd.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(18, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        email.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(19, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        tell.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(20, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        nokn.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(21, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        nokrel.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(22, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        nokemail.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(23, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        nokadd.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(24, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        noktell.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(25, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        ghighq = RetrieveFields.retrieveByFieldIndex_HasOneKey(26, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        highq.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Qual_Tab, AppFields.Qual_Fld1a, ghighq, "string");
        yob.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(27, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        gpfac = RetrieveFields.retrieveByFieldIndex_HasOneKey(28, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        pfac.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.PFA_Tab, AppFields.Pfa_Fld1a, gpfac, "string");
        pfan.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(29, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        gtribe = RetrieveFields.retrieveByFieldIndex_HasOneKey(30, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        tribe.SelectedItem.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Tribe_Tab, AppFields.Trb_Fld1a, gtribe, "string");
        filepath = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, stid.Text, "string");
        Image1.ImageUrl = filepath;

    }
    protected void txtmale_CheckedChanged(object sender, EventArgs e)
    {
        if(txtmale.Checked == true)
        {
            txtfemale.Checked = false;
            gen = "M";
        }

    }
    protected void txtfemale_CheckedChanged(object sender, EventArgs e)
    {
        if(txtfemale.Checked == true)
        {
            txtmale.Checked = false;
            gen = "F";
        }
    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Save_StaffMaster(stid.Text,surn.Text,fn.Text,ln.Text,gen, marst,dateob,gstate,glga,datefa,gl,gdepfa,gloc2,gdept,gsec,gdesig,gloc,gpgl,stadd.Text,email.Text,tell.Text,nokn.Text,nokrel.Text,nokemail.Text,nokadd.Text,noktell.Text,ghighq,yob.Text,gpfac,pfan.Text,gtribe,filepath);

        clear();

        lbldanger.Text = "";
        lblsuccess.Text = "Record Saved Successfully";

        FillCombo.DropDownListItems(1, soo, AppTables.STA_Tab);
        FillCombo.DropDownListItems(1, tribe, AppTables.Tribe_Tab);
        FillCombo.DropDownListItems(1, lfa, AppTables.Loc_Tab);
        FillCombo.DropDownListItems(1, depfa, AppTables.Dept_Tab);
        FillCombo.DropDownListItems(1, loc, AppTables.Loc_Tab);
        FillCombo.DropDownListItems(1, dept, AppTables.Dept_Tab);
        FillCombo.DropDownListItems(1, desig, AppTables.Desig_Tab);
        FillCombo.DropDownListItems(1, glfa, AppTables.Grade_Tab);
        FillCombo.DropDownListItems(1, highq, AppTables.Qual_Tab);
        FillCombo.DropDownListItems(1, pfac, AppTables.PFA_Tab);
        FillCombo.DropDownListItems(1, pgl, AppTables.Grade_Tab);
    
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Staff_Master(stid.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        clear();
        
        
    }
    protected void soo_SelectedIndexChanged(object sender, EventArgs e)
    {
        gstate = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.STA_Tab, AppFields.STA_Fld1b, soo.SelectedItem.Text, "string");
        if (gstate!="")
        {
            FillCombo.DropDownListItems_HasOneKey(2, lgo, AppTables.LGA_Tab, AppFields.STA_Fld1a,gstate);
        }
    }
    protected void lgo_SelectedIndexChanged(object sender, EventArgs e)
    {
        glga = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(1, AppTables.LGA_Tab, AppFields.STA_Fld1a,gstate,AppFields.LGA_Fld1b, lgo.SelectedItem.Text, "string");
    }

    protected void dept_SelectedIndexChanged(object sender, EventArgs e)
    {
                
       
        gdept = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, dept.SelectedItem.Text, "string");
        if (gdept != "")
        {
            FillCombo.DropDownListItems_HasOneKey(2, sect, AppTables.Sec_Tab, AppFields.Dept_Fld1a, gdept);
        }
    }
    protected void sect_SelectedIndexChanged(object sender, EventArgs e)
    {
        gsec = RetrieveFields.retrieveByFieldIndex_HasTwoKeys(1, AppTables.Sec_Tab, AppFields.Dept_Fld1a, gdept, AppFields.Sec_Fld1b, sect.SelectedItem.Text, "string");
    }
    protected void tribe_SelectedIndexChanged(object sender, EventArgs e)
    {
        gtribe = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Tribe_Tab, AppFields.Trb_Fld1b, tribe.SelectedItem.Text, "string");
    }

    protected void lfa_SelectedIndexChanged(object sender, EventArgs e)
    {
        gl = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Loc_Tab, AppFields.Loc_Fld1b, lfa.SelectedItem.Text, "string");
    }
    protected void desig_SelectedIndexChanged(object sender, EventArgs e)
    {
        gdesig = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Desig_Tab, AppFields.Desig_Fld1b, desig.SelectedItem.Text, "string");
    }

    protected void glfa_SelectedIndexChanged(object sender, EventArgs e)
    {
        gloc = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Grade_Tab, AppFields.Grade_Fld1b, glfa.SelectedItem.Text, "string");
    }

    protected void loc_SelectedIndexChanged(object sender, EventArgs e)
    {
        gloc2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Loc_Tab, AppFields.Loc_Fld1b, loc.SelectedItem.Text, "string");
    }

    protected void highq_SelectedIndexChanged(object sender, EventArgs e)
    {
        ghighq = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Qual_Tab, AppFields.Qual_Fld1b, highq.SelectedItem.Text, "string");
    }
    protected void pfac_SelectedIndexChanged(object sender, EventArgs e)
    {
        gpfac = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.PFA_Tab, AppFields.Pfa_Fld1b, pfac.SelectedItem.Text, "string");
    }

    protected void depfa_SelectedIndexChanged(object sender, EventArgs e)
    {
        gdepfa = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Dept_Tab, AppFields.Dept_Fld1b, depfa.SelectedItem.Text, "string");
    }
    protected void txtmar3_CheckedChanged(object sender, EventArgs e)
    {
        if (txtmar3.Checked == true)
        {
            txtmar1.Checked = false;
            txtmar2.Checked = false;
            marst = "D";
        }
    }
    protected void txtmar2_CheckedChanged(object sender, EventArgs e)
    {
        if(txtmar2.Checked == true)
        {
            txtmar1.Checked = false;
            txtmar3.Checked = false;
            marst = "M";
        }
    }
    protected void txtmar1_CheckedChanged(object sender, EventArgs e)
    {
        if (txtmar1.Checked == true)
        {
            txtmar2.Checked = false;
            txtmar3.Checked = false;
            marst = "S";
        }

    }

    protected void preview_Click(object sender, EventArgs e)
{
    Boolean fileOK = false;
    if (fileupload.HasFile)
    {
        String fileExtension = System.IO.Path.GetExtension(fileupload.FileName).ToLower();
        String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
        for (int i = 0; i < allowedExtensions.Length; i++)
        {
            if (fileExtension == allowedExtensions[i])
            {
                fileOK = true;
            }
        }
    }
    if (fileOK)
    {
        try
        {
            var strFileName = "";
            if (fileupload.FileName != null)
            {
                strFileName = fileupload.FileName;
                filepath = "~/img/" + strFileName;
                if (System.IO.File.Exists(Server.MapPath(filepath)) == true)
                {
                    System.IO.File.Delete(Server.MapPath(filepath));
                    //System.IO.File.
                    fileupload.SaveAs(Server.MapPath(filepath));
                    Image1.ImageUrl = filepath;
                }
                else
                {
                    fileupload.SaveAs(Server.MapPath(filepath));
                    Image1.ImageUrl = filepath;
                }
            }
        }
        catch (Exception ex)
        {
            lbldanger.Text = ex.Message;
        }
    }
    }


protected void surn_TextChanged(object sender, EventArgs e)
{

}
protected void fn_TextChanged(object sender, EventArgs e)
{

}
protected void ln_TextChanged(object sender, EventArgs e)
{

}
protected void dob_TextChanged(object sender, EventArgs e)
{
    if(dob.Text != string.Empty)
    {
       // DateTime smn = DateTime.Parse(dob.Text);

     //   dateob = smn.ToShortDateString();
     //   dateob = DateTime.ParseExact(dob.Text, "dd/MM/yyyy", new System.Globalization.DateTimeFormatInfo()).ToString();
       // dob.Text = dateob;

        DateTime lk = HR_Report.myconvdate(dob.Text);
        dateob = lk.ToShortDateString();      
        dob.Text = dateob;
    }



}
protected void stadd_TextChanged(object sender, EventArgs e)
{

}
protected void email_TextChanged(object sender, EventArgs e)
{

}
        public static string local(string result)
        {

         using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "Select* from Staff_Master where Staff_Id =' 001 '";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                
                    
                        result = dr.GetValue(8).ToString();
                    
              
     
                }
               
                   
            }
        }
        return result;
    }
    private void clear()
        {
            stid.Text = "";
            surn.Text = "";
            fn.Text = "";
            ln.Text = "";
            gen = "";
            marst = "";
            dob.Text = "";
            gstate = "";
            glga = "";
            dfa.Text = "";
            gl = "";
            gdepfa = "";
            gloc2 = "";
            gdept = "";
            gsec = "";
            gdesig = "";
            gloc = "";
            pgl.SelectedItem.Text = "";
            stadd.Text = "";
            email.Text = "";
            tell.Text = "";
            nokn.Text = "";
            nokrel.Text = "";
            nokemail.Text = "";
            nokadd.Text = "";
            noktell.Text = "";
            ghighq = "";
            yob.Text = "";
            gpfac = "";
            pfan.Text = "";
            gtribe = "";
            soo.SelectedItem.Text = "";
            tribe.SelectedItem.Text = "";
            lfa.SelectedItem.Text = "";
            depfa.SelectedItem.Text = "";
            loc.SelectedItem.Text = "";
            dept.SelectedItem.Text = "";
            desig.SelectedItem.Text = "";
            glfa.SelectedItem.Text = "";
            highq.SelectedItem.Text = "";
            pfac.SelectedItem.Text = "";
            lgo.SelectedItem.Text = "";
            sect.SelectedItem.Text = "";
            txtmale.Checked = false;
            txtfemale.Checked = false;
            txtmar1.Checked = false;
            txtmar2.Checked = false;
            txtmar3.Checked = false;
            Image1.ImageUrl = "";
            filepath = "x";
            Chk1.Checked = false;
            Chk2.Checked = false;
        }

    private void clear2()
    {
       
        surn.Text = "";
        fn.Text = "";
        ln.Text = "";
        gen = "";
        marst = "";
        dob.Text = "";
        gstate = "";
        glga = "";
        dfa.Text = "";
        gl = "";
        gdepfa = "";
        gloc2 = "";
        gdept = "";
        gsec = "";
        gdesig = "";
        gloc = "";
        pgl.SelectedItem.Text = "";
        stadd.Text = "";
        email.Text = "";
        tell.Text = "";
        nokn.Text = "";
        nokrel.Text = "";
        nokemail.Text = "";
        nokadd.Text = "";
        noktell.Text = "";
        ghighq = "";
        yob.Text = "";
        gpfac = "";
        pfan.Text = "";
        gtribe = "";
        soo.SelectedItem.Text = "";
        tribe.SelectedItem.Text = "";
        lfa.SelectedItem.Text = "";
        depfa.SelectedItem.Text = "";
        loc.SelectedItem.Text = "";
        dept.SelectedItem.Text = "";
        desig.SelectedItem.Text = "";
        glfa.SelectedItem.Text = "";
        highq.SelectedItem.Text = "";
        pfac.SelectedItem.Text = "";
        lgo.SelectedIndex = -1;
        sect.SelectedIndex = -1;
        txtmale.Checked = false;
        txtfemale.Checked = false;
        txtmar1.Checked = false;
        txtmar2.Checked = false;
        txtmar3.Checked = false;
        Image1.ImageUrl = "";
        filepath = "x";
    }
    protected void Chk1_CheckedChanged(object sender, EventArgs e)
    {
        if(Chk1.Checked == true)
        {
            lbldanger.Text = "";
            lblsuccess.Text = "";
            Chk2.Checked = false;
            stid.Enabled = false;
            clear2();
            rek = HR_Report.count();
            today = DateTime.Now.Year.ToString();

            if ((rek.ToString()).Length == 1)
            {
                stid.Text = today + "/000" + rek.ToString();
            }
            else if ((rek.ToString()).Length == 2)
            {
                stid.Text = today + "/00" + rek.ToString();
            }
            else if ((rek.ToString()).Length == 3)
            {
                stid.Text = today + "/0" + rek.ToString();
            }
            else if ((rek.ToString()).Length == 4)
            {
                stid.Text = today + "/" + rek.ToString();
            }
            
        }
    }
    protected void Chk2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chk2.Checked == true)
        {
            lbldanger.Text = "";
            lblsuccess.Text = "";
            Chk1.Checked = false;
            stid.Enabled = true;
            stid.Text = "";
        }
    }
    protected void dfa_TextChanged(object sender, EventArgs e)
    {
        if(dfa.Text != string.Empty)
        {
         //     datefa = DateTime.ParseExact(dfa.Text, "dd/MM/yyyy", new System.Globalization.DateTimeFormatInfo()).ToString();

            //DateTime sbg = DateTime.Parse(dfa.Text);

            //datefa = sbg.ToShortDateString();

            //dfa.Text = datefa;

            DateTime dt = HR_Report.myconvdate(dfa.Text);
            datefa = dt.ToShortDateString();
            dfa.Text = datefa;
        }
        }

    protected void pgl_SelectedIndexChanged(object sender, EventArgs e)
    {
        gpgl = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.Grade_Tab, AppFields.Grade_Fld1b, pgl.SelectedItem.Text, "string");
    }
}