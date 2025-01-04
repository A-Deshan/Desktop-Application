using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class FinancialData : Form
    {
        // Initialize the MySQL connection
        MySqlConnection con = new MySqlConnection("server=localhost;database=smartfitness;username=root;password=!@delA2$");

        public FinancialData()
        {
            InitializeComponent();
        }

        // Navigate to Homepage
        private void button1_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();

        }
        private void btnPsearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;database=smartfitness;username=root;password=!@delA2$"))
                {
                    con.Open();
                    string query = "SELECT * FROM membertbl WHERE MemberId = @MemberId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberId", Psearch.Text);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable ds = new DataTable();
                            adapter.Fill(ds);
                            if (ds.Rows.Count > 0)
                            {
                                DataRow row = ds.Rows[0];
                                Pid.Text = row["MemberId"].ToString();
                                Pname.Text = row["Name"].ToString();

                                MessageBox.Show("Search Done.", "Search Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Check Member ID.", "Search Member info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define fonts
            Font titleFont = new Font("Times New Roman", 24, FontStyle.Bold);
            Font subTitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font contentFont = new Font("Segoe UI", 10);
            Font footerFont = new Font("Segoe UI", 10, FontStyle.Italic);

            // Define brush
            Brush brush = Brushes.Black;

            // Function to calculate centered position
            float CenterText(string text, Font font, int pageWidth)
            {
                float textWidth = e.Graphics.MeasureString(text, font).Width;
                return (pageWidth - textWidth) / 2;
            }

            int pageWidth = e.PageBounds.Width;

            // Draw header
            e.Graphics.DrawLine(Pens.Black, new Point(50, 20), new Point(pageWidth - 50, 20));
            e.Graphics.DrawString("SMART FITNESS GYMNASIUM", titleFont, brush, new PointF(CenterText("SMART FITNESS GYMNASIUM", titleFont, pageWidth), 40));
            e.Graphics.DrawString("NO.24/A Madapatha road, Piliyandala", contentFont, brush, new PointF(CenterText("NO:24/A Madapatha road, Piliyandala", contentFont, pageWidth), 80));
            e.Graphics.DrawString("COLOMBO, SRI LANKA", contentFont, brush, new PointF(CenterText("COLOMBO, SRI LANKA", contentFont, pageWidth), 100));
            e.Graphics.DrawString("TEL: +94 112 256 332", contentFont, brush, new PointF(CenterText("TEL: +94 112 256 332", contentFont, pageWidth), 120));
            e.Graphics.DrawString("INFO: @SmartFitness.com", contentFont, brush, new PointF(CenterText("INFO: @SmartFitness.com", contentFont, pageWidth), 140));
            e.Graphics.DrawLine(Pens.Black, new Point(50, 160), new Point(pageWidth - 50, 160));

            // Draw member details
            e.Graphics.DrawString("MEMBER DETAILS", subTitleFont, brush, new PointF(CenterText("MEMBER DETAILS", subTitleFont, pageWidth), 180));
            e.Graphics.DrawLine(Pens.Black, new Point(50, 210), new Point(pageWidth - 50, 210));

            e.Graphics.DrawString("Member Id:", contentFont, brush, new PointF(150, 230));
            e.Graphics.DrawString(Pid.Text, contentFont, brush, new PointF(300, 230));

            e.Graphics.DrawString("Name of the member:", contentFont, brush, new PointF(150, 260));
            e.Graphics.DrawString(Pname.Text, contentFont, brush, new PointF(300, 260));

            e.Graphics.DrawString("Payment month/s:", contentFont, brush, new PointF(150, 290));
            e.Graphics.DrawString(Paymonth.Text, contentFont, brush, new PointF(300, 290));

            e.Graphics.DrawLine(Pens.Black, new Point(50, 320), new Point(pageWidth - 50, 320));

            // Draw payment details
            e.Graphics.DrawString("PAYMENT DETAILS", subTitleFont, brush, new PointF(CenterText("PAYMENT DETAILS", subTitleFont, pageWidth), 340));
            e.Graphics.DrawLine(Pens.Black, new Point(50, 370), new Point(pageWidth - 50, 370));

            e.Graphics.DrawString("Full payment:", contentFont, brush, new PointF(150, 390));
            e.Graphics.DrawString(Pamount.Text, contentFont, brush, new PointF(300, 390));

            e.Graphics.DrawLine(Pens.Black, new Point(50, 450), new Point(pageWidth - 50, 450));

            // Draw footer
            e.Graphics.DrawString(".....THANK YOU FOR JOINING WITH US....", footerFont, brush, new PointF(CenterText(".....THANK YOU FOR JOINING WITH US....", footerFont, pageWidth), 470));
            e.Graphics.DrawLine(Pens.Black, new Point(50, 490), new Point(pageWidth - 50, 490));

            // Add additional footer information
            e.Graphics.DrawString("Printed on: " + DateTime.Now.ToString("dd/MM/yyyy"), footerFont, brush, new PointF(CenterText("Printed on: " + DateTime.Now.ToString("dd/MM/yyyy"), footerFont, pageWidth), 510));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;database=smartfitness;username=root;password=!@delA2$"))
                {
                    con.Open();
                    string query = "INSERT INTO paymenttbl (MemberId, Name, PaymentMonth, PaymentAmount) VALUES (@MemberId, @Name, @PaymentMonth, @PaymentAmount)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberId", Pid.Text);
                        cmd.Parameters.AddWithValue("@Name", Pname.Text);
                        cmd.Parameters.AddWithValue("@PaymentMonth", Paymonth.Text);
                        cmd.Parameters.AddWithValue("@PaymentAmount", Pamount.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment details saved successfully.", "Save Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Vsearch.Text))
            {
                MessageBox.Show("Please enter a Member Id.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PaymentsDGV.DataSource = null;

            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;database=smartfitness;username=root;password=!@delA2$"))
                {
                    con.Open();
                    string query = "SELECT MemberId, PaymentMonth FROM paymenttbl WHERE MemberId = @MemberId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberId", Vsearch.Text);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            PaymentsDGV.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}








