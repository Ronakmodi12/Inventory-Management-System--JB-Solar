using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace ArkaGreenPowerPvtLtd
{
	public class DatewiseReport : Form
	{
		private IContainer components = null;

		private GroupBox groupBox1;

		private GroupBox groupBox3;

		private DataGridView dataGridView1;

		private GroupBox groupBox2;

		private Button button1;

		private Label label1;

		private DateTimePicker dateTimePicker1;

		private string lPath;

		private BindingSource lSource = new BindingSource();
        private Button btnExport;
        private DataTable lXMLTagTable;

		public DatewiseReport()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.LoadReport(this.dateTimePicker1.Text.Trim());
		}

		private void CreateTable()
		{
			this.lXMLTagTable = new DataTable();
			this.lXMLTagTable.Columns.Add("Module No");
			this.lXMLTagTable.Columns.Add("Serial No");
			this.lXMLTagTable.Columns.Add("PMax");
			this.lXMLTagTable.Columns.Add("VMax");
			this.lXMLTagTable.Columns.Add("IMax");
            this.lXMLTagTable.Columns.Add("Isc");
            this.lXMLTagTable.Columns.Add("Voc");
            this.lXMLTagTable.Columns.Add("Fill Factor");
            this.lXMLTagTable.Columns.Add("Unique ID");
        }

		private void DatewiseReport_Load(object sender, EventArgs e)
		{
			this.lPath = string.Concat(Environment.CurrentDirectory, "\\XMLTag.xml");
			this.CreateTable();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatewiseReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 428);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Report";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(6, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1020, 347);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 55);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 8, 27, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(457, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Date";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Green;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExport.Location = new System.Drawing.Point(924, 436);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(114, 39);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DatewiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1050, 487);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatewiseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatewiseReport";
            this.Load += new System.EventHandler(this.DatewiseReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		private void LoadReport(string strDate)
		{
			try
			{
				this.lXMLTagTable.Rows.Clear();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(this.lPath);
				for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
				{
					if (strDate.ToString().Trim() == dataSet.Tables[0].Rows[i]["WDate"].ToString().Trim())
					{
						DataRow str = this.lXMLTagTable.NewRow();
						str[0] = dataSet.Tables[0].Rows[i][1].ToString();
						str[1] = dataSet.Tables[0].Rows[i][2].ToString();
						str[2] = dataSet.Tables[0].Rows[i][5].ToString();
						str[3] = dataSet.Tables[0].Rows[i][7].ToString();
						str[4] = dataSet.Tables[0].Rows[i][6].ToString();
						str[5] = dataSet.Tables[0].Rows[i][3].ToString();
                        str[6] = dataSet.Tables[0].Rows[i][4].ToString();
                        str[7] = dataSet.Tables[0].Rows[i][8].ToString();
                        str[8] = dataSet.Tables[0].Rows[i][10].ToString();
						this.lXMLTagTable.Rows.Add(str);
					}
				}
				this.lSource.DataSource = this.lXMLTagTable;
				this.dataGridView1.DataSource = this.lSource;


                dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToResizeColumns = true;
            }
			catch (Exception exception)
			{
			}
		}

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Get details should be done first.", "Report warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to export.", "Report warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            StringBuilder sb = new StringBuilder();
            // Column headers
            string columnsHeader = "";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                columnsHeader += dataGridView1.Columns[i].Name + ",";
            }
            sb.Append(columnsHeader + Environment.NewLine);
            // Go through each cell in the datagridview
            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                // Make sure it's not an empty row.
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        // Append the cells data followed by a comma to delimit.

                        sb.Append(dgvRow.Cells[c].Value + ",");
                    }
                    // Add a new line in the text file.
                    sb.Append(Environment.NewLine);
                }
            }
            // Load up the save file dialog with the default option as saving as a .csv file.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";

            // sfd.FileName = Convert.ToString(System.DateTime.Now);
            DateTime dateAndTime = DateTime.Now;
           // sfd.FileName = (dateAndTime.ToString("dd/MM/yyyy"));
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // If they've selected a save location...
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, true))
                {
                    // Write the stringbuilder text to the the file.
                    sw.WriteLine(sb.ToString());
                }

                // Confirm to the user it has been completed.
                MessageBox.Show("CSV file saved.", "Report Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}