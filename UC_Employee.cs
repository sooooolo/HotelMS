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
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(empid) from employees";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                LabelToSet.Text = (num + 1).ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtGender.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" &&  txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                String surname = txtSurname.Text;
                String gender = txtGender.Text;
                Int64 phone = Int64.Parse(txtPhone.Text);
                String email = txtAddress.Text;
                String username = txtUsername.Text;
                String password = txtPassword.Text;

                query = "insert into employees (empname,empsurname,gender,phone,email,username,pass) values ('" + name + "','" + surname + "','" + gender + "'," + phone + ",'" + email + "','" + username + "','" + password + "')";
                fn.setData(query, "Employee Registered.");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            

        }

        private void tabEmpDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabEmpDetails.SelectedIndex==1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if(tabEmpDetails.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employees";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdSearch.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    query = "delete from employee where empid=" + txtIdSearch.Text + "";
                fn.setData(query, "Record deleted.");
                tabEmpDetails_SelectedIndexChanged(this, null);
            }
           

        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
