using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Xml;

namespace ArkaGreenPowerPvtLtd
{
	public class CellMFG : Form
	{
		private IContainer components = null;

		private GroupBox groupBox3;

		private Button button1;

		private GroupBox groupBox2;

		private TextBox txtcomman;

		private Label label1;

		private GroupBox groupBox1;

		private DataGrid dataGrid1;

		private string lPath;

		private BindingSource lSource2 = new BindingSource();

		public CellMFG()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(this.lPath);
			XmlElement xmlElement = xmlDocument.CreateElement("CellName");
			xmlElement.InnerText = this.txtcomman.Text.Trim();
			xmlDocument.DocumentElement.AppendChild(xmlElement);
			xmlDocument.Save(this.lPath);
			MessageBox.Show("Record added successfully");
			this.LoadCell();
		}

		private void CellMFG_Load(object sender, EventArgs e)
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			this.lPath = string.Concat(baseDirectory, "\\XMLCellMFG.xml");
			this.LoadCell();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellMFG));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcomman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(6, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 227);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.BackColor = System.Drawing.Color.White;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.Maroon;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.White;
            this.dataGrid1.CaptionText = "Cell Manufaturer List";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Maroon;
            this.dataGrid1.Location = new System.Drawing.Point(6, 10);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(347, 211);
            this.dataGrid1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(252, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtcomman);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 106);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtcomman
            // 
            this.txtcomman.ForeColor = System.Drawing.Color.Black;
            this.txtcomman.Location = new System.Drawing.Point(31, 47);
            this.txtcomman.Name = "txtcomman";
            this.txtcomman.Size = new System.Drawing.Size(205, 20);
            this.txtcomman.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cell Manufacturer Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cell Manufacture Name";
            // 
            // CellMFG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(400, 378);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CellMFG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CellMFG";
            this.Load += new System.EventHandler(this.CellMFG_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private void LoadCell()
		{
			try
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(this.lPath);
				this.dataGrid1.DataSource = dataSet;
			}
			catch (Exception exception)
			{
			}
		}
	}
}