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
        clsStaff AnStaff = new clsStaff();
        AnStaff.StaffName = txtStaffName.Text;
        AnStaff.StaffPhone = txtPhone.Text;
        AnStaff.Email = txtEmail.Text;
        AnStaff.StaffRole = ddlStaffRole.SelectedValue;
        AnStaff.Active = chkActive.Checked;
        Response.Redirect("StaffViewer.aspx");
    }   

}