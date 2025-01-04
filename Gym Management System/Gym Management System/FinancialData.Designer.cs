namespace Gym_Management_System
{
    partial class FinancialData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialData));
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Pid = new TextBox();
            Pname = new TextBox();
            Pamount = new TextBox();
            Psearch = new TextBox();
            btnPsearch = new Button();
            Paymonth = new TextBox();
            btnSave = new Button();
            btnPrint = new Button();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            panel1 = new Panel();
            PaymentsDGV = new DataGridView();
            btnPay = new Button();
            Vsearch = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Highlight;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(306, 417);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
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
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(152, 18);
            label1.Name = "label1";
            label1.Size = new Size(284, 21);
            label1.TabIndex = 1;
            label1.Text = "SMART FITNESS GYMNASIUM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.NavajoWhite;
            label2.Font = new Font("Bell MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 50);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 2;
            label2.Text = "Financial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(15, 14);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "MemberId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 86);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(186, 14);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 5;
            label5.Text = "Payment Month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(186, 86);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 6;
            label6.Text = "Payment Amount";
            // 
            // Pid
            // 
            Pid.Location = new Point(15, 46);
            Pid.Name = "Pid";
            Pid.Size = new Size(100, 23);
            Pid.TabIndex = 7;
            // 
            // Pname
            // 
            Pname.Location = new Point(15, 117);
            Pname.Name = "Pname";
            Pname.Size = new Size(100, 23);
            Pname.TabIndex = 8;
            // 
            // Pamount
            // 
            Pamount.Location = new Point(186, 117);
            Pamount.Name = "Pamount";
            Pamount.Size = new Size(100, 23);
            Pamount.TabIndex = 10;
            // 
            // Psearch
            // 
            Psearch.Location = new Point(48, 108);
            Psearch.Name = "Psearch";
            Psearch.Size = new Size(100, 23);
            Psearch.TabIndex = 11;
            // 
            // btnPsearch
            // 
            btnPsearch.BackColor = SystemColors.Highlight;
            btnPsearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPsearch.ForeColor = SystemColors.ActiveCaptionText;
            btnPsearch.Location = new Point(166, 108);
            btnPsearch.Name = "btnPsearch";
            btnPsearch.Size = new Size(75, 23);
            btnPsearch.TabIndex = 12;
            btnPsearch.Text = "Search";
            btnPsearch.UseVisualStyleBackColor = false;
            btnPsearch.Click += btnPsearch_Click;
            // 
            // Paymonth
            // 
            Paymonth.Location = new Point(186, 46);
            Paymonth.Name = "Paymonth";
            Paymonth.Size = new Size(101, 23);
            Paymonth.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(164, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 26);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.Highlight;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = SystemColors.InactiveCaptionText;
            btnPrint.Location = new Point(60, 176);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(65, 23);
            btnPrint.TabIndex = 18;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog1";
            printPreviewDialog.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Pid);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(Pname);
            panel1.Controls.Add(Paymonth);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Pamount);
            panel1.Location = new Point(12, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 244);
            panel1.TabIndex = 20;
            // 
            // PaymentsDGV
            // 
            PaymentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentsDGV.Location = new Point(403, 142);
            PaymentsDGV.Name = "PaymentsDGV";
            PaymentsDGV.Size = new Size(238, 264);
            PaymentsDGV.TabIndex = 21;
            // 
            // btnPay
            // 
            btnPay.BackColor = SystemColors.MenuHighlight;
            btnPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(522, 108);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(109, 23);
            btnPay.TabIndex = 22;
            btnPay.Text = "View Payments";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // Vsearch
            // 
            Vsearch.Location = new Point(403, 109);
            Vsearch.Name = "Vsearch";
            Vsearch.Size = new Size(100, 23);
            Vsearch.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(628, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 16);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FinancialData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(660, 443);
            Controls.Add(pictureBox1);
            Controls.Add(Vsearch);
            Controls.Add(btnPay);
            Controls.Add(PaymentsDGV);
            Controls.Add(panel1);
            Controls.Add(btnPsearch);
            Controls.Add(Psearch);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FinancialData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinancialData";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Pid;
        private TextBox Pname;
        private TextBox Pamount;
        private TextBox Psearch;
        private Button btnPsearch;
        private MonthCalendar Pmonth;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox Paymonth;
        private Button btnSave;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private Panel panel1;
        private DataGridView PaymentsDGV;
        private Button btnPay;
        private TextBox Vsearch;
        private PictureBox pictureBox1;
    }
}