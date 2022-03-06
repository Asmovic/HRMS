using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class hrpages_StaffAppraisalForm : System.Web.UI.Page
{
    private static string p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16,p17,p18,p19,p20,c1,g1,g2,
        g3,g4,g5,g6,g7,g8,g9,g10,g11,g12,g13,g14,g15,g16,g17,g18,g19,g20;
    private static DateTime bh, bn;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtstid_TextChanged(object sender, EventArgs e)
    {
        txtname.Text = HR_Report.Return_StaffName(txtstid.Text);
        var dept= RetrieveFields.retrieveByFieldIndex_HasOneKey(13, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtdept.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Dept_Tab, AppFields.Dept_Fld1a, dept, "string");
        var desig = RetrieveFields.retrieveByFieldIndex_HasOneKey(15, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        txtclass.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Desig_Tab, AppFields.Desig_Fld1a, desig, "string");

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select *  from Appraisal_Subject  ";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {

                    lbldesc1.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "01", "string");
                    lbldesc2.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "02", "string");
                    lbldesc3.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "03", "string");
                    lbldesc4.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "04", "string");
                    lbldesc5.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "05", "string");
                    lbldesc6.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "06", "string");
                    lbldesc7.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "07", "string");
                    lbldesc8.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "08", "string");
                    lbldesc9.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "09", "string");
                    lbldesc10.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "10", "string");
                    lbldesc11.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "11", "string");
                    lbldesc12.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "12", "string");
                    lbldesc13.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "13", "string");
                    lbldesc14.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "14", "string");
                    lbldesc15.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "15", "string");
                    lbldesc16.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "16", "string");
                    lbldesc17.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "17", "string");
                    lbldesc18.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "18", "string");
                    lbldesc19.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "19", "string");
                    lbldesc20.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.Apprsubj_Tab, "SNO", "20", "string");
                }
            }

        }

    string fr = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.ApprHd_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if(fr != string.Empty)
        {
            DateTime gh = DateTime.Parse(fr);
            txtfrom.Text = gh.ToShortDateString();
        }
        string ji = RetrieveFields.retrieveByFieldIndex_HasOneKey(3, AppTables.ApprHd_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if( ji != string.Empty)
        {
            DateTime hf = DateTime.Parse(ji);
            txtto.Text = hf.ToShortDateString();
        }

        string po = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.ApprHd_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if(po != string.Empty)
        {
            DateTime hy = DateTime.Parse(po);
            txtret.Text = hy.ToShortDateString();
        }
        c1 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.ApprHd_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (c1 == "A")
        {
            Chk1.Checked = true;
        Chk2.Checked = false;
        }
        else if (c1 == "S")
        { 
            Chk2.Checked = true;
        Chk1.Checked = false;
        }
        else
        {
            Chk2.Checked = false;
            Chk1.Checked = false;
        }

        //var arr = [ "EX","VGD","GD","AVG","BAVG" ];
        //List<String> fn = new List<string>();
        //fn.Add("EX");
        //fn.Add("VGD");
        //fn.Add("GD");
        //fn.Add("AVG");
        //fn.Add("BAVG");

        //if()

        p1 = RetrieveFields.retrieveByFieldIndex_HasOneKey(5, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p1 == "EX")
        {
            Chkj1.Checked = true;
            Chkj2.Checked = false;
            Chkj3.Checked = false;
            Chkj4.Checked = false;
            Chkj5.Checked = false;
        }
        else if (p1 == "VGD")
        {
            Chkj1.Checked = false;
            Chkj2.Checked = true;
            Chkj3.Checked = false;
            Chkj4.Checked = false;
            Chkj5.Checked = false;
        }

        else if (p1 == "GD")
        {
            Chkj1.Checked = false;
            Chkj2.Checked = false;
            Chkj3.Checked = true;
            Chkj4.Checked = false;
            Chkj5.Checked = false;
        }

        else if (p1 == "AVG")
        {
            Chkj1.Checked = false;
            Chkj2.Checked = false;
            Chkj3.Checked =false;
            Chkj4.Checked =  true;
            Chkj5.Checked = false;
        }
        else if (p1 == "BAVG")
        {
            Chkj1.Checked = false;
            Chkj2.Checked = false;
            Chkj3.Checked = false;
            Chkj4.Checked = false;
            Chkj5.Checked = true;
        }
        else 
        {
            Chkj1.Checked = false;
            Chkj2.Checked = false;
            Chkj3.Checked = false;
            Chkj4.Checked = false;
            Chkj5.Checked = false;
        }

         p2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(8, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p2 == "EX")
        {
            Chkq1.Checked = true;
            Chkq2.Checked = false;
            Chkq3.Checked = false;
            Chkq4.Checked = false;
            Chkq5.Checked = false;
        }
        else if (p2 == "VGD")
        {
            Chkq1.Checked = false;
            Chkq2.Checked = true;
            Chkq3.Checked = false;
            Chkq4.Checked = false;
            Chkq5.Checked = false;
        }

        else if (p2 == "GD")
        {
            Chkq1.Checked = false;
            Chkq2.Checked = false;
            Chkq3.Checked = true;
            Chkq4.Checked = false;
            Chkq5.Checked = false;
        }

        else if (p2 == "AVG")
        {
            Chkq1.Checked = false;
            Chkq2.Checked = false;
            Chkq3.Checked = false;
            Chkq4.Checked = true;
            Chkq5.Checked = false;
        }
        else if (p2 == "BAVG")
        {
            Chkq1.Checked = false;
            Chkq2.Checked = false;
            Chkq3.Checked = false;
            Chkq4.Checked = false;
            Chkq5.Checked = true;
        }
        else
        {
            Chkq1.Checked = false;
            Chkq2.Checked = false;
            Chkq3.Checked = false;
            Chkq4.Checked = false;
            Chkq5.Checked = false;
        }

         p3 = RetrieveFields.retrieveByFieldIndex_HasOneKey(11, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p3 == "EX")
        {
            Chkp1.Checked = true;
            Chkp2.Checked = false;
            Chkp3.Checked = false;
            Chkp4.Checked = false;
            Chkp5.Checked = false;
        }
        else if (p3 == "VGD")
        {
            Chkp1.Checked = false;
            Chkp2.Checked = true;
            Chkp3.Checked = false;
            Chkp4.Checked = false;
            Chkp5.Checked = false;
        }

        else if (p3 == "GD")
        {
            Chkp1.Checked = false;
            Chkp2.Checked = false;
            Chkp3.Checked = true;
            Chkp4.Checked = false;
            Chkp5.Checked = false;
        }

        else if (p3 == "AVG")
        {
            Chkp1.Checked = false;
            Chkp2.Checked = false;
            Chkp3.Checked = false;
            Chkp4.Checked = true;
            Chkp5.Checked = false;
        }
        else if (p3 == "BAVG")
        {
            Chkp1.Checked = false;
            Chkp2.Checked = false;
            Chkp3.Checked = false;
            Chkp4.Checked = false;
            Chkp5.Checked = true;
        }
        else
        {
            Chkp1.Checked = false;
            Chkp2.Checked = false;
            Chkp3.Checked = false;
            Chkp4.Checked = false;
            Chkp5.Checked = false;
        }

         p4 = RetrieveFields.retrieveByFieldIndex_HasOneKey(14, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p4 == "EX")
        {
            Chkd1.Checked = true;
            Chkd2.Checked = false;
            Chkd3.Checked = false;
            Chkd4.Checked = false;
            Chkd5.Checked = false;
        }
        else if (p4 == "VGD")
        {
            Chkd1.Checked = false;
            Chkd2.Checked = true;
            Chkd3.Checked = false;
            Chkd4.Checked = false;
            Chkd5.Checked = false;
        }

        else if (p4 == "GD")
        {
            Chkd1.Checked = false;
            Chkd2.Checked = false;
            Chkd3.Checked = true;
            Chkd4.Checked = false;
            Chkd5.Checked = false;
        }

        else if (p4 == "AVG")
        {
            Chkd1.Checked = false;
            Chkd2.Checked = false;
            Chkd3.Checked = false;
            Chkd4.Checked = true;
            Chkd5.Checked = false;
        }
        else if (p4 == "BAVG")
        {
            Chkd1.Checked = false;
            Chkd2.Checked = false;
            Chkd3.Checked = false;
            Chkd4.Checked = false;
            Chkd5.Checked = true;
        }
        else
        {
            Chkd1.Checked = false;
            Chkd2.Checked = false;
            Chkd3.Checked = false;
            Chkd4.Checked = false;
            Chkd5.Checked = false;
        }
        p5 = RetrieveFields.retrieveByFieldIndex_HasOneKey(17, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p5 == "EX")
        {
            Chka1.Checked = true;
            Chka2.Checked = false;
            Chka3.Checked = false;
            Chka4.Checked = false;
            Chka5.Checked = false;
        }
        else if (p5 == "VGD")
        {
            Chka1.Checked = false;
            Chka2.Checked = true;
            Chka3.Checked = false;
            Chka4.Checked = false;
            Chka5.Checked = false;
        }

        else if (p5 == "GD")
        {
            Chka1.Checked = false;
            Chka2.Checked = false;
            Chka3.Checked = true;
            Chka4.Checked = false;
            Chka5.Checked = false;
        }

        else if (p5 == "AVG")
        {
            Chka1.Checked = false;
            Chka2.Checked = false;
            Chka3.Checked = false;
            Chka4.Checked = true;
            Chka5.Checked = false;
        }
        else if (p5 == "BAVG")
        {
            Chka1.Checked = false;
            Chka2.Checked = false;
            Chka3.Checked = false;
            Chka4.Checked = false;
            Chka5.Checked = true;
        }
        else
        {
            Chka1.Checked = false;
            Chka2.Checked = false;
            Chka3.Checked = false;
            Chka4.Checked = false;
            Chka5.Checked = false;
        }

          p6 = RetrieveFields.retrieveByFieldIndex_HasOneKey(20, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p6 == "EX")
        {
            Chkr1.Checked = true;
            Chkr2.Checked = false;
            Chkr3.Checked = false;
            Chkr4.Checked = false;
            Chkr5.Checked = false;
        }
        else if (p6 == "VGD")
        {
            Chkr1.Checked = false;
            Chkr2.Checked = true;
            Chkr3.Checked = false;
            Chkr4.Checked = false;
            Chkr5.Checked = false;
        }

        else if (p6 == "GD")
        {
            Chkr1.Checked = false;
            Chkr2.Checked = false;
            Chkr3.Checked = true;
            Chkr4.Checked = false;
            Chkr5.Checked = false;
        }

        else if (p6 == "AVG")
        {
            Chkr1.Checked = false;
            Chkr2.Checked = false;
            Chkr3.Checked = false;
            Chkr4.Checked = true;
            Chkr5.Checked = false;
        }
        else if (p6 == "BAVG")
        {
            Chkr1.Checked = false;
            Chkr2.Checked = false;
            Chkr3.Checked = false;
            Chkr4.Checked = false;
            Chkr5.Checked = true;
        }
        else
        {
            Chkr1.Checked = false;
            Chkr2.Checked = false;
            Chkr3.Checked = false;
            Chkr4.Checked = false;
            Chkr5.Checked = false;
        }

        p7 = RetrieveFields.retrieveByFieldIndex_HasOneKey(23, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p7 == "EX")
        {
            Chkc1.Checked = true;
            Chkc2.Checked = false;
            Chkc3.Checked = false;
            Chkc4.Checked = false;
            Chkc5.Checked = false;
        }
        else if (p7 == "VGD")
        {
            Chkc1.Checked = false;
            Chkc2.Checked = true;
            Chkc3.Checked = false;
            Chkc4.Checked = false;
            Chkc5.Checked = false;
        }

        else if (p7 == "GD")
        {
            Chkc1.Checked = false;
            Chkc2.Checked = false;
            Chkc3.Checked = true;
            Chkc4.Checked = false;
            Chkc5.Checked = false;
        }

        else if (p7 == "AVG")
        {
            Chkc1.Checked = false;
            Chkc2.Checked = false;
            Chkc3.Checked = false;
            Chkc4.Checked = true;
            Chkc5.Checked = false;
        }
        else if (p7 == "BAVG")
        {
            Chkc1.Checked = false;
            Chkc2.Checked = false;
            Chkc3.Checked = false;
            Chkc4.Checked = false;
            Chkc5.Checked = true;
        }
        else
        {
            Chkc1.Checked = false;
            Chkc2.Checked = false;
            Chkc3.Checked = false;
            Chkc4.Checked = false;
            Chkc5.Checked = false;
        }


        p8 = RetrieveFields.retrieveByFieldIndex_HasOneKey(26, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p8 == "EX")
        {
            Chks1.Checked = true;
            Chks2.Checked = false;
            Chks3.Checked = false;
            Chks4.Checked = false;
            Chks5.Checked = false;
        }
        else if (p8 == "VGD")
        {
            Chks1.Checked = false;
            Chks2.Checked = true;
            Chks3.Checked = false;
            Chks4.Checked = false;
            Chks5.Checked = false;
        }

        else if (p8 == "GD")
        {
            Chks1.Checked = false;
            Chks2.Checked = false;
            Chks3.Checked = true;
            Chks4.Checked = false;
            Chks5.Checked = false;
        }

        else if (p8 == "AVG")
        {
            Chks1.Checked = false;
            Chks2.Checked = false;
            Chks3.Checked = false;
            Chks4.Checked = true;
            Chks5.Checked = false;
        }
        else if (p8 == "BAVG")
        {
            Chks1.Checked = false;
            Chks2.Checked = false;
            Chks3.Checked = false;
            Chks4.Checked = false;
            Chks5.Checked = true;
        }
        else
        {
            Chks1.Checked = false;
            Chks2.Checked = false;
            Chks3.Checked = false;
            Chks4.Checked = false;
            Chks5.Checked = false;
        }

        p9 = RetrieveFields.retrieveByFieldIndex_HasOneKey(29, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p9 == "EX")
        {
            Chko1.Checked = true;
            Chko2.Checked = false;
            Chko3.Checked = false;
            Chko4.Checked = false;
            Chko5.Checked = false;
        }
        else if (p9 == "VGD")
        {
            Chko1.Checked = false;
            Chko2.Checked = true;
            Chko3.Checked = false;
            Chko4.Checked = false;
            Chko5.Checked = false;
        }

        else if (p9 == "GD")
        {
            Chko1.Checked = false;
            Chko2.Checked = false;
            Chko3.Checked = true;
            Chko4.Checked = false;
            Chko5.Checked = false;
        }

        else if (p9 == "AVG")
        {
            Chko1.Checked = false;
            Chko2.Checked = false;
            Chko3.Checked = false;
            Chko4.Checked = true;
            Chko5.Checked = false;
        }
        else if (p9 == "BAVG")
        {
            Chko1.Checked = false;
            Chko2.Checked = false;
            Chko3.Checked = false;
            Chko4.Checked = false;
            Chko5.Checked = true;
        }
        else
        {
            Chko1.Checked = false;
            Chko2.Checked = false;
            Chko3.Checked = false;
            Chko4.Checked = false;
            Chko5.Checked = false;
        }

        p10 = RetrieveFields.retrieveByFieldIndex_HasOneKey(32, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p10 == "EX")
        {
            Chkap1.Checked = true;
            Chkap2.Checked = false;
            Chkap3.Checked = false;
            Chkap4.Checked = false;
            Chkap5.Checked = false;
        }
        else if (p10 == "VGD")
        {
            Chkap1.Checked = false;
            Chkap2.Checked = true;
            Chkap3.Checked = false;
            Chkap4.Checked = false;
            Chkap5.Checked = false;
        }

        else if (p10 == "GD")
        {
            Chkap1.Checked = false;
            Chkap2.Checked = false;
            Chkap3.Checked = true;
            Chkap4.Checked = false;
            Chkap5.Checked = false;
        }

        else if (p10 == "AVG")
        {
            Chkap1.Checked = false;
            Chkap2.Checked = false;
            Chkap3.Checked = false;
            Chkap4.Checked = true;
            Chkap5.Checked = false;
        }
        else if (p10 == "BAVG")
        {
            Chkap1.Checked = false;
            Chkap2.Checked = false;
            Chkap3.Checked = false;
            Chkap4.Checked = false;
            Chkap5.Checked = true;
        }
        else
        {
            Chkap1.Checked = false;
            Chkap2.Checked = false;
            Chkap3.Checked = false;
            Chkap4.Checked = false;
            Chkap5.Checked = false;
        }

           p11 = RetrieveFields.retrieveByFieldIndex_HasOneKey(35, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p11 == "EX")
        {
            Chkbp1.Checked = true;
            Chkbp2.Checked = false;
            Chkbp3.Checked = false;
            Chkbp4.Checked = false;
            Chkbp5.Checked = false;
        }
        else if (p11 == "VGD")
        {
            Chkbp1.Checked = false;
            Chkbp2.Checked = true;
            Chkbp3.Checked = false;
            Chkbp4.Checked = false;
            Chkbp5.Checked = false;
        }

        else if (p11 == "GD")
        {
            Chkbp1.Checked = false;
            Chkbp2.Checked = false;
            Chkbp3.Checked = true;
            Chkbp4.Checked = false;
            Chkbp5.Checked = false;
        }

        else if (p11 == "AVG")
        {
            Chkbp1.Checked = false;
            Chkbp2.Checked = false;
            Chkbp3.Checked = false;
            Chkbp4.Checked = true;
            Chkbp5.Checked = false;
        }
        else if (p11 == "BAVG")
        {
            Chkbp1.Checked = false;
            Chkbp2.Checked = false;
            Chkbp3.Checked = false;
            Chkbp4.Checked = false;
            Chkbp5.Checked = true;
        }
        else
        {
            Chkbp1.Checked = false;
            Chkbp2.Checked = false;
            Chkbp3.Checked = false;
            Chkbp4.Checked = false;
            Chkbp5.Checked = false;
        }

        p12 = RetrieveFields.retrieveByFieldIndex_HasOneKey(38, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p12 == "EX")
        {
            Chkcp1.Checked = true;
            Chkcp2.Checked = false;
            Chkcp3.Checked = false;
            Chkcp4.Checked = false;
            Chkcp5.Checked = false;
        }
        else if (p12 == "VGD")
        {
            Chkcp1.Checked = false;
            Chkcp2.Checked = true;
            Chkcp3.Checked = false;
            Chkcp4.Checked = false;
            Chkcp5.Checked = false;
        }

        else if (p12 == "GD")
        {
            Chkcp1.Checked = false;
            Chkcp2.Checked = false;
            Chkcp3.Checked = true;
            Chkcp4.Checked = false;
            Chkcp5.Checked = false;
        }

        else if (p12 == "AVG")
        {
            Chkcp1.Checked = false;
            Chkcp2.Checked = false;
            Chkcp3.Checked = false;
            Chkcp4.Checked = true;
            Chkcp5.Checked = false;
        }
        else if (p12 == "BAVG")
        {
            Chkcp1.Checked = false;
            Chkcp2.Checked = false;
            Chkcp3.Checked = false;
            Chkcp4.Checked = false;
            Chkcp5.Checked = true;
        }
        else
        {
            Chkcp1.Checked = false;
            Chkcp2.Checked = false;
            Chkcp3.Checked = false;
            Chkcp4.Checked = false;
            Chkcp5.Checked = false;
        }

        p13 = RetrieveFields.retrieveByFieldIndex_HasOneKey(41, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p13 == "EX")
        {
            Chkdp1.Checked = true;
            Chkdp2.Checked = false;
            Chkdp3.Checked = false;
            Chkdp4.Checked = false;
            Chkdp5.Checked = false;
        }
        else if (p13 == "VGD")
        {
            Chkdp1.Checked = false;
            Chkdp2.Checked = true;
            Chkdp3.Checked = false;
            Chkdp4.Checked = false;
            Chkdp5.Checked = false;
        }

        else if (p13 == "GD")
        {
            Chkdp1.Checked = false;
            Chkdp2.Checked = false;
            Chkdp3.Checked = true;
            Chkdp4.Checked = false;
            Chkdp5.Checked = false;
        }

        else if (p13 == "AVG")
        {
            Chkdp1.Checked = false;
            Chkdp2.Checked = false;
            Chkdp3.Checked = false;
            Chkdp4.Checked = true;
            Chkdp5.Checked = false;
        }
        else if (p13 == "BAVG")
        {
            Chkdp1.Checked = false;
            Chkdp2.Checked = false;
            Chkdp3.Checked = false;
            Chkdp4.Checked = false;
            Chkdp5.Checked = true;
        }
        else
        {
            Chkdp1.Checked = false;
            Chkdp2.Checked = false;
            Chkdp3.Checked = false;
            Chkdp4.Checked = false;
            Chkdp5.Checked = false;
        }

        p14 = RetrieveFields.retrieveByFieldIndex_HasOneKey(44, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p14 == "EX")
        {
            Chkep1.Checked = true;
            Chkep2.Checked = false;
            Chkep3.Checked = false;
            Chkep4.Checked = false;
            Chkep5.Checked = false;
        }
        else if (p14 == "VGD")
        {
            Chkep1.Checked = false;
            Chkep2.Checked = true;
            Chkep3.Checked = false;
            Chkep4.Checked = false;
            Chkep5.Checked = false;
        }

        else if (p14 == "GD")
        {
            Chkep1.Checked = false;
            Chkep2.Checked = false;
            Chkep3.Checked = true;
            Chkep4.Checked = false;
            Chkep5.Checked = false;
        }

        else if (p14 == "AVG")
        {
            Chkep1.Checked = false;
            Chkep2.Checked = false;
            Chkep3.Checked = false;
            Chkep4.Checked = true;
            Chkep5.Checked = false;
        }
        else if (p14 == "BAVG")
        {
            Chkep1.Checked = false;
            Chkep2.Checked = false;
            Chkep3.Checked = false;
            Chkep4.Checked = false;
            Chkep5.Checked = true;
        }
        else
        {
            Chkep1.Checked = false;
            Chkep2.Checked = false;
            Chkep3.Checked = false;
            Chkep4.Checked = false;
            Chkep5.Checked = false;
        }

        p15 = RetrieveFields.retrieveByFieldIndex_HasOneKey(47, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p15 == "EX")
        {
            Chkfp1.Checked = true;
            Chkfp2.Checked = false;
            Chkfp3.Checked = false;
            Chkfp4.Checked = false;
            Chkfp5.Checked = false;
        }
        else if (p15 == "VGD")
        {
            Chkfp1.Checked = false;
            Chkfp2.Checked = true;
            Chkfp3.Checked = false;
            Chkfp4.Checked = false;
            Chkfp5.Checked = false;
        }

        else if (p15 == "GD")
        {
            Chkfp1.Checked = false;
            Chkfp2.Checked = false;
            Chkfp3.Checked = true;
            Chkfp4.Checked = false;
            Chkfp5.Checked = false;
        }

        else if (p15 == "AVG")
        {
            Chkfp1.Checked = false;
            Chkfp2.Checked = false;
            Chkfp3.Checked = false;
            Chkfp4.Checked = true;
            Chkfp5.Checked = false;
        }
        else if (p15 == "BAVG")
        {
            Chkfp1.Checked = false;
            Chkfp2.Checked = false;
            Chkfp3.Checked = false;
            Chkfp4.Checked = false;
            Chkfp5.Checked = true;
        }
        else
        {
            Chkfp1.Checked = false;
            Chkfp2.Checked = false;
            Chkfp3.Checked = false;
            Chkfp4.Checked = false;
            Chkfp5.Checked = false;
        }

        p16 = RetrieveFields.retrieveByFieldIndex_HasOneKey(50, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p16 == "EX")
        {
            Chkgp1.Checked = true;
            Chkgp2.Checked = false;
            Chkgp3.Checked = false;
            Chkgp4.Checked = false;
            Chkgp5.Checked = false;
        }
        else if (p16 == "VGD")
        {
            Chkgp1.Checked = false;
            Chkgp2.Checked = true;
            Chkgp3.Checked = false;
            Chkgp4.Checked = false;
            Chkgp5.Checked = false;
        }

        else if (p16 == "GD")
        {
            Chkgp1.Checked = false;
            Chkgp2.Checked = false;
            Chkgp3.Checked = true;
            Chkgp4.Checked = false;
            Chkgp5.Checked = false;
        }

        else if (p16 == "AVG")
        {
            Chkgp1.Checked = false;
            Chkgp2.Checked = false;
            Chkgp3.Checked = false;
            Chkgp4.Checked = true;
            Chkgp5.Checked = false;
        }
        else if (p16 == "BAVG")
        {
            Chkgp1.Checked = false;
            Chkgp2.Checked = false;
            Chkgp3.Checked = false;
            Chkgp4.Checked = false;
            Chkgp5.Checked = true;
        }
        else
        {
            Chkgp1.Checked = false;
            Chkgp2.Checked = false;
            Chkgp3.Checked = false;
            Chkgp4.Checked = false;
            Chkgp5.Checked = false;
        }

        p17 = RetrieveFields.retrieveByFieldIndex_HasOneKey(53, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p17 == "EX")
        {
            Chkhp1.Checked = true;
            Chkhp2.Checked = false;
            Chkhp3.Checked = false;
            Chkhp4.Checked = false;
            Chkhp5.Checked = false;
        }
        else if (p17 == "VGD")
        {
            Chkhp1.Checked = false;
            Chkhp2.Checked = true;
            Chkhp3.Checked = false;
            Chkhp4.Checked = false;
            Chkhp5.Checked = false;
        }

        else if (p17 == "GD")
        {
            Chkhp1.Checked = false;
            Chkhp2.Checked = false;
            Chkhp3.Checked = true;
            Chkhp4.Checked = false;
            Chkhp5.Checked = false;
        }

        else if (p17 == "AVG")
        {
            Chkhp1.Checked = false;
            Chkhp2.Checked = false;
            Chkhp3.Checked = false;
            Chkhp4.Checked = true;
            Chkhp5.Checked = false;
        }
        else if (p17 == "BAVG")
        {
            Chkhp1.Checked = false;
            Chkhp2.Checked = false;
            Chkhp3.Checked = false;
            Chkhp4.Checked = false;
            Chkhp5.Checked = true;
        }
        else
        {
            Chkhp1.Checked = false;
            Chkhp2.Checked = false;
            Chkhp3.Checked = false;
            Chkhp4.Checked = false;
            Chkhp5.Checked = false;
        }

        p18 = RetrieveFields.retrieveByFieldIndex_HasOneKey(56, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p18 == "EX")
        {
            Chkip1.Checked = true;
            Chkip2.Checked = false;
            Chkip3.Checked = false;
            Chkip4.Checked = false;
            Chkip5.Checked = false;
        }
        else if (p18 == "VGD")
        {
            Chkip1.Checked = false;
            Chkip2.Checked = true;
            Chkip3.Checked = false;
            Chkip4.Checked = false;
            Chkip5.Checked = false;
        }

        else if (p18 == "GD")
        {
            Chkip1.Checked = false;
            Chkip2.Checked = false;
            Chkip3.Checked = true;
            Chkip4.Checked = false;
            Chkip5.Checked = false;
        }

        else if (p18 == "AVG")
        {
            Chkip1.Checked = false;
            Chkip2.Checked = false;
            Chkip3.Checked = false;
            Chkip4.Checked = true;
            Chkip5.Checked = false;
        }
        else if (p18 == "BAVG")
        {
            Chkip1.Checked = false;
            Chkip2.Checked = false;
            Chkip3.Checked = false;
            Chkip4.Checked = false;
            Chkip5.Checked = true;
        }
        else
        {
            Chkip1.Checked = false;
            Chkip2.Checked = false;
            Chkip3.Checked = false;
            Chkip4.Checked = false;
            Chkip5.Checked = false;
        }

        p19 = RetrieveFields.retrieveByFieldIndex_HasOneKey(59, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p19 == "EX")
        {
            Chkjp1.Checked = true;
            Chkjp2.Checked = false;
            Chkjp3.Checked = false;
            Chkjp4.Checked = false;
            Chkjp5.Checked = false;
        }
        else if (p19 == "VGD")
        {
            Chkjp1.Checked = false;
            Chkjp2.Checked = true;
            Chkjp3.Checked = false;
            Chkjp4.Checked = false;
            Chkjp5.Checked = false;
        }

        else if (p19 == "GD")
        {
            Chkjp1.Checked = false;
            Chkjp2.Checked = false;
            Chkjp3.Checked = true;
            Chkjp4.Checked = false;
            Chkjp5.Checked = false;
        }

        else if (p19 == "AVG")
        {
            Chkjp1.Checked = false;
            Chkjp2.Checked = false;
            Chkjp3.Checked = false;
            Chkjp4.Checked = true;
            Chkjp5.Checked = false;
        }
        else if (p19 == "BAVG")
        {
            Chkjp1.Checked = false;
            Chkjp2.Checked = false;
            Chkjp3.Checked = false;
            Chkjp4.Checked = false;
            Chkjp5.Checked = true;
        }
        else
        {
            Chkjp1.Checked = false;
            Chkjp2.Checked = false;
            Chkjp3.Checked = false;
            Chkjp4.Checked = false;
            Chkjp5.Checked = false;
        }

        p20 = RetrieveFields.retrieveByFieldIndex_HasOneKey(62, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        if (p20 == "EX")
        {
            Chkkp1.Checked = true;
            Chkkp2.Checked = false;
            Chkkp3.Checked = false;
            Chkkp4.Checked = false;
            Chkkp5.Checked = false;
        }
        else if (p20 == "VGD")
        {
            Chkkp1.Checked = false;
            Chkkp2.Checked = true;
            Chkkp3.Checked = false;
            Chkkp4.Checked = false;
            Chkkp5.Checked = false;
        }

        else if (p20 == "GD")
        {
            Chkkp1.Checked = false;
            Chkkp2.Checked = false;
            Chkkp3.Checked = true;
            Chkkp4.Checked = false;
            Chkkp5.Checked = false;
        }

        else if (p20 == "AVG")
        {
            Chkkp1.Checked = false;
            Chkkp2.Checked = false;
            Chkkp3.Checked = false;
            Chkkp4.Checked = true;
            Chkkp5.Checked = false;
        }
        else if (p20 == "BAVG")
        {
            Chkkp1.Checked = false;
            Chkkp2.Checked = false;
            Chkkp3.Checked = false;
            Chkkp4.Checked = false;
            Chkkp5.Checked = true;
        }
        else
        {
            Chkkp1.Checked = false;
            Chkkp2.Checked = false;
            Chkkp3.Checked = false;
            Chkkp4.Checked = false;
            Chkkp5.Checked = false;
        }


        txtdesc1.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(4, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc2.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(7, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc3.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(10, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc4.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(13, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc5.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(16, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc6.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(19, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc7.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(22, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc8.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(25, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc9.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(28, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc10.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc11.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(34, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc12.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(37, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc13.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(40, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc14.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(43, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc15.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(46, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc16.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(49, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc17.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(52, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc18.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(55, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc19.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(58, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
        txtdesc20.Text = RetrieveFields.retrieveByFieldIndex_HasOneKey(61, AppTables.ApprDet_Tab, AppFields.ApprHd_Fld1a, txtstid.Text, "string");
      

        Image1.ImageUrl = RetrieveFields.retrieveByFieldIndex_HasOneKey(31, AppTables.Stm_Tab, AppFields.Stm_Fld1a, txtstid.Text, "string");
        lblmn.Text = txtname.Text;
        lblmd.Text = txtdept.Text;
        DateTime fx = HR_Report.myconvdate(txtfrom.Text);
        lblfr.Text = fx.ToShortDateString();
        DateTime ds = HR_Report.myconvdate(txtto.Text);
        lblto.Text = ds.ToShortDateString();


         bh = HR_Report.myconvdate(txtfrom.Text);
         bn = HR_Report.myconvdate(txtto.Text);
        HR_Report.RetrieveModal(txtstid.Text, bh, bn);
        HR_Report.BindDataMod(ListView1);
        
    }
    protected void Chk1_CheckedChanged(object sender, EventArgs e)
    {
        if(Chk1.Checked == true)
        {
            Chk2.Checked = false;
            c1 = "A";
        }
    }
    protected void Chk2_CheckedChanged(object sender, EventArgs e)
    {
        if(Chk2.Checked == true)
        {
            Chk1.Checked = false;
            c1 = "S";
        }
    }
   
    protected void Chkj2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkj2.Checked == true)
        {
            Chkj3.Checked = false;
            Chkj1.Checked = false;
            Chkj4.Checked = false;
            Chkj5.Checked = false;
            p1 = "VGD";
        }
    }
    protected void Chkj3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkj3.Checked == true)
        {
            Chkj2.Checked = false;
            Chkj1.Checked = false;
            Chkj4.Checked = false;
            Chkj5.Checked = false;
            p1 = "GD";
        }
    }

    protected void Chkj5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkj5.Checked == true)
        {
            Chkj2.Checked = false;
            Chkj1.Checked = false;
            Chkj4.Checked = false;
            Chkj3.Checked = false;
            p1 = "BAVG";
        }
    }
 
    protected void Chkq2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkq2.Checked == true)
        {
            Chkq3.Checked = false;
            Chkq1.Checked = false;
            Chkq4.Checked = false;
            Chkq5.Checked = false;
            p2 = "VGD";
        }
    }
    protected void Chkq3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkq3.Checked == true)
        {
            Chkq2.Checked = false;
            Chkq1.Checked = false;
            Chkq4.Checked = false;
            Chkq5.Checked = false;
            p2 = "GD";
        }
    }
 
  
    protected void Chkp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkp2.Checked == true)
        {
            Chkp3.Checked = false;
            Chkp1.Checked = false;
            Chkp4.Checked = false;
            Chkp5.Checked = false;
            p3 = "VGD";
        }
    }
    protected void Chkp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkp3.Checked == true)
        {
            Chkp2.Checked = false;
            Chkp1.Checked = false;
            Chkp4.Checked = false;
            Chkp5.Checked = false;
            p3 = "GD";
        }
    }
  
    protected void Chkd2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkd2.Checked == true)
        {
            Chkd3.Checked = false;
            Chkd1.Checked = false;
            Chkd4.Checked = false;
            Chkd5.Checked = false;
            p4 = "VGD";
        }
    }
    protected void Chkd3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkd3.Checked == true)
        {
            Chkd2.Checked = false;
            Chkd1.Checked = false;
            Chkd4.Checked = false;
            Chkd5.Checked = false;
            p4 = "GD";
        }
    }
   
    protected void Chka2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chka2.Checked == true)
        {
            Chka3.Checked = false;
            Chka1.Checked = false;
            Chka4.Checked = false;
            Chka5.Checked = false;
            p5 = "VGD";
        }
    }
    protected void Chka3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chka3.Checked == true)
        {
            Chka2.Checked = false;
            Chka1.Checked = false;
            Chka4.Checked = false;
            Chka5.Checked = false;
            p5 = "GD";
        }
    }

    protected void Chkr2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkr2.Checked == true)
        {
            Chkr3.Checked = false;
            Chkr1.Checked = false;
            Chkr4.Checked = false;
            Chkr5.Checked = false;
            p6 = "VGD";
        }
    }
    protected void Chkr3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkr3.Checked == true)
        {
            Chkr2.Checked = false;
            Chkr1.Checked = false;
            Chkr4.Checked = false;
            Chkr5.Checked = false;
            p6 = "GD";
        }
    }

    protected void Chkc2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkc2.Checked == true)
        {
            Chkc3.Checked = false;
            Chkc1.Checked = false;
            Chkc4.Checked = false; 
            Chkc5.Checked = false;
            p7 = "VGD";
        }
    }
    protected void Chkc3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkc3.Checked == true)
        {
            Chkc2.Checked = false;
            Chkc1.Checked = false;
            Chkc4.Checked = false;
            Chkc5.Checked = false;
            p7 = "GD";
        }
    }
   
    protected void Chks2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chks2.Checked == true)
        {
            Chks3.Checked = false;
            Chks1.Checked = false;
            Chks4.Checked = false;
            Chks5.Checked = false;
            p8 = "VGD";
        }
    }
    protected void Chks3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chks3.Checked == true)
        {
            Chks2.Checked = false;
            Chks1.Checked = false;
            Chks4.Checked = false;
            Chks5.Checked = false;
            p8 = "GD";
        }
    }
   
    protected void Chko2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chko2.Checked == true)
        {
            Chko3.Checked = false;
            Chko1.Checked = false;
            Chko4.Checked = false;
            Chko5.Checked = false;
            p9 = "VGD";
        }
    }
    protected void Chko3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chko3.Checked == true)
        {
            Chko2.Checked = false;
            Chko1.Checked = false;
            Chko4.Checked = false;
            Chko5.Checked = false;
            p9 = "GD";
        }
    }

    protected void Chkj1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkj1.Checked == true)
        {
            Chkj4.Checked = false;
            Chkj2.Checked = false;
            Chkj3.Checked = false;
            Chkj5.Checked = false;
            p1 = "EX";
        }
    }
    protected void Chkj4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkj4.Checked == true)
        {
            Chkj1.Checked = false;
            Chkj2.Checked = false;
            Chkj3.Checked = false;
            Chkj5.Checked = false;
            p1 = "AVG";
        }
    }
    protected void Chkq1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkq1.Checked == true)
        {
            Chkq4.Checked = false;
            Chkq2.Checked = false;
            Chkq3.Checked = false;
            Chkq5.Checked = false;
            p2 = "EX";
        }
    }
    protected void Chkq4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkq4.Checked == true)
        {
            Chkq1.Checked = false;
            Chkq2.Checked = false;
            Chkq3.Checked = false;
            Chkq5.Checked = false;
            p2 = "AVG";
        }
    }
    protected void Chkp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkp1.Checked == true)
        {
            Chkp4.Checked = false;
            Chkp2.Checked = false;
            Chkp3.Checked = false;
            Chkp5.Checked = false;
            p3 = "EX";
        }
    }
    protected void Chkp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkp4.Checked == true)
        {
            Chkp1.Checked = false;
            Chkp2.Checked = false;
            Chkp3.Checked = false;
            Chkp5.Checked = false;
            p3 = "AVG";
        }
    }
    protected void Chkd1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkd1.Checked == true)
        {
            Chkd4.Checked = false;
            Chkd2.Checked = false;
            Chkd3.Checked = false;
            Chkd5.Checked = false;
            p4 = "EX";
        }
    }
    protected void Chkd4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkd4.Checked == true)
        {
            Chkd1.Checked = false;
            Chkd2.Checked = false;
            Chkd3.Checked = false;
            Chkd5.Checked = false;
            p4 = "AVG";
        }
    }
    protected void Chka1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chka1.Checked == true)
        {
            Chka4.Checked = false;
            Chka2.Checked = false;
            Chka3.Checked = false;
            Chka5.Checked = false;
            p5 = "EX";
        }
    }
    protected void Chka4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chka4.Checked == true)
        {
            Chka1.Checked = false;
            Chka2.Checked = false;
            Chka3.Checked = false;
            Chka5.Checked = false;
            p5 = "AVG";
        }
    }
    protected void Chkr1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkr1.Checked == true)
        {
            Chkr4.Checked = false;
            Chkr2.Checked = false;
            Chkr3.Checked = false;
            Chkr5.Checked = false;
            p6 = "EX";
        }
    }
    protected void Chkr4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkr4.Checked == true)
        {
            Chkr1.Checked = false;
            Chkr2.Checked = false;
            Chkr3.Checked = false;
            Chkr5.Checked = false;
            p6 = "AVG";
        }
    }
    protected void Chkc1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkc1.Checked == true)
        {
            Chkc4.Checked = false;
            Chkc2.Checked = false;
            Chkc3.Checked = false;
            Chkc5.Checked = false;
            p7 = "EX";
        }
    }
    protected void Chkc4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkc4.Checked == true)
        {
            Chkc1.Checked = false;
            Chkc2.Checked = false;
            Chkc3.Checked = false;
            Chkc5.Checked = false;
            p7 = "AVG";
        }
    }
    protected void Chks1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chks1.Checked == true)
        {
            Chks4.Checked = false;
            Chks2.Checked = false;
            Chks3.Checked = false;
            Chks5.Checked = false;
            p8 = "EX";
        }
    }
    protected void Chks4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chks4.Checked == true)
        {
            Chks1.Checked = false;
            Chks2.Checked = false;
            Chks3.Checked = false;
            Chks5.Checked = false;
            p8 = "AVG";
        }
    }
    protected void Chko1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chko1.Checked == true)
        {
            Chko4.Checked = false;
            Chko2.Checked = false;
            Chko3.Checked = false;
            Chko5.Checked = false;
            p9 = "EX";
        }
    }
    protected void Chko4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chko4.Checked == true)
        {
            Chko1.Checked = false;
            Chko2.Checked = false;
            Chko3.Checked = false;
            Chko5.Checked = false;
            p9 = "AVG";
        }
    }

    protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Chkq5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkq5.Checked == true)
        {
            Chkq2.Checked = false;
            Chkq1.Checked = false;
            Chkq4.Checked = false;
            Chkq3.Checked = false;
            p2 = "BAVG";
        }
    }
    protected void Chkp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkp5.Checked == true)
        {
            Chkp2.Checked = false;
            Chkp1.Checked = false;
            Chkp4.Checked = false;
            Chkp3.Checked = false;
            p3 = "BAVG";
        }
    }
    protected void Chkd5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkd5.Checked == true)
        {
            Chkd2.Checked = false;
            Chkd1.Checked = false;
            Chkd4.Checked = false;
            Chkd3.Checked = false;
            p4 = "BAVG";
        }
    }
    protected void Chka5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chka5.Checked == true)
        {
            Chka2.Checked = false;
            Chka1.Checked = false;
            Chka4.Checked = false;
            Chka3.Checked = false;
            p5 = "BAVG";
        }
    }
    protected void Chkr5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkr5.Checked == true)
        {
            Chkr2.Checked = false;
            Chkr1.Checked = false;
            Chkr4.Checked = false;
            Chkr3.Checked = false;
            p6 = "BAVG";
        }
    }
    protected void Chkc5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkc5.Checked == true)
        {
            Chkc2.Checked = false;
            Chkc1.Checked = false;
            Chkc4.Checked = false;
            Chkc3.Checked = false;
            p7 = "BAVG";
        }
    }
    protected void Chks5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chks5.Checked == true)
        {
            Chks2.Checked = false;
            Chks1.Checked = false;
            Chks4.Checked = false;
            Chks3.Checked = false;
            p8 = "BAVG";
        }
    }
    protected void Chko5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chko5.Checked == true)
        {
            Chko2.Checked = false;
            Chko1.Checked = false;
            Chko4.Checked = false;
            Chko3.Checked = false;
            p9 = "BAVG";
        }
    }
    protected void Chkap1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkap1.Checked == true)
        {
            Chkap2.Checked = false;
            Chkap3.Checked = false;
            Chkap4.Checked = false;
            Chkap5.Checked = false;
            p10 = "EX";
        }
    }
    protected void Chkap2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkap2.Checked == true)
        {
            Chkap1.Checked = false;
            Chkap3.Checked = false;
            Chkap4.Checked = false;
            Chkap5.Checked = false;
            p10 = "VGD";
        }
    }
    protected void Chkap3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkap3.Checked == true)
        {
            Chkap2.Checked = false;
            Chkap1.Checked = false;
            Chkap4.Checked = false;
            Chkap5.Checked = false;
            p10 = "GD";
        }
    }
    protected void Chkap4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkap4.Checked == true)
        {
            Chkap2.Checked = false;
            Chkap3.Checked = false;
            Chkap1.Checked = false;
            Chkap5.Checked = false;
            p10 = "AVG";
        }
    }
    protected void Chkap5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkap5.Checked == true)
        {
            Chkap2.Checked = false;
            Chkap3.Checked = false;
            Chkap4.Checked = false;
            Chkap1.Checked = false;
            p10 = "BAVG";
        }
    }

    protected void Chkbp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkbp1.Checked == true)
        {
            Chkbp2.Checked = false;
            Chkbp3.Checked = false;
            Chkbp4.Checked = false;
            Chkbp5.Checked = false;
            p11 = "EX";
        }
    }
    protected void Chkbp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkbp2.Checked == true)
        {
            Chkbp1.Checked = false;
            Chkbp3.Checked = false;
            Chkbp4.Checked = false;
            Chkbp5.Checked = false;
            p11 = "VGD";
        }
    }
    protected void Chkbp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkbp3.Checked == true)
        {
            Chkbp2.Checked = false;
            Chkbp1.Checked = false;
            Chkbp4.Checked = false;
            Chkbp5.Checked = false;
            p11 = "GD";
        }
    }
    protected void Chkbp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkbp4.Checked == true)
        {
            Chkbp2.Checked = false;
            Chkbp3.Checked = false;
            Chkbp1.Checked = false;
            Chkbp5.Checked = false;
            p11 = "AVG";
        }
    }
    protected void Chkbp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkbp5.Checked == true)
        {
            Chkbp2.Checked = false;
            Chkbp3.Checked = false;
            Chkbp4.Checked = false;
            Chkbp1.Checked = false;
            p11 = "BAVG";
        }
    }

    protected void Chkcp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkcp1.Checked == true)
        {
            Chkcp2.Checked = false;
            Chkcp3.Checked = false;
            Chkcp4.Checked = false;
            Chkcp5.Checked = false;
            p12 = "EX";
        }
    }
    protected void Chkcp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkcp2.Checked == true)
        {
            Chkcp1.Checked = false;
            Chkcp3.Checked = false;
            Chkcp4.Checked = false;
            Chkcp5.Checked = false;
            p12 = "VGD";
        }
    }
    protected void Chkcp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkcp3.Checked == true)
        {
            Chkcp2.Checked = false;
            Chkcp1.Checked = false;
            Chkcp4.Checked = false;
            Chkcp5.Checked = false;
            p12 = "GD";
        }
    }
    protected void Chkcp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkcp4.Checked == true)
        {
            Chkcp2.Checked = false;
            Chkcp3.Checked = false;
            Chkcp1.Checked = false;
            Chkcp5.Checked = false;
            p12 = "AVG";
        }
    }
    protected void Chkcp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkcp5.Checked == true)
        {
            Chkcp2.Checked = false;
            Chkcp3.Checked = false;
            Chkcp4.Checked = false;
            Chkcp1.Checked = false;
            p12 = "BAVG";
        }
    }

    protected void Chkdp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkdp1.Checked == true)
        {
            Chkdp2.Checked = false;
            Chkdp3.Checked = false;
            Chkdp4.Checked = false;
            Chkdp5.Checked = false;
            p13 = "EX";
        }
    }
    protected void Chkdp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkdp2.Checked == true)
        {
            Chkdp1.Checked = false;
            Chkdp3.Checked = false;
            Chkdp4.Checked = false;
            Chkdp5.Checked = false;
            p13 = "VGD";
        }
    }
    protected void Chkdp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkdp3.Checked == true)
        {
            Chkdp2.Checked = false;
            Chkdp1.Checked = false;
            Chkdp4.Checked = false;
            Chkdp5.Checked = false;
            p13 = "GD";
        }
    }
    protected void Chkdp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkdp4.Checked == true)
        {
            Chkdp2.Checked = false;
            Chkdp3.Checked = false;
            Chkdp1.Checked = false;
            Chkdp5.Checked = false;
            p13 = "AVG";
        }
    }
    protected void Chkdp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkdp5.Checked == true)
        {
            Chkdp2.Checked = false;
            Chkdp3.Checked = false;
            Chkdp4.Checked = false;
            Chkdp1.Checked = false;
            p13 = "BAVG";
        }
    }

    protected void Chkep1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkep1.Checked == true)
        {
            Chkep2.Checked = false;
            Chkep3.Checked = false;
            Chkep4.Checked = false;
            Chkep5.Checked = false;
            p14 = "EX";
        }
    }
    protected void Chkep2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkep2.Checked == true)
        {
            Chkep1.Checked = false;
            Chkep3.Checked = false;
            Chkep4.Checked = false;
            Chkep5.Checked = false;
            p14 = "VGD";
        }
    }
    protected void Chkep3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkep3.Checked == true)
        {
            Chkep2.Checked = false;
            Chkep1.Checked = false;
            Chkep4.Checked = false;
            Chkep5.Checked = false;
            p14 = "GD";
        }
    }
    protected void Chkep4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkep4.Checked == true)
        {
            Chkep2.Checked = false;
            Chkep3.Checked = false;
            Chkep1.Checked = false;
            Chkep5.Checked = false;
            p14 = "AVG";
        }
    }
    protected void Chkep5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkep5.Checked == true)
        {
            Chkep2.Checked = false;
            Chkep3.Checked = false;
            Chkep4.Checked = false;
            Chkep1.Checked = false;
            p14 = "BAVG";
        }
    }

    protected void Chkfp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkfp1.Checked == true)
        {
            Chkfp2.Checked = false;
            Chkfp3.Checked = false;
            Chkfp4.Checked = false;
            Chkfp5.Checked = false;
            p15 = "EX";
        }
    }
    protected void Chkfp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkfp2.Checked == true)
        {
            Chkfp1.Checked = false;
            Chkfp3.Checked = false;
            Chkfp4.Checked = false;
            Chkfp5.Checked = false;
            p15 = "VGD";
        }
    }
    protected void Chkfp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkfp3.Checked == true)
        {
            Chkfp2.Checked = false;
            Chkfp1.Checked = false;
            Chkfp4.Checked = false;
            Chkfp5.Checked = false;
            p15 = "GD";
        }
    }
    protected void Chkfp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkfp4.Checked == true)
        {
            Chkfp2.Checked = false;
            Chkfp3.Checked = false;
            Chkfp1.Checked = false;
            Chkfp5.Checked = false;
            p15 = "AVG";
        }
    }
    protected void Chkfp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkfp5.Checked == true)
        {
            Chkfp2.Checked = false;
            Chkfp3.Checked = false;
            Chkfp4.Checked = false;
            Chkfp1.Checked = false;
            p15 = "BAVG";
        }
    }

    protected void Chkgp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkgp1.Checked == true)
        {
            Chkgp2.Checked = false;
            Chkgp3.Checked = false;
            Chkgp4.Checked = false;
            Chkgp5.Checked = false;
            p16 = "EX";
        }
    }
    protected void Chkgp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkgp2.Checked == true)
        {
            Chkgp1.Checked = false;
            Chkgp3.Checked = false;
            Chkgp4.Checked = false;
            Chkgp5.Checked = false;
            p16 = "VGD";
        }
    }
    protected void Chkgp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkgp3.Checked == true)
        {
            Chkgp2.Checked = false;
            Chkgp1.Checked = false;
            Chkgp4.Checked = false;
            Chkgp5.Checked = false;
            p16 = "GD";
        }
    }
    protected void Chkgp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkgp4.Checked == true)
        {
            Chkgp2.Checked = false;
            Chkgp3.Checked = false;
            Chkgp1.Checked = false;
            Chkgp5.Checked = false;
            p16 = "AVG";
        }
    }
    protected void Chkgp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkgp5.Checked == true)
        {
            Chkgp2.Checked = false;
            Chkgp3.Checked = false;
            Chkgp4.Checked = false;
            Chkgp1.Checked = false;
            p16 = "BAVG";
        }
    }

    protected void Chkhp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkhp1.Checked == true)
        {
            Chkhp2.Checked = false;
            Chkhp3.Checked = false;
            Chkhp4.Checked = false;
            Chkhp5.Checked = false;
            p17 = "EX";
        }
    }
    protected void Chkhp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkhp2.Checked == true)
        {
            Chkhp1.Checked = false;
            Chkhp3.Checked = false;
            Chkhp4.Checked = false;
            Chkhp5.Checked = false;
            p17 = "VGD";
        }
    }
    protected void Chkhp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkhp3.Checked == true)
        {
            Chkhp2.Checked = false;
            Chkhp1.Checked = false;
            Chkhp4.Checked = false;
            Chkhp5.Checked = false;
            p17 = "GD";
        }
    }
    protected void Chkhp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkhp4.Checked == true)
        {
            Chkhp2.Checked = false;
            Chkhp3.Checked = false;
            Chkhp1.Checked = false;
            Chkhp5.Checked = false;
            p17 = "AVG";
        }
    }
    protected void Chkhp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkhp5.Checked == true)
        {
            Chkhp2.Checked = false;
            Chkhp3.Checked = false;
            Chkhp4.Checked = false;
            Chkhp1.Checked = false;
            p17 = "BAVG";
        }
    }

    protected void Chkip1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkip1.Checked == true)
        {
            Chkip2.Checked = false;
            Chkip3.Checked = false;
            Chkip4.Checked = false;
            Chkip5.Checked = false;
            p18 = "EX";
        }
    }
    protected void Chkip2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkip2.Checked == true)
        {
            Chkip1.Checked = false;
            Chkip3.Checked = false;
            Chkip4.Checked = false;
            Chkip5.Checked = false;
            p18 = "VGD";
        }
    }
    protected void Chkip3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkip3.Checked == true)
        {
            Chkip2.Checked = false;
            Chkip1.Checked = false;
            Chkip4.Checked = false;
            Chkip5.Checked = false;
            p18 = "GD";
        }
    }
    protected void Chkip4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkip4.Checked == true)
        {
            Chkip2.Checked = false;
            Chkip3.Checked = false;
            Chkip1.Checked = false;
            Chkip5.Checked = false;
            p18 = "AVG";
        }
    }
    protected void Chkip5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkip5.Checked == true)
        {
            Chkip2.Checked = false;
            Chkip3.Checked = false;
            Chkip4.Checked = false;
            Chkip1.Checked = false;
            p18 = "BAVG";
        }
    }


    protected void submitButton_Click(object sender, EventArgs e)
    {

        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {

                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select *  from Appraisal_Subject  ";
                SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {

                    g1 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "01", "string");
                    g2 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "02", "string");
                    g3 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "03", "string");
                    g4 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "04", "string");
                    g5 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "05", "string");
                    g6 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "06", "string");
                    g7 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "07", "string");
                    g8 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "08", "string");
                    g9 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "09", "string");
                    g10 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "10", "string");
                    g11 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "11", "string");
                    g12 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "12", "string");
                    g13 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "13", "string");
                    g14 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "14", "string");
                    g15 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "15", "string");
                    g16 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "16", "string");
                    g17 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "17", "string");
                    g18 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "18", "string");
                    g19 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "19", "string");
                    g20 = RetrieveFields.retrieveByFieldIndex_HasOneKey(1, AppTables.Apprsubj_Tab, "SNO", "20", "string");

                    SaveRecord.Save_Appr_Header(txtstid.Text, c1, txtfrom.Text, txtto.Text, txtret.Text);
                    SaveRecord.Save_Appr_Details(txtstid.Text, txtfrom.Text, txtto.Text, g1, txtdesc1.Text, p1, g2, txtdesc2.Text, p2,
                       g3,txtdesc3.Text,p3, g4,
                        txtdesc4.Text, p4, g5, txtdesc5.Text, p5, g6, txtdesc6.Text, p6, g7, txtdesc7.Text, p7, g8, txtdesc8.Text, p8,
                        g9, txtdesc9.Text, p9, g10, txtdesc10.Text, p10, g11, txtdesc11.Text, p11, g12, txtdesc12.Text, p12, g13, txtdesc13.Text, p13,
                        g14, txtdesc14.Text, p14, g15, txtdesc15.Text, p15, g16, txtdesc16.Text, p16, g17, txtdesc17.Text, p17, g18, txtdesc18.Text, p18,g19, txtdesc19.Text, p19,g20, txtdesc20.Text, p20);

                    lbldanger.Text = "";
                    lblsuccess.Text = "Record Save Successfully";
                    clear_controls();
                }
            }

        }
    }
    protected void deleteButton_Click(object sender, EventArgs e)
    {
        SaveRecord.Delete_Appr_Header(txtstid.Text);
        SaveRecord.Delete_Appr_Details(txtstid.Text);
        lblsuccess.Text = "";
        lbldanger.Text = "Record Deleted Successfully";
        clear_controls();
    }

    private void clear_controls()
    {
        txtstid.Text = "";
        txtname.Text = "";
        txtdept.Text = "";
        txtclass.Text = "";
        txtfrom.Text = "";
        txtto.Text = "";
        txtret.Text = "";
        Chk1.Checked = false;
        Chk2.Checked = false;
        Chkj1.Checked = false;
        Chkj2.Checked = false;
        Chkj3.Checked = false;
        Chkj4.Checked = false;
        Chkj5.Checked = false;
        Chkq1.Checked = false;
        Chkq2.Checked = false;
        Chkq3.Checked = false;
        Chkq4.Checked = false;
        Chkq5.Checked = false;
        Chkp1.Checked = false;
        Chkp2.Checked = false;
        Chkp3.Checked = false;
        Chkp4.Checked = false;
        Chkp5.Checked = false;
        Chkd1.Checked = false;
        Chkd2.Checked = false;
        Chkd3.Checked = false;
        Chkd4.Checked = false;
        Chkd5.Checked = false;
        Chka1.Checked = false;
        Chka2.Checked = false;
        Chka3.Checked = false;
        Chka4.Checked = false;
        Chka5.Checked = false;
        Chkr1.Checked = false;
        Chkr2.Checked = false;
        Chkr3.Checked = false;
        Chkr4.Checked = false;
        Chkr5.Checked = false;
        Chkc1.Checked = false;
        Chkc2.Checked = false;
        Chkc3.Checked = false;
        Chkc4.Checked = false;
        Chkc5.Checked = false;
        Chks1.Checked = false;
        Chks2.Checked = false;
        Chks3.Checked = false;
        Chks4.Checked = false;
        Chks5.Checked = false;
        Chko1.Checked = false;
        Chko2.Checked = false;
        Chko3.Checked = false;
        Chko4.Checked = false;
        Chko5.Checked = false;
        Chkap1.Checked = false;
        Chkap2.Checked = false;
        Chkap3.Checked = false;
        Chkap4.Checked = false;
        Chkap5.Checked = false;
        Chkbp1.Checked = false;
        Chkbp2.Checked = false;
        Chkbp3.Checked = false;
        Chkbp4.Checked = false;
        Chkbp5.Checked = false;
        Chkcp1.Checked = false;
        Chkcp2.Checked = false;
        Chkcp3.Checked = false;
        Chkcp4.Checked = false;
        Chkcp5.Checked = false;
        Chkdp1.Checked = false;
        Chkdp2.Checked = false;
        Chkdp3.Checked = false;
        Chkdp4.Checked = false;
        Chkdp5.Checked = false;
        Chkep1.Checked = false;
        Chkep2.Checked = false;
        Chkep3.Checked = false;
        Chkep4.Checked = false;
        Chkep5.Checked = false;
        Chkfp1.Checked = false;
        Chkfp2.Checked = false;
        Chkfp3.Checked = false;
        Chkfp4.Checked = false;
        Chkfp5.Checked = false;
        Chkgp1.Checked = false;
        Chkgp2.Checked = false;
        Chkgp3.Checked = false;
        Chkgp4.Checked = false;
        Chkgp5.Checked = false;
        Chkhp1.Checked = false;
        Chkhp2.Checked = false;
        Chkhp3.Checked = false;
        Chkhp4.Checked = false;
        Chkhp5.Checked = false;
        Chkip1.Checked = false;
        Chkip2.Checked = false;
        Chkip3.Checked = false;
        Chkip4.Checked = false;
        Chkip5.Checked = false;
        Chkjp1.Checked = false;
        Chkjp2.Checked = false;
        Chkjp3.Checked = false;
        Chkjp4.Checked = false;
        Chkjp5.Checked = false;
        Chkkp1.Checked = false;
        Chkkp2.Checked = false;
        Chkkp3.Checked = false;
        Chkkp4.Checked = false;
        Chkkp5.Checked = false;
        txtdesc1.Text = "";
        txtdesc2.Text = "";
        txtdesc3.Text = "";
        txtdesc4.Text = "";
        txtdesc5.Text = "";
        txtdesc6.Text = "";
        txtdesc7.Text = "";
        txtdesc8.Text = "";
        txtdesc9.Text = "";
        txtdesc10.Text = "";
        txtdesc11.Text = "";
        txtdesc12.Text = "";
        txtdesc13.Text = "";
        txtdesc14.Text = "";
        txtdesc15.Text = "";
        txtdesc16.Text = "";
        txtdesc17.Text = "";
        txtdesc18.Text = "";
        txtdesc19.Text = "";
        txtdesc20.Text = "";
        Image1.ImageUrl = "";
    }
    protected void Chkjp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkjp1.Checked == true)
        {
            Chkjp2.Checked = false;
            Chkjp3.Checked = false;
            Chkjp4.Checked = false;
            Chkjp5.Checked = false;
            p19 = "EX";
        }
    }
    protected void Chkjp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkjp2.Checked == true)
        {
            Chkjp1.Checked = false;
            Chkjp3.Checked = false;
            Chkjp4.Checked = false;
            Chkjp5.Checked = false;
            p19 = "VGD";
        }
    }
    protected void Chkjp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkjp3.Checked == true)
        {
            Chkjp2.Checked = false;
            Chkjp1.Checked = false;
            Chkjp4.Checked = false;
            Chkjp5.Checked = false;
            p19 = "GD";
        }
    }
    protected void Chkjp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkjp4.Checked == true)
        {
            Chkjp2.Checked = false;
            Chkjp3.Checked = false;
            Chkjp1.Checked = false;
            Chkjp5.Checked = false;
            p19 = "AVG";
        }
    }
    protected void Chkjp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkjp5.Checked == true)
        {
            Chkjp2.Checked = false;
            Chkjp3.Checked = false;
            Chkjp4.Checked = false;
            Chkjp1.Checked = false;
            p19 = "BAVG";
        }
    }
    protected void Chkkp1_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkkp1.Checked == true)
        {
            Chkkp2.Checked = false;
            Chkkp3.Checked = false;
            Chkkp4.Checked = false;
            Chkkp5.Checked = false;
            p20 = "EX";
        }
    }
    protected void Chkkp2_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkkp2.Checked == true)
        {
            Chkkp1.Checked = false;
            Chkkp3.Checked = false;
            Chkkp4.Checked = false;
            Chkkp5.Checked = false;
            p20 = "VGD";
        }
    }
    protected void Chkkp3_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkkp3.Checked == true)
        {
            Chkkp2.Checked = false;
            Chkkp1.Checked = false;
            Chkkp4.Checked = false;
            Chkkp5.Checked = false;
            p20 = "GD";
        }
    }
    protected void Chkkp4_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkkp4.Checked == true)
        {
            Chkkp2.Checked = false;
            Chkkp3.Checked = false;
            Chkkp1.Checked = false;
            Chkkp5.Checked = false;
            p20 = "AVG";
        }
    }
    protected void Chkkp5_CheckedChanged(object sender, EventArgs e)
    {
        if (Chkkp5.Checked == true)
        {
            Chkkp2.Checked = false;
            Chkkp3.Checked = false;
            Chkkp4.Checked = false;
            Chkkp1.Checked = false;
            p20 = "BAVG";
        }
    }
    protected void txtto_TextChanged(object sender, EventArgs e)
    {
        lblmn.Text = txtname.Text;
        lblmd.Text = txtdept.Text;
        DateTime fx = HR_Report.myconvdate(txtfrom.Text);
        lblfr.Text = fx.ToShortDateString();
        DateTime ds = HR_Report.myconvdate(txtto.Text);
        lblto.Text = ds.ToShortDateString();


        bh = HR_Report.myconvdate(txtfrom.Text);
        bn = HR_Report.myconvdate(txtto.Text);
        HR_Report.RetrieveModal(txtstid.Text, bh, bn);
        HR_Report.BindDataMod(ListView1);
    }
}