using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {

        enum bulan { Januari = 0, Februari, Maret, April, Mei, Juni, Juli, Agustus, September, Oktober, November, Desember };

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(bulan));
            numericUpDown1.Maximum = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            numericUpDown1.Minimum = 1;
            DateTime awal = new DateTime(2016, 1, 1);
            DateTime akhir = new DateTime(2016, 12, 31);
            for (int i = 0; i < akhir.DayOfYear; i++)
            {
                if (awal.DayOfWeek.ToString() == "Saturday" || awal.DayOfWeek.ToString() == "Sunday")
                {
                    monthCalendar1.AddBoldedDate(awal);
                }
                awal = awal.AddDays(1);
            }

           
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tgl =Convert.ToInt32( numericUpDown1.Value);
            DateTime cek = new DateTime(DateTime.Today.Year, comboBox1.SelectedIndex+1, tgl);

            monthCalendar1.AddBoldedDate(cek);
            MessageBox.Show("Tanggal Libur Telah Ditambahkan");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime x = new DateTime(2016, comboBox1.SelectedIndex + 1, Convert.ToInt32(numericUpDown1.Value));
            if (x.DayOfWeek.ToString() != "Saturday" || x.DayOfWeek.ToString() != "Sunday" || x.Day != 23 || x.Month != 10)
            {
                monthCalendar1.RemoveBoldedDate(x);
                MessageBox.Show("Tanggal Libur Telah Dihapus");
                
            }
        }
    }
}
