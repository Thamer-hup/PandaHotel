using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AnStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Add(); 
        Response.Redirect("Default.aspx");
    }  
    void Add()
    {
        HotelClasses.clsStaffCollection AllStaff = new clsStaffCollection();
        String Error = AllStaff.ThisStaff.Valid(txtStaffName.Text, txtPhone.Text, txtEmail.Text, chkActive.Checked, ddlStaffRole.SelectedValue); 
        if(Error == "")
        {
            AllStaff.ThisStaff.StaffName = txtStaffName.Text;
            AllStaff.ThisStaff.StaffPhone = txtPhone.Text;
            AllStaff.ThisStaff.Email = txtEmail.Text;
            AllStaff.ThisStaff.Active = chkActive.Checked;
            AllStaff.ThisStaff.StaffRole = ddlStaffRole.SelectedValue;
            AllStaff.Add(); 
        }
        else
        {
            lblError.Text = "There were problem with the data" + Error; 
        }
    }

}