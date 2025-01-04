using MySql.Data.MySqlClient;
using System.Data;

namespace Gym_Management_System
{
    public partial class Searchmember : Form
    {
        private DataTable dt = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=smartfitness;username=root;password=!@delA2$");
        public Searchmember()
        {
            InitializeComponent();
        }
        private void populate()
        {
            try
            {
                con.Open();
                string queir = "SELECT * FROM membertbl";
                MySqlDataAdapter cmd = new MySqlDataAdapter(queir, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(cmd);
                var ds = new DataSet();
                cmd.Fill(ds);
                SearchMemberDGV.DataSource = ds.Tables[0];
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
        DataTable dataTable;
        private void MemberInfo_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            else
            {
                string searchValue = txtBoxSearch.Text.ToLower();
                bool valueFound = false;
                foreach (DataGridViewRow row in SearchMemberDGV.Rows)
                {
                    row.Selected = false;
                }


                foreach (DataGridViewRow row in SearchMemberDGV.Rows)
                {
                    if (row.Cells["MemberId"].Value != null && row.Cells["MemberId"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                        valueFound = true;
                        SearchMemberDGV.FirstDisplayedScrollingRowIndex = row.Index;
                        break;

                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SearchMemberDGV.SelectedRows.Count > 0)
            {
                // Get the MemberId of the selected row
                int memberId = Convert.ToInt32(SearchMemberDGV.SelectedRows[0].Cells["MemberId"].Value);
               
                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this member?", "Delete Member", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM membertbl WHERE MemberId = @MemberId";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@MemberId", memberId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member deleted successfully.");
                            
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("No member found with the provided MemberId.");
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
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


