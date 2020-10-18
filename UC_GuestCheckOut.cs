using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

namespace HotelMS.All_User_Control
{
    public partial class UC_GuestCheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_GuestCheckOut()
        {
            InitializeComponent();
        }

        private void UC_GuestCheckOut_Load(object sender, EventArgs e)
        {
            query = "select guest.gid, guest.gname, guest.gsurname, guest.gender, guest.phone, guest.birthdate, guest.idproof, guest.gaddress, guest.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from guest inner join rooms on guest.roomid = rooms.roomid where checkedout = 'NO' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtGName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGSurname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtRoomNo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select guest.gid, guest.gname, guest.gsurname, guest.gender, guest.phone, guest.birthdate, guest.idproof, guest.gaddress, guest.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from guest inner join rooms on guest.roomid = rooms.roomid where gname like '"+txtName.Text+ "%'and gsurname like '" + txtSurname.Text + "%' and checkedout = 'NO' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtGName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            query = "select guest.gid, guest.gname, guest.gsurname, guest.gender, guest.phone, guest.birthdate, guest.idproof, guest.gaddress, guest.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from guest inner join rooms on guest.roomid = rooms.roomid where gsurname like '" + txtSurname.Text + "%' and checkedout = 'NO' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtGName.Text != "" && txtGSurname.Text != "")
            {
                if(MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning )==DialogResult.OK)
                {
                    String gdate = txtCheckOutDate.Text;
                    query = "update guest set checkedout = 'YES', checkoutdate='" + gdate + "' where gid = " + id + " update rooms set booked ='NO' where roomNo = '" + txtRoomNo.Text + "' ";
                    fn.setData(query, "Checked Out Successfully.");
                    UC_GuestCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No guest selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtGName.Clear();
            txtSurname.Clear();
            txtGSurname.Clear();
            txtRoomNo.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_GuestCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
