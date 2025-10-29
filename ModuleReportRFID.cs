using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace ArkaGreenPowerPvtLtd
{
	public class ModuleReportRFID : Form
	{
		private string lPath;

		private string lPath1;

		private DataTable lData;

		private DataTable lDataDisplay;

		private DataSet myDataSet;

		private DataSet myTagSet;

		private bool lFlag = false;

		private IContainer components = null;

		private Button button1;

		private GroupBox groupBox1;

		private GroupBox groupBox3;

		private GroupBox groupBox2;

		private ComboBox comboBox1;

		private Label label1;

		private DataGrid dataGrid1;

		public ModuleReportRFID()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.comboBox1.Text != "")
			{
                try
                {
                    this.lDataDisplay.Rows.Clear();
                    this.LoadTagXml();
                    for (int i = 0; i < this.myTagSet.Tables[0].Rows.Count; i++)
                    {
                        if (this.myTagSet.Tables[0].Rows[i]["ModuleNo"].ToString().Trim() == this.comboBox1.Text.Trim())
                        {
                            DataRow dataRow = this.lDataDisplay.NewRow();
                            dataRow[0] = this.myTagSet.Tables[0].Rows[i]["ModuleNo"].ToString().Trim();
                            dataRow[1] = this.myTagSet.Tables[0].Rows[i]["SerialNo"].ToString().Trim();
                            dataRow[2] = this.myTagSet.Tables[0].Rows[i]["Isc"].ToString().Trim();
                            dataRow[3] = this.myTagSet.Tables[0].Rows[i]["Voc"].ToString().Trim();
                            dataRow[4] = this.myTagSet.Tables[0].Rows[i]["PMax"].ToString().Trim();
                            dataRow[5] = this.myTagSet.Tables[0].Rows[i]["IMax"].ToString().Trim();
                            dataRow[6] = this.myTagSet.Tables[0].Rows[i]["VMax"].ToString().Trim();
                            dataRow[7] = this.myTagSet.Tables[0].Rows[i]["FF"].ToString().Trim();
                            //dataRow[8] = this.myTagSet.Tables[0].Rows[i]["Effeciency"].ToString().Trim();
                            this.lDataDisplay.Rows.Add(dataRow);
                        }
                    }
                }
                catch (Exception ecp) { }
				this.dataGrid1.DataSource = this.lDataDisplay;
			}
		}

		private void CreateDisplayTable()
		{
			this.lDataDisplay = new DataTable();
			this.lDataDisplay.Columns.Add("ModuleNo");
			this.lDataDisplay.Columns.Add("SerialNo");
			this.lDataDisplay.Columns.Add("Isc");
			this.lDataDisplay.Columns.Add("Voc");
			this.lDataDisplay.Columns.Add("PMax");
			this.lDataDisplay.Columns.Add("IMax");
			this.lDataDisplay.Columns.Add("VMax");
			this.lDataDisplay.Columns.Add("FF");
			//this.lDataDisplay.Columns.Add("Effeciency");
		}

		private void CreateTable()
		{
			this.lData = new DataTable();
			this.lData.Columns.Add("ModuleNo");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleReportRFID));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(482, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Report";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(28, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 347);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(11, 16);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(641, 326);
            this.dataGrid1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(28, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 55);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Module";
            // 
            // ModuleReportRFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 436);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModuleReportRFID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuleReportRFID";
            this.Load += new System.EventHandler(this.ModuleReportRFID_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		private void LoadModuleNo()
		{
			try
			{
				this.CreateTable();
				this.myDataSet = new DataSet();
				this.myDataSet.ReadXml(this.lPath);
				for (int i = 0; i < this.myDataSet.Tables[0].Rows.Count; i++)
				{
					for (int j = 0; j < this.lData.Rows.Count; j++)
					{
						if (!(this.myDataSet.Tables[0].Rows[i]["PVModule"].ToString().Trim() != this.lData.Rows[j]["ModuleNo"].ToString().Trim()))
						{
							this.lFlag = false;
						}
						else
						{
							this.lFlag = true;
						}
					}
					if ((this.lFlag ? true : this.lData.Rows.Count == 0))
					{
						DataRow dataRow = this.lData.NewRow();
						dataRow[0] = this.myDataSet.Tables[0].Rows[i]["PVModule"].ToString().Trim();
						this.lData.Rows.Add(dataRow);
					}
				}
				this.comboBox1.DataSource = this.lData;
				this.comboBox1.DisplayMember = "ModuleNo";
			}
			catch (Exception)
			{
			}
		}

		private void LoadTagXml()
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			this.lPath1 = string.Concat(baseDirectory, "XMLTag.xml");
			this.myTagSet = new DataSet();
			this.myTagSet.ReadXml(this.lPath1);
		}

		private void ModuleReportRFID_Load(object sender, EventArgs e)
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			this.lPath = string.Concat(baseDirectory, "XMLCompanySettings.xml");
			this.LoadModuleNo();
			this.CreateDisplayTable();
		}
	}
}