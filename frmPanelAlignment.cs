using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReaderB;

namespace ArkaGreenPowerPvtLtd
{
    public partial class frmPanelAlignment : Form
    {
        #region for Variable
        TextBox maskadr_textbox = new TextBox();
        TextBox Edit_WordPtr = new TextBox();
        TextBox maskLen_textBox = new TextBox();
        TextBox textbox1 = new TextBox();
        TextBox txtUID = new TextBox();
        string ReadRfidTagValue;
        string AppIniPath;
        private string m_plotString;
        #endregion

        public frmPanelAlignment()
        {
            InitializeComponent();
        }

        private void btnStartReading_Click(object sender, EventArgs e)
        {
            if (btnStartReading.Text == "Start Reading")
            {
                timer1.Enabled = true;
                btnStartReading.Text = "Stop Reading";
            }
            else if (btnStartReading.Text == "Stop Reading")
            {
                timer1.Enabled = false;
                btnStartReading.Text = "Start Reading";
            }
        }
        #region for Get RFID Tag No
        private void GetRFIDTagID()
        {
            int CardNum = 0; int Totallen = 0; int EPClen, m; byte[] EPC = new byte[5000]; int CardIndex; string temps;
            string sEPC; bool isonlistview;
            byte AdrTID = 0; byte LenTID = 0; byte TIDFlag = 0;
            FrmMain.fCmdRet = StaticClassReaderB.Inventory_G2(ref FrmMain.fComAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, FrmMain.frmcomportindex);
            if ((FrmMain.fCmdRet == 1) | (FrmMain.fCmdRet == 2) | (FrmMain.fCmdRet == 3) | (FrmMain.fCmdRet == 4) | (FrmMain.fCmdRet == 0xFB))
            {
                byte[] daw = new byte[Totallen];
                Array.Copy(EPC, daw, Totallen);
                temps = ByteArrayToHexString(daw);
                m = 0;
                if (CardNum != 0)
                {
                    for (CardIndex = 0; CardIndex < CardNum; CardIndex++)
                    {
                        EPClen = daw[m];
                        sEPC = temps.Substring(m * 2 + 2, EPClen * 2);
                        m = m + EPClen + 1;
                        if (sEPC.Length == EPClen * 2)
                        {
                            isonlistview = false;
                            if (!isonlistview)
                            {
                                txtUID.Text = sEPC;
                            }
                        }
                    }
                }
            }
            if ((FrmMain.fCmdRet == 0x30) || (FrmMain.fCmdRet == 0x37))
            {
                timer1.Enabled = false;
                MessageBox.Show("Reader Got Disconnected.Please Restart your application");
                this.Close();
                Application.Exit();
            }
        }
        #endregion

        #region for Read Tag Value
        private string ReadTagValue()
        {
            byte WordPtr, ENum;
            byte Num = 0;
            byte Mem = 0;
            byte EPClength = 0;
            string str;
            byte[] CardData = new byte[320];
            FrmMain.MaskFlag = 0;
            maskadr_textbox.Text = "00";
            maskLen_textBox.Text = "00";
            FrmMain.Maskadr = Convert.ToByte(maskadr_textbox.Text, 16);
            FrmMain.MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
            str = txtUID.Text.Trim();
            ENum = Convert.ToByte(str.Length / 4);
            EPClength = Convert.ToByte(ENum * 2);
            byte[] EPC = new byte[ENum];
            EPC = HexStringToByteArray(str);
            Mem = 3;
            Edit_WordPtr.Text = "00";
            textbox1.Text = "32";
            WordPtr = Convert.ToByte(Edit_WordPtr.Text, 16);
            Num = Convert.ToByte(textbox1.Text);
            FrmMain.fPassWord = HexStringToByteArray("00000000");
            FrmMain.fCmdRet = StaticClassReaderB.ReadCard_G2(ref FrmMain.fComAdr, EPC, Mem, WordPtr, Num, FrmMain.fPassWord, FrmMain.Maskadr, FrmMain.MaskLen, FrmMain.MaskFlag, CardData, EPClength, ref FrmMain.ferrorcode, FrmMain.frmcomportindex);
            if (FrmMain.fCmdRet == 0)
            {
                byte[] daw = new byte[Num * 2];
                Array.Copy(CardData, daw, Num * 2);
                ReadRfidTagValue = ByteArrayToHexString(daw);
            }
            else
                ReadRfidTagValue = "";
            return ReadRfidTagValue;
        }
        #endregion

        #region for ByteArrayToHexString
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();

        }
        #endregion

        #region for HexStringToByteArray
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        #endregion

        #region timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                GetRFIDTagID();
                if (txtUID.Text != "")
                {
                    string strReadTagValue = ReadTagValue();
                    if (strReadTagValue != "")
                    {
                        listBox1.Items.Add(strReadTagValue);
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    }
                }
            }
            catch (Exception exp) { }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

    }
}
