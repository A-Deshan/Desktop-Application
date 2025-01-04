using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Gym_Management_System
{
    public partial class MemberInfo : Form
    {
        public MemberInfo()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=smartfitness;username=root;password=!@delA2$");
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "" || txtBoxAge.Text == "" || txtBoxHeight.Text == "" || txtBoxWeight.Text == "" || Joindate.Text == "" || txtBoxPhoneNo.Text == "" || txtBoxFees.Text == "")
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Membertbl values('" + txtBoxMemberId.Text + "','" + txtBoxName.Text + "','" + comboBoxGender.Text + "','" + txtBoxAge.Text + "','" + txtBoxHeight.Text + "', '" + txtBoxWeight.Text + "','" + Joindate.Text + "','" + txtBoxPhoneNo.Text + "', '" + comboBoxTiming.Text + "','" + txtBoxFees.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    txtBoxMemberId.Text = "";
                    txtBoxName.Text = "";
                    comboBoxGender.Text = "";
                    txtBoxAge.Text = "";
                    txtBoxHeight.Text = "";
                    txtBoxWeight.Text = "";
                    Joindate.Text = "";
                    txtBoxPhoneNo.Text = "";
                    comboBoxTiming.Text = "";
                    txtBoxFees.Text = "";
                    con.Close();
                    MessageBox.Show("Registration Successful");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            txtBoxMemberId.Text = "";
            txtBoxName.Text = "";
            comboBoxGender.Text = "";
            txtBoxAge.Text = "";
            txtBoxHeight.Text = "";
            txtBoxWeight.Text = "";
            Joindate.Text = "";
            txtBoxPhoneNo.Text = "";
            comboBoxTiming.Text = "";
            txtBoxFees.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
