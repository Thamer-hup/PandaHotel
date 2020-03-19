using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses; 

public partial class AnRoom : System.Web.UI.Page
{

        Int32 RoomId;
        protected void Page_Load(object sender, EventArgs e)
        {
            RoomId = Convert.ToInt32(Session["RoomId"]);
            if (IsPostBack == false)
            {
                if (RoomId != -1)
                {
                    DisplayRoom();

                }
            }
        }
        void DisplayRoom()
        {
            HotelClasses.clsRoomCollection AllRoom = new clsRoomCollection();
            AllRoom.ThisRoom.Find(RoomId);
            txtRoomNumber.Text = AllRoom.ThisRoom.RoomNumber;
            txtFloorNo.Text = AllRoom.ThisRoom.FloorNo.ToString();
            txtDailyCharge.Text = AllRoom.ThisRoom.DailyCharge.ToString();
            chkAvailable.Checked = AllRoom.ThisRoom.AvailableForBooking ;
            ddlStaffRole.SelectedValue = AllRoom.ThisRoom.RoomTypeId.ToString();
        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (RoomId == -1)
            {
                Add();
                Response.Redirect("DefaultRoom.aspx");
            }
            else
            {
                Update();
                Response.Redirect("DefaultRoom.aspx");
            }
        }
        void Add()
        {
            clsRoomCollection AllRoom = new clsRoomCollection();
            String Error = AllRoom.ThisRoom.Valid(txtRoomNumber.Text, txtFloorNo.Text, txtDailyCharge.Text, chkAvailable.Checked, Convert.ToInt32(ddlStaffRole.SelectedValue));
            if (Error == "")
            {
                AllRoom.ThisRoom.RoomNumber = txtRoomNumber.Text;
                AllRoom.ThisRoom.FloorNo  =Convert.ToInt32( txtFloorNo.Text);
                AllRoom.ThisRoom.DailyCharge = Convert.ToDouble (txtDailyCharge.Text);
                AllRoom.ThisRoom.AvailableForBooking  = chkAvailable.Checked ;
                AllRoom.ThisRoom.RoomTypeId = Convert.ToInt32(ddlStaffRole.SelectedValue);
                AllRoom.Add();
            }
            else
            {
                lblError.Text = "There were problem with the data" + Error;
            }
        }
        void Update()
        {
            clsRoomCollection AllRoom = new clsRoomCollection();
            String Error = AllRoom.ThisRoom.Valid(txtRoomNumber.Text, txtFloorNo.Text, txtDailyCharge.Text, chkAvailable.Checked, Convert.ToInt32(ddlStaffRole.SelectedValue));
            if (Error == "")
            {
                AllRoom.ThisRoom.RoomId = RoomId;
                AllRoom.ThisRoom.RoomNumber = txtRoomNumber.Text;
                AllRoom.ThisRoom.FloorNo = Convert.ToInt32(txtFloorNo.Text);
                AllRoom.ThisRoom.DailyCharge = Convert.ToDouble(txtDailyCharge.Text);
                AllRoom.ThisRoom.AvailableForBooking = chkAvailable.Checked;
                AllRoom.ThisRoom.RoomTypeId = Convert.ToInt32(ddlStaffRole.SelectedValue);
                AllRoom.Update();
            }
            else
            {
                lblError.Text = "There were problem with the data" + Error;
            }
        }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultRoom.aspx");
    }
}