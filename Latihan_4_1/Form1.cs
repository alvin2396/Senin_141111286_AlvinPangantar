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

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        SaveFileDialog save = new SaveFileDialog();
        OpenFileDialog openfile = new OpenFileDialog();

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

            combosize.SelectedIndex = 2;
            combofont.Text = "Tahoma";
        }

        private void combofont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(combofont.SelectedItem.ToString(), richTextBox1.Font.Size);
        }

        private void combosize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(combofont.Font.FontFamily, float.Parse(combosize.SelectedItem.ToString()));

        }

        private void italicbtn_Click(object sender, EventArgs e)
        {
            Font new1, old;
            old = richTextBox1.SelectionFont;
            if (old.Italic)
            {
                new1 = new Font(old, old.Style & ~FontStyle.Italic);
                italicbtn.Checked = false;
            }
            else
            {
                new1 = new Font(old, old.Style | FontStyle.Italic);
                italicbtn.Checked = true;
            }
            richTextBox1.SelectionFont = new1;
        }

        private void underbtn_Click(object sender, EventArgs e)
        {
            Font new1, old;
            old = richTextBox1.SelectionFont;
            if (old.Underline)
            {
                new1 = new Font(old, old.Style & ~FontStyle.Underline);
                underbtn.Checked = false;
            }
            else
            {
                new1 = new Font(old, old.Style | FontStyle.Underline);
                underbtn.Checked = true;
            }
            richTextBox1.SelectionFont = new1;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!richTextBox1.Modified)
            {
                richTextBox1.Clear();
            }
            else
            {
                if(MessageBox.Show("File belum disave, ingin save?","Save",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    save.Filter = "Rich Text Box(*.rtf)|*.rtf";
                    save.FileName = "";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(save.FileName, richTextBox1.Text);
                    }
                    
                }
                richTextBox1.Clear();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save.Filter = "Rich Text Box(*.rtf)|*.rtf";
            save.FileName = "";
            if(save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, richTextBox1.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile.Filter = "Rich Text Box(*.rtf)|*.rtf";
            openfile.FileName = "";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                String text = openfile.FileName;
                richTextBox1.Text = File.ReadAllText(text);
            }   
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Modified)
            {
                if(MessageBox.Show("File anda belum di save, save terlebih dahulu","Keluar",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    save.Filter = "Rich Text Box(*.rtf)|*.rtf";
                    save.FileName = "";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(save.FileName, richTextBox1.Text);
                    }
                    Application.Exit();
                }
                
            }
            else
            {
                Application.Exit();
            }
        }
    }
}

