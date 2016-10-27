<<<<<<< HEAD
﻿namespace Tugas_1_2
=======
﻿namespace Latihan_1_2
>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
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
<<<<<<< HEAD
            this.calender = new System.Windows.Forms.DateTimePicker();
            this.test = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.VScrollBar();
            this.min = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(216, 119);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(133, 20);
            this.calender.TabIndex = 17;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.Color.Black;
            this.test.Location = new System.Drawing.Point(239, 235);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(26, 37);
            this.test.TabIndex = 14;
            this.test.Text = "-";
            this.test.TextAlign = System.Drawing.ContentAlignment.TopCenter;
=======
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.calender = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(106, 101);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(33, 124);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(447, 101);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(31, 124);
            this.vScrollBar2.TabIndex = 3;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(166, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(298, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "MAX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(196, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "MIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(390, 119);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(23, 153);
            this.max.TabIndex = 11;
            this.max.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(143, 119);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(23, 153);
            this.min.TabIndex = 10;
            this.min.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
=======
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(327, 200);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maksimum";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.Color.Red;
            this.test.Location = new System.Drawing.Point(252, 304);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(40, 45);
            this.test.TabIndex = 6;
            this.test.Text = "-";
            this.test.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.Color.Silver;
            this.min.Location = new System.Drawing.Point(165, 247);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(23, 34);
            this.min.TabIndex = 7;
            this.min.Text = "-";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.ForeColor = System.Drawing.Color.Silver;
            this.max.Location = new System.Drawing.Point(369, 247);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(22, 34);
            this.max.TabIndex = 8;
            this.max.Text = "-";
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(212, 114);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(144, 20);
            this.calender.TabIndex = 9;
>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 439);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
=======
            this.ClientSize = new System.Drawing.Size(570, 553);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
            this.Name = "Form1";
            this.Text = "Framework Lanjutan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.DateTimePicker calender;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar max;
        private System.Windows.Forms.VScrollBar min;

=======
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.DateTimePicker calender;
>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
    }
}

