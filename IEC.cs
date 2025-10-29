using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Xml;

namespace ArkaGreenPowerPvtLtd
{
	public class IEC : Form
	{
		private IContainer components = null;

		private Button button1;

		private GroupBox groupBox3;

		private GroupBox groupBox2;

		private TextBox txtcomman;

		private Label label1;

		private GroupBox groupBox1;

		private Label label2;

		private DateTimePicker dateTimePicker1;

		private DataGrid dataGrid1;

		private string lPath;

		private DataTable Dt;

		public IEC()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			XmlTextReader xmlTextReader = new XmlTextReader(this.lPath);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(xmlTextReader);
			xmlTextReader.Close();
			XmlDocumentFragment xmlDocumentFragment = xmlDocument.CreateDocumentFragment();
			string[] strArrays = new string[] { "<IEC><IECName>", this.txtcomman.Text.Trim(), "</IECName><Date>", this.dateTimePicker1.Text.Trim(), "</Date></IEC>" };
			xmlDocumentFragment.InnerXml = string.Concat(strArrays);
			XmlNode documentElement = xmlDocument.DocumentElement;
			documentElement.InsertAfter(xmlDocumentFragment, documentElement.LastChild);
			xmlDocument.Save(this.lPath);
			MessageBox.Show("Record Added Successfully");
			this.LoadIEC();
		}

		private void CreateTable()
		{
			this.Dt = new DataTable();
			this.Dt.Columns.Add("IECName");
			this.Dt.Columns.Add("Date");
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void IEC_Load(object sender, EventArgs e)
		{
			this.CreateTable();
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			this.lPath = string.Concat(baseDirectory, "XMLIEC.xml");
			this.LoadIEC();
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IEC));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcomman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(133, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid1);
            this.groupBox3.Location = new System.Drawing.Point(6, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 239);
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
            this.dataGrid1.CaptionText = "IEC Certification Details";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Maroon;
            this.dataGrid1.Location = new System.Drawing.Point(3, 13);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(485, 220);
            this.dataGrid1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtcomman);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // txtcomman
            // 
            this.txtcomman.Location = new System.Drawing.Point(133, 19);
            this.txtcomman.Name = "txtcomman";
            this.txtcomman.Size = new System.Drawing.Size(164, 20);
            this.txtcomman.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certificate Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 346);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IEC Certificate Name";
            // 
            // IEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(516, 358);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IEC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IEC";
            this.Load += new System.EventHandler(this.IEC_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private void LoadIEC()
		{
			try
			{
				this.Dt.Rows.Clear();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(this.lPath);
				for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
				{
					DataRow str = this.Dt.NewRow();
					str[0] = dataSet.Tables[0].Rows[i][0].ToString();
					str[1] = dataSet.Tables[0].Rows[i][1].ToString();
					this.Dt.Rows.Add(str);
				}
				this.dataGrid1.DataSource = this.Dt;
			}
			catch (Exception exception)
			{
			}
		}
	}
}