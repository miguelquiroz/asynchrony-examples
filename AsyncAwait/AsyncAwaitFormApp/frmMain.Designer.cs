namespace BreakfastApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSyncTest_A = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cblbbreakfast = new System.Windows.Forms.CheckedListBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            // 
            // btnSyncTest_A
            // 
            this.btnSyncTest_A.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSyncTest_A.Location = new System.Drawing.Point(14, 395);
            this.btnSyncTest_A.Name = "btnSyncTest_A";
            this.btnSyncTest_A.Size = new System.Drawing.Size(193, 42);
            this.btnSyncTest_A.TabIndex = 0;
            this.btnSyncTest_A.Text = "make breakfast";
            this.btnSyncTest_A.UseVisualStyleBackColor = true;
            this.btnSyncTest_A.Click += new System.EventHandler(this.btnSyncTest_A_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ToDo List";
            // 
            // cblbbreakfast
            // 
            this.cblbbreakfast.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cblbbreakfast.FormattingEnabled = true;
            this.cblbbreakfast.Items.AddRange(new object[] {
            ""});
            this.cblbbreakfast.Location = new System.Drawing.Point(14, 62);
            this.cblbbreakfast.Name = "cblbbreakfast";
            this.cblbbreakfast.ScrollAlwaysVisible = true;
            this.cblbbreakfast.Size = new System.Drawing.Size(326, 301);
            this.cblbbreakfast.TabIndex = 2;
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.Location = new System.Drawing.Point(361, 62);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(497, 301);
            this.txtLog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(361, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log console";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(890, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(942, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1099, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.cblbbreakfast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSyncTest_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakfast App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Button btnSyncTest_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cblbbreakfast;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

