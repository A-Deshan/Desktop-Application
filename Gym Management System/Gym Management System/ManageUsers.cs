using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Manageusers : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=smartfitness;username=root;password=!@delA2$");

        public Manageusers()
        {
            InitializeComponent();
        }
        private void populate()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM usertbl";
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, con);
                DataTable ds = new DataTable();
                cmd.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    ManageUserDGV.DataSource = ds;
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Manageusers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxUId.Text == "" || txtBoxUname.Text == "" || txtBoxUPassword.Text == "" || txtBoxUPhoneNo.Text == "")
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("insert into usertbl values('" + txtBoxUId.Text + "', '" + txtBoxUname.Text + "', '" + txtBoxUPassword.Text + "','" + txtBoxUPhoneNo.Text + "')", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User Successfully Added");
                con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ManageUserDGV.SelectedRows.Count > 0)
            {
                // Get the UserId of the selected row
                int userId = Convert.ToInt32(ManageUserDGV.SelectedRows[0].Cells["UserId"].Value);

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM usertbl WHERE UserId = @UserId";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully.");
                        populate();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void ManageUserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxUId.Text =
            ManageUserDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtBoxUname.Text =
            ManageUserDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxUPassword.Text =
            ManageUserDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtBoxUPhoneNo.Text =
            ManageUserDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

