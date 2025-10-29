namespace ArkaGreenPowerPvtLtd
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolwritetag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellManufactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iECCertificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolwritetag,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 56);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolwritetag
            // 
            this.toolwritetag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolwritetag.Image = global::JB_Solar.Properties.Resources.icons8_rfid_tag_30;
            this.toolwritetag.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolwritetag.Name = "toolwritetag";
            this.toolwritetag.Size = new System.Drawing.Size(83, 52);
            this.toolwritetag.Text = "Write Tag";
            this.toolwritetag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolwritetag.Click += new System.EventHandler(this.toolwritetag_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem2.Image = global::JB_Solar.Properties.Resources.Read;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 52);
            this.toolStripMenuItem2.Text = "Read Tag";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCountryToolStripMenuItem,
            this.addToolStripMenuItem,
            this.cellManufactureToolStripMenuItem,
            this.iECCertificationToolStripMenuItem,
            this.moduleNoToolStripMenuItem,
            this.companySettingsToolStripMenuItem});
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem3.Image = global::JB_Solar.Properties.Resources.Setting;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(74, 52);
            this.toolStripMenuItem3.Text = "Settings";
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addCountryToolStripMenuItem
            // 
            this.addCountryToolStripMenuItem.Name = "addCountryToolStripMenuItem";
            this.addCountryToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addCountryToolStripMenuItem.Text = "Country Details";
            this.addCountryToolStripMenuItem.Click += new System.EventHandler(this.addCountryToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addToolStripMenuItem.Text = "Module Manufature";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // cellManufactureToolStripMenuItem
            // 
            this.cellManufactureToolStripMenuItem.Name = "cellManufactureToolStripMenuItem";
            this.cellManufactureToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cellManufactureToolStripMenuItem.Text = "Cell manufacture";
            this.cellManufactureToolStripMenuItem.Click += new System.EventHandler(this.cellManufactureToolStripMenuItem_Click);
            // 
            // iECCertificationToolStripMenuItem
            // 
            this.iECCertificationToolStripMenuItem.Name = "iECCertificationToolStripMenuItem";
            this.iECCertificationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.iECCertificationToolStripMenuItem.Text = "IEC Certification";
            this.iECCertificationToolStripMenuItem.Click += new System.EventHandler(this.iECCertificationToolStripMenuItem_Click);
            // 
            // moduleNoToolStripMenuItem
            // 
            this.moduleNoToolStripMenuItem.Name = "moduleNoToolStripMenuItem";
            this.moduleNoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.moduleNoToolStripMenuItem.Text = "Module No";
            this.moduleNoToolStripMenuItem.Click += new System.EventHandler(this.moduleNoToolStripMenuItem_Click);
            // 
            // companySettingsToolStripMenuItem
            // 
            this.companySettingsToolStripMenuItem.Name = "companySettingsToolStripMenuItem";
            this.companySettingsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.companySettingsToolStripMenuItem.Text = "Company settings";
            this.companySettingsToolStripMenuItem.Click += new System.EventHandler(this.companySettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem1.Image = global::JB_Solar.Properties.Resources.solar_panel;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 52);
            this.toolStripMenuItem1.Text = "AlignPanel";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reportToolStripMenuItem.Image = global::JB_Solar.Properties.Resources.clipboard;
            this.reportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(65, 52);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            this.dailyReportToolStripMenuItem.Visible = false;
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitToolStripMenuItem.Image = global::JB_Solar.Properties.Resources.exit;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 52);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(166, 17);
            this.toolStripStatusLabel1.Text = "Reader Not Connected";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 607);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JB POWER Solar Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolwritetag;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellManufactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iECCertificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem companySettingsToolStripMenuItem;
    }
}

