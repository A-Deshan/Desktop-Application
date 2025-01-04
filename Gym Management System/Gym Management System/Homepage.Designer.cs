namespace Gym_Management_System
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            menuStrip1 = new MenuStrip();
            memberInfoToolStripMenuItem = new ToolStripMenuItem();
            addEquipmentToolStripMenuItem = new ToolStripMenuItem();
            financialDataToolStripMenuItem = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { memberInfoToolStripMenuItem, addEquipmentToolStripMenuItem, financialDataToolStripMenuItem, manageUsersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(498, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // memberInfoToolStripMenuItem
            // 
            memberInfoToolStripMenuItem.BackColor = Color.Teal;
            memberInfoToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            memberInfoToolStripMenuItem.Image = (Image)resources.GetObject("memberInfoToolStripMenuItem.Image");
            memberInfoToolStripMenuItem.Name = "memberInfoToolStripMenuItem";
            memberInfoToolStripMenuItem.Size = new Size(115, 21);
            memberInfoToolStripMenuItem.Text = "Member Info";
            memberInfoToolStripMenuItem.Click += memberInfoToolStripMenuItem_Click;
            // 
            // addEquipmentToolStripMenuItem
            // 
            addEquipmentToolStripMenuItem.BackColor = SystemColors.ControlLight;
            addEquipmentToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addEquipmentToolStripMenuItem.Image = (Image)resources.GetObject("addEquipmentToolStripMenuItem.Image");
            addEquipmentToolStripMenuItem.Name = "addEquipmentToolStripMenuItem";
            addEquipmentToolStripMenuItem.Size = new Size(131, 21);
            addEquipmentToolStripMenuItem.Text = "Search member";
            addEquipmentToolStripMenuItem.Click += addEquipmentToolStripMenuItem_Click;
            // 
            // financialDataToolStripMenuItem
            // 
            financialDataToolStripMenuItem.BackColor = Color.Teal;
            financialDataToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            financialDataToolStripMenuItem.Image = (Image)resources.GetObject("financialDataToolStripMenuItem.Image");
            financialDataToolStripMenuItem.Name = "financialDataToolStripMenuItem";
            financialDataToolStripMenuItem.Size = new Size(120, 21);
            financialDataToolStripMenuItem.Text = "Financial Data";
            financialDataToolStripMenuItem.Click += financialDataToolStripMenuItem_Click;
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.BackColor = SystemColors.ControlLight;
            manageUsersToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageUsersToolStripMenuItem.Image = (Image)resources.GetObject("manageUsersToolStripMenuItem.Image");
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(122, 21);
            manageUsersToolStripMenuItem.Text = "Manage Users";
            manageUsersToolStripMenuItem.Click += manageUsersToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(423, 366);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 1;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(498, 399);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem memberInfoToolStripMenuItem;
        private ToolStripMenuItem addEquipmentToolStripMenuItem;
        private ToolStripMenuItem financialDataToolStripMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private Button button1;
    }
}