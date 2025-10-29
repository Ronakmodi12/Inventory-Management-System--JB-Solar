using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ArkaGreenPowerPvtLtd
{
    public class Module : Form
    {
        private IContainer components = null;
        private BindingSource lCS = new BindingSource();
        private Button button1;
        private int IDForEdit;
        private Label label1;
        private string AppIniPath;
        private TextBox txtcomman;

        private GroupBox groupBox3;

        private GroupBox groupBox2;

        private GroupBox groupBox1;
        private DataTable lCompanyTable;
        private DataGrid dataGrid1;
        private Button button2;
        private string lPath;
        private string indice;

        public Module()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(this.lPath);
            XmlElement xmlElement = xmlDocument.CreateElement("ModuleName");
            xmlElement.InnerText = this.txtcomman.Text.Trim();
            xmlDocument.DocumentElement.AppendChild(xmlElement);
            xmlDocument.Save(this.lPath);
            MessageBox.Show("Record Added Successfully");
            this.LoadModule();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Module));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcomman = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(132, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Name";
            // 
            // txtcomman
            // 
            this.txtcomman.ForeColor = System.Drawing.Color.Black;
            this.txtcomman.Location = new System.Drawing.Point(131, 19);
            this.txtcomman.Name = "txtcomman";
            this.txtcomman.Size = new System.Drawing.Size(205, 20);
            this.txtcomman.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(6, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 212);
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
            this.dataGrid1.CaptionText = "Module Name List";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Maroon;
            this.dataGrid1.Location = new System.Drawing.Point(6, 13);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(344, 193);
            this.dataGrid1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtcomman);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(213, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Name";
            // 
            // Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(406, 343);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Module";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Module_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void LoadModule()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(this.lPath);
                this.dataGrid1.DataSource = ds;
                //this.dataGridView1.DataSource = ds;
            }
            catch (Exception exception)
            {
            }

        }
        private void CreateTable()
        {
            this.lCompanyTable = new DataTable();
             
            this.lCompanyTable.Columns.Add("Module Name");
            
        }
        private void Module_Load(object sender, EventArgs e)
        {
           // CreateTable();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            this.lPath = string.Concat(baseDirectory, "XMLModule.xml");
            this.LoadModule();
        }
        



        private void button2_Click(object sender, EventArgs e)
        {
            //XmlDocument xmldoc = new XmlDocument();
            //xmldoc.Load("XMLModule.xml");

            //XmlNode xmlnode = xmldoc.DocumentElement.ChildNodes.Item(Convert.ToInt16(indice));
            //xmlnode.ParentNode.RemoveChild(xmlnode);

            //xmldoc.Save("XMLModule.xml");
            //MessageBox.Show("delete successfully..!");
            //this.LoadModule();
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow owningRow = this.dataGridView1.CurrentCell.OwningRow;
            
            //this.txtcomman.Text = owningRow.Cells[0].Value.ToString();
            
        }
    }
}