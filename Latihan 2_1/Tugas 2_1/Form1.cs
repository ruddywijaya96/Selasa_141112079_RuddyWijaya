using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int tgl = Convert.ToInt32(NumericUpDown1.Value);
            int bln = Convert.ToInt32(Januari.SelectedIndex) + 1;
            if (bln == 2 && tgl > 29)
                MessageBox.Show("Salah!");
            DateTime lbr = new DateTime(2016, bln, tgl);
            monthCalendar1.AddAnnuallyBoldedDate(lbr);
            monthCalendar1.SetDate(lbr);
            monthCalendar1.UpdateBoldedDates();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime tgl = monthCalendar1.SelectionRange.Start.Date;
            monthCalendar1.RemoveAnnuallyBoldedDate(tgl);
            monthCalendar1.UpdateBoldedDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Januari.SelectedIndex = 0;
            DateTime tglLahir = new DateTime(1996, 2, 2);
            DateTime weekend = new DateTime(2016, 1, 1);
            while (weekend.Year == 2016)
            {
                if (weekend.DayOfWeek == DayOfWeek.Saturday || weekend.DayOfWeek == DayOfWeek.Sunday)
                    monthCalendar1.AddBoldedDate(weekend);
                weekend = weekend.AddDays(1);
            }
            monthCalendar1.AddAnnuallyBoldedDate(tglLahir);
            monthCalendar1.UpdateBoldedDates();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
