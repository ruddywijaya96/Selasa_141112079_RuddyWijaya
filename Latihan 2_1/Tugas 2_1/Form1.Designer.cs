namespace Tugas_2_1
{
    partial class Form1
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Januari = new System.Windows.Forms.DomainUpDown();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(433, 217);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "Hapus";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(433, 103);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Tambah";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Januari
            // 
            this.Januari.Items.Add("Januari");
            this.Januari.Items.Add("Februari");
            this.Januari.Items.Add("Maret");
            this.Januari.Items.Add("April");
            this.Januari.Items.Add("Mei");
            this.Januari.Items.Add("Juni");
            this.Januari.Items.Add("Juli");
            this.Januari.Items.Add("Agustus");
            this.Januari.Items.Add("September");
            this.Januari.Items.Add("Oktober");
            this.Januari.Items.Add("November");
            this.Januari.Items.Add("Desember");
            this.Januari.Location = new System.Drawing.Point(301, 60);
            this.Januari.Name = "Januari";
            this.Januari.Size = new System.Drawing.Size(120, 20);
            this.Januari.TabIndex = 6;
            this.Januari.Text = "Januari";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(147, 61);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(96, 20);
            this.NumericUpDown1.TabIndex = 5;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(147, 93);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 311);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Januari);
            this.Controls.Add(this.NumericUpDown1);
            this.Name = "Form1";
            this.Text = "Framework Lanjutan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DomainUpDown Januari;
        internal System.Windows.Forms.NumericUpDown NumericUpDown1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

