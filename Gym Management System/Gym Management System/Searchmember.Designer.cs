namespace Gym_Management_System
{
    partial class Searchmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searchmember));
            btnBack = new Button();
            label1 = new Label();
            txtBoxSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            SearchMemberDGV = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SearchMemberDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Highlight;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(542, 419);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 33);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(199, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 21);
            label1.TabIndex = 1;
            label1.Text = "SMART FITNESS GYMNASIUM";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(284, 85);
            txtBoxSearch.Multiline = true;
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(143, 23);
            txtBoxSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(449, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(381, 419);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 33);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // SearchMemberDGV
            // 
            SearchMemberDGV.BackgroundColor = SystemColors.ControlLight;
            SearchMemberDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchMemberDGV.GridColor = SystemColors.MenuHighlight;
            SearchMemberDGV.Location = new Point(5, 127);
            SearchMemberDGV.Name = "SearchMemberDGV";
            SearchMemberDGV.Size = new Size(678, 266);
            SearchMemberDGV.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.NavajoWhite;
            label2.Font = new Font("Poor Richard", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(284, 43);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 15;
            label2.Text = "MEMBER LIST";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(665, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 21);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Searchmember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(695, 479);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(SearchMemberDGV);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtBoxSearch);
            Controls.Add(label1);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Searchmember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Searchmember";
            Load += MemberInfo_Load;
            ((System.ComponentModel.ISupportInitialize)SearchMemberDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox txtBoxSearch;
        private Button btnSearch;
        private Button btnDelete;
        private DataGridView SearchMemberDGV;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private PictureBox pictureBox1;
    }
}