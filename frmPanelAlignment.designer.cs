namespace ArkaGreenPowerPvtLtd
{
    partial class frmPanelAlignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelAlignment));
            this.btnStartReading = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartReading
            // 
            this.btnStartReading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartReading.BackColor = System.Drawing.Color.Silver;
            this.btnStartReading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartReading.Location = new System.Drawing.Point(416, 12);
            this.btnStartReading.Name = "btnStartReading";
            this.btnStartReading.Size = new System.Drawing.Size(163, 35);
            this.btnStartReading.TabIndex = 3;
            this.btnStartReading.Text = "Start Reading";
            this.btnStartReading.UseVisualStyleBackColor = false;
            this.btnStartReading.Click += new System.EventHandler(this.btnStartReading_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(910, 420);
            this.listBox1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(416, 479);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmPanelAlignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(973, 512);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStartReading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPanelAlignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Panel Alignment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartReading;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClear;
    }
}