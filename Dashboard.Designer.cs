namespace HotelMS
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuestDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuestReg = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Employee1 = new HotelMS.All_User_Control.UC_Employee();
            this.guestDetails1 = new HotelMS.All_User_Control.GuestDetails();
            this.uC_GuestCheckOut1 = new HotelMS.All_User_Control.UC_GuestCheckOut();
            this.uC_CustomerRegistration1 = new HotelMS.All_User_Control.UC_CustomerRegistration();
            this.uC_AddRoom1 = new HotelMS.All_User_Control.UC_AddRoom();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnGuestDetails);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnGuestReg);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(89, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1680, 153);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.White;
            this.MovingPanel.Location = new System.Drawing.Point(64, 100);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(236, 5);
            this.MovingPanel.TabIndex = 0;
            this.MovingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MovingPanel_Paint);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployee.Location = new System.Drawing.Point(1325, 20);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(236, 85);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnGuestDetails
            // 
            this.btnGuestDetails.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuestDetails.BorderRadius = 26;
            this.btnGuestDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGuestDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGuestDetails.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnGuestDetails.CheckedState.Parent = this.btnGuestDetails;
            this.btnGuestDetails.CustomImages.Parent = this.btnGuestDetails;
            this.btnGuestDetails.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuestDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuestDetails.ForeColor = System.Drawing.Color.White;
            this.btnGuestDetails.HoverState.Parent = this.btnGuestDetails;
            this.btnGuestDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnGuestDetails.Image")));
            this.btnGuestDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuestDetails.ImageSize = new System.Drawing.Size(35, 35);
            this.btnGuestDetails.Location = new System.Drawing.Point(1012, 20);
            this.btnGuestDetails.Name = "btnGuestDetails";
            this.btnGuestDetails.ShadowDecoration.Parent = this.btnGuestDetails;
            this.btnGuestDetails.Size = new System.Drawing.Size(236, 85);
            this.btnGuestDetails.TabIndex = 3;
            this.btnGuestDetails.Text = "Guest Info";
            this.btnGuestDetails.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCheckOut.BorderRadius = 26;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCheckOut.Location = new System.Drawing.Point(658, 20);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(236, 85);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnGuestReg
            // 
            this.btnGuestReg.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuestReg.BorderRadius = 26;
            this.btnGuestReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGuestReg.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGuestReg.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnGuestReg.CheckedState.Parent = this.btnGuestReg;
            this.btnGuestReg.CustomImages.Parent = this.btnGuestReg;
            this.btnGuestReg.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuestReg.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuestReg.ForeColor = System.Drawing.Color.White;
            this.btnGuestReg.HoverState.Parent = this.btnGuestReg;
            this.btnGuestReg.Image = ((System.Drawing.Image)(resources.GetObject("btnGuestReg.Image")));
            this.btnGuestReg.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGuestReg.Location = new System.Drawing.Point(346, 20);
            this.btnGuestReg.Name = "btnGuestReg";
            this.btnGuestReg.ShadowDecoration.Parent = this.btnGuestReg;
            this.btnGuestReg.Size = new System.Drawing.Size(236, 85);
            this.btnGuestReg.TabIndex = 1;
            this.btnGuestReg.Text = "Guest Registration";
            this.btnGuestReg.Click += new System.EventHandler(this.btnGuestReg_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddRoom.BorderRadius = 26;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddRoom.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddRoom.Location = new System.Drawing.Point(64, 20);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(236, 85);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.guestDetails1);
            this.panel2.Controls.Add(this.uC_GuestCheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRegistration1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(86, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1677, 595);
            this.panel2.TabIndex = 1;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(3, 0);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1752, 549);
            this.uC_Employee1.TabIndex = 5;
            // 
            // guestDetails1
            // 
            this.guestDetails1.BackColor = System.Drawing.Color.White;
            this.guestDetails1.Location = new System.Drawing.Point(3, 0);
            this.guestDetails1.Name = "guestDetails1";
            this.guestDetails1.Size = new System.Drawing.Size(1752, 549);
            this.guestDetails1.TabIndex = 2;
            // 
            // uC_GuestCheckOut1
            // 
            this.uC_GuestCheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_GuestCheckOut1.Location = new System.Drawing.Point(3, 3);
            this.uC_GuestCheckOut1.Name = "uC_GuestCheckOut1";
            this.uC_GuestCheckOut1.Size = new System.Drawing.Size(1752, 549);
            this.uC_GuestCheckOut1.TabIndex = 0;
            // 
            // uC_CustomerRegistration1
            // 
            this.uC_CustomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegistration1.Location = new System.Drawing.Point(3, 0);
            this.uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            this.uC_CustomerRegistration1.Size = new System.Drawing.Size(1752, 549);
            this.uC_CustomerRegistration1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(3, 0);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1752, 549);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.IndicateFocus = true;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.IndicateFocus = true;
            this.btnMinimize.Location = new System.Drawing.Point(12, 51);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseTransparentBackground = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1841, 878);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnGuestDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnGuestReg;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private System.Windows.Forms.Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private All_User_Control.UC_CustomerRegistration uC_CustomerRegistration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_GuestCheckOut uC_GuestCheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.GuestDetails guestDetails1;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}