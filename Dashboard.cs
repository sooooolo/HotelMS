using HotelMS.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            uC_Employee1.Visible = false;
            guestDetails1.Visible = false;
            btnAddRoom.PerformClick(); 
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guestDetails1.Visible = true;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            uC_GuestCheckOut1.Visible = false;
            guestDetails1.BringToFront();
            MovingPanel.Left = btnGuestDetails.Left;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left;
            uC_AddRoom1.Visible = true;
            uC_CustomerRegistration1.Visible = false;
            uC_AddRoom1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnEmployee.Left;

            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
            guestDetails1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            uC_GuestCheckOut1.Visible = false;
        }

        private void btnGuestReg_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnGuestReg.Left;
            uC_CustomerRegistration1.Visible = true;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.BringToFront();
        }

        private void MovingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCheckOut.Left;
            uC_GuestCheckOut1.BringToFront();
            uC_GuestCheckOut1.Visible = true;
            uC_CustomerRegistration1.Visible = false;
            uC_AddRoom1.Visible = false;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
