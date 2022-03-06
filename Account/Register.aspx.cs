using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using HRAPP;

public partial class Account_Register : Page
{
    private static string gcode;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillCombo.DropDownListItems(1, cmbrol, AppTables.ROL_Tab);

    }
    protected void CreateUser_Click(object sender, EventArgs e)
    {
       string gk = RetrieveFields.retrieveByFieldIndex_HasOneKey(2, AppTables.ROL_Tab, AppFields.ROL_Fld1a, gcode, "string");

        if (gk == txtentc.Text)
        {
            var manager = new UserManager();
            var user = new ApplicationUser() { UserName = UserName.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                IdentityHelper.SignIn(manager, user, isPersistent: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
        else
        {
            ErrorMessage.Text = "Incorrect Code";
            UserName.Text = "";
            txtentc.Text = "";
            FillCombo.DropDownListItems(1, cmbrol, AppTables.ROL_Tab);
        }

    }


    protected void cmbrol_SelectedIndexChanged(object sender, EventArgs e)
    {
       gcode = RetrieveFields.retrieveByFieldIndex_HasOneKey(0, AppTables.ROL_Tab, AppFields.ROL_Fld1b, cmbrol.SelectedItem.Text, "string");

        
    }

}