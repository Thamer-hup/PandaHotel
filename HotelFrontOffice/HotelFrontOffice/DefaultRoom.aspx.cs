using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class DefaultRoom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayRooms();
        }

    }
    public void DisplayRooms()
    {
        clsRoomCollection AllRoom = new clsRoomCollection();
        lstRoom.DataSource = AllRoom.RoomList;
        lstRoom.DataValueField = "RoomId";
        lstRoom.DataTextField = "RoomNumber";
        lstRoom.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["RoomId"] = -1;
        Response.Redirect("AnRoom.aspx");
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 RoomId;
        if (lstRoom.SelectedIndex != -1)
        {
            RoomId = Convert.ToInt32(lstRoom.SelectedValue);
            Session["RoomId"] = RoomId;
            Response.Redirect("AnRoom.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsRoomCollection AllRoom = new clsRoomCollection();
        AllRoom.ReportByRoomNumber(txtRoomNumber.Text);
        lstRoom.DataSource = AllRoom.RoomList;
        lstRoom.DataValueField = "RoomId";
        lstRoom.DataTextField = "RoomNumber";
        lstRoom.DataBind();
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayRooms();
    }

    protected void lbnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}