using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AnStaff : System.Web.UI.Page
{
    Int32 StaffId; 
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if(IsPostBack == false)
        {
            if(StaffId != -1)
            {
                DisplayStaff(); 

            }
        }
    }
    void DisplayStaff()
    {
        HotelClasses.clsStaffCollection AllStaff = new clsStaffCollection();
        AllStaff.ThisStaff.Find(StaffId);
        txtStaffName.Text = AllStaff.ThisStaff.StaffName;
        txtPhone.Text = AllStaff.ThisStaff.StaffPhone;
        txtEmail.Text = AllStaff.ThisStaff.Email;
        chkActive.Checked = AllStaff.ThisStaff.Active;
        ddlStaffRole.SelectedValue = AllStaff.ThisStaff.StaffRoleId.ToString(); 
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StaffId == -1)
        {
            Add();
            Response.Redirect("Default.aspx");
        }
        else
        {
            Update();
            Response.Redirect("Default.aspx");
        }
    }  
    void Add()
    {
        HotelClasses.clsStaffCollection AllStaff = new clsStaffCollection();
        String Error = AllStaff.ThisStaff.Valid(txtStaffName.Text, txtPhone.Text, txtEmail.Text, chkActive.Checked, Convert.ToInt32(ddlStaffRole.SelectedValue)); 
        if(Error == "")
        {
            AllStaff.ThisStaff.StaffName = txtStaffName.Text;
            AllStaff.ThisStaff.StaffPhone = txtPhone.Text;
            AllStaff.ThisStaff.Email = txtEmail.Text;
            AllStaff.ThisStaff.Active = chkActive.Checked;
            AllStaff.ThisStaff.StaffRoleId = Convert.ToInt32(ddlStaffRole.SelectedValue);
            AllStaff.Add();
        }
        else
        {
            lblError.Text = "There were problem with the data" + Error; 
        }
    }
    void Update()
    {
        HotelClasses.clsStaffCollection AllStaff = new clsStaffCollection();
        String Error = AllStaff.ThisStaff.Valid(txtStaffName.Text, txtPhone.Text, txtEmail.Text, chkActive.Checked, Convert.ToInt32( ddlStaffRole.SelectedValue));
        if (Error == "")
        {
            AllStaff.ThisStaff.StaffId = StaffId; 
            AllStaff.ThisStaff.StaffName = txtStaffName.Text;
            AllStaff.ThisStaff.StaffPhone = txtPhone.Text;
            AllStaff.ThisStaff.Email = txtEmail.Text;
            AllStaff.ThisStaff.Active = chkActive.Checked;
            AllStaff.ThisStaff.StaffRoleId = Convert.ToInt32(ddlStaffRole.SelectedValue);
            AllStaff.Update();
        }
        else
        {
            lblError.Text = "There were problem with the data" + Error;
        }
    }

}