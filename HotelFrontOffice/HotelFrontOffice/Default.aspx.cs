using HotelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayStaff(); 
        }

    }
    public void DisplayStaff()
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        lstStaff.DataSource = AllStaff.StaffList;
        lstStaff.DataValueField = "StaffId";
        lstStaff.DataTextField = "StaffName";
        lstStaff.DataBind(); 

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("AnStaff.aspx"); 
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if(lstStaff.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("Delete.aspx"); 
        }
        else
        {
            lblError.Text = "Please select a record to delete"; 
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaff.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("AnStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        AllStaff.ReportByStaffName(txtStaffName.Text); 
        lstStaff.DataSource = AllStaff.StaffList;
        lstStaff.DataValueField = "StaffId";
        lstStaff.DataTextField = "StaffName";
        lstStaff.DataBind();
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayStaff();
    }
} 