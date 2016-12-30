using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdit edit = new FormEdit();
            edit.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegis regis = new formRegis();
            regis.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDelete delete = new FormDelete();
            delete.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListItem list = new FormListItem();
            list.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPenjualan jual = new FormPenjualan();
            jual.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPembelian beli = new FormPembelian();
            beli.Show();
        }
    }
}
