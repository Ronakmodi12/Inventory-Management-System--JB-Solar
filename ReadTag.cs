using ReaderB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace ArkaGreenPowerPvtLtd
{
	public class ReadTag : Form
	{
		private IContainer components = null;

		private GroupBox groupBox1;

		private GroupBox groupBox2;

		private System.Windows.Forms.Label lblsno;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.Label lblmno;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label lblCellMName;

		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Label lblPVMName;

		private System.Windows.Forms.Label label6;

		private System.Windows.Forms.Label lblcelldate;

		private System.Windows.Forms.Label label8;

		private System.Windows.Forms.Label lblPVdate;

		private System.Windows.Forms.Label label10;

		private System.Windows.Forms.Label lblVmax;

		private System.Windows.Forms.Label label12;

		private System.Windows.Forms.Label lblPmax;

		private System.Windows.Forms.Label label14;

		private System.Windows.Forms.Label lblcellcountry;

		private System.Windows.Forms.Label label16;

		private System.Windows.Forms.Label lblPVcountry;

		private System.Windows.Forms.Label label18;

		private System.Windows.Forms.Label lblIecdate;

		private System.Windows.Forms.Label label20;

		private System.Windows.Forms.Label lblIEClab;

		private System.Windows.Forms.Label label22;

		private System.Windows.Forms.Label lblff;

		private System.Windows.Forms.Label label24;

		private System.Windows.Forms.Label lblImax;

		private System.Windows.Forms.Label label26;

		private Button button1;

		private TextBox txtcurve;

		private TextBox txtvoltagecurrent;

		private Button button2;

		private System.Windows.Forms.Label lbleff;

		private System.Windows.Forms.Label label13;

		private System.Windows.Forms.Label lblisc;

		private System.Windows.Forms.Label label9;

		private System.Windows.Forms.Label lblvoc;

		private System.Windows.Forms.Label label5;

		private GroupBox groupBox3;

		private ZedGraphControl zg1;

		private TextBox maskadr_textbox = new TextBox();

		private TextBox Edit_WordPtr = new TextBox();

		private TextBox maskLen_textBox = new TextBox();

		private TextBox textbox1 = new TextBox();

		private TextBox txtUID = new TextBox();

		private string ReadRfidTagValue;

		private string AppIniPath;

		private GraphPane m_graphPane;

		private string m_plotString;

		private PointPairList m_pointsList;

		private string strV1;

		private string strI1;

		private string strV2;

		private string strI2;

		private string strV3;

		private string strI3;

		private string strV4;

		private string strI4;

		private string strV5;

		private string strI5;

		private string strI6;

		private string strV6;

		private string strI7;

		private string strV7;

		private string strI8;

		private string strV8;

		private string strV10;

		private string strI10;

		private string strV9;

		private string strI9;

		private double lVoc;

		private double lIsc;

		private double lVmp;

		private double lImp;

		private string V1;

		private string V2;

		private string V3;

		private string V4;

		private string V5;

		private string V6;

		private string V7;

		private string V8;

		private string V9;

		private string V10;

		private string C1;

		private string C2;

		private string C3;

		private string C4;

		private string C5;

		private string C6;

		private string C7;

		private string C8;

		private string C9;

		private string C10;

		public ReadTag()
		{
			this.InitializeComponent();
			this.m_graphPane = this.zg1.GraphPane;
			this.FillPaneBackground();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.GetRFIDTagID();
				if (this.txtUID.Text != "")
				{
					string str = this.ReadTagValue();
					if ((str == "" ? false : str != null))
					{
						this.GetXMLValue(str);
						this.PopulateGraphValue(this.lVmp, this.lImp, this.lVoc, this.lIsc);
						this.SetCurveValue();
						this.ProcessPointsData();
						this.CreateLineGraph();
						this.SetSize();
						this.ReadRfidTagValue = "";
					}
				}
			}
			catch (Exception exception)
			{
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.lblvoc.Text = "";
			this.lblisc.Text = "";
			this.lbleff.Text = "";
			this.lblcellcountry.Text = "";
			this.lblcelldate.Text = "";
			this.lblCellMName.Text = "";
			this.lblff.Text = "";
			this.lblIecdate.Text = "";
			this.lblIEClab.Text = "";
			this.lblImax.Text = "";
			this.lblmno.Text = "";
			this.lblPmax.Text = "";
			this.lblPVcountry.Text = "";
			this.lblPVdate.Text = "";
			this.lblPVMName.Text = "";
			this.lblVmax.Text = "";
			this.lblsno.Text = "";
            this.txtUID.Text = "";
            zg1.GraphPane.CurveList.Clear();
            zg1.GraphPane.GraphObjList.Clear();
            zg1.Refresh();
		}

		private string ByteArrayToHexString(byte[] data)
		{
			StringBuilder stringBuilder = new StringBuilder((int)data.Length * 3);
			byte[] numArray = data;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				byte num = numArray[i];
				stringBuilder.Append(Convert.ToString(num, 16).PadLeft(2, '0'));
			}
			return stringBuilder.ToString().ToUpper();
		}

		public string ConvertHexToString(string HexValue)
		{
			string str = "";
			while (HexValue.Length > 0)
			{
				char chr = Convert.ToChar(Convert.ToUInt32(HexValue.Substring(0, 2), 16));
				str = string.Concat(str, chr.ToString());
				HexValue = HexValue.Substring(2, HexValue.Length - 2);
			}
			return str;
		}

		private void CreateLineGraph()
		{

            //clear if anything exists.            
            m_graphPane.CurveList.Clear();

            string _graphTitle = "", _xTitle = "", _yTitle = "";

            // Set the titles and axis labels
            SetLineBarTitleAndAxisDetails(ref _graphTitle, ref _xTitle, ref _yTitle);
            m_graphPane.Title.Text = _graphTitle;
            m_graphPane.XAxis.Title.Text = _xTitle;
            m_graphPane.YAxis.Title.Text = _yTitle;

            // Generate a blue curve with Star symbols
            LineItem myCurve = m_graphPane.AddCurve("PV Module Graph", m_pointsList, Color.DarkGreen, SymbolType.Star);


            // Calculate the Axis Scale Ranges
            zg1.AxisChange();

            //this.m_graphPane.CurveList.Clear();
            //string str = "";
            //string str1 = "";
            //string str2 = "";
            //this.SetLineBarTitleAndAxisDetails(ref str, ref str1, ref str2);
            //this.m_graphPane.Title.Text = str;
            //this.m_graphPane.XAxis.Title.Text = str1;
            //this.m_graphPane.YAxis.Title.Text = str2;
            //this.m_graphPane.AddCurve("PV Module Graph", this.m_pointsList, Color.Blue, SymbolType.Star);
            //this.zg1.AxisChange();
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

		private void GetRFIDTagID()
		{
			int num = 0;
			int num1 = 0;
			byte[] numArray = new byte[5000];
			byte num2 = 0;
			byte num3 = 0;
			byte num4 = 0;
			FrmMain.fCmdRet = StaticClassReaderB.Inventory_G2(ref FrmMain.fComAdr, num2, num3, num4, numArray, ref num1, ref num, FrmMain.frmcomportindex);
			if (FrmMain.fCmdRet == 1 | FrmMain.fCmdRet == 2 | FrmMain.fCmdRet == 3 | FrmMain.fCmdRet == 4 | FrmMain.fCmdRet == 251)
			{
				byte[] numArray1 = new byte[num1];
				Array.Copy(numArray, numArray1, num1);
				string hexString = this.ByteArrayToHexString(numArray1);
				int num5 = 0;
				if (num != 0)
				{
					for (int i = 0; i < num; i++)
					{
						int num6 = numArray1[num5];
						string str = hexString.Substring(num5 * 2 + 2, num6 * 2);
						num5 = num5 + num6 + 1;
						if (str.Length == num6 * 2)
						{
							if (!false)
							{
								this.txtUID.Text = str;
							}
						}
					}
				}
			}
		}

		private int GetUID(string TID)
		{
			string str = TID.Substring(0, 32).ToString();
			str.ToCharArray();
			int num = 0;
			int num1 = 1;
			string str1 = str;
			for (int i = 0; i < str1.Length; i++)
			{
				char chr = str1[i];
				if (num1 >= 1)
				{
					if (chr != '0')
					{
						num1 = 0;
					}
					else
					{
						num++;
					}
				}
			}
			str = str.Substring(num, str.Length - num);
			string str2 = TID.Substring(32, 3);
			this.lblsno.Text = this.ConvertHexToString(str);
			return int.Parse(str2);
		}

		private string GetValuewithDecimal(string strExtVal)
		{
			string str = strExtVal.Substring(0, 2);
			string str1 = strExtVal.Substring(2, 2);
			string str2 = string.Concat(str, ".", str1);
			return Convert.ToDouble(str2).ToString();
		}

		private void GetXMLValue(string strTagID)
		{
			int uID = this.GetUID(strTagID);
			this.ReadPMax(strTagID);
			this.ReadVPM(strTagID);
			this.ReadIPM(strTagID);
			this.ReadFF(strTagID);
			this.ReadVoc(strTagID);
			this.ReadIsc(strTagID);
			this.ReadDate(strTagID);
            //string str = string.Concat(this.AppIniPath, "XMLCompanySettings.xml");
            string str = this.AppIniPath + "XMLCompanySettings.xml";
            DataSet dataSet = new DataSet();
			dataSet.ReadXml(str);
            //ClsCheck lCheck = new ClsCheck();
            //dataSet = lCheck.FillDataGrid("select * from T_EInfo where Eserial='" + txtUID.Text.Trim() + "'");
           // lCheck = null;
			for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
			{
                if (uID.ToString().Trim() == dataSet.Tables[0].Rows[i]["ID"].ToString().Trim())
                //if (uID > 0 && txtUID.Text != "")
                {
                    lblmno.Text = dataSet.Tables[0].Rows[i][1].ToString();
                    lblPVMName.Text = dataSet.Tables[0].Rows[i][3].ToString();
                    lblPVdate.Text = dataSet.Tables[0].Rows[i][5].ToString();
                    lblPVcountry.Text = dataSet.Tables[0].Rows[i][4].ToString();
                    lblCellMName.Text = dataSet.Tables[0].Rows[i][6].ToString();
                    lblcellcountry.Text = dataSet.Tables[0].Rows[i][7].ToString();
                    lblcelldate.Text = dataSet.Tables[0].Rows[i][8].ToString();
                    lblIEClab.Text = dataSet.Tables[0].Rows[i][9].ToString();
                    lblIecdate.Text = dataSet.Tables[0].Rows[i][10].ToString();
                }
                //if (uID.ToString().Trim() == dataSet.Tables[0].Rows[i]["ID"].ToString().Trim())
                //{
                //    this.lblmno.Text = dataSet.Tables[0].Rows[i][1].ToString();
                //    this.lblPVMName.Text = dataSet.Tables[0].Rows[i][3].ToString();
                //    this.lblPVcountry.Text = dataSet.Tables[0].Rows[i][5].ToString();
                //    this.lblCellMName.Text = dataSet.Tables[0].Rows[i][6].ToString();
                //    this.lblcellcountry.Text = dataSet.Tables[0].Rows[i][7].ToString();
                //    this.lblcelldate.Text = dataSet.Tables[0].Rows[i][8].ToString();
                //    this.lblIEClab.Text = dataSet.Tables[0].Rows[i][9].ToString();
                //    this.lblIecdate.Text = dataSet.Tables[0].Rows[i][10].ToString();
                //}
			}
		}

		private byte[] HexStringToByteArray(string s)
		{
			s = s.Replace(" ", "");
			byte[] num = new byte[s.Length / 2];
			for (int i = 0; i < s.Length; i = i + 2)
			{
				num[i / 2] = Convert.ToByte(s.Substring(i, 2), 16);
			}
			return num;
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcurve = new System.Windows.Forms.TextBox();
            this.txtvoltagecurrent = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbleff = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblisc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblvoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcellcountry = new System.Windows.Forms.Label();
            this.lblff = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblPVcountry = new System.Windows.Forms.Label();
            this.lblIecdate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblImax = new System.Windows.Forms.Label();
            this.lblmno = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVmax = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblIEClab = new System.Windows.Forms.Label();
            this.lblsno = new System.Windows.Forms.Label();
            this.lblPmax = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPVMName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCellMName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPVdate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblcelldate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtcurve);
            this.groupBox1.Controls.Add(this.txtvoltagecurrent);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtcurve
            // 
            this.txtcurve.BackColor = System.Drawing.Color.White;
            this.txtcurve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcurve.Location = new System.Drawing.Point(961, 532);
            this.txtcurve.Multiline = true;
            this.txtcurve.Name = "txtcurve";
            this.txtcurve.ReadOnly = true;
            this.txtcurve.Size = new System.Drawing.Size(199, 10);
            this.txtcurve.TabIndex = 19;
            this.txtcurve.Visible = false;
            // 
            // txtvoltagecurrent
            // 
            this.txtvoltagecurrent.BackColor = System.Drawing.Color.White;
            this.txtvoltagecurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvoltagecurrent.ForeColor = System.Drawing.Color.Black;
            this.txtvoltagecurrent.Location = new System.Drawing.Point(961, 522);
            this.txtvoltagecurrent.Name = "txtvoltagecurrent";
            this.txtvoltagecurrent.Size = new System.Drawing.Size(199, 20);
            this.txtvoltagecurrent.TabIndex = 20;
            this.txtvoltagecurrent.Text = "Voltage(V)              Current(I)";
            this.txtvoltagecurrent.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.zg1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(644, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 512);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IV Curve Graph";
            // 
            // zg1
            // 
            this.zg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.zg1.Location = new System.Drawing.Point(3, 68);
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(556, 441);
            this.zg1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbleff);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblisc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblvoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblcellcountry);
            this.groupBox2.Controls.Add(this.lblff);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.lblPVcountry);
            this.groupBox2.Controls.Add(this.lblIecdate);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblImax);
            this.groupBox2.Controls.Add(this.lblmno);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblVmax);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblIEClab);
            this.groupBox2.Controls.Add(this.lblsno);
            this.groupBox2.Controls.Add(this.lblPmax);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblPVMName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblCellMName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblPVdate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblcelldate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 518);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read Tag Details Specification";
            // 
            // lbleff
            // 
            this.lbleff.AutoSize = true;
            this.lbleff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbleff.Location = new System.Drawing.Point(158, 119);
            this.lbleff.Name = "lbleff";
            this.lbleff.Size = new System.Drawing.Size(48, 16);
            this.lbleff.TabIndex = 31;
            this.lbleff.Text = "Value";
            this.lbleff.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Effeciency";
            this.label13.Visible = false;
            // 
            // lblisc
            // 
            this.lblisc.AutoSize = true;
            this.lblisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblisc.Location = new System.Drawing.Point(461, 97);
            this.lblisc.Name = "lblisc";
            this.lblisc.Size = new System.Drawing.Size(48, 16);
            this.lblisc.TabIndex = 29;
            this.lblisc.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(330, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Current: Isc";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(307, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(46, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblvoc
            // 
            this.lblvoc.AutoSize = true;
            this.lblvoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblvoc.Location = new System.Drawing.Point(158, 98);
            this.lblvoc.Name = "lblvoc";
            this.lblvoc.Size = new System.Drawing.Size(48, 16);
            this.lblvoc.TabIndex = 27;
            this.lblvoc.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Current: Voc";
            // 
            // lblcellcountry
            // 
            this.lblcellcountry.AutoSize = true;
            this.lblcellcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcellcountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblcellcountry.Location = new System.Drawing.Point(429, 370);
            this.lblcellcountry.Name = "lblcellcountry";
            this.lblcellcountry.Size = new System.Drawing.Size(48, 16);
            this.lblcellcountry.TabIndex = 11;
            this.lblcellcountry.Text = "Value";
            // 
            // lblff
            // 
            this.lblff.AutoSize = true;
            this.lblff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblff.Location = new System.Drawing.Point(460, 74);
            this.lblff.Name = "lblff";
            this.lblff.Size = new System.Drawing.Size(48, 16);
            this.lblff.TabIndex = 19;
            this.lblff.Text = "Value";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(27, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(223, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Country Of Origin For Solar Cell";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(331, 76);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 16);
            this.label24.TabIndex = 18;
            this.label24.Text = "Fill Factor (FF)";
            // 
            // lblPVcountry
            // 
            this.lblPVcountry.AutoSize = true;
            this.lblPVcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPVcountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPVcountry.Location = new System.Drawing.Point(429, 345);
            this.lblPVcountry.Name = "lblPVcountry";
            this.lblPVcountry.Size = new System.Drawing.Size(48, 16);
            this.lblPVcountry.TabIndex = 9;
            this.lblPVcountry.Text = "Value";
            // 
            // lblIecdate
            // 
            this.lblIecdate.AutoSize = true;
            this.lblIecdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIecdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblIecdate.Location = new System.Drawing.Point(430, 318);
            this.lblIecdate.Name = "lblIecdate";
            this.lblIecdate.Size = new System.Drawing.Size(48, 16);
            this.lblIecdate.TabIndex = 23;
            this.lblIecdate.Text = "Value";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(25, 343);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(230, 16);
            this.label18.TabIndex = 8;
            this.label18.Text = "Country Of Origin For PV Module";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(26, 318);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(232, 16);
            this.label20.TabIndex = 22;
            this.label20.Text = "Date Of Obtaining IEC Certificate";
            // 
            // lblImax
            // 
            this.lblImax.AutoSize = true;
            this.lblImax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblImax.Location = new System.Drawing.Point(158, 76);
            this.lblImax.Name = "lblImax";
            this.lblImax.Size = new System.Drawing.Size(48, 16);
            this.lblImax.TabIndex = 17;
            this.lblImax.Text = "Value";
            // 
            // lblmno
            // 
            this.lblmno.AutoSize = true;
            this.lblmno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblmno.Location = new System.Drawing.Point(460, 33);
            this.lblmno.Name = "lblmno";
            this.lblmno.Size = new System.Drawing.Size(128, 16);
            this.lblmno.TabIndex = 3;
            this.lblmno.Text = "Module Serial No";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(24, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 16);
            this.label26.TabIndex = 16;
            this.label26.Text = "Current: I- max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module Name   ";
            // 
            // lblVmax
            // 
            this.lblVmax.AutoSize = true;
            this.lblVmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblVmax.Location = new System.Drawing.Point(460, 53);
            this.lblVmax.Name = "lblVmax";
            this.lblVmax.Size = new System.Drawing.Size(48, 16);
            this.lblVmax.TabIndex = 15;
            this.lblVmax.Text = "Value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(331, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Voltage: V-max";
            // 
            // lblIEClab
            // 
            this.lblIEClab.AutoSize = true;
            this.lblIEClab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIEClab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblIEClab.Location = new System.Drawing.Point(429, 295);
            this.lblIEClab.Name = "lblIEClab";
            this.lblIEClab.Size = new System.Drawing.Size(48, 16);
            this.lblIEClab.TabIndex = 21;
            this.lblIEClab.Text = "Value";
            // 
            // lblsno
            // 
            this.lblsno.AutoSize = true;
            this.lblsno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblsno.Location = new System.Drawing.Point(157, 34);
            this.lblsno.Name = "lblsno";
            this.lblsno.Size = new System.Drawing.Size(128, 16);
            this.lblsno.TabIndex = 1;
            this.lblsno.Text = "Module Serial No";
            // 
            // lblPmax
            // 
            this.lblPmax.AutoSize = true;
            this.lblPmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPmax.Location = new System.Drawing.Point(158, 54);
            this.lblPmax.Name = "lblPmax";
            this.lblPmax.Size = new System.Drawing.Size(48, 16);
            this.lblPmax.TabIndex = 13;
            this.lblPmax.Text = "Value";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(25, 296);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(312, 16);
            this.label22.TabIndex = 20;
            this.label22.Text = "Name of The IEC Certificate(Issueing Name)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(25, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Power: P-max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Serial No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name of The PV Module Manufacturer\r\n ";
            // 
            // lblPVMName
            // 
            this.lblPVMName.AutoSize = true;
            this.lblPVMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPVMName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPVMName.Location = new System.Drawing.Point(429, 196);
            this.lblPVMName.Name = "lblPVMName";
            this.lblPVMName.Size = new System.Drawing.Size(48, 16);
            this.lblPVMName.TabIndex = 1;
            this.lblPVMName.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name of The Solar Cell Manufacturer";
            // 
            // lblCellMName
            // 
            this.lblCellMName.AutoSize = true;
            this.lblCellMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellMName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCellMName.Location = new System.Drawing.Point(430, 225);
            this.lblCellMName.Name = "lblCellMName";
            this.lblCellMName.Size = new System.Drawing.Size(48, 16);
            this.lblCellMName.TabIndex = 3;
            this.lblCellMName.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Month /Year of The Module Manufacture\r\n";
            // 
            // lblPVdate
            // 
            this.lblPVdate.AutoSize = true;
            this.lblPVdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPVdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPVdate.Location = new System.Drawing.Point(430, 247);
            this.lblPVdate.Name = "lblPVdate";
            this.lblPVdate.Size = new System.Drawing.Size(48, 16);
            this.lblPVdate.TabIndex = 5;
            this.lblPVdate.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Month /Year Of The Solar Cell Manufacture\r\n";
            // 
            // lblcelldate
            // 
            this.lblcelldate.AutoSize = true;
            this.lblcelldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblcelldate.Location = new System.Drawing.Point(430, 270);
            this.lblcelldate.Name = "lblcelldate";
            this.lblcelldate.Size = new System.Drawing.Size(48, 16);
            this.lblcelldate.TabIndex = 7;
            this.lblcelldate.Text = "Value";
            // 
            // ReadTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1229, 548);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ReadTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadTag";
            this.Load += new System.EventHandler(this.ReadTag_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		private void PopulateGraphValue(double Vpm, double Ipm, double Voc, double Isc)
		{
            double lStart, lMiddle, lLast, lSecondLast, lCheck;
            lCheck = Math.Exp(Voc);
            lStart = 1 / (Isc - Ipm);
            lMiddle = Isc * Math.Exp(Voc - Vpm);
            lLast = Ipm * Math.Exp(Voc);
            lSecondLast = lStart * lMiddle;
            double lK = -(lSecondLast - lLast);
            double K;
            K = Math.Log(lK, 2.82);
            double B, A;
            B = Voc * K;
            A = Isc / (Math.Exp(-B) - 1);
            double lValue = Vpm / 5;
            double I;
            int lCount = 0;

            for (double V = lValue; V <= Vpm; V = V + lValue)
            {
                I = V * ((Ipm - Isc) / Vpm) + Isc;
                SetVoltageCurrent(V, I, lCount);
                lCount = lCount + 1;
            }
            double lValue1 = (Voc - Vpm) / 5;
            for (double V = Vpm + lValue1; V <= Voc; V = V + lValue1)
            {
                // double lVal = K * V;
                // double lVal1 = lVal - B;
                //  double lSet = Math.Exp(lVal1);
                I = ((V - Voc) * Ipm) / (Vpm - Voc);
                SetVoltageCurrent(V, I, lCount);
                lCount = lCount + 1;
            }

            this.V10 = string.Format("{0:0.00}",Voc);
            this.C10 = "0.00";

            //double ipm;
            //double i;
            //Math.Exp(Voc);
            //double isc = 1 / (Isc - Ipm);
            //double num = Isc * Math.Exp(Voc - Vpm);
            //double ipm1 = Ipm * Math.Exp(Voc);
            //double num1 = -(isc * num - ipm1);
            //double voc = Voc * Math.Log(num1, 2.82);
            //double isc1 = Isc / (Math.Exp(-voc) - 1);
            //double vpm = Voc / 5;
            //int num2 = 0;
            //for (i = vpm; i <= Voc; i = i + vpm)
            //{
            //    ipm = i * ((Isc - Ipm) / Vpm) + Isc;
            //    this.SetVoltageCurrent(i, ipm, num2);
            //    num2++;
            //}
            //double voc1 = (Vpm - Voc) / 5;
            //for (i = Voc + voc1; i <= Vpm; i = i + voc1)
            //{
            //    ipm = (i - Vpm) * Ipm / (Voc - Vpm);
            //    this.SetVoltageCurrent(i, ipm, num2);
            //    num2++;
            //}
		}

		private void ProcessPointsData()
		{
            m_plotString = txtcurve.Text;
            List<string[]> _pointsList = new List<string[]>();
            //'\n' refers to newLine character., using it as Delimter
            string[] _graphInputRows = m_plotString.Split('\n');

            m_pointsList = new PointPairList();
            for (int i = 0; i < _graphInputRows.Length; i++)
            {
                //"r" appears at the end., getting rid of it
                string _yValue = _graphInputRows[i].Replace("\r", "");
                _yValue = _yValue.Trim();
                if (_yValue != "")
                {
                    //'\t' refers to tab character., using it as Delimter
                    string[] _pointsTemp = _yValue.Split('\t');
                    double _x = Convert.ToDouble(_pointsTemp[0]);
                    double _y = Convert.ToDouble(_pointsTemp[1]);
                    m_pointsList.Add(_x, _y);
                }
            }


            //this.m_plotString = this.txtcurve.Text;
            //List<string[]> strArrays = new List<string[]>();
            //string mPlotString = this.m_plotString;
            //char[] chrArray = new char[] { '\n' };
            //string[] strArrays1 = mPlotString.Split(chrArray);
            //this.m_pointsList = new PointPairList();
            //for (int i = 0; i < (int)strArrays1.Length; i++)
            //{
            //    string str = strArrays1[i].Replace("\r", "");
            //    str = str.Trim();
            //    if (str != "")
            //    {
            //        chrArray = new char[] { '\t' };
            //        string[] strArrays2 = str.Split(chrArray);
            //        double num = Convert.ToDouble(strArrays2[0]);
            //        double num1 = Convert.ToDouble(strArrays2[1]);
            //        this.m_pointsList.Add(num, num1);
            //    }
            //}
		}

		private void ReadCurrentVoltage(string strReadValue)
		{
			int num = 48;
			for (int i = 0; i <= 19; i++)
			{
				string valuewithDecimal = this.GetValuewithDecimal(strReadValue.Substring(num, 4));
				if (i == 0)
				{
					this.strV1 = valuewithDecimal;
				}
				else if (i == 1)
				{
					this.strI1 = valuewithDecimal;
				}
				else if (i == 2)
				{
					this.strV2 = valuewithDecimal;
				}
				else if (i == 3)
				{
					this.strI2 = valuewithDecimal;
				}
				else if (i == 4)
				{
					this.strV3 = valuewithDecimal;
				}
				else if (i == 5)
				{
					this.strI3 = valuewithDecimal;
				}
				else if (i == 6)
				{
					this.strV4 = valuewithDecimal;
				}
				else if (i == 7)
				{
					this.strI4 = valuewithDecimal;
				}
				else if (i == 8)
				{
					this.strV5 = valuewithDecimal;
				}
				else if (i == 9)
				{
					this.strI5 = valuewithDecimal;
				}
				else if (i == 10)
				{
					this.strV6 = valuewithDecimal;
				}
				else if (i == 11)
				{
					this.strI6 = valuewithDecimal;
				}
				else if (i == 12)
				{
					this.strV7 = valuewithDecimal;
				}
				else if (i == 13)
				{
					this.strI7 = valuewithDecimal;
				}
				else if (i == 14)
				{
					this.strV8 = valuewithDecimal;
				}
				else if (i == 15)
				{
					this.strI8 = valuewithDecimal;
				}
				else if (i == 16)
				{
					this.strV9 = valuewithDecimal;
				}
				else if (i == 17)
				{
					this.strI9 = valuewithDecimal;
				}
				else if (i == 18)
				{
					this.strV10 = valuewithDecimal;
				}
				else if (i == 19)
				{
					if (!(valuewithDecimal == "0"))
					{
						this.strI10 = valuewithDecimal;
					}
					else
					{
						this.strI10 = "0.00";
					}
				}
				num = num + 4;
				valuewithDecimal = "";
			}
			string str = string.Concat(this.strV1, "\t", this.strI1, Environment.NewLine);
			string[] newLine = new string[] { str, this.strV2, "\t", this.strI2, Environment.NewLine };
			str = string.Concat(newLine);
			newLine = new string[] { str, this.strV3, "\t", this.strI3, Environment.NewLine };
			str = string.Concat(newLine);
			newLine = new string[] { str, this.strV4, "\t", this.strI4, Environment.NewLine };
			str = string.Concat(newLine);
			newLine = new string[] { str, this.strV5, "\t", this.strI5, Environment.NewLine };
			str = string.Concat(newLine);
			newLine = new string[] { str, this.strV6, "\t", this.strI6, Environment.NewLine };
			str = string.Concat(newLine);
			newLine = new string[] { str, this.strV7, "\t", this.strI7, Environment.NewLine };
			str = string.Concat(newLine);
			newLine = new string[] { str, this.strV8, "\t", this.strI8, Environment.NewLine };
			str = string.Concat(newLine);
			newLine = new string[] { str, this.strV9, "\t", this.strI9, Environment.NewLine };
			str = string.Concat(newLine);
			newLine = new string[] { str, this.strV10, "\t", this.strI10, Environment.NewLine };
			str = string.Concat(newLine);
			this.txtcurve.Text = str;
		}

		private void ReadDate(string strReadValue)
		{
			string str = strReadValue.Substring(61, 2);
			string str1 = strReadValue.Substring(63, 2);
			string str2 = strReadValue.Substring(65, 4);
			string[] strArrays = new string[] { str, "/", str1, "/", str2 };
			string str3 = string.Concat(strArrays);
			this.lblPVdate.Text = str3;
		}

		private void ReadFF(string strReadValue)
		{
			string str = strReadValue.Substring(48, 3);
			string str1 = strReadValue.Substring(51, 2);
			string str2 = string.Concat(str, ".", str1);
			double num = Convert.ToDouble(str2);
			this.lblff.Text = num.ToString();
		}

		private void ReadIPM(string strReadValue)
		{
			string str = strReadValue.Substring(44, 2);
			string str1 = strReadValue.Substring(46, 2);
			string str2 = string.Concat(str, ".", str1);
			double num = Convert.ToDouble(str2);
			this.lImp = num;
			this.lblImax.Text = num.ToString();
		}

		private void ReadIsc(string strReadValue)
		{
			string str = strReadValue.Substring(57, 2);
			string str1 = strReadValue.Substring(59, 2);
			string str2 = string.Concat(str, ".", str1);
			double num = Convert.ToDouble(str2);
			this.lIsc = num;
			this.lblisc.Text = num.ToString();
		}

		private void ReadPMax(string strReadValue)
		{
			string str = strReadValue.Substring(35, 3);
			string str1 = strReadValue.Substring(38, 2);
			string str2 = string.Concat(str, ".", str1);
			double num = Convert.ToDouble(str2);
			this.lblPmax.Text = num.ToString();
		}

		private void ReadTag_Load(object sender, EventArgs e)
		{
			this.AppIniPath = AppDomain.CurrentDomain.BaseDirectory;
		}

		private string ReadTagValue()
		{
			byte num = 0;
			byte num1 = 0;
			byte num2 = 0;
			byte[] numArray = new byte[320];
			FrmMain.MaskFlag = 0;
			this.maskadr_textbox.Text = "00";
			this.maskLen_textBox.Text = "00";
			FrmMain.Maskadr = Convert.ToByte(this.maskadr_textbox.Text, 16);
			FrmMain.MaskLen = Convert.ToByte(this.maskLen_textBox.Text, 16);
			string str = this.txtUID.Text.Trim();
			byte num3 = Convert.ToByte(str.Length / 4);
			num2 = Convert.ToByte(num3 * 2);
			byte[] byteArray = new byte[num3];
			byteArray = this.HexStringToByteArray(str);
			num1 = 3;
			this.Edit_WordPtr.Text = "00";
			this.textbox1.Text = "32";
			byte num4 = Convert.ToByte(this.Edit_WordPtr.Text, 16);
			num = Convert.ToByte(this.textbox1.Text);
			FrmMain.fPassWord = this.HexStringToByteArray("00000000");
			FrmMain.fCmdRet = StaticClassReaderB.ReadCard_G2(ref FrmMain.fComAdr, byteArray, num1, num4, num, FrmMain.fPassWord, FrmMain.Maskadr, FrmMain.MaskLen, FrmMain.MaskFlag, numArray, num2, ref FrmMain.ferrorcode, FrmMain.frmcomportindex);
			if (FrmMain.fCmdRet != 0)
			{
				this.ReadRfidTagValue = "";
			}
			else
			{
				byte[] numArray1 = new byte[num * 2];
				Array.Copy(numArray, numArray1, num * 2);
				this.ReadRfidTagValue = this.ByteArrayToHexString(numArray1);
			}
			return this.ReadRfidTagValue;
		}

		private void ReadVoc(string strReadValue)
		{
			string str = strReadValue.Substring(53, 2);
			string str1 = strReadValue.Substring(55, 2);
			string str2 = string.Concat(str, ".", str1);
			double num = Convert.ToDouble(str2);
			this.lVoc = num;
			this.lblvoc.Text = num.ToString();
		}

		private void ReadVPM(string strReadValue)
		{
			string str = strReadValue.Substring(40, 2);
			string str1 = strReadValue.Substring(42, 2);
			string str2 = string.Concat(str, ".", str1);
			double num = Convert.ToDouble(str2);
			this.lVmp = num;
			this.lblVmax.Text = num.ToString();
		}

		private void SetCurveValue()
		{
			string str = string.Concat(this.V1, "\t", this.C1, Environment.NewLine);
			string[] v2 = new string[] { str, this.V2, "\t", this.C2, Environment.NewLine };
			str = string.Concat(v2);
			v2 = new string[] { str, this.V3, "\t", this.C3, Environment.NewLine };
			str = string.Concat(v2);
			v2 = new string[] { str, this.V4, "\t", this.C4, Environment.NewLine };
			str = string.Concat(v2);
			v2 = new string[] { str, this.V5, "\t", this.C5, Environment.NewLine };
			str = string.Concat(v2);
			v2 = new string[] { str, this.V6, "\t", this.C6, Environment.NewLine };
			str = string.Concat(v2);
			v2 = new string[] { str, this.V7, "\t", this.C7, Environment.NewLine };
			str = string.Concat(v2);
			v2 = new string[] { str, this.V8, "\t", this.C8, Environment.NewLine };
			str = string.Concat(v2);
			v2 = new string[] { str, this.V9, "\t", this.C9, Environment.NewLine };
			str = string.Concat(v2);
			v2 = new string[] { str, this.V10, "\t", this.C10, Environment.NewLine };
			str = string.Concat(v2);
			this.txtcurve.Text = str;
		}

		private void SetLineBarTitleAndAxisDetails(ref string _graphTitle, ref string _xTitle, ref string _yTitle)
		{
			_graphTitle = "PV Module Graph";
			string str = "Voltage(V)";
			string str1 = "Current(I)";
			string str2 = "V";
			string str3 = "I";
			if (_graphTitle == "")
			{
				_graphTitle = "I-V Curve";
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

		private void SetVoltageCurrent(double V, double I, int lCount)
		{
			if (lCount == 0)
			{
				this.V1 = string.Format("{0:0.00}", V);
				this.C1 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 1)
			{
				this.V2 = string.Format("{0:0.00}", V);
				this.C2 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 2)
			{
				this.V3 = string.Format("{0:0.00}", V);
				this.C3 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 3)
			{
				this.V4 = string.Format("{0:0.00}", V);
				this.C4 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 4)
			{
				this.V5 = string.Format("{0:0.00}", V);
				this.C5 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 5)
			{
				this.V6 = string.Format("{0:0.00}", V);
				this.C6 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 6)
			{
				this.V7 = string.Format("{0:0.00}", V);
				this.C7 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 7)
			{
				this.V8 = string.Format("{0:0.00}", V);
				this.C8 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 8)
			{
				this.V9 = string.Format("{0:0.00}", V);
				this.C9 = string.Format("{0:0.00}", I);
			}
			else if (lCount == 9)
			{
				this.V10 = string.Format("{0:0.00}", V);
				this.C10 = string.Format("{0:0.00}", I);
			}
		}
	}
}