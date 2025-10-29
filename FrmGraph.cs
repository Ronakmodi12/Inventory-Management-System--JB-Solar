using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ArkaGreenPowerPvtLtd
{
	public class FrmGraph : Form
	{
		private IContainer components = null;

		public FrmGraph()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGraph));
            this.SuspendLayout();
            // 
            // FrmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGraph";
            this.Text = "FrmGraph";
            this.ResumeLayout(false);

		}
	}
}