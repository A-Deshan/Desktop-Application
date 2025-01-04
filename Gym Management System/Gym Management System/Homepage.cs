using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void memberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberInfo member = new MemberInfo();
            member.Show();
            this.Hide();
        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchmember searchM = new Searchmember();
            searchM.Show();
            this.Hide();
        }

        private void financialDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialData financialD = new FinancialData();
            financialD.Show();
            this.Hide();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manageusers manageU = new Manageusers();
            manageU.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginform loginF = new Loginform();
            loginF.Show();
            this.Hide();
        }
    }
}
