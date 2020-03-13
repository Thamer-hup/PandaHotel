using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class Delete : System.Web.UI.Page
{
    Int32 StaffId; 
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]); 

    }

    void DeleteAddress()
    {
        clsStaffCollection AllStafff = new clsStaffCollection();
        AllStafff.ThisStaff.Find(StaffId);
        AllStafff.Delete(); 
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteAddress();
        Response.Redirect("Default.aspx"); 

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx"); 
    }
}