using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using ZedGraph;

namespace ArkaGreenPowerPvtLtd
{
	public class CurveGraph : Form
	{
		private IContainer components = null;

		private ZedGraphControl zg1;

		private TextBox txtvoltagecurrent;

		private TextBox txtcv;

		private GroupBox groupBox1;

		private System.Windows.Forms.Label label12;

		private System.Windows.Forms.Label label11;

		private System.Windows.Forms.Label label10;

		private System.Windows.Forms.Label label9;

		private System.Windows.Forms.Label label8;

		private TextBox txtYUnit;

		private TextBox txtXUnit;

		private Button cmdBarGraph;

		private System.Windows.Forms.Label label7;

		private System.Windows.Forms.Label label5;

		private TextBox txtYTitle;

		private TextBox txtXTitle;

		private TextBox txtPlotTitle;

		private TextBox txtLineBarPlotData;

		private System.Windows.Forms.Label label6;

		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label1;

		private Button cmdLinePlot;

		private TextBox textBox3;

		private TextBox textBox4;

		private TextBox textBox5;

		private TextBox textBox1;

		private TextBox textBox2;

		public GraphPane m_graphPane;

		private string m_plotString;

		private PointPairList m_pointsList;

		public TextBox t1 = new TextBox();

		public CurveGraph()
		{
			this.InitializeComponent();
			this.m_graphPane = this.zg1.GraphPane;
			this.FillPaneBackground();
		}

		private void CreateLineGraph()
		{
			this.m_graphPane.CurveList.Clear();
			string str = "";
			string str1 = "";
			string str2 = "";
			this.SetLineBarTitleAndAxisDetails(ref str, ref str1, ref str2);
			this.m_graphPane.Title.Text = str;
			this.m_graphPane.XAxis.Title.Text = str1;
			this.m_graphPane.YAxis.Title.Text = str2;
			this.m_graphPane.AddCurve("Graph", this.m_pointsList, Color.Blue, SymbolType.Star);
			this.zg1.AxisChange();
		}

		private void CurveGraph_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtcv.Text = this.t1.Text;
				this.ProcessPointsData();
				this.CreateLineGraph();
				this.SetSize();
			}
			catch (Exception exception)
			{
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

		private void FillPaneBackground()
		{
			this.m_graphPane.Chart.Fill = new Fill(Color.DarkGray, Color.LightGoldenrodYellow, 45f);
			this.m_graphPane.Fill = new Fill(Color.Red, Color.FromArgb(220, 220, 255), 45f);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurveGraph));
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.txtvoltagecurrent = new System.Windows.Forms.TextBox();
            this.txtcv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYUnit = new System.Windows.Forms.TextBox();
            this.txtXUnit = new System.Windows.Forms.TextBox();
            this.cmdBarGraph = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYTitle = new System.Windows.Forms.TextBox();
            this.txtXTitle = new System.Windows.Forms.TextBox();
            this.txtPlotTitle = new System.Windows.Forms.TextBox();
            this.txtLineBarPlotData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLinePlot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zg1
            // 
            this.zg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zg1.ForeColor = System.Drawing.Color.Black;
            this.zg1.Location = new System.Drawing.Point(0, 167);
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(543, 324);
            this.zg1.TabIndex = 1;
            // 
            // txtvoltagecurrent
            // 
            this.txtvoltagecurrent.BackColor = System.Drawing.Color.White;
            this.txtvoltagecurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvoltagecurrent.ForeColor = System.Drawing.Color.Maroon;
            this.txtvoltagecurrent.Location = new System.Drawing.Point(307, 14);
            this.txtvoltagecurrent.Name = "txtvoltagecurrent";
            this.txtvoltagecurrent.Size = new System.Drawing.Size(199, 20);
            this.txtvoltagecurrent.TabIndex = 18;
            this.txtvoltagecurrent.Text = "Voltage(V)              Current(I)";
            // 
            // txtcv
            // 
            this.txtcv.BackColor = System.Drawing.Color.White;
            this.txtcv.ForeColor = System.Drawing.Color.Maroon;
            this.txtcv.Location = new System.Drawing.Point(307, 33);
            this.txtcv.Multiline = true;
            this.txtcv.Name = "txtcv";
            this.txtcv.ReadOnly = true;
            this.txtcv.Size = new System.Drawing.Size(199, 115);
            this.txtcv.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcv);
            this.groupBox1.Controls.Add(this.txtvoltagecurrent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 154);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph Value";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.ForeColor = System.Drawing.Color.Maroon;
            this.textBox3.Location = new System.Drawing.Point(114, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "I";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.ForeColor = System.Drawing.Color.Maroon;
            this.textBox4.Location = new System.Drawing.Point(114, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "V";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.ForeColor = System.Drawing.Color.Maroon;
            this.textBox5.Location = new System.Drawing.Point(114, 67);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Current";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(113, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "Voltage";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(113, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "PV Module Graph";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Y Axis Unit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "X Axis Unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Y Axis Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "X Axis Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Plot Title";
            // 
            // txtYUnit
            // 
            this.txtYUnit.Location = new System.Drawing.Point(73, 111);
            this.txtYUnit.Name = "txtYUnit";
            this.txtYUnit.Size = new System.Drawing.Size(100, 20);
            this.txtYUnit.TabIndex = 6;
            // 
            // txtXUnit
            // 
            this.txtXUnit.Location = new System.Drawing.Point(73, 85);
            this.txtXUnit.Name = "txtXUnit";
            this.txtXUnit.Size = new System.Drawing.Size(100, 20);
            this.txtXUnit.TabIndex = 5;
            // 
            // cmdBarGraph
            // 
            this.cmdBarGraph.Location = new System.Drawing.Point(438, 113);
            this.cmdBarGraph.Name = "cmdBarGraph";
            this.cmdBarGraph.Size = new System.Drawing.Size(75, 23);
            this.cmdBarGraph.TabIndex = 9;
            this.cmdBarGraph.Text = "Bar Graph";
            this.cmdBarGraph.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(331, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 52);
            this.label7.TabIndex = 15;
            this.label7.Text = "Paste Two Columns of \r\nNumerical Values from a \r\nspreadsheet to Plot Data field. " +
    "\r\nPlot Line Graph or Bar Graph";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Y Axis Unit";
            // 
            // txtYTitle
            // 
            this.txtYTitle.Location = new System.Drawing.Point(73, 59);
            this.txtYTitle.Name = "txtYTitle";
            this.txtYTitle.Size = new System.Drawing.Size(100, 20);
            this.txtYTitle.TabIndex = 4;
            // 
            // txtXTitle
            // 
            this.txtXTitle.Location = new System.Drawing.Point(73, 33);
            this.txtXTitle.Name = "txtXTitle";
            this.txtXTitle.Size = new System.Drawing.Size(100, 20);
            this.txtXTitle.TabIndex = 3;
            // 
            // txtPlotTitle
            // 
            this.txtPlotTitle.Location = new System.Drawing.Point(73, 7);
            this.txtPlotTitle.Name = "txtPlotTitle";
            this.txtPlotTitle.Size = new System.Drawing.Size(100, 20);
            this.txtPlotTitle.TabIndex = 2;
            // 
            // txtLineBarPlotData
            // 
            this.txtLineBarPlotData.Location = new System.Drawing.Point(188, 33);
            this.txtLineBarPlotData.Multiline = true;
            this.txtLineBarPlotData.Name = "txtLineBarPlotData";
            this.txtLineBarPlotData.Size = new System.Drawing.Size(135, 98);
            this.txtLineBarPlotData.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y Axis Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Plot Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X Axis Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X Axis Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plot Title";
            // 
            // cmdLinePlot
            // 
            this.cmdLinePlot.Location = new System.Drawing.Point(357, 113);
            this.cmdLinePlot.Name = "cmdLinePlot";
            this.cmdLinePlot.Size = new System.Drawing.Size(75, 23);
            this.cmdLinePlot.TabIndex = 8;
            this.cmdLinePlot.Text = "Line Plot";
            this.cmdLinePlot.UseVisualStyleBackColor = true;
            // 
            // CurveGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zg1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurveGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurveGraph";
            this.Load += new System.EventHandler(this.CurveGraph_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		private void ProcessPointsData()
		{
			this.m_plotString = this.t1.Text;
			List<string[]> strArrays = new List<string[]>();
			string mPlotString = this.m_plotString;
			char[] chrArray = new char[] { '\n' };
			string[] strArrays1 = mPlotString.Split(chrArray);
			this.m_pointsList = new PointPairList();
			for (int i = 0; i < (int)strArrays1.Length; i++)
			{
				string str = strArrays1[i].Replace("\r", "");
				str = str.Trim();
				if (str != "")
				{
					chrArray = new char[] { '\t' };
					string[] strArrays2 = str.Split(chrArray);
					double num = Convert.ToDouble(strArrays2[0]);
					double num1 = Convert.ToDouble(strArrays2[1]);
					this.m_pointsList.Add(num, num1);
				}
			}
		}

		private void SetLineBarTitleAndAxisDetails(ref string _graphTitle, ref string _xTitle, ref string _yTitle)
		{
			_graphTitle = "Graph";
			string str = "Voltage";
			string str1 = "Current";
			string str2 = "V";
			string str3 = "I";
			if (_graphTitle == "")
			{
				_graphTitle = "Graph";
			}
			if (str == "")
			{
				_xTitle = "X Axis";
			}
			if (str1 == "")
			{
				_yTitle = "Y Axis";
			}
			if (str2 != "")
			{
				_xTitle = string.Concat(str, " (", str2, " )");
			}
			if (str3 != "")
			{
				_yTitle = string.Concat(str1, " (", str3, " )");
			}
		}

		private void SetSize()
		{
			this.zg1.Location = new Point(5, 168);
			ZedGraphControl size = this.zg1;
			Rectangle clientRectangle = base.ClientRectangle;
			int width = clientRectangle.Width - 10;
			clientRectangle = base.ClientRectangle;
			size.Size = new System.Drawing.Size(width, clientRectangle.Height - 168);
		}
	}
}