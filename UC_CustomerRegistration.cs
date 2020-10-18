using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelMS.All_User_Control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void setCombobox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while(sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear( );
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType='" + txtRoom.Text + "' and booked = 'NO' ";
            setCombobox(query, txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();

        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo ='" + txtRoomNo.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString() ;
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }


        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if(txtName.Text != ""&& txtSurname.Text != "" && txtGender.Text != "" && txtPhone.Text != "" && txtBirthDate.Text != "" && txtIdProof.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                String surname = txtSurname.Text;
                String gender = txtGender.Text;
                Int64 phone = Int64.Parse(txtPhone.Text);
                String bd = txtBirthDate.Text;
                String idProof = txtIdProof.Text;
                String address = txtAddress.Text;
                String checkIn = txtCheckIn.Text;

                query = "Insert into guest (gname, gsurname, gender, phone, birthdate, idproof, gaddress, checkin, roomid) values ('" + name+ "','" + surname + "','" + gender + "','" + phone + "','" + bd + "','" + idProof + "','" + address + "','" + checkIn + "'," + rid + ") update rooms set booked = 'YES' where roomNo = '" + txtRoomNo.Text + "'";
                fn.setData(query, "Room number " + txtRoomNo.Text + "Allocation Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Please, fill all the fields.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtBirthDate.ResetText();
            txtIdProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();

        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
