using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace Tugas_1_2
=======
namespace Latihan_1_2
>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

=======
>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
        private void Form1_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (min.Value < max.Value)
            {
                min.Text = min.Value.ToString();
                max.Text = max.Value.ToString();
            }
            else
            {
                min.Text = max.Value.ToString();
                max.Text = min.Value.ToString();
            }

            DateTime tmp = new DateTime();
            tmp = new DateTime(DateTime.Today.Year + Math.Abs(min.Value - max.Value), DateTime.Today.Month, DateTime.Today.Day);
            calender.MinDate = DateTime.Today.Date;
            calender.MaxDate = tmp;

            test.Text = Convert.ToString(DateTime.Today.Year + Math.Abs(min.Value - max.Value));
=======
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value < vScrollBar2.Value)
            {
                min.Text = vScrollBar1.Value.ToString();
                max.Text = vScrollBar2.Value.ToString();
            }
            else
            {
                min.Text = vScrollBar2.Value.ToString();
                max.Text = vScrollBar1.Value.ToString();
            }

            DateTime tmp = new DateTime();
            tmp = new DateTime(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value), DateTime.Today.Month, DateTime.Today.Day);
            calender.MinDate = DateTime.Today.Date;
            calender.MaxDate = tmp;

            test.Text = Convert.ToString(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
<<<<<<< HEAD
            if (min.Value > max.Value)
            {
                min.Text = min.Value.ToString();
                max.Text = max.Value.ToString();
            }
            else
            {
                min.Text = max.Value.ToString();
                max.Text = min.Value.ToString();
            }

            DateTime tmp = new DateTime();
            tmp = new DateTime(DateTime.Today.Year + Math.Abs(min.Value - max.Value), DateTime.Today.Month, DateTime.Today.Day);
            calender.MinDate = DateTime.Today.Date;
            calender.MaxDate = tmp;

            test.Text = Convert.ToString(DateTime.Today.Year + Math.Abs(min.Value - max.Value));
        }

        private void label1_Click(object sender, EventArgs e)
        {

=======
            if (vScrollBar1.Value > vScrollBar2.Value)
            {
                min.Text = vScrollBar1.Value.ToString();
                max.Text = vScrollBar2.Value.ToString();
            }
            else
            {
                min.Text = vScrollBar2.Value.ToString();
                max.Text = vScrollBar1.Value.ToString();
            }

            DateTime tmp = new DateTime();
            tmp = new DateTime(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value), DateTime.Today.Month, DateTime.Today.Day);
            calender.MinDate = DateTime.Today.Date;
            calender.MaxDate = tmp;

            test.Text = Convert.ToString(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value));
>>>>>>> 07a3286f7de6a7ae71a65ca9fbe394027c46ea96
        }
    }
}
