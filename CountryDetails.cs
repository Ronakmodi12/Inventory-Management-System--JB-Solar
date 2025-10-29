using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Xml;

namespace ArkaGreenPowerPvtLtd
{
	public class CountryDetails : Form
	{
		private IContainer components = null;

		private GroupBox groupBox1;

		private GroupBox groupBox2;

		private GroupBox groupBox3;

		private Button button1;

		private TextBox txtcomman;

		private Label label1;

		private DataGrid dataGrid1;

		private string lPath;

		public CountryDetails()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(this.lPath);
			XmlElement xmlElement = xmlDocument.CreateElement("CountryName");
			xmlElement.InnerText = this.txtcomman.Text.Trim();
			xmlDocument.DocumentElement.AppendChild(xmlElement);
			xmlDocument.Save(this.lPath);
			MessageBox.Show("Country Added Successfully");
			this.LoadCountry();
		}

		private void CountryDetails_Load(object sender, EventArgs e)
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			this.lPath = string.Concat(baseDirectory, "XMLCountry.xml");
			this.LoadCountry();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcomman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(6, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 227);
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
            this.dataGrid1.CaptionText = "Country List";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Maroon;
            this.dataGrid1.Location = new System.Drawing.Point(6, 11);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(344, 210);
            this.dataGrid1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtcomman);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(246, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcomman
            // 
            this.txtcomman.ForeColor = System.Drawing.Color.Black;
            this.txtcomman.Location = new System.Drawing.Point(19, 41);
            this.txtcomman.Name = "txtcomman";
            this.txtcomman.Size = new System.Drawing.Size(205, 20);
            this.txtcomman.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Name";
            // 
            // CountryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(395, 356);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CountryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountryDetails";
            this.Load += new System.EventHandler(this.CountryDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		private void LoadCountry()
		{
			try
			{
				this.dataGrid1.ParentRowsVisible = false;
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