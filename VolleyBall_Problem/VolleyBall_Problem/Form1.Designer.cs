namespace VolleyBall_Problem
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
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtHasil
            // 
            this.TxtHasil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtHasil.ForeColor = System.Drawing.Color.Black;
            this.TxtHasil.Location = new System.Drawing.Point(99, 166);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.Size = new System.Drawing.Size(100, 20);
            this.TxtHasil.TabIndex = 15;
            this.TxtHasil.TextChanged += new System.EventHandler(this.rslt2_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(157, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "KELUAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtnHitung
            // 
            this.BtnHitung.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnHitung.ForeColor = System.Drawing.Color.Black;
            this.BtnHitung.Location = new System.Drawing.Point(110, 121);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(75, 23);
            this.BtnHitung.TabIndex = 13;
            this.BtnHitung.Text = "Hasil";
            this.BtnHitung.UseVisualStyleBackColor = false;
            this.BtnHitung.Click += new System.EventHandler(this.Btnresult_Click);
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(99, 84);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(120, 20);
            this.Txt2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Skor B";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(99, 45);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(120, 20);
            this.Txt1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Skor A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valley Ball Problem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnHitung);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHasil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnHitung;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

