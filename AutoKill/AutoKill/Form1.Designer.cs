namespace AutoKill
{
    partial class AutoKillForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoKillForm));
            this.B_Kill = new System.Windows.Forms.Button();
            this.CLB_Tasks = new System.Windows.Forms.CheckedListBox();
            this.L_Frequency = new System.Windows.Forms.Label();
            this.TB_Frequency = new System.Windows.Forms.TextBox();
            this.CB_Ask = new System.Windows.Forms.CheckBox();
            this.L_Time = new System.Windows.Forms.Label();
            this.L_TimeLeft = new System.Windows.Forms.Label();
            this.NI_AutoKill = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Kill
            // 
            this.B_Kill.Location = new System.Drawing.Point(233, 345);
            this.B_Kill.Name = "B_Kill";
            this.B_Kill.Size = new System.Drawing.Size(129, 23);
            this.B_Kill.TabIndex = 0;
            this.B_Kill.Text = "Kill Selected Now";
            this.B_Kill.UseVisualStyleBackColor = true;
            this.B_Kill.Click += new System.EventHandler(this.B_Kill_Click);
            // 
            // CLB_Tasks
            // 
            this.CLB_Tasks.FormattingEnabled = true;
            this.CLB_Tasks.Items.AddRange(new object[] {
            "Chrome",
            "GitHub",
            "Blender-app",
            "Cisco",
            "ITunesHelper",
            "vpnui",
            "adb"});
            this.CLB_Tasks.Location = new System.Drawing.Point(12, 39);
            this.CLB_Tasks.Name = "CLB_Tasks";
            this.CLB_Tasks.Size = new System.Drawing.Size(350, 199);
            this.CLB_Tasks.TabIndex = 1;
            // 
            // L_Frequency
            // 
            this.L_Frequency.AutoSize = true;
            this.L_Frequency.Location = new System.Drawing.Point(13, 245);
            this.L_Frequency.Name = "L_Frequency";
            this.L_Frequency.Size = new System.Drawing.Size(57, 13);
            this.L_Frequency.TabIndex = 2;
            this.L_Frequency.Text = "Frequency";
            // 
            // TB_Frequency
            // 
            this.TB_Frequency.Location = new System.Drawing.Point(12, 262);
            this.TB_Frequency.Name = "TB_Frequency";
            this.TB_Frequency.Size = new System.Drawing.Size(100, 20);
            this.TB_Frequency.TabIndex = 3;
            this.TB_Frequency.Text = "60";
            this.TB_Frequency.TextChanged += new System.EventHandler(this.TB_Frequency_TextChanged);
            // 
            // CB_Ask
            // 
            this.CB_Ask.AutoSize = true;
            this.CB_Ask.Location = new System.Drawing.Point(242, 322);
            this.CB_Ask.Name = "CB_Ask";
            this.CB_Ask.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB_Ask.Size = new System.Drawing.Size(120, 17);
            this.CB_Ask.TabIndex = 5;
            this.CB_Ask.Text = "Show Popup On Kill";
            this.CB_Ask.UseVisualStyleBackColor = true;
            // 
            // L_Time
            // 
            this.L_Time.AutoSize = true;
            this.L_Time.Location = new System.Drawing.Point(260, 245);
            this.L_Time.Name = "L_Time";
            this.L_Time.Size = new System.Drawing.Size(102, 13);
            this.L_Time.TabIndex = 6;
            this.L_Time.Text = "Seconds Remaining";
            // 
            // L_TimeLeft
            // 
            this.L_TimeLeft.AutoSize = true;
            this.L_TimeLeft.Location = new System.Drawing.Point(305, 265);
            this.L_TimeLeft.Name = "L_TimeLeft";
            this.L_TimeLeft.Size = new System.Drawing.Size(13, 13);
            this.L_TimeLeft.TabIndex = 7;
            this.L_TimeLeft.Text = "0";
            // 
            // NI_AutoKill
            // 
            this.NI_AutoKill.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NI_AutoKill.BalloonTipText = "Open Interface";
            this.NI_AutoKill.BalloonTipTitle = "AutoKill";
            this.NI_AutoKill.Icon = ((System.Drawing.Icon)(resources.GetObject("NI_AutoKill.Icon")));
            this.NI_AutoKill.Text = "AutoKill";
            this.NI_AutoKill.Visible = true;
            this.NI_AutoKill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NI_AutoKill_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newItemToolStripMenuItem.Text = "New Item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.uncheckAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.helpToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem2});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkAllToolStripMenuItem.Text = "Check All";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uncheckAllToolStripMenuItem.Text = "Uncheck All";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Add Item";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.aboutToolStripMenuItem1.Text = "Open Help Page";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.aboutToolStripMenuItem2.Text = "About AutoKill";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // AutoKillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 377);
            this.Controls.Add(this.L_TimeLeft);
            this.Controls.Add(this.L_Time);
            this.Controls.Add(this.CB_Ask);
            this.Controls.Add(this.TB_Frequency);
            this.Controls.Add(this.L_Frequency);
            this.Controls.Add(this.CLB_Tasks);
            this.Controls.Add(this.B_Kill);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutoKillForm";
            this.Text = "AutoKill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoKillForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Kill;
        private System.Windows.Forms.CheckedListBox CLB_Tasks;
        private System.Windows.Forms.Label L_Frequency;
        private System.Windows.Forms.TextBox TB_Frequency;
        private System.Windows.Forms.CheckBox CB_Ask;
        private System.Windows.Forms.Label L_Time;
        private System.Windows.Forms.Label L_TimeLeft;
        private System.Windows.Forms.NotifyIcon NI_AutoKill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
    }
}

