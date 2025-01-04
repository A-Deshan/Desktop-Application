using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace Gym_Management_System
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Input Username & password");
            }
            else
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=smartfitness;username=root;password=!@delA2$");
                con.Open();
                string query = "SELECT * FROM usertbl WHERE Username ='" + txtUname.Text + "'And Password = '" + txtPassword.Text + "'";
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, con);
                DataTable ds = new DataTable();
                cmd.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Homepage homepage = new Homepage();
                    homepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password Try again");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    


