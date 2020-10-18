using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMS.All_User_Control
{
    public partial class GuestDetails : UserControl
    {
        function fn = new function();
        String query;
        public GuestDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                query = "select guest.gid, guest.gname, guest.gsurname, guest.gender, guest.phone, guest.birthdate, guest.idproof, guest.gaddress, guest.checkin, guest.checkoutdate, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from guest inner join rooms on guest.roomid = rooms.roomid";
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                query = "select guest.gid, guest.gname, guest.gsurname, guest.gender, guest.phone, guest.birthdate, guest.idproof, guest.gaddress, guest.checkin, guest.checkoutdate, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from guest inner join rooms on guest.roomid = rooms.roomid where checkoutdate is null";
                getRecord(query);
            }

            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "select guest.gid, guest.gname, guest.gsurname, guest.gender, guest.phone, guest.birthdate, guest.idproof, guest.gaddress, guest.checkin, guest.checkoutdate, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from guest inner join rooms on guest.roomid = rooms.roomid where checkoutdate is not null";
                getRecord(query);

            }

        }
        private void getRecord(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
