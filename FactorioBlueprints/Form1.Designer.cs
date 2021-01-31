namespace BlueprintLibrary
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
            this.txtDecoded = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expressModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertBeltTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.fromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmF3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmT1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmT2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmT3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertInserterTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.comingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIF3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIT1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIT2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIT3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtEncoded = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clipboardMonitor1 = new EsseivaN.Tools.ClipboardMonitor();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDecoded
            // 
            this.txtDecoded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDecoded.Location = new System.Drawing.Point(0, 0);
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.Size = new System.Drawing.Size(377, 422);
            this.txtDecoded.TabIndex = 3;
            this.txtDecoded.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.encodeToolStripMenuItem,
            this.decodeToolStripMenuItem,
            this.convertBeltTypeToolStripMenuItem,
            this.convertInserterTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.fastModeToolStripMenuItem,
            this.expressModeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // fastModeToolStripMenuItem
            // 
            this.fastModeToolStripMenuItem.CheckOnClick = true;
            this.fastModeToolStripMenuItem.Name = "fastModeToolStripMenuItem";
            this.fastModeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.fastModeToolStripMenuItem.Text = "Fast mode";
            this.fastModeToolStripMenuItem.ToolTipText = "Auto-run converter once app focused";
            this.fastModeToolStripMenuItem.Click += new System.EventHandler(this.fastModeToolStripMenuItem_Click);
            // 
            // expressModeToolStripMenuItem
            // 
            this.expressModeToolStripMenuItem.CheckOnClick = true;
            this.expressModeToolStripMenuItem.Name = "expressModeToolStripMenuItem";
            this.expressModeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.expressModeToolStripMenuItem.Text = "Express mode";
            this.expressModeToolStripMenuItem.ToolTipText = "Auto-run converter once data copied to clipboard";
            this.expressModeToolStripMenuItem.Click += new System.EventHandler(this.expressModeToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // encodeToolStripMenuItem
            // 
            this.encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
            this.encodeToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.encodeToolStripMenuItem.Text = "Encode";
            this.encodeToolStripMenuItem.Click += new System.EventHandler(this.encodeToolStripMenuItem_Click);
            // 
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.decodeToolStripMenuItem.Text = "Decode";
            this.decodeToolStripMenuItem.Click += new System.EventHandler(this.decodeToolStripMenuItem_Click);
            // 
            // convertBeltTypeToolStripMenuItem
            // 
            this.convertBeltTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.toolStripSeparator5,
            this.fromToolStripMenuItem,
            this.tsmF1,
            this.tsmF2,
            this.tsmF3,
            this.toolStripSeparator1,
            this.toToolStripMenuItem,
            this.tsmT1,
            this.tsmT2,
            this.tsmT3,
            this.toolStripSeparator2,
            this.runToolStripMenuItem});
            this.convertBeltTypeToolStripMenuItem.Name = "convertBeltTypeToolStripMenuItem";
            this.convertBeltTypeToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.convertBeltTypeToolStripMenuItem.Text = "Convert belt type";
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.CheckOnClick = true;
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.enabledToolStripMenuItem.Text = "Enabled";
            this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(126, 6);
            // 
            // fromToolStripMenuItem
            // 
            this.fromToolStripMenuItem.Name = "fromToolStripMenuItem";
            this.fromToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.fromToolStripMenuItem.Text = "From";
            // 
            // tsmF1
            // 
            this.tsmF1.CheckOnClick = true;
            this.tsmF1.Name = "tsmF1";
            this.tsmF1.Size = new System.Drawing.Size(129, 22);
            this.tsmF1.Text = "1 (normal)";
            this.tsmF1.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmF2
            // 
            this.tsmF2.CheckOnClick = true;
            this.tsmF2.Name = "tsmF2";
            this.tsmF2.Size = new System.Drawing.Size(129, 22);
            this.tsmF2.Text = "2 (fast)";
            this.tsmF2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmF3
            // 
            this.tsmF3.CheckOnClick = true;
            this.tsmF3.Name = "tsmF3";
            this.tsmF3.Size = new System.Drawing.Size(129, 22);
            this.tsmF3.Text = "3 (express)";
            this.tsmF3.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // toToolStripMenuItem
            // 
            this.toToolStripMenuItem.Name = "toToolStripMenuItem";
            this.toToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.toToolStripMenuItem.Text = "To";
            // 
            // tsmT1
            // 
            this.tsmT1.CheckOnClick = true;
            this.tsmT1.Name = "tsmT1";
            this.tsmT1.Size = new System.Drawing.Size(129, 22);
            this.tsmT1.Text = "1 (normal)";
            this.tsmT1.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // tsmT2
            // 
            this.tsmT2.CheckOnClick = true;
            this.tsmT2.Name = "tsmT2";
            this.tsmT2.Size = new System.Drawing.Size(129, 22);
            this.tsmT2.Text = "2 (fast)";
            this.tsmT2.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // tsmT3
            // 
            this.tsmT3.CheckOnClick = true;
            this.tsmT3.Name = "tsmT3";
            this.tsmT3.Size = new System.Drawing.Size(129, 22);
            this.tsmT3.Text = "3 (express)";
            this.tsmT3.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // convertInserterTypeToolStripMenuItem
            // 
            this.convertInserterTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem1,
            this.toolStripSeparator6,
            this.comingSoonToolStripMenuItem,
            this.tsmIF1,
            this.tsmIF2,
            this.tsmIF3,
            this.toolStripSeparator3,
            this.toToolStripMenuItem1,
            this.tsmIT1,
            this.tsmIT2,
            this.tsmIT3,
            this.toolStripSeparator4,
            this.runToolStripMenuItem1});
            this.convertInserterTypeToolStripMenuItem.Name = "convertInserterTypeToolStripMenuItem";
            this.convertInserterTypeToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.convertInserterTypeToolStripMenuItem.Text = "Convert inserter type";
            // 
            // enabledToolStripMenuItem1
            // 
            this.enabledToolStripMenuItem1.CheckOnClick = true;
            this.enabledToolStripMenuItem1.Name = "enabledToolStripMenuItem1";
            this.enabledToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.enabledToolStripMenuItem1.Text = "Enabled";
            this.enabledToolStripMenuItem1.Click += new System.EventHandler(this.enabledToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(113, 6);
            // 
            // comingSoonToolStripMenuItem
            // 
            this.comingSoonToolStripMenuItem.Name = "comingSoonToolStripMenuItem";
            this.comingSoonToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.comingSoonToolStripMenuItem.Text = "From";
            // 
            // tsmIF1
            // 
            this.tsmIF1.CheckOnClick = true;
            this.tsmIF1.Name = "tsmIF1";
            this.tsmIF1.Size = new System.Drawing.Size(116, 22);
            this.tsmIF1.Text = "Normal";
            this.tsmIF1.Click += new System.EventHandler(this.tsmIF2_Click);
            // 
            // tsmIF2
            // 
            this.tsmIF2.CheckOnClick = true;
            this.tsmIF2.Name = "tsmIF2";
            this.tsmIF2.Size = new System.Drawing.Size(116, 22);
            this.tsmIF2.Text = "Fast";
            this.tsmIF2.Click += new System.EventHandler(this.tsmIF2_Click);
            // 
            // tsmIF3
            // 
            this.tsmIF3.CheckOnClick = true;
            this.tsmIF3.Name = "tsmIF3";
            this.tsmIF3.Size = new System.Drawing.Size(116, 22);
            this.tsmIF3.Text = "Stack";
            this.tsmIF3.Click += new System.EventHandler(this.tsmIF2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(113, 6);
            // 
            // toToolStripMenuItem1
            // 
            this.toToolStripMenuItem1.Name = "toToolStripMenuItem1";
            this.toToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.toToolStripMenuItem1.Text = "To";
            // 
            // tsmIT1
            // 
            this.tsmIT1.CheckOnClick = true;
            this.tsmIT1.Name = "tsmIT1";
            this.tsmIT1.Size = new System.Drawing.Size(116, 22);
            this.tsmIT1.Text = "Normal";
            this.tsmIT1.Click += new System.EventHandler(this.tsmIT1_Click);
            // 
            // tsmIT2
            // 
            this.tsmIT2.CheckOnClick = true;
            this.tsmIT2.Name = "tsmIT2";
            this.tsmIT2.Size = new System.Drawing.Size(116, 22);
            this.tsmIT2.Text = "Fast";
            this.tsmIT2.Click += new System.EventHandler(this.tsmIT2_Click);
            // 
            // tsmIT3
            // 
            this.tsmIT3.CheckOnClick = true;
            this.tsmIT3.Name = "tsmIT3";
            this.tsmIT3.Size = new System.Drawing.Size(116, 22);
            this.tsmIT3.Text = "Stack";
            this.tsmIT3.Click += new System.EventHandler(this.tsmIT3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(113, 6);
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.runToolStripMenuItem1.Text = "Run";
            this.runToolStripMenuItem1.Click += new System.EventHandler(this.runToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtDecoded);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtEncoded);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtEncoded
            // 
            this.txtEncoded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncoded.Location = new System.Drawing.Point(0, 0);
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.Size = new System.Drawing.Size(407, 422);
            this.txtEncoded.TabIndex = 4;
            this.txtEncoded.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select blueprint to load";
            // 
            // clipboardMonitor1
            // 
            this.clipboardMonitor1.BackColor = System.Drawing.Color.Red;
            this.clipboardMonitor1.Enabled = false;
            this.clipboardMonitor1.Location = new System.Drawing.Point(770, 3);
            this.clipboardMonitor1.Name = "clipboardMonitor1";
            this.clipboardMonitor1.Size = new System.Drawing.Size(28, 17);
            this.clipboardMonitor1.TabIndex = 6;
            this.clipboardMonitor1.Text = "clipboardMonitor1";
            this.clipboardMonitor1.Visible = false;
            this.clipboardMonitor1.ClipboardChanged += new System.EventHandler<EsseivaN.Tools.ClipboardChangedEventArgs>(this.clipboardMonitor1_ClipboardChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clipboardMonitor1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Factrio blueprint tools";
            this.Activated += new System.EventHandler(this.Form1_Enter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtDecoded;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem encodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txtEncoded;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem convertBeltTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmF1;
        private System.Windows.Forms.ToolStripMenuItem tsmF2;
        private System.Windows.Forms.ToolStripMenuItem tsmF3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmT1;
        private System.Windows.Forms.ToolStripMenuItem tsmT2;
        private System.Windows.Forms.ToolStripMenuItem tsmT3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertInserterTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comingSoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expressModeToolStripMenuItem;
        private EsseivaN.Tools.ClipboardMonitor clipboardMonitor1;
        private System.Windows.Forms.ToolStripMenuItem tsmIF1;
        private System.Windows.Forms.ToolStripMenuItem tsmIF2;
        private System.Windows.Forms.ToolStripMenuItem tsmIF3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmIT1;
        private System.Windows.Forms.ToolStripMenuItem tsmIT2;
        private System.Windows.Forms.ToolStripMenuItem tsmIT3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

