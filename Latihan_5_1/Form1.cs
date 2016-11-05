using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            foreach (FontFamily font in FontFamily.Families)
            {
                combofont.Items.Add(font.Name.ToString());
            }
            for (int i = 8; i <= 72; i += 2)
            {
                combosize.Items.Add(i);
            }

            foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
            {
                combocolor.Items.Add(kc);
            }
            foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
            {
                comboback.Items.Add(kc);
            }
            combosize.SelectedIndex = 2;
            combofont.Text = "Times New Roman";
            combocolor.Text = "Black";
            comboback.Text = "White";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Font new1, old;
            old = richTextBox1.SelectionFont;
            if (old.Bold)
            {
                new1 = new Font(old, old.Style & ~FontStyle.Bold);
                toolbold.Checked = false;
            }
            else
            {
                new1 = new Font(old, old.Style | FontStyle.Bold);
                toolbold.Checked = true;
            }
            richTextBox1.SelectionFont = new1;
        }

        private void toolitalic_Click(object sender, EventArgs e)
        {
            Font new1, old;
            old = richTextBox1.SelectionFont;
            if (old.Italic)
            {
                new1 = new Font(old, old.Style & ~FontStyle.Italic);
                toolitalic.Checked = false;
            }
            else
            {
                new1 = new Font(old, old.Style | FontStyle.Italic);
                toolitalic.Checked = true;
            }
            richTextBox1.SelectionFont = new1;
        }

        private void toolunder_Click(object sender, EventArgs e)
        {
            Font new1, old;
            old = richTextBox1.SelectionFont;
            if (old.Underline)
            {
                new1 = new Font(old, old.Style & ~FontStyle.Underline);
                toolunder.Checked = false;
            }
            else
            {
                new1 = new Font(old, old.Style | FontStyle.Underline);
                toolunder.Checked = true;
            }
            richTextBox1.SelectionFont = new1;
        }

      

      

        OpenFileDialog ofd = new OpenFileDialog();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Rich Text Box(*.rtf)|*.rtf";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String text = ofd.FileName;
                richTextBox1.Text = File.ReadAllText(text);
            }
        }

        SaveFileDialog sfd = new SaveFileDialog();

        private void savetool_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Rich Text Box(*.rtf)|*.rtf";
            sfd.FileName = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }

        private void exittool_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                if (MessageBox.Show("File Anda Belum Disimpan!! Apakah anda ingin keluar ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sfd.Filter = "Rich Text Box(*.rtf)|*.rtf";
                    sfd.FileName = "";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, richTextBox1.Text);
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void newtool_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Modified)
            {
                richTextBox1.Clear();
            }
            else
            {
                if (MessageBox.Show("File Anda Belum Disimpan!! Ingin disimpan ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sfd.Filter = "Rich Text Box(*.rtf)|*.rtf";
                    sfd.FileName = "";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, richTextBox1.Text);
                    }
                }
                richTextBox1.Clear();
            }
        }

      

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void combosize_Click(object sender, EventArgs e)
        {
        }

        private void combofont_Click(object sender, EventArgs e)
        {
           
        }

        private void combocolor_Click(object sender, EventArgs e)
        {

        }



        private void comboback_Click(object sender, EventArgs e)
        {

        }

        private void combofont_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Font = new Font(combofont.SelectedItem.ToString(), richTextBox1.Font.Size);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(combofont.SelectedItem.ToString(), richTextBox1.Font.Size);

            }
        }

        private void comboback_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.FromName(comboback.Text);

        }

        private void combosize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(combosize.SelectedItem.ToString()));

        }

        private void combocolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromName(combocolor.Text);

        }
        edit editor;
        Form1 form;
        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editor == null || !editor.IsHandleCreated)
            {
                editor = new edit();
                editor.MdiParent = form;
                editor.BringToFront();
                richTextBox1.SendToBack();
                editor.Show();
            }
            else
            {
                editor.Show();
            }
        }

        public void show()
        {
            richTextBox1.BringToFront();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    
    }
}
