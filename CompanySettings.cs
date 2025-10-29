using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Xml;

namespace ArkaGreenPowerPvtLtd
{
	public class CompanySettings : Form
	{
		private IContainer components = null;

		private GroupBox groupBox1;

		private GroupBox groupBox3;

		private GroupBox groupBox2;

		private Button button1;

		private Label label1;

		private GroupBox groupBox6;

		private GroupBox groupBox5;

		private GroupBox groupBox4;

		private Label label3;

		private ComboBox comyear;

		private Label label2;

		private ComboBox compv;

		private GroupBox groupBox7;

		private Label label7;

		private Label label9;

		private Label label8;

		private Label label6;

		private Label label5;

		private Label label4;

		private DateTimePicker datecertification;

		private ComboBox comclab;

		private Label label11;

		private Label label10;

		private DateTimePicker datecell;

		private ComboBox comcountry1;

		private ComboBox comcellmName;

		private DateTimePicker datepv;

		private ComboBox comcountry;

		private ComboBox compvmname;

		private Button button2;

		private Button button3;

		private DataGridView dataGridView1;

		private string AppIniPath;

		private BindingSource lCS = new BindingSource();

		private DataTable lCompanyTable;

		private DataTable lIECDataTable;

		private int CSID;

		private int IDForEdit;

		public CompanySettings()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.compv.Text == "")
			{
				MessageBox.Show("select Module Type");
			}
			else if (this.comyear.Text == "")
			{
				MessageBox.Show("select Warranty year");
			}
			else if (this.compvmname.Text == "")
			{
				MessageBox.Show("select PV Manufacturer Name");
			}
			else if (this.comcountry.Text == "")
			{
				MessageBox.Show("select PV Manufacturer Country Name");
			}
			else if (this.comcellmName.Text == "")
			{
				MessageBox.Show("select Cell Manufacturer Name");
			}
			else if (this.comcountry1.Text == "")
			{
				MessageBox.Show("select Cell Manufacturer Country Name");
			}
			else if (!(this.comclab.Text == ""))
			{
				int d = this.GetID() + 1;
				string str = string.Concat(this.AppIniPath, "XMLCompanySettings.xml");
				XmlTextReader xmlTextReader = new XmlTextReader(str);
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(xmlTextReader);
				xmlTextReader.Close();
				XmlDocumentFragment xmlDocumentFragment = xmlDocument.CreateDocumentFragment();
				object[] objArray = new object[] { "<Company><ID>", d, "</ID><PVModule>", this.compv.Text.Trim(), "</PVModule><Warranty>", this.comyear.Text.Trim(), "</Warranty><PVMName>", this.compvmname.Text.Trim(), "</PVMName><PVCountry>", this.comcountry.Text.Trim(), "</PVCountry><PVDate>", this.datepv.Text.Trim(), "</PVDate><CellMName>", this.comcellmName.Text.Trim(), "</CellMName><CellCountry>", this.comcountry1.Text.Trim(), "</CellCountry><CellDate>", this.datecell.Text.Trim(), "</CellDate><IECLab>", this.comclab.Text.Trim(), "</IECLab><IECDate>", this.datecertification.Text.Trim(), "</IECDate></Company>" };
				xmlDocumentFragment.InnerXml = string.Concat(objArray);
				XmlNode documentElement = xmlDocument.DocumentElement;
				documentElement.InsertAfter(xmlDocumentFragment, documentElement.LastChild);
				xmlDocument.Save(str);
				MessageBox.Show("Record Added Successfully");
				this.LoadCompanySettings();
			}
			else
			{
				MessageBox.Show("select Certification Lab");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (this.IDForEdit == 0)
			{
				MessageBox.Show("Select Row for Edit");
			}
			else
			{
				string str = string.Concat(this.AppIniPath, "XMLCompanySettings.xml");
				XmlTextReader xmlTextReader = new XmlTextReader(str);
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(xmlTextReader);
				xmlTextReader.Close();
				XmlElement documentElement = xmlDocument.DocumentElement;
				XmlNode xmlNodes = documentElement.SelectSingleNode(string.Concat("/CompanySettings/Company[ID='", this.IDForEdit.ToString(), "']"));
				XmlElement xmlElement = xmlDocument.CreateElement("Company");
				object[] dForEdit = new object[] { "<ID>", this.IDForEdit, "</ID><PVModule>", this.compv.Text.Trim(), "</PVModule><Warranty>", this.comyear.Text.Trim(), "</Warranty><PVMName>", this.compvmname.Text.Trim(), "</PVMName><PVCountry>", this.comcountry.Text.Trim(), "</PVCountry><PVDate>", this.datepv.Text.Trim(), "</PVDate><CellMName>", this.comcellmName.Text.Trim(), "</CellMName><CellCountry>", this.comcountry1.Text.Trim(), "</CellCountry><CellDate>", this.datecell.Text.Trim(), "</CellDate><IECLab>", this.comclab.Text.Trim(), "</IECLab><IECDate>", this.datecertification.Text.Trim(), "</IECDate>", documentElement.ReplaceChild(xmlElement, xmlNodes) };
				xmlElement.InnerXml = string.Concat(dForEdit);
				xmlDocument.Save(str);
				MessageBox.Show("Value updated successfully");
				this.LoadCompanySettings();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (this.IDForEdit == 0)
			{
				MessageBox.Show("Select Row for Edit");
			}
			else
			{
				string str = string.Concat(this.AppIniPath, "XMLCompanySettings.xml");
				XmlTextReader xmlTextReader = new XmlTextReader(str);
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(xmlTextReader);
				xmlTextReader.Close();
				XmlElement documentElement = xmlDocument.DocumentElement;
				XmlNode xmlNodes = documentElement.SelectSingleNode(string.Concat("/CompanySettings/Company[ID='", this.IDForEdit.ToString(), "']"));
				documentElement.RemoveChild(xmlNodes);
				xmlDocument.Save(str);
				MessageBox.Show("Value Deleted successfully");
				this.LoadCompanySettings();
                clearall();
			}
		}


        public void clearall()
        {
            compv.Text = "";
            comyear.Text = "";

        }
		private void comclab_SelectedIndexChanged(object sender, EventArgs e)
		{
            try
            {
                for (int i = 0; i < this.lIECDataTable.Rows.Count; i++)
                {
                    if (this.comclab.Text.Trim() == this.lIECDataTable.Rows[i]["IECName"].ToString().Trim())
                    {
                        this.datecertification.Text = this.lIECDataTable.Rows[i]["Date"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
			
		}

		private void CompanySettings_Load(object sender, EventArgs e)
		{
			this.AppIniPath = AppDomain.CurrentDomain.BaseDirectory;
			this.CreateTable();
			this.PopulateModule();
			this.GetYear();
			this.PopulateCountry();
			this.PopulatePVManufacturer();
			this.PopulateCellManufacturer();
			this.PopulateIECCertification();
			this.LoadCompanySettings();
		}

		private void CreateTable()
		{
			this.lCompanyTable = new DataTable();
			this.lCompanyTable.Columns.Add("ID");
			this.lCompanyTable.Columns.Add("Module Name");
			this.lCompanyTable.Columns.Add("Warranty");
			this.lCompanyTable.Columns.Add("PV Manufacturer");
			this.lCompanyTable.Columns.Add("PV Manufacturer Country");
			this.lCompanyTable.Columns.Add("PV Manufacturer Date");
			this.lCompanyTable.Columns.Add("Cell Manufacturer");
			this.lCompanyTable.Columns.Add("Cell Manufacturer Country");
			this.lCompanyTable.Columns.Add("Cell Manufacturer Date");
			this.lCompanyTable.Columns.Add("Certification Lab");
			this.lCompanyTable.Columns.Add("Certification Date");
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                DataGridViewRow owningRow = this.dataGridView1.CurrentCell.OwningRow;
                this.IDForEdit = int.Parse(owningRow.Cells[0].Value.ToString());
                this.compv.Text = owningRow.Cells[1].Value.ToString();
                this.comyear.Text = owningRow.Cells[2].Value.ToString();
                this.compvmname.Text = owningRow.Cells[3].Value.ToString();
                this.comcountry.Text = owningRow.Cells[4].Value.ToString();
                this.datepv.Text = owningRow.Cells[5].Value.ToString();
                this.comcellmName.Text = owningRow.Cells[6].Value.ToString();
                this.comcountry1.Text = owningRow.Cells[7].Value.ToString();
                this.datecell.Text = owningRow.Cells[8].Value.ToString();
                this.comclab.Text = owningRow.Cells[9].Value.ToString();
                this.datecertification.Text = owningRow.Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
			
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private int GetID()
		{
			try
			{
				string str = string.Concat(this.AppIniPath, "XMLCompanySettings.xml");
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(str);
				for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
				{
					if (i == dataSet.Tables[0].Rows.Count - 1)
					{
						this.CSID = int.Parse(dataSet.Tables[0].Rows[i][0].ToString());
					}
				}
			}
			catch (Exception exception)
			{
				this.CSID = 0;
			}
			return this.CSID;
		}

		private void GetYear()
		{
			for (int i = 1; i < 30; i++)
			{
				this.comyear.Items.Add(i.ToString());
			}
		}

		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanySettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.datecertification = new System.Windows.Forms.DateTimePicker();
            this.comclab = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.datecell = new System.Windows.Forms.DateTimePicker();
            this.comcountry1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comcellmName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.datepv = new System.Windows.Forms.DateTimePicker();
            this.comcountry = new System.Windows.Forms.ComboBox();
            this.compvmname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comyear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 519);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(8, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1015, 206);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(7, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(995, 187);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(6, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 280);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(701, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(929, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.datecertification);
            this.groupBox7.Controls.Add(this.comclab);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(9, 197);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(452, 79);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "IEC Certification";
            // 
            // datecertification
            // 
            this.datecertification.CustomFormat = "";
            this.datecertification.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datecertification.Location = new System.Drawing.Point(157, 48);
            this.datecertification.Name = "datecertification";
            this.datecertification.Size = new System.Drawing.Size(231, 20);
            this.datecertification.TabIndex = 1;
            // 
            // comclab
            // 
            this.comclab.FormattingEnabled = true;
            this.comclab.Location = new System.Drawing.Point(157, 20);
            this.comclab.Name = "comclab";
            this.comclab.Size = new System.Drawing.Size(231, 21);
            this.comclab.TabIndex = 0;
            this.comclab.SelectedIndexChanged += new System.EventHandler(this.comclab_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Certification Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Certification Lab";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.datecell);
            this.groupBox6.Controls.Add(this.comcountry1);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.comcellmName);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(479, 69);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(457, 121);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cell Manufacturer Details";
            // 
            // datecell
            // 
            this.datecell.CustomFormat = "M/yyyy";
            this.datecell.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datecell.Location = new System.Drawing.Point(193, 92);
            this.datecell.Name = "datecell";
            this.datecell.Size = new System.Drawing.Size(232, 20);
            this.datecell.TabIndex = 2;
            // 
            // comcountry1
            // 
            this.comcountry1.FormattingEnabled = true;
            this.comcountry1.Location = new System.Drawing.Point(193, 57);
            this.comcountry1.Name = "comcountry1";
            this.comcountry1.Size = new System.Drawing.Size(231, 21);
            this.comcountry1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Month of Manufacture";
            // 
            // comcellmName
            // 
            this.comcellmName.FormattingEnabled = true;
            this.comcellmName.Location = new System.Drawing.Point(194, 25);
            this.comcellmName.Name = "comcellmName";
            this.comcellmName.Size = new System.Drawing.Size(231, 21);
            this.comcellmName.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Manufacturer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Country of Origin";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.datepv);
            this.groupBox5.Controls.Add(this.comcountry);
            this.groupBox5.Controls.Add(this.compvmname);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(8, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(453, 124);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PV Module Manufacturer Details";
            // 
            // datepv
            // 
            this.datepv.CustomFormat = "";
            this.datepv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepv.Location = new System.Drawing.Point(190, 91);
            this.datepv.Name = "datepv";
            this.datepv.Size = new System.Drawing.Size(232, 20);
            this.datepv.TabIndex = 2;
            // 
            // comcountry
            // 
            this.comcountry.FormattingEnabled = true;
            this.comcountry.Location = new System.Drawing.Point(190, 56);
            this.comcountry.Name = "comcountry";
            this.comcountry.Size = new System.Drawing.Size(231, 21);
            this.comcountry.TabIndex = 1;
            // 
            // compvmname
            // 
            this.compvmname.FormattingEnabled = true;
            this.compvmname.Location = new System.Drawing.Point(191, 24);
            this.compvmname.Name = "compvmname";
            this.compvmname.Size = new System.Drawing.Size(231, 21);
            this.compvmname.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Month of Manufacture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Country of Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manufacturer Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comyear);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.compv);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(164, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(631, 52);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(540, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Years";
            // 
            // comyear
            // 
            this.comyear.FormattingEnabled = true;
            this.comyear.Location = new System.Drawing.Point(423, 15);
            this.comyear.Name = "comyear";
            this.comyear.Size = new System.Drawing.Size(105, 21);
            this.comyear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(343, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Warranty";
            // 
            // compv
            // 
            this.compv.FormattingEnabled = true;
            this.compv.Location = new System.Drawing.Point(143, 16);
            this.compv.Name = "compv";
            this.compv.Size = new System.Drawing.Size(182, 21);
            this.compv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PV Module Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompanySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1058, 530);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompanySettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanySettings";
            this.Load += new System.EventHandler(this.CompanySettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}

		private void LoadCompanySettings()
		{
			try
			{
				string str = string.Concat(this.AppIniPath, "XMLCompanySettings.xml");
				this.lCompanyTable.Rows.Clear();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(str);
				for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
				{
					DataRow dataRow = this.lCompanyTable.NewRow();
					dataRow[0] = dataSet.Tables[0].Rows[i][0].ToString();
					dataRow[1] = dataSet.Tables[0].Rows[i][1].ToString();
					dataRow[2] = dataSet.Tables[0].Rows[i][2].ToString();
					dataRow[3] = dataSet.Tables[0].Rows[i][3].ToString();
					dataRow[4] = dataSet.Tables[0].Rows[i][4].ToString();
					dataRow[5] = dataSet.Tables[0].Rows[i][5].ToString();
					dataRow[6] = dataSet.Tables[0].Rows[i][6].ToString();
					dataRow[7] = dataSet.Tables[0].Rows[i][7].ToString();
					dataRow[8] = dataSet.Tables[0].Rows[i][8].ToString();
					dataRow[9] = dataSet.Tables[0].Rows[i][9].ToString();
					dataRow[10] = dataSet.Tables[0].Rows[i][10].ToString();
					this.lCompanyTable.Rows.Add(dataRow);
				}
				this.lCS.DataSource = this.lCompanyTable;
				this.dataGridView1.DataSource = this.lCS;
			}
			catch (Exception exception)
			{
			}
		}

		private void PopulateCellManufacturer()
		{
			string str = string.Concat(this.AppIniPath, "\\XMLCellMFG.xml");
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(str);
			for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
			{
				this.comcellmName.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
			}
		}

		private void PopulateCountry()
		{
			string str = string.Concat(this.AppIniPath, "\\XMLCountry.xml");
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(str);
			for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
			{
				this.comcountry.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
				this.comcountry1.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
			}
		}

		private void PopulateIECCertification()
		{
			string str = string.Concat(this.AppIniPath, "\\XMLIEC.xml");
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(str);
			for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
			{
				this.comclab.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
			}
			this.lIECDataTable = dataSet.Tables[0];
		}

		private void PopulateModule()
		{
			string str = string.Concat(this.AppIniPath, "XMLModule.xml");
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(str);
			for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
			{
				this.compv.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
			}
		}

		private void PopulatePVManufacturer()
		{
			string str = string.Concat(this.AppIniPath, "\\XMLModuleMFG.xml");
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(str);
			for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
			{
				this.compvmname.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
			}
		}

		private void UpdateXml()
		{
			string str = string.Concat(this.AppIniPath, "\\XMLCompanySettings.xml");
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(str);
			foreach (XmlNode xmlNodes in xmlDocument.SelectSingleNode("CompanySettings"))
			{
				if (xmlNodes.Name == "Company")
				{
					foreach (XmlNode text in xmlDocument.SelectSingleNode("CompanySettings/Company"))
					{
						if (text.Name == "PVModule")
						{
							text.InnerXml = this.compv.Text;
						}
					}
				}
			}
		}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}