namespace Latihan_3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.combofont = new System.Windows.Forms.ComboBox();
            this.combosize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.boldbtn = new System.Windows.Forms.ToolStripButton();
            this.italicbtn = new System.Windows.Forms.ToolStripButton();
            this.underbtn = new System.Windows.Forms.ToolStripButton();
            this.warnabtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(491, 221);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // combofont
            // 
            this.combofont.FormattingEnabled = true;
            this.combofont.Location = new System.Drawing.Point(240, 1);
            this.combofont.Name = "combofont";
            this.combofont.Size = new System.Drawing.Size(153, 21);
            this.combofont.TabIndex = 1;
            this.combofont.SelectedIndexChanged += new System.EventHandler(this.combofont_SelectedIndexChanged);
            // 
            // combosize
            // 
            this.combosize.FormattingEnabled = true;
            this.combosize.Location = new System.Drawing.Point(149, 1);
            this.combosize.Name = "combosize";
            this.combosize.Size = new System.Drawing.Size(41, 21);
            this.combosize.TabIndex = 2;
            this.combosize.SelectedIndexChanged += new System.EventHandler(this.combosize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldbtn,
            this.italicbtn,
            this.underbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(517, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // boldbtn
            // 
            this.boldbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldbtn.Image = ((System.Drawing.Image)(resources.GetObject("boldbtn.Image")));
            this.boldbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldbtn.Name = "boldbtn";
            this.boldbtn.Size = new System.Drawing.Size(23, 22);
            this.boldbtn.Text = "toolStripButton1";
            this.boldbtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // italicbtn
            // 
            this.italicbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicbtn.Image = ((System.Drawing.Image)(resources.GetObject("italicbtn.Image")));
            this.italicbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicbtn.Name = "italicbtn";
            this.italicbtn.Size = new System.Drawing.Size(23, 22);
            this.italicbtn.Text = "toolStripButton2";
            this.italicbtn.Click += new System.EventHandler(this.italicbtn_Click);
            // 
            // underbtn
            // 
            this.underbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underbtn.Image = ((System.Drawing.Image)(resources.GetObject("underbtn.Image")));
            this.underbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underbtn.Name = "underbtn";
            this.underbtn.Size = new System.Drawing.Size(23, 22);
            this.underbtn.Text = "underbtn";
            this.underbtn.Click += new System.EventHandler(this.underbtn_Click);
            // 
            // warnabtn
            // 
            this.warnabtn.Location = new System.Drawing.Point(399, 1);
            this.warnabtn.Name = "warnabtn";
            this.warnabtn.Size = new System.Drawing.Size(45, 21);
            this.warnabtn.TabIndex = 6;
            this.warnabtn.Text = "Color";
            this.warnabtn.UseVisualStyleBackColor = true;
            this.warnabtn.Click += new System.EventHandler(this.warnabtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 261);
            this.Controls.Add(this.warnabtn);
            this.Controls.Add(this.combosize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combofont);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox combofont;
        private System.Windows.Forms.ComboBox combosize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boldbtn;
        private System.Windows.Forms.ToolStripButton italicbtn;
        private System.Windows.Forms.ToolStripButton underbtn;
        private System.Windows.Forms.Button warnabtn;
    }
}

