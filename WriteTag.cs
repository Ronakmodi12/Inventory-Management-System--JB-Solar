using iTextSharp.text.pdf;
using iTextSharp.text;
using ReaderB;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ArkaGreenPowerPvtLtd
{
	public class WriteTag : Form
    {
        #region variables
        int lRows = 0, waranty = 0;
		private IContainer components = null;

		private GroupBox groupBox1;

		private GroupBox groupBox12;

		private Button button3;

		private TextBox txtsqlsno;

		private string lOperationType = "";

		private DataTable lWriteDataTable = new DataTable();

		private int lDot;

		private bool lWriteTag = false;

		private bool lTagStatus = false;

		private string strBefore;

		private string fExtension;

		private TextBox maskadr_textbox = new TextBox();

		private TextBox Edit_WordPtr = new TextBox();

		private TextBox maskLen_textBox = new TextBox();

		private TextBox textbox1 = new TextBox();

		private string strIVValue;

		private DataSet DsModule;

		private float Voc;

		private float Isc;

		private float Vpm;

		private float Ipm;

		private DataTable dt = new DataTable();

        private DataSet dts = new DataSet();

		private int ID;

		private string RPMax;

		private string RVMax;

		private string RIMax;

		private string RFF;

		private string RVocMax;

		private string RIscMax;

		private string REffMax;

		private bool lWrite;

		private string AppIniPath;

		private string strWriteValue;

		private string strIVValue1;
        private Button btnWrite;
        private Label label32;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private Button button2;
        private TextBox txtsno;
        private Label label14;
        private GroupBox groupBox4;
        private Button btnGetUniqueID;
        private ComboBox txtmodule;
        private TextBox txtsno1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox10;
        private TextBox txtisc;
        private Label label36;
        private TextBox txtvoc;
        private Label label33;
        private TextBox txtff;
        private TextBox txtvmax;
        private Label label28;
        private Label label29;
        private TextBox txtimax;
        private TextBox txtpmax;
        private Label label24;
        private Label label25;
        private GroupBox groupBox5;
        private TextBox txtpvmdate;
        private TextBox txtcountry;
        private TextBox txtpvmanufacturer;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox9;
        private TextBox txttagmfg;
        private TextBox txtuid;
        private Label label20;
        private Label label21;
        private GroupBox groupBox6;
        private TextBox txtcellmdate;
        private Label label7;
        private TextBox txtcountry1;
        private Label label9;
        private TextBox txtcellmname;
        private Label label8;
        private GroupBox groupBox8;
        private Button btnPreview;
        private Label label47;
        private Label C10;
        private Label V10;
        private Label label50;
        private Label label35;
        private Label C9;
        private Label V9;
        private Label label38;
        private Label label39;
        private Label C8;
        private Label V8;
        private Label label42;
        private Label label27;
        private Label C7;
        private Label V7;
        private Label label30;
        private Label label31;
        private Label C6;
        private Label V6;
        private Label label34;
        private Label label19;
        private Label C5;
        private Label V5;
        private Label label22;
        private Label label23;
        private Label C4;
        private Label V4;
        private Label label26;
        private Label label3;
        private Label C3;
        private Label V3;
        private Label label12;
        private Label label15;
        private Label C2;
        private Label V2;
        private Label label18;
        private Label lblv1;
        private Label C1;
        private Label V1;
        private Label label13;
        private Label lblv0;
        private Label label16;
        private Label V0;
        private Label label17;
        private GroupBox groupBox7;
        private TextBox txtcdate;
        private Label label11;
        private TextBox txtclab;
        private Label label10;
        private AlpexSolarRFID lSolar;

       
        #endregion
        public WriteTag()
		{
			this.InitializeComponent();
		}

        #region Add points
        private string AddPoints()
		{
			string str = string.Concat(this.V1.Text.Trim(), "\t", this.C1.Text.Trim(), Environment.NewLine);
			string[] strArrays = new string[] { str, this.V2.Text.Trim(), "\t", this.C2.Text.Trim(), Environment.NewLine };
			str = string.Concat(strArrays);
			strArrays = new string[] { str, this.V3.Text.Trim(), "\t", this.C3.Text.Trim(), Environment.NewLine };
			str = string.Concat(strArrays);
			strArrays = new string[] { str, this.V4.Text.Trim(), "\t", this.C4.Text.Trim(), Environment.NewLine };
			str = string.Concat(strArrays);
			strArrays = new string[] { str, this.V5.Text.Trim(), "\t", this.C5.Text.Trim(), Environment.NewLine };
			str = string.Concat(strArrays);
			strArrays = new string[] { str, this.V6.Text.Trim(), "\t", this.C6.Text.Trim(), Environment.NewLine };
			str = string.Concat(strArrays);
			strArrays = new string[] { str, this.V7.Text.Trim(), "\t", this.C7.Text.Trim(), Environment.NewLine };
			str = string.Concat(strArrays);
			strArrays = new string[] { str, this.V8.Text.Trim(), "\t", this.C8.Text.Trim(), Environment.NewLine };
			str = string.Concat(strArrays);
			strArrays = new string[] { str, this.V9.Text.Trim(), "\t", this.C9.Text.Trim(), Environment.NewLine };
			str = string.Concat(strArrays);
			strArrays = new string[] { str, this.V10.Text.Trim(), "\t", this.C10.Text.Trim(), Environment.NewLine };
			return string.Concat(strArrays);
		}
        #endregion

        private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}
        #region ClearAll
        private void ClearAll()
		{
			
         
			this.txtsno1.Clear();
			this.txtpvmanufacturer.Clear();
			this.txtcdate.Clear();
			this.txtcellmdate.Clear();
			this.txtcellmname.Clear();
			this.txtclab.Clear();
			this.txtcountry.Clear();
			this.txtcountry1.Clear();
			this.txtff.Clear();
			this.txtimax.Clear();
			this.txtpmax.Clear();
			this.txtpvmdate.Clear();
			this.txttagmfg.Clear();
			this.txtuid.Clear();
			this.txtvmax.Clear();
            this.txtvoc.Clear();
            this.txtisc.Clear();
		}
        #endregion

        private void button3_Click_1(object sender, EventArgs e)
		{
			this.lWrite = true;
		}

		private void button3_Click_2(object sender, EventArgs e)
		{
			CurveGraph curveGraph = new CurveGraph();
			curveGraph.t1.Text = this.AddPoints();
			curveGraph.Show();
		}

		private void button3_Click_3(object sender, EventArgs e)
		{
			this.lOperationType = "";
			this.dt.Rows.Clear();
			clscommon _clscommon = new clscommon();
			_clscommon.SetAdapterObject(string.Concat("select top 1 TR_SerialNum,TR_Isc,TR_Voc,TR_Pm,TR_Ipm,TR_Vpm,TR_FF from T_TestRecord where TR_SerialNum like '%", this.txtsqlsno.Text.Trim(), "%'"));
			DataSet dataSet = new DataSet();
			_clscommon.lAdapter.Fill(dataSet);
			this.dt = dataSet.Tables[0];
			dataSet.Dispose();
			_clscommon.DestroyAdapterObject();
			_clscommon = null;
			if (this.dt.Rows.Count > 0)
			{
				this.txtsno1.Text = this.dt.Rows[0]["TR_SerialNum"].ToString().Trim();
				this.lOperationType = "Sql";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
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

        #region Extracting Values
        public string ConvertStringToHex1(string asciiString)
		{
			string str = "";
			string str1 = asciiString;
			for (int i = 0; i < str1.Length; i++)
			{
				int num = str1[i];
				str = string.Concat(str, string.Format("{0:x2}", Convert.ToUInt32(num.ToString())));
			}
			return str;
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void GetCurrentVoltageForWrite(string strCV)
		{
			int num = strCV.IndexOf(".");
			string str = strCV.Substring(0, num);
			if (num == 1)
			{
				str = string.Concat("0", str);
			}
			string str1 = strCV.Substring(num + 1, 2);
			string str2 = string.Concat(str, str1);
			this.strIVValue = string.Concat(this.strIVValue, str2);
		}

		private void GetExtention()
		{
			if (this.txtsno.Text != "")
			{
				int length = this.txtsno.Text.Length - 5;
				string str = this.txtsno.Text.Substring(length, 5);
				this.fExtension = WriteTag.SubstringAfter(str, ".");
			}
		}

		private void GetFF(string s1)
		{
			string str;
			string str1;
			try
			{
				this.lDot = s1.IndexOf(".");
				this.strBefore = s1.Substring(0, this.lDot);
				this.RFF = this.strBefore;
				if (this.lDot == 1)
				{
					this.strBefore = string.Concat("00", this.strBefore);
				}
				else if (this.lDot == 2)
				{
					this.strBefore = string.Concat("0", this.strBefore);
				}
				str = s1.Substring(this.lDot + 1, 2);
				this.RFF = string.Concat(this.RFF, ".", str);
				str1 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
			catch (Exception exception)
			{
				str = s1.Substring(this.lDot + 1, 1);
				this.RFF = string.Concat(this.RFF, ".", str);
				str1 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
		}

		private void GetFileValue(string strFilledName, string s1)
		{
			if (strFilledName.Trim() == "Pm(W)")
			{
				this.txtpmax.Text = s1;
				this.GetPMax(s1);
			}
			else if (strFilledName.Trim()  == "Vpm(V)")
			{
				this.txtvmax.Text = s1;
				this.GetVPM(s1);
			}
			else if (strFilledName.Trim()  == "Ipm(A)")
			{
				this.txtimax.Text = s1;
				this.GetIPM(s1);
			}
			else if (strFilledName.Trim()  == "F.F.(%)")
			{
				this.txtff.Text = s1;
				this.GetFF(s1);
			}
			else if (strFilledName.Trim()  == "Voc(V)")
			{
                this.txtvoc.Text = s1;
				this.GetVoc(s1);
			}
			else if (strFilledName.Trim()  == "Isc(A)")
			{
                this.txtisc.Text = s1;
				this.GetIsc(s1);
			}
		}

		private void GetIPM(string s1)
		{
			string str;
			string str1;
			try
			{
				this.lDot = s1.IndexOf(".");
				this.strBefore = s1.Substring(0, this.lDot);
				this.RIMax = this.strBefore;
				if (this.lDot == 1)
				{
					this.strBefore = string.Concat("0", this.strBefore);
				}
				str = s1.Substring(this.lDot + 1, 2);
				this.RIMax = string.Concat(this.RIMax, ".", str);
				str1 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
			catch (Exception exception)
			{
				str = s1.Substring(this.lDot + 1, 1);
				this.RIMax = string.Concat(this.RIMax, ".", str);
				str1 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
		}

		private void GetIsc(string s1)
		{
			string str;
			string str1;
			try
			{
				int num = s1.IndexOf(".");
				string str2 = s1.Substring(0, num);
				this.RIscMax = str2;
				if (num == 1)
				{
					str2 = string.Concat("0", str2);
				}
				str = s1.Substring(num + 1, 2);
				this.RIscMax = string.Concat(this.RIscMax, ".", str);
				str1 = string.Concat(str2, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
			catch (Exception exception)
			{
				str = s1.Substring(this.lDot + 1, 1);
				this.RIscMax = string.Concat(this.RIscMax, ".", str);
				str1 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
		}

		private void GetManuctureDate()
		{
			int day;
			if (DateTime.Today.Day.ToString().Length != 1)
			{
				string str = this.strWriteValue;
				day = DateTime.Today.Day;
				this.strWriteValue = string.Concat(str, day.ToString());
			}
			else
			{
				string str1 = this.strWriteValue;
				day = DateTime.Today.Day;
				this.strWriteValue = string.Concat(str1, "0", day.ToString());
			}
			if (DateTime.Today.Month.ToString().Length != 1)
			{
				string str2 = this.strWriteValue;
				day = DateTime.Today.Month;
				this.strWriteValue = string.Concat(str2, day.ToString());
			}
			else
			{
				string str3 = this.strWriteValue;
				day = DateTime.Today.Month;
				this.strWriteValue = string.Concat(str3, "0", day.ToString());
			}
			string str4 = this.strWriteValue;
			day = DateTime.Today.Year;
			this.strWriteValue = string.Concat(str4, day.ToString());
		}

		private void GetPMax(string s1)
		{
			string str;
			string str1;
			try
			{
				int num = s1.IndexOf(".");
				string str2 = s1.Substring(0, num);
				this.RPMax = str2;
				if (num == 1)
				{
					str2 = string.Concat("00", str2);
				}
				else if (num == 2)
				{
					str2 = string.Concat("0", str2);
				}
				str = s1.Substring(num + 1, 2);
				this.RPMax = string.Concat(this.RPMax, ".", str);
				str1 = string.Concat(str2, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
			catch (Exception exception)
			{
				str = s1.Substring(this.lDot + 1, 1);
				this.RPMax = string.Concat(this.RPMax, ".", str);
				str1 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
		}

		private void GetRFIDTagID()
		{
			int num = 0;
			int num1 = 0;
			byte[] numArray = new byte[5000];
			byte num2 = 0;
			byte num3 = 0;
			byte num4 = 0;
			ListViewItem listViewItem = new ListViewItem();
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
								this.txtuid.Text = str;
								this.lTagStatus = true;
							}
						}
					}
				}
			}
		}
        #endregion

        #region Get Excel Info
        private void GetSqlExcelInformation(DataTable lESDataTable, string ESql, string CompanyID)
		{
			string hex1;
			string str;
			int length;
			int i;
			this.strWriteValue = "";
			if (ESql == "Sql")
			{
				hex1 = this.ConvertStringToHex1(lESDataTable.Rows[0]["SN"].ToString());
				str = "";
				length = 32 - hex1.Length;
				for (i = 0; i < length; i++)
				{
					str = string.Concat(str, "0");
				}
				this.strWriteValue = string.Concat(str, hex1, CompanyID);
				this.GetFileValue("Pmax", lESDataTable.Rows[0]["TR_Pm"].ToString());
				this.GetFileValue("Vmax", lESDataTable.Rows[0]["TR_Vpm"].ToString());
				this.GetFileValue("Imax", lESDataTable.Rows[0]["TR_Ipm"].ToString());
				this.GetFileValue("ff", lESDataTable.Rows[0]["TR_FF"].ToString());
				this.GetFileValue("Voc", lESDataTable.Rows[0]["TR_Voc"].ToString());
				this.GetFileValue("Isc", lESDataTable.Rows[0]["TR_Isc"].ToString());
				this.GetManuctureDate();
				this.Vpm = float.Parse(lESDataTable.Rows[0]["TR_Vpm"].ToString());
				this.Ipm = float.Parse(lESDataTable.Rows[0]["TR_Ipm"].ToString());
				this.Voc = float.Parse(lESDataTable.Rows[0]["TR_Voc"].ToString());
				this.Isc = float.Parse(lESDataTable.Rows[0]["TR_Isc"].ToString());
				this.PopulateGraphValue(this.Vpm, this.Ipm, this.Voc, this.Isc);
			}
			else if (ESql == "Excel")
			{
                hex1 = this.ConvertStringToHex1(this.txtsno1.Text.Trim());
				str = "";
				length = 32 - hex1.Length;
				for (i = 0; i < length; i++)
				{
					str = string.Concat(str, "0");
				}
				this.strWriteValue = string.Concat(str, hex1, CompanyID);
                 string str1 = string.Concat("SN='", this.txtsno1.Text.Trim() + "'");
                //  DataRow[] dataRowArray = lESDataTable.Select(string.Concat("SN like '%", this.txtsno1.Text.Trim(), "%'"));
                // DataRow[] dataRowArray = lESDataTable.Select(string.Concat("SN(NO) ='", this.txtsno1.Text.Trim(), "'"));
                
                DataRow[] dataRowArray = lESDataTable.Select(str1);
                this.GetFileValue("Pm(W)", dataRowArray[0][9].ToString());
				this.GetFileValue("Vpm(V)", dataRowArray[0][11].ToString());
				this.GetFileValue("Ipm(A)", dataRowArray[0][10].ToString());
				this.GetFileValue("F.F.(%)", dataRowArray[0][2].ToString());
				this.GetFileValue("Voc(V)", dataRowArray[0][8].ToString());
				this.GetFileValue("Isc(A)", dataRowArray[0][7].ToString());
				this.GetManuctureDate();
                this.Vpm = float.Parse(dataRowArray[0][11].ToString());
                this.Ipm = float.Parse(dataRowArray[0][10].ToString());
                this.Voc = float.Parse(dataRowArray[0][8].ToString());
                this.Isc = float.Parse(dataRowArray[0][7].ToString());

				this.PopulateGraphValue(this.Vpm, this.Ipm, this.Voc, this.Isc);
			}
		}
        #endregion

        #region Get Voc n VPM
        private void GetVoc(string s1)
		{
			string str;
			try
			{
				int num = s1.IndexOf(".");
				string str1 = s1.Substring(0, num);
				this.RVocMax = str1;
				if (num == 1)
				{
					str1 = string.Concat("0", str1);
				}
				str = s1.Substring(num + 1, 2);
				this.RVocMax = string.Concat(this.RVocMax, ".", str);
				string str2 = string.Concat(str1, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str2);
			}
			catch (Exception exception)
			{
				str = s1.Substring(this.lDot + 1, 1);
				this.RVocMax = string.Concat(this.RVocMax, ".", str);
				string str3 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str3);
			}
		}

		private void GetVPM(string s1)
		{
			string str;
			string str1;
			try
			{
				this.lDot = s1.IndexOf(".");
				this.strBefore = s1.Substring(0, this.lDot);
				this.RVMax = this.strBefore;
				if (this.lDot == 1)
				{
					this.strBefore = string.Concat("0", this.strBefore);
				}
				str = s1.Substring(this.lDot + 1, 2);
				this.RVMax = string.Concat(this.RVMax, ".", str);
				str1 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
			catch (Exception exception)
			{
				str = s1.Substring(this.lDot + 1, 1);
				this.RVMax = string.Concat(this.RVMax, ".", str);
				str1 = string.Concat(this.strBefore, str);
				this.strWriteValue = string.Concat(this.strWriteValue, str1);
			}
		}
        private string CreateGraphPoint()
        {
            string strCurrentVolt = V1.Text.Trim() + "\t" + C1.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V2.Text.Trim() + "\t" + C2.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V3.Text.Trim() + "\t" + C3.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V4.Text.Trim() + "\t" + C4.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V5.Text.Trim() + "\t" + C5.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V6.Text.Trim() + "\t" + C6.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V7.Text.Trim() + "\t" + C7.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V8.Text.Trim() + "\t" + C8.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V9.Text.Trim() + "\t" + C9.Text.Trim() + Environment.NewLine;
            strCurrentVolt = strCurrentVolt + V10.Text.Trim() + "\t" + C10.Text.Trim() + Environment.NewLine;

            return strCurrentVolt;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtsqlsno = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsno = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetUniqueID = new System.Windows.Forms.Button();
            this.txtmodule = new System.Windows.Forms.ComboBox();
            this.txtsno1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtisc = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtvoc = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtff = new System.Windows.Forms.TextBox();
            this.txtvmax = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtimax = new System.Windows.Forms.TextBox();
            this.txtpmax = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtpvmdate = new System.Windows.Forms.TextBox();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.txtpvmanufacturer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txttagmfg = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtcellmdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcountry1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcellmname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.C10 = new System.Windows.Forms.Label();
            this.V10 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.C9 = new System.Windows.Forms.Label();
            this.V9 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.C8 = new System.Windows.Forms.Label();
            this.V8 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.C7 = new System.Windows.Forms.Label();
            this.V7 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.C6 = new System.Windows.Forms.Label();
            this.V6 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.C5 = new System.Windows.Forms.Label();
            this.V5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.C4 = new System.Windows.Forms.Label();
            this.V4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.C3 = new System.Windows.Forms.Label();
            this.V3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.Label();
            this.V2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblv1 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.Label();
            this.V1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblv0 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.V0 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtcdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtclab = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.groupBox12);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write Tag";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.ForeColor = System.Drawing.Color.Black;
            this.btnWrite.Location = new System.Drawing.Point(460, 472);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(270, 51);
            this.btnWrite.TabIndex = 7;
            this.btnWrite.Text = "Write Tag";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button3);
            this.groupBox12.Controls.Add(this.txtsqlsno);
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Enabled = false;
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox12.Location = new System.Drawing.Point(1005, 476);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(147, 25);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "For Sql File";
            this.groupBox12.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(491, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 15);
            this.button3.TabIndex = 2;
            this.button3.Text = "Get Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_3);
            // 
            // txtsqlsno
            // 
            this.txtsqlsno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsqlsno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtsqlsno.Location = new System.Drawing.Point(129, 8);
            this.txtsqlsno.Name = "txtsqlsno";
            this.txtsqlsno.Size = new System.Drawing.Size(314, 22);
            this.txtsqlsno.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label32.Location = new System.Drawing.Point(10, 11);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(113, 16);
            this.label32.TabIndex = 8;
            this.label32.Text = "Enter Serial No";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(22, 476);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtsno);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(19, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 90);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "For Excel File";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(130, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtsno
            // 
            this.txtsno.ForeColor = System.Drawing.Color.Black;
            this.txtsno.Location = new System.Drawing.Point(130, 18);
            this.txtsno.Name = "txtsno";
            this.txtsno.ReadOnly = true;
            this.txtsno.Size = new System.Drawing.Size(233, 22);
            this.txtsno.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(17, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Select File";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetUniqueID);
            this.groupBox4.Controls.Add(this.txtmodule);
            this.groupBox4.Controls.Add(this.txtsno1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(401, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 88);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PV Module";
            // 
            // btnGetUniqueID
            // 
            this.btnGetUniqueID.BackColor = System.Drawing.Color.White;
            this.btnGetUniqueID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetUniqueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUniqueID.ForeColor = System.Drawing.Color.Black;
            this.btnGetUniqueID.Location = new System.Drawing.Point(293, 19);
            this.btnGetUniqueID.Name = "btnGetUniqueID";
            this.btnGetUniqueID.Size = new System.Drawing.Size(102, 45);
            this.btnGetUniqueID.TabIndex = 3;
            this.btnGetUniqueID.Text = "Get Unq ID";
            this.btnGetUniqueID.UseVisualStyleBackColor = false;
            this.btnGetUniqueID.Click += new System.EventHandler(this.btnGetUniqueID_Click_1);
            // 
            // txtmodule
            // 
            this.txtmodule.ForeColor = System.Drawing.Color.Black;
            this.txtmodule.FormattingEnabled = true;
            this.txtmodule.Location = new System.Drawing.Point(143, 48);
            this.txtmodule.Name = "txtmodule";
            this.txtmodule.Size = new System.Drawing.Size(138, 24);
            this.txtmodule.TabIndex = 2;
            // 
            // txtsno1
            // 
            this.txtsno1.ForeColor = System.Drawing.Color.Black;
            this.txtsno1.Location = new System.Drawing.Point(144, 16);
            this.txtsno1.Name = "txtsno1";
            this.txtsno1.Size = new System.Drawing.Size(138, 22);
            this.txtsno1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PV Module Name";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtisc);
            this.groupBox10.Controls.Add(this.label36);
            this.groupBox10.Controls.Add(this.txtvoc);
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.txtff);
            this.groupBox10.Controls.Add(this.txtvmax);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.txtimax);
            this.groupBox10.Controls.Add(this.txtpmax);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox10.Location = new System.Drawing.Point(22, 253);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(789, 115);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Technical Specification for PV Module";
            // 
            // txtisc
            // 
            this.txtisc.ForeColor = System.Drawing.Color.Black;
            this.txtisc.Location = new System.Drawing.Point(509, 78);
            this.txtisc.Name = "txtisc";
            this.txtisc.ReadOnly = true;
            this.txtisc.Size = new System.Drawing.Size(152, 22);
            this.txtisc.TabIndex = 15;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label36.Location = new System.Drawing.Point(396, 81);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(28, 16);
            this.label36.TabIndex = 14;
            this.label36.Text = "Isc";
            // 
            // txtvoc
            // 
            this.txtvoc.ForeColor = System.Drawing.Color.Black;
            this.txtvoc.Location = new System.Drawing.Point(159, 77);
            this.txtvoc.Name = "txtvoc";
            this.txtvoc.ReadOnly = true;
            this.txtvoc.Size = new System.Drawing.Size(172, 22);
            this.txtvoc.TabIndex = 13;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label33.Location = new System.Drawing.Point(48, 81);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 16);
            this.label33.TabIndex = 12;
            this.label33.Text = "Voc";
            // 
            // txtff
            // 
            this.txtff.ForeColor = System.Drawing.Color.Black;
            this.txtff.Location = new System.Drawing.Point(509, 50);
            this.txtff.Name = "txtff";
            this.txtff.ReadOnly = true;
            this.txtff.Size = new System.Drawing.Size(152, 22);
            this.txtff.TabIndex = 3;
            // 
            // txtvmax
            // 
            this.txtvmax.ForeColor = System.Drawing.Color.Black;
            this.txtvmax.Location = new System.Drawing.Point(159, 49);
            this.txtvmax.Name = "txtvmax";
            this.txtvmax.ReadOnly = true;
            this.txtvmax.Size = new System.Drawing.Size(172, 22);
            this.txtvmax.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label28.Location = new System.Drawing.Point(48, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 16);
            this.label28.TabIndex = 11;
            this.label28.Text = "V-max (Volt)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label29.Location = new System.Drawing.Point(396, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 16);
            this.label29.TabIndex = 10;
            this.label29.Text = "Fill-Factor";
            // 
            // txtimax
            // 
            this.txtimax.ForeColor = System.Drawing.Color.Black;
            this.txtimax.Location = new System.Drawing.Point(509, 22);
            this.txtimax.Name = "txtimax";
            this.txtimax.ReadOnly = true;
            this.txtimax.Size = new System.Drawing.Size(152, 22);
            this.txtimax.TabIndex = 1;
            // 
            // txtpmax
            // 
            this.txtpmax.ForeColor = System.Drawing.Color.Black;
            this.txtpmax.Location = new System.Drawing.Point(159, 21);
            this.txtpmax.Name = "txtpmax";
            this.txtpmax.ReadOnly = true;
            this.txtpmax.Size = new System.Drawing.Size(172, 22);
            this.txtpmax.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label24.Location = new System.Drawing.Point(47, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "W-max (Watt)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label25.Location = new System.Drawing.Point(395, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 16);
            this.label25.TabIndex = 0;
            this.label25.Text = "I-max (Amp)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtpvmdate);
            this.groupBox5.Controls.Add(this.txtcountry);
            this.groupBox5.Controls.Add(this.txtpvmanufacturer);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox5.Location = new System.Drawing.Point(19, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(376, 120);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PV Module Manufacturer Details";
            // 
            // txtpvmdate
            // 
            this.txtpvmdate.ForeColor = System.Drawing.Color.Black;
            this.txtpvmdate.Location = new System.Drawing.Point(191, 87);
            this.txtpvmdate.Name = "txtpvmdate";
            this.txtpvmdate.ReadOnly = true;
            this.txtpvmdate.Size = new System.Drawing.Size(150, 22);
            this.txtpvmdate.TabIndex = 12;
            // 
            // txtcountry
            // 
            this.txtcountry.ForeColor = System.Drawing.Color.Black;
            this.txtcountry.Location = new System.Drawing.Point(191, 53);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.ReadOnly = true;
            this.txtcountry.Size = new System.Drawing.Size(149, 22);
            this.txtcountry.TabIndex = 11;
            // 
            // txtpvmanufacturer
            // 
            this.txtpvmanufacturer.ForeColor = System.Drawing.Color.Black;
            this.txtpvmanufacturer.Location = new System.Drawing.Point(192, 22);
            this.txtpvmanufacturer.Name = "txtpvmanufacturer";
            this.txtpvmanufacturer.ReadOnly = true;
            this.txtpvmanufacturer.Size = new System.Drawing.Size(148, 22);
            this.txtpvmanufacturer.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(24, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date of Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Country of Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manufacturer Name";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txttagmfg);
            this.groupBox9.Controls.Add(this.txtuid);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox9.Location = new System.Drawing.Point(401, 375);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(410, 81);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "RFID and Tag Details";
            // 
            // txttagmfg
            // 
            this.txttagmfg.ForeColor = System.Drawing.Color.Black;
            this.txttagmfg.Location = new System.Drawing.Point(345, 45);
            this.txttagmfg.Name = "txttagmfg";
            this.txttagmfg.ReadOnly = true;
            this.txttagmfg.Size = new System.Drawing.Size(23, 22);
            this.txttagmfg.TabIndex = 14;
            this.txttagmfg.Visible = false;
            // 
            // txtuid
            // 
            this.txtuid.ForeColor = System.Drawing.Color.Black;
            this.txtuid.Location = new System.Drawing.Point(102, 35);
            this.txtuid.Name = "txtuid";
            this.txtuid.ReadOnly = true;
            this.txtuid.Size = new System.Drawing.Size(215, 22);
            this.txtuid.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(323, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 12;
            this.label20.Text = "Tag MFG";
            this.label20.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label21.Location = new System.Drawing.Point(14, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 16);
            this.label21.TabIndex = 11;
            this.label21.Text = "Unique ID";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtcellmdate);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtcountry1);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtcellmname);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox6.Location = new System.Drawing.Point(401, 126);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(410, 121);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cell Manufacturer Details";
            // 
            // txtcellmdate
            // 
            this.txtcellmdate.ForeColor = System.Drawing.Color.Black;
            this.txtcellmdate.Location = new System.Drawing.Point(175, 87);
            this.txtcellmdate.Name = "txtcellmdate";
            this.txtcellmdate.ReadOnly = true;
            this.txtcellmdate.Size = new System.Drawing.Size(148, 22);
            this.txtcellmdate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(13, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date of Manufacturer";
            // 
            // txtcountry1
            // 
            this.txtcountry1.ForeColor = System.Drawing.Color.Black;
            this.txtcountry1.Location = new System.Drawing.Point(174, 53);
            this.txtcountry1.Name = "txtcountry1";
            this.txtcountry1.ReadOnly = true;
            this.txtcountry1.Size = new System.Drawing.Size(149, 22);
            this.txtcountry1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(13, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Manufacturer Name";
            // 
            // txtcellmname
            // 
            this.txtcellmname.ForeColor = System.Drawing.Color.Black;
            this.txtcellmname.Location = new System.Drawing.Point(175, 22);
            this.txtcellmname.Name = "txtcellmname";
            this.txtcellmname.ReadOnly = true;
            this.txtcellmname.Size = new System.Drawing.Size(148, 22);
            this.txtcellmname.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(13, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Country of Origin";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnPreview);
            this.groupBox8.Controls.Add(this.label47);
            this.groupBox8.Controls.Add(this.C10);
            this.groupBox8.Controls.Add(this.V10);
            this.groupBox8.Controls.Add(this.label50);
            this.groupBox8.Controls.Add(this.label35);
            this.groupBox8.Controls.Add(this.C9);
            this.groupBox8.Controls.Add(this.V9);
            this.groupBox8.Controls.Add(this.label38);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.C8);
            this.groupBox8.Controls.Add(this.V8);
            this.groupBox8.Controls.Add(this.label42);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.C7);
            this.groupBox8.Controls.Add(this.V7);
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this.label31);
            this.groupBox8.Controls.Add(this.C6);
            this.groupBox8.Controls.Add(this.V6);
            this.groupBox8.Controls.Add(this.label34);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.C5);
            this.groupBox8.Controls.Add(this.V5);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.C4);
            this.groupBox8.Controls.Add(this.V4);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.C3);
            this.groupBox8.Controls.Add(this.V3);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.C2);
            this.groupBox8.Controls.Add(this.V2);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.lblv1);
            this.groupBox8.Controls.Add(this.C1);
            this.groupBox8.Controls.Add(this.V1);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.lblv0);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.V0);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox8.Location = new System.Drawing.Point(839, 30);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(313, 418);
            this.groupBox8.TabIndex = 17;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "IV Curve for the Module";
            // 
            // btnPreview
            // 
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPreview.Location = new System.Drawing.Point(137, 375);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(101, 33);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview Graph";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label47.Location = new System.Drawing.Point(21, 332);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(44, 16);
            this.label47.TabIndex = 43;
            this.label47.Text = "V(10)";
            // 
            // C10
            // 
            this.C10.AutoSize = true;
            this.C10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C10.Location = new System.Drawing.Point(248, 331);
            this.C10.Name = "C10";
            this.C10.Size = new System.Drawing.Size(57, 16);
            this.C10.TabIndex = 42;
            this.C10.Text = "Current";
            // 
            // V10
            // 
            this.V10.AutoSize = true;
            this.V10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V10.Location = new System.Drawing.Point(87, 332);
            this.V10.Name = "V10";
            this.V10.Size = new System.Drawing.Size(62, 16);
            this.V10.TabIndex = 41;
            this.V10.Text = "Voltage";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label50.Location = new System.Drawing.Point(183, 331);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(38, 16);
            this.label50.TabIndex = 40;
            this.label50.Text = "I(10)";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label35.Location = new System.Drawing.Point(21, 306);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 16);
            this.label35.TabIndex = 39;
            this.label35.Text = "V(9)";
            // 
            // C9
            // 
            this.C9.AutoSize = true;
            this.C9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C9.Location = new System.Drawing.Point(248, 305);
            this.C9.Name = "C9";
            this.C9.Size = new System.Drawing.Size(57, 16);
            this.C9.TabIndex = 38;
            this.C9.Text = "Current";
            // 
            // V9
            // 
            this.V9.AutoSize = true;
            this.V9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V9.Location = new System.Drawing.Point(87, 306);
            this.V9.Name = "V9";
            this.V9.Size = new System.Drawing.Size(62, 16);
            this.V9.TabIndex = 37;
            this.V9.Text = "Voltage";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label38.Location = new System.Drawing.Point(183, 305);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(30, 16);
            this.label38.TabIndex = 36;
            this.label38.Text = "I(9)";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label39.Location = new System.Drawing.Point(21, 276);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(36, 16);
            this.label39.TabIndex = 35;
            this.label39.Text = "V(8)";
            // 
            // C8
            // 
            this.C8.AutoSize = true;
            this.C8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C8.Location = new System.Drawing.Point(248, 275);
            this.C8.Name = "C8";
            this.C8.Size = new System.Drawing.Size(57, 16);
            this.C8.TabIndex = 34;
            this.C8.Text = "Current";
            // 
            // V8
            // 
            this.V8.AutoSize = true;
            this.V8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V8.Location = new System.Drawing.Point(87, 276);
            this.V8.Name = "V8";
            this.V8.Size = new System.Drawing.Size(62, 16);
            this.V8.TabIndex = 33;
            this.V8.Text = "Voltage";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label42.Location = new System.Drawing.Point(183, 275);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(30, 16);
            this.label42.TabIndex = 32;
            this.label42.Text = "I(8)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label27.Location = new System.Drawing.Point(21, 245);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 16);
            this.label27.TabIndex = 31;
            this.label27.Text = "V(7)";
            // 
            // C7
            // 
            this.C7.AutoSize = true;
            this.C7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C7.Location = new System.Drawing.Point(248, 244);
            this.C7.Name = "C7";
            this.C7.Size = new System.Drawing.Size(57, 16);
            this.C7.TabIndex = 30;
            this.C7.Text = "Current";
            // 
            // V7
            // 
            this.V7.AutoSize = true;
            this.V7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V7.Location = new System.Drawing.Point(87, 245);
            this.V7.Name = "V7";
            this.V7.Size = new System.Drawing.Size(62, 16);
            this.V7.TabIndex = 29;
            this.V7.Text = "Voltage";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label30.Location = new System.Drawing.Point(183, 244);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 16);
            this.label30.TabIndex = 28;
            this.label30.Text = "I(7)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label31.Location = new System.Drawing.Point(20, 215);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 16);
            this.label31.TabIndex = 27;
            this.label31.Text = "V(6)";
            // 
            // C6
            // 
            this.C6.AutoSize = true;
            this.C6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C6.Location = new System.Drawing.Point(247, 214);
            this.C6.Name = "C6";
            this.C6.Size = new System.Drawing.Size(57, 16);
            this.C6.TabIndex = 26;
            this.C6.Text = "Current";
            // 
            // V6
            // 
            this.V6.AutoSize = true;
            this.V6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V6.Location = new System.Drawing.Point(86, 215);
            this.V6.Name = "V6";
            this.V6.Size = new System.Drawing.Size(62, 16);
            this.V6.TabIndex = 25;
            this.V6.Text = "Voltage";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label34.Location = new System.Drawing.Point(183, 214);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(30, 16);
            this.label34.TabIndex = 24;
            this.label34.Text = "I(6)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(20, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 16);
            this.label19.TabIndex = 23;
            this.label19.Text = "V(5)";
            // 
            // C5
            // 
            this.C5.AutoSize = true;
            this.C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C5.Location = new System.Drawing.Point(247, 186);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(57, 16);
            this.C5.TabIndex = 22;
            this.C5.Text = "Current";
            // 
            // V5
            // 
            this.V5.AutoSize = true;
            this.V5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V5.Location = new System.Drawing.Point(86, 187);
            this.V5.Name = "V5";
            this.V5.Size = new System.Drawing.Size(62, 16);
            this.V5.TabIndex = 21;
            this.V5.Text = "Voltage";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label22.Location = new System.Drawing.Point(184, 186);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 16);
            this.label22.TabIndex = 20;
            this.label22.Text = "I(5)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label23.Location = new System.Drawing.Point(20, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 16);
            this.label23.TabIndex = 19;
            this.label23.Text = "V(4)";
            // 
            // C4
            // 
            this.C4.AutoSize = true;
            this.C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C4.Location = new System.Drawing.Point(247, 156);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(57, 16);
            this.C4.TabIndex = 18;
            this.C4.Text = "Current";
            // 
            // V4
            // 
            this.V4.AutoSize = true;
            this.V4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V4.Location = new System.Drawing.Point(86, 157);
            this.V4.Name = "V4";
            this.V4.Size = new System.Drawing.Size(62, 16);
            this.V4.TabIndex = 17;
            this.V4.Text = "Voltage";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label26.Location = new System.Drawing.Point(184, 156);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 16);
            this.label26.TabIndex = 16;
            this.label26.Text = "I(4)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "V(3)";
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C3.Location = new System.Drawing.Point(247, 124);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(57, 16);
            this.C3.TabIndex = 14;
            this.C3.Text = "Current";
            // 
            // V3
            // 
            this.V3.AutoSize = true;
            this.V3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V3.Location = new System.Drawing.Point(87, 125);
            this.V3.Name = "V3";
            this.V3.Size = new System.Drawing.Size(62, 16);
            this.V3.TabIndex = 13;
            this.V3.Text = "Voltage";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(185, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "I(3)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(20, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "V(2)";
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C2.Location = new System.Drawing.Point(247, 94);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(57, 16);
            this.C2.TabIndex = 10;
            this.C2.Text = "Current";
            // 
            // V2
            // 
            this.V2.AutoSize = true;
            this.V2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V2.Location = new System.Drawing.Point(86, 95);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(62, 16);
            this.V2.TabIndex = 9;
            this.V2.Text = "Voltage";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label18.Location = new System.Drawing.Point(184, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 16);
            this.label18.TabIndex = 8;
            this.label18.Text = "I(2)";
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblv1.Location = new System.Drawing.Point(20, 67);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(36, 16);
            this.lblv1.TabIndex = 7;
            this.lblv1.Text = "V(1)";
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.C1.Location = new System.Drawing.Point(247, 66);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(57, 16);
            this.C1.TabIndex = 6;
            this.C1.Text = "Current";
            // 
            // V1
            // 
            this.V1.AutoSize = true;
            this.V1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V1.Location = new System.Drawing.Point(86, 67);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(62, 16);
            this.V1.TabIndex = 5;
            this.V1.Text = "Voltage";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(184, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "I(1)";
            // 
            // lblv0
            // 
            this.lblv0.AutoSize = true;
            this.lblv0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblv0.Location = new System.Drawing.Point(20, 37);
            this.lblv0.Name = "lblv0";
            this.lblv0.Size = new System.Drawing.Size(48, 16);
            this.lblv0.TabIndex = 3;
            this.lblv0.Text = "V(No)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(247, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Current";
            // 
            // V0
            // 
            this.V0.AutoSize = true;
            this.V0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.V0.Location = new System.Drawing.Point(86, 37);
            this.V0.Name = "V0";
            this.V0.Size = new System.Drawing.Size(62, 16);
            this.V0.TabIndex = 1;
            this.V0.Text = "Voltage";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label17.Location = new System.Drawing.Point(184, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "I(No)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtcdate);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.txtclab);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox7.Location = new System.Drawing.Point(22, 375);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(373, 81);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "IEC Certification";
            // 
            // txtcdate
            // 
            this.txtcdate.ForeColor = System.Drawing.Color.Black;
            this.txtcdate.Location = new System.Drawing.Point(145, 50);
            this.txtcdate.Name = "txtcdate";
            this.txtcdate.ReadOnly = true;
            this.txtcdate.Size = new System.Drawing.Size(149, 22);
            this.txtcdate.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Certification Date";
            // 
            // txtclab
            // 
            this.txtclab.ForeColor = System.Drawing.Color.Black;
            this.txtclab.Location = new System.Drawing.Point(145, 18);
            this.txtclab.Name = "txtclab";
            this.txtclab.ReadOnly = true;
            this.txtclab.Size = new System.Drawing.Size(148, 22);
            this.txtclab.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(7, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Certification Lab";
            // 
            // WriteTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 548);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WriteTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WriteTag";
            this.Load += new System.EventHandler(this.WriteTag_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

		}
        #endregion
        #region PopulateGraphValue and Populate Module
        private void PopulateGraphValue(float Vpm, float Ipm, float Voc, float Isc)
		{

            strIVValue = null;

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
            V10.Text = String.Format("{0:0.00}", Voc);
            GetCurrentVoltageForWrite(V10.Text);
            C10.Text = String.Format("{0:0.00}", 0);
            GetCurrentVoltageForWrite(C10.Text);


            //double ipm;
            //double i;
            ////Math.Exp((double)Voc);
            ////double isc = (double)(1f / (Isc - Ipm));
            ////double num = (double)Isc * Math.Exp((double)(Voc - Vpm));
            ////double ipm1 = (double)Ipm * Math.Exp((double)Voc);
            ////double num1 = isc * num;
            ////double num2 = Math.Log(-(num1 - ipm1), 2.82);
            ////double voc = (double)Voc * num2;
            ////double isc1 = (double)Isc / (Math.Exp(-voc) - 1);

            ////double vpm = (double)(Vpm / 5f);
            ////int num3 = 0;
            ////for (i = vpm; i <= (double)Vpm; i = i + vpm)
            ////{
            ////    ipm = i * (double)((Ipm - Isc) / Vpm) + (double)Isc;
            ////    this.SetVoltageCurrent(i, ipm, num3);
            ////    num3++;
            ////}

            //double vpm = (double)(Voc / 5f);
            //int num3 = 0;
            //for (i = vpm; i <= (double)Voc; i = i + vpm)
            //{
            //    ipm = i * (double)((Isc - Ipm) / Vpm) + (double)Isc;
            //    this.SetVoltageCurrent(i, ipm, num3);
            //    num3++;
            //}

            //double voc1 = (double)((Voc - Vpm) / 5f);
            //for (i = (double)Vpm + voc1; i <= (double)Voc; i = i + voc1)
            //{
            //    ipm = (i - (double)Voc) * (double)Ipm / (double)(Vpm - Voc);
            //    this.SetVoltageCurrent(i, ipm, num3);
            //    num3++;
            //}

            ////double voc1 = (double)((Vpm - Voc) / 5f);
            ////for (i = (double)Voc + voc1; i <= (double)Vpm; i = i + voc1)
            ////{
            ////    ipm = (i - (double)Vpm) * (double)Ipm / (double)(Voc - Vpm);
            ////    this.SetVoltageCurrent(i, ipm, num3);
            ////    num3++;
            ////}
            
            //this.V10.Text = string.Format("{0:0.00}", Vpm);
            //this.GetCurrentVoltageForWrite(this.V10.Text);
            //this.C10.Text = string.Format("{0:0.00}", 0);
            //this.GetCurrentVoltageForWrite(this.C10.Text);
		}

		private void PopulateModule()
		{
			try
			{
				string str = string.Concat(this.AppIniPath, "\\XMLCompanySettings.xml");
				this.DsModule = new DataSet();
				this.DsModule.ReadXml(str);
				for (int i = 0; i < this.DsModule.Tables[0].Rows.Count; i++)
				{
					this.txtmodule.Items.Add(this.DsModule.Tables[0].Rows[i]["PVModule"].ToString());
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Create Company Settings first");
			}
		}
        #endregion

        #region SetVoltageCurrent
        private void SetVoltageCurrent(double V, double I, int lCount)
		{
			if (lCount == 0)
			{
				this.V1.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V1.Text);
				this.C1.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C1.Text);
			}
			else if (lCount == 1)
			{
				this.V2.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V2.Text);
				this.C2.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C2.Text);
			}
			else if (lCount == 2)
			{
				this.V3.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V3.Text);
				this.C3.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C3.Text);
			}
			else if (lCount == 3)
			{
				this.V4.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V4.Text);
				this.C4.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C4.Text);
			}
			else if (lCount == 4)
			{
				this.V5.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V5.Text);
				this.C5.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C5.Text);
			}
			else if (lCount == 5)
			{
				this.V6.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V6.Text);
				this.C6.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C6.Text);
			}
			else if (lCount == 6)
			{
				this.V7.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V7.Text);
				this.C7.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C7.Text);
			}
			else if (lCount == 7)
			{
				this.V8.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V8.Text);
				this.C8.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C8.Text);
			}
			else if (lCount == 8)
			{
				this.V9.Text = string.Format("{0:0.00}", V);
				this.GetCurrentVoltageForWrite(this.V9.Text);
				this.C9.Text = string.Format("{0:0.00}", I);
				this.GetCurrentVoltageForWrite(this.C9.Text);
			}
		}

		public static string SubstringAfter(string source, string value)
		{
			string str;
			if (!string.IsNullOrEmpty(value))
			{
				CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
				int num = compareInfo.IndexOf(source, value, CompareOptions.Ordinal);
				str = (num >= 0 ? source.Substring(num + value.Length) : string.Empty);
			}
			else
			{
				str = source;
			}
			return str;
		}

		private string SubstringBefore(string source, string value)
		{
			string str;
			if (!string.IsNullOrEmpty(value))
			{
				CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
				int num = compareInfo.IndexOf(source, value, CompareOptions.Ordinal);
				str = (num >= 0 ? source.Substring(0, num) : string.Empty);
			}
			else
			{
				str = value;
			}
			return str;
		}
        #endregion

        #region Write TAg
        private bool WriteDatFileDataInTag(string p)
		{
			bool flag;
			byte num = 0;
			byte num1 = 0;
			byte num2 = 0;
			byte num3 = 0;
			int num4 = 0;
			FrmMain.MaskFlag = 0;
			this.maskadr_textbox.Text = "00";
			this.maskLen_textBox.Text = "00";
			byte[] numArray = new byte[320];
			byte[] numArray1 = new byte[230];
			if ((this.maskadr_textbox.Text == "" ? false : !(this.maskLen_textBox.Text == "")))
			{
				FrmMain.Maskadr = Convert.ToByte(this.maskadr_textbox.Text, 16);
				FrmMain.MaskLen = Convert.ToByte(this.maskLen_textBox.Text, 16);
				string str = this.txtuid.Text.Trim();
				byte num5 = Convert.ToByte(str.Length / 4);
				num2 = Convert.ToByte(num5 * 2);
				byte[] byteArray = new byte[num5];
				byteArray = this.HexStringToByteArray(str);
				num = 3;
				this.Edit_WordPtr.Text = "00";
				string str1 = p;
				this.textbox1.Text = "64";
				byte num6 = Convert.ToByte(this.Edit_WordPtr.Text, 16);
				Convert.ToByte(this.textbox1.Text);
				FrmMain.fPassWord = this.HexStringToByteArray("00000000");
				num1 = Convert.ToByte(str1.Length / 4);
				byte[] byteArray1 = new byte[num1 * 2];
				byteArray1 = this.HexStringToByteArray(str1);
				num3 = Convert.ToByte(num1 * 2);
				int num7 = 0;
				while (!this.lWrite)
				{
					FrmMain.fCmdRet = StaticClassReaderB.WriteCard_G2(ref FrmMain.fComAdr, byteArray, num, num6, num3, byteArray1, FrmMain.fPassWord, FrmMain.Maskadr, FrmMain.MaskLen, FrmMain.MaskFlag, num4, num2, ref FrmMain.ferrorcode, FrmMain.frmcomportindex);
					if (FrmMain.fCmdRet != 0)
					{
						if (num7 == 25)
						{
							this.lWrite = true;
							MessageBox.Show("Tag Does not Write, so write again");
							this.lWriteTag = false;
							str1 = "";
						}
						num7++;
					}
					else
					{
						this.lWrite = true;
						this.WriteXMLForTag();
						MessageBox.Show("Tag Write Successfully");
                        //WriteCompanySettings(); MessageBox.Show("xml write");
                        this.CreatePDFFileName();

                        this.lWriteTag = true;
						//this.txtuid.Text = "";
                        ClearAll();
						str1 = "";
                        txtsqlsno.Text = "";
                        if (dt.Rows.Count > lRows+1)
                        {
                            lRows++; //MessageBox.Show("lrows increament");
                            txtsno1.Text = dt.Rows[lRows]["SN"].ToString(); //MessageBox.Show("txtsno1 changed");
                        }
					}
				}
				flag = this.lWriteTag;
			}
			else
			{
				FrmMain.fIsInventoryScan = false;
				flag = this.lWriteTag;
			}
			return flag;
		}
        #endregion

        private void CreatePDFFileName()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "pdf\\" + this.txtsno1.Text.Trim() + ".pdf"))
            {
                if (MessageBox.Show("Are you sure! You want to replace pdf ? \n ", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CurveGraph CG = new CurveGraph();
                    CG.t1.Text = this.CreateGraphPoint();
                    CG.Show();
                    CG.m_graphPane.GetImage().Save(AppDomain.CurrentDomain.BaseDirectory + "pdf\\graphimg.jpg");
                    CG.Close();
                    CreatePDFFile();

                }
            }

            else
            {
                CurveGraph CG = new CurveGraph();
                CG.t1.Text = this.CreateGraphPoint();
                CG.Show();
                CG.m_graphPane.GetImage().Save(AppDomain.CurrentDomain.BaseDirectory + "pdf\\graphimg.jpg");
                CG.Close();
                this.CreatePDFFile();
            }
        }


        private void CreatePDFFile()
        {

            Document doc = new Document(PageSize.LETTER, 10f, 10f, 42f, 35f);

            try
            {
                try
                {
                    string pdfFilePath = string.Concat(AppDomain.CurrentDomain.BaseDirectory + "pdf\\", this.txtsno1.Text.Trim(), ".pdf");
                    PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));
                    doc.Open();

                    iTextSharp.text.Image imgLogo = iTextSharp.text.Image.GetInstance(AppDomain.CurrentDomain.BaseDirectory + "pv_logo.png");
                    imgLogo.ScaleToFit(500f, 87f);
                    // imgLogo.Alignment = 5;
                    imgLogo.IndentationLeft = 0f;
                    imgLogo.SpacingAfter = 9f;
                    imgLogo.BorderWidth = 0f;
                    imgLogo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(imgLogo);

                    // iTextSharp.text.Image imgLogo1 = null;
                    //PdfPTable headerTable = new PdfPTable(2) { TotalWidth = 500f, LockedWidth = true };
                    //headerTable.DefaultCell.FixedHeight = 60;
                    //headerTable.DefaultCell.Border = PdfPCell.NO_BORDER;
                    //PdfPCell RightCell = new PdfPCell(new Phrase("RFID Data Of Solar Module", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 18f, 1, BaseColor.BLACK))));
                    //RightCell.Border = PdfPCell.NO_BORDER;
                    //RightCell.HorizontalAlignment = Element.ALIGN_MIDDLE;
                    //RightCell.VerticalAlignment = Element.ALIGN_MIDDLE; 
                    // headerTable.AddCell(imgLogo1);
                    //headerTable.AddCell(RightCell);
                    //  doc.Add(headerTable);

                    Paragraph para = new Paragraph("RFID Data Of Solar Module\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14));

                    para.Alignment = Element.ALIGN_CENTER;

                    doc.Add(para);

                    Paragraph paraspace = new Paragraph("\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14));

                    paraspace.Alignment = Element.ALIGN_CENTER;

                    doc.Add(paraspace);



                    PdfPTable PdfTable = new PdfPTable(1)
                    {
                        TotalWidth = 360f,
                        LockedWidth = true
                    };
                    PdfPCell lPdfPCell = null;
                    PdfPTable lPdfTable1 = new PdfPTable(2);
                    PdfPCell cell = new PdfPCell(new Phrase("ID of The Tag", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtuid.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("PV Module Manufacture Name", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtpvmanufacturer.Text, new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Month & Year of PV Module Manufacture", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    DateTime now = DateTime.Now;
                    cell = new PdfPCell(new Phrase(txtpvmdate.Text, new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Country of Origin of PV Module", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtcountry.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Unique Serial Number of the Module", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtsno1.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Module Type", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtmodule.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Max Wattage of the Module(Pmax)", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtpmax.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Max Current of the Module(Imax)", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtimax.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Max Voltage of the Module(Vmax)", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtvmax.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    // cell = new PdfPCell(new Phrase("Short Circuit Current of the Module(Isc)", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    //  lPdfTable1.AddCell(cell);
                    //    cell = new PdfPCell(new Phrase(this.txtIsc.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    // lPdfTable1.AddCell(cell);
                    //  cell = new PdfPCell(new Phrase("Open Circuit Voltage of the Module(Voc)", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    //   lPdfTable1.AddCell(cell);
                    // cell = new PdfPCell(new Phrase(this.txtVoc.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    // lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Fill Factor of the Module(FF)", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtff.Text.Trim(), new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Name of the Manufacture of Solar Cell", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtcellmname.Text, new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Month & Year of Cell Manufacture ", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtcellmdate.Text, new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Country of Origin Cell ", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtcountry1.Text, new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Date and Year of IEC PV Module Qualification Certification", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtcdate.Text, new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Name of the Test Lab Issuing IEC Certificate", new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);
                    cell = new PdfPCell(new Phrase(this.txtclab.Text, new iTextSharp.text.Font(FontFactory.GetFont("Verdana", 6f, BaseColor.BLACK))));
                    lPdfTable1.AddCell(cell);


                    lPdfPCell = new PdfPCell(new PdfPTable(lPdfTable1))
                    {
                        BackgroundColor = new BaseColor(Color.White)
                    };
                    PdfTable.AddCell(lPdfPCell);
                    PdfTable.SpacingBefore = 3f;
                    doc.Add(PdfTable);
                    iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(AppDomain.CurrentDomain.BaseDirectory + "pdf\\graphimg.jpg");
                    jpg.ScaleToFit(350f, 280f);
                    jpg.Alignment = 5;
                    jpg.IndentationLeft = 1f;
                    jpg.SpacingAfter = 9f;
                    jpg.BorderWidth = 36f;
                    jpg.SpacingBefore = 0f;
                    doc.Add(jpg);
                }
                catch (DocumentException documentException)
                {
                }
                catch (IOException oException)
                {
                }
                catch (Exception exception)
                {
                }
            }
            finally
            {
                doc.Close();
            }
        }

        #region Write func
        private void WriteDatFileInTag(string p)
		{
			MessageBox.Show("0");
			byte num = 0;
			byte num1 = 0;
			byte num2 = 0;
			byte num3 = 0;
			byte num4 = 0;
			int num5 = 0;
			FrmMain.MaskFlag = 0;
			this.maskadr_textbox.Text = "00";
			this.maskLen_textBox.Text = "00";
			MessageBox.Show("00");
			byte[] numArray = new byte[320];
			byte[] numArray1 = new byte[230];
			MessageBox.Show("000");
			if ((this.maskadr_textbox.Text == "" ? false : !(this.maskLen_textBox.Text == "")))
			{
				MessageBox.Show("1");
				FrmMain.Maskadr = Convert.ToByte(this.maskadr_textbox.Text, 16);
				FrmMain.MaskLen = Convert.ToByte(this.maskLen_textBox.Text, 16);
				string str = this.txtuid.Text.Trim();
				byte num6 = Convert.ToByte(str.Length / 4);
				num3 = Convert.ToByte(num6 * 2);
				byte[] byteArray = new byte[num6];
				MessageBox.Show("2");
				byteArray = this.HexStringToByteArray(str);
				MessageBox.Show("3");
				num1 = 3;
				this.Edit_WordPtr.Text = "00";
				string str1 = p;
				this.textbox1.Text = "64";
				byte num7 = Convert.ToByte(this.Edit_WordPtr.Text, 16);
				num = Convert.ToByte(this.textbox1.Text);
				MessageBox.Show("4");
				FrmMain.fPassWord = this.HexStringToByteArray("00000000");
				MessageBox.Show("5");
				num2 = Convert.ToByte(str1.Length / 4);
				byte[] byteArray1 = new byte[num2 * 2];
				MessageBox.Show("6");
				byteArray1 = this.HexStringToByteArray(str1);
				MessageBox.Show("7");
				num4 = Convert.ToByte(num2 * 2);
				FrmMain.fCmdRet = StaticClassReaderB.WriteCard_G2(ref FrmMain.fComAdr, byteArray, num1, num7, num4, byteArray1, FrmMain.fPassWord, FrmMain.Maskadr, FrmMain.MaskLen, FrmMain.MaskFlag, num5, num3, ref FrmMain.ferrorcode, FrmMain.frmcomportindex);
				MessageBox.Show("8");
				if (FrmMain.fCmdRet == 0)
				{
					MessageBox.Show("Tag Write Successfully");
				}
			}
			else
			{
				FrmMain.fIsInventoryScan = false;
			}
		}
        #endregion

        #region PageLoad
        private void WriteTag_Load(object sender, EventArgs e)
		{
			this.AppIniPath = AppDomain.CurrentDomain.BaseDirectory;
			this.PopulateModule();
		}
        #endregion

        #region Write Tag Functions
        private void WriteTagValue()
		{
			try
			{
				this.lWrite = false;
				if ((this.strWriteValue == "" ? true : this.strWriteValue == null))
				{
					MessageBox.Show("Search again or RFID Tag Not Found");
				}
				else
				{
					this.strIVValue1 = "";
					string str = "";
					int length = 128 - this.strWriteValue.Length;
					for (int i = 0; i < length; i++)
					{
						str = string.Concat(str, "0");
					}
					this.strIVValue1 = string.Concat(this.strWriteValue, str);
					if (this.WriteDatFileDataInTag(this.strIVValue1))
					{
						this.textBox2.Text = this.strIVValue1;
						this.strIVValue1 = "";
						this.strWriteValue = "";
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Some error found try again");
			}
		}

        private void WriteXMLForTag()
        {
            string str = string.Concat(this.AppIniPath, "\\XMLTag.xml");
            XmlTextReader xmlTextReader = new XmlTextReader(str);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlTextReader);
            xmlTextReader.Close();
            XmlDocumentFragment xmlDocumentFragment = xmlDocument.CreateDocumentFragment();
            object[] d = new object[] { "<Tag><ID>", this.ID, "</ID><ModuleNo>", this.txtmodule.Text.Trim(), "</ModuleNo><SerialNo>", this.txtsno1.Text.Trim(), "</SerialNo><Isc>", this.RIscMax, "</Isc><Voc>", this.RVocMax, "</Voc><PMax>", this.RPMax, "</PMax><IMax>", this.RIMax, "</IMax><VMax>", this.RVMax, "</VMax><FF>", this.RFF, "</FF><Effeciency>", this.REffMax, "</Effeciency><UniqueNo>", this.txtuid.Text.Trim(), "</UniqueNo><WDate>", null, null };
            d[23] = DateTime.Today.Date.ToShortDateString();
            d[24] = "</WDate></Tag>";
            xmlDocumentFragment.InnerXml = string.Concat(d);
            XmlNode documentElement = xmlDocument.DocumentElement;
            documentElement.InsertAfter(xmlDocumentFragment, documentElement.LastChild);
            xmlDocument.Save(str);
		}
        #endregion

        #region GetUnique Id

        private void btnGetUniqueID_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region WriteCompanySettings
        private void WriteCompanySettings()
        {
            clscommon lComman = new clscommon();
            lComman.SetCommandObject("insert into T_EInfo(PVModule,Warranty,PVMName,PVCountry,PVDate,CellMName,CellCountry,CellDate,IECLab,IECDate,serial,Eserial) values(@PVModule,@Warranty,@PVMName,@PVCountry,@PVDate,@CellMName,@CellCountry,@CellDate,@IECLab,@IECDate,@serial,@Eserial)");
            lComman.AddParameterInCommandObject("@PVModule", txtmodule.Text.Trim());
            lComman.AddParameterInCommandObject("@Warranty", waranty.ToString());
            lComman.AddParameterInCommandObject("@PVMName", txtpvmanufacturer.Text);
            lComman.AddParameterInCommandObject("@PVCountry", txtcountry.Text);
            lComman.AddParameterInCommandObject("@PVDate", txtpvmdate.Text);
            lComman.AddParameterInCommandObject("@CellMName", txtcellmname.Text);
            lComman.AddParameterInCommandObject("@CellCountry", txtcountry1.Text);
            lComman.AddParameterInCommandObject("@CellDate", txtcellmdate.Text.Trim());
            lComman.AddParameterInCommandObject("@IECLab", txtclab.Text.Trim());
            lComman.AddParameterInCommandObject("@IECDate", txtcdate.Text.Trim());
            lComman.AddParameterInCommandObject("@serial", txtsno1.Text.Trim());
            lComman.AddParameterInCommandObject("@Eserial", txtuid.Text.Trim());
            lComman.objCommand.ExecuteNonQuery();
            lComman.DestroyCommandObject();
            lComman = null;
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.lOperationType = "";
            this.dt.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                DefaultExt = "xls",
                Filter = "Office Files|*.xls;*.xlsx"
            };
            openFileDialog.ShowDialog();
            if ((int)openFileDialog.FileNames.Length > 0)
            {
                
                this.txtsno.Text = openFileDialog.FileName;
                this.lOperationType = "Excel";
                this.GetExtention();
                this.lSolar = new AlpexSolarRFID();
                this.dt = this.lSolar.ReadExcelFile(this.txtsno.Text, this.fExtension);
                this.lSolar = null;
                 
                    txtsno1.Text = dt.Rows[lRows]["SN"].ToString();

            
            }
        }

        private void btnGetUniqueID_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((this.txtmodule.Text == "" ? false : this.txtsno1.Text != "") && txtsno1.Text.Length < 17)
                {
                    string str = "";
                    for (int i = 0; i < this.DsModule.Tables[0].Rows.Count; i++)
                    {
                        if (this.txtmodule.Text.Trim() == this.DsModule.Tables[0].Rows[i]["PVModule"].ToString())
                        {
                            this.txtpvmanufacturer.Text = this.DsModule.Tables[0].Rows[i]["PVMName"].ToString();
                            this.txtpvmdate.Text = this.DsModule.Tables[0].Rows[i]["PVDate"].ToString();
                            this.txtcountry.Text = this.DsModule.Tables[0].Rows[i]["PVCountry"].ToString();
                            this.txtcellmname.Text = this.DsModule.Tables[0].Rows[i]["CellMName"].ToString();
                            this.txtcountry1.Text = this.DsModule.Tables[0].Rows[i]["CellCountry"].ToString();
                            this.txtcellmdate.Text = this.DsModule.Tables[0].Rows[i]["CellDate"].ToString();
                            this.txtclab.Text = this.DsModule.Tables[0].Rows[i]["IECLab"].ToString();
                            this.txtcdate.Text = this.DsModule.Tables[0].Rows[i]["IECDate"].ToString();
                            this.txttagmfg.Text = "ID Tech Solution";
                            waranty = Convert.ToInt32(DsModule.Tables[0].Rows[i]["Warranty"].ToString());
                            string str1 = this.DsModule.Tables[0].Rows[i]["ID"].ToString();
                            if (str1.Length != 1)
                            {
                                str = (str1.Length != 2 ? string.Concat(str, str1.ToString()) : string.Concat(str, "0", str1.ToString()));
                            }
                            else
                            {
                                str = string.Concat(str, "00", str1.ToString());
                            }
                            if (this.lOperationType == "Excel")
                            {
                                this.GetSqlExcelInformation(this.dt, "Excel", str);
                            }
                            else if (this.lOperationType == "Sql")
                            {
                                this.GetSqlExcelInformation(this.dt, "Sql", str);
                            }
                        }
                    }
                    this.GetRFIDTagID();
                }
                else
                {
                    MessageBox.Show("Serial No. should not more than 16 digit OR Select PV Module Name","Warning",MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Serial No");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if ((this.txtuid.Text == "" ? false : this.txtuid.Text != null))
            {
                this.WriteTagValue();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            CurveGraph curveGraph = new CurveGraph();
            curveGraph.t1.Text = this.AddPoints();
            curveGraph.Show();
        }

        private void txtpvmanufacturer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}