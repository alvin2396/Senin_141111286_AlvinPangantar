namespace Latihan_5_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbold = new System.Windows.Forms.ToolStripButton();
            this.toolitalic = new System.Windows.Forms.ToolStripButton();
            this.toolunder = new System.Windows.Forms.ToolStripButton();
            this.combosize = new System.Windows.Forms.ToolStripComboBox();
            this.combofont = new System.Windows.Forms.ToolStripComboBox();
            this.combocolor = new System.Windows.Forms.ToolStripComboBox();
            this.comboback = new System.Windows.Forms.ToolStripComboBox();
            this.boldbtn = new System.Windows.Forms.ToolStripButton();
            this.italicbtn = new System.Windows.Forms.ToolStripButton();
            this.underbtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtool = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savetool = new System.Windows.Forms.ToolStripMenuItem();
            this.exittool = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(640, 210);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Font";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbold,
            this.toolitalic,
            this.toolunder,
            this.combosize,
            this.combofont,
            this.combocolor,
            this.comboback,
            this.boldbtn,
            this.italicbtn,
            this.underbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbold
            // 
            this.toolbold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbold.Image = ((System.Drawing.Image)(resources.GetObject("toolbold.Image")));
            this.toolbold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbold.Name = "toolbold";
            this.toolbold.Size = new System.Drawing.Size(23, 22);
            this.toolbold.Text = "toolbold";
            this.toolbold.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolitalic
            // 
            this.toolitalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolitalic.Image = ((System.Drawing.Image)(resources.GetObject("toolitalic.Image")));
            this.toolitalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolitalic.Name = "toolitalic";
            this.toolitalic.Size = new System.Drawing.Size(23, 22);
            this.toolitalic.Text = "toolitalic";
            this.toolitalic.Click += new System.EventHandler(this.toolitalic_Click);
            // 
            // toolunder
            // 
            this.toolunder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolunder.Image = ((System.Drawing.Image)(resources.GetObject("toolunder.Image")));
            this.toolunder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolunder.Name = "toolunder";
            this.toolunder.Size = new System.Drawing.Size(23, 22);
            this.toolunder.Text = "toolunderline";
            this.toolunder.Click += new System.EventHandler(this.toolunder_Click);
            // 
            // combosize
            // 
            this.combosize.Name = "combosize";
            this.combosize.Size = new System.Drawing.Size(121, 25);
            this.combosize.SelectedIndexChanged += new System.EventHandler(this.combosize_SelectedIndexChanged);
            this.combosize.Click += new System.EventHandler(this.combosize_Click);
            // 
            // combofont
            // 
            this.combofont.Name = "combofont";
            this.combofont.Size = new System.Drawing.Size(121, 25);
            this.combofont.SelectedIndexChanged += new System.EventHandler(this.combofont_SelectedIndexChanged_1);
            this.combofont.Click += new System.EventHandler(this.combofont_Click);
            // 
            // combocolor
            // 
            this.combocolor.Name = "combocolor";
            this.combocolor.Size = new System.Drawing.Size(121, 25);
            this.combocolor.SelectedIndexChanged += new System.EventHandler(this.combocolor_SelectedIndexChanged);
            this.combocolor.Click += new System.EventHandler(this.combocolor_Click);
            // 
            // comboback
            // 
            this.comboback.Name = "comboback";
            this.comboback.Size = new System.Drawing.Size(121, 25);
            this.comboback.SelectedIndexChanged += new System.EventHandler(this.comboback_SelectedIndexChanged);
            this.comboback.Click += new System.EventHandler(this.comboback_Click);
            // 
            // boldbtn
            // 
            this.boldbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldbtn.Name = "boldbtn";
            this.boldbtn.Size = new System.Drawing.Size(23, 22);
            this.boldbtn.Text = "toolStripButton1";
            // 
            // italicbtn
            // 
            this.italicbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicbtn.Name = "italicbtn";
            this.italicbtn.Size = new System.Drawing.Size(23, 22);
            this.italicbtn.Text = "toolStripButton2";
            // 
            // underbtn
            // 
            this.underbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underbtn.Name = "underbtn";
            this.underbtn.Size = new System.Drawing.Size(23, 22);
            this.underbtn.Text = "underbtn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtool,
            this.openToolStripMenuItem,
            this.savetool,
            this.exittool});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newtool
            // 
            this.newtool.Name = "newtool";
            this.newtool.Size = new System.Drawing.Size(152, 22);
            this.newtool.Text = "New";
            this.newtool.Click += new System.EventHandler(this.newtool_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // savetool
            // 
            this.savetool.Name = "savetool";
            this.savetool.Size = new System.Drawing.Size(152, 22);
            this.savetool.Text = "Save";
            this.savetool.Click += new System.EventHandler(this.savetool_Click);
            // 
            // exittool
            // 
            this.exittool.Name = "exittool";
            this.exittool.Size = new System.Drawing.Size(152, 22);
            this.exittool.Text = "Exit";
            this.exittool.Click += new System.EventHandler(this.exittool_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Back Color";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Size";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boldbtn;
        private System.Windows.Forms.ToolStripButton italicbtn;
        private System.Windows.Forms.ToolStripButton underbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtool;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savetool;
        private System.Windows.Forms.ToolStripMenuItem exittool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolbold;
        private System.Windows.Forms.ToolStripButton toolitalic;
        private System.Windows.Forms.ToolStripButton toolunder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripComboBox combosize;
        private System.Windows.Forms.ToolStripComboBox combofont;
        private System.Windows.Forms.ToolStripComboBox combocolor;
        private System.Windows.Forms.ToolStripComboBox comboback;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}

