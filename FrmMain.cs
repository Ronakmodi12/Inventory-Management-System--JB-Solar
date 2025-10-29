using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ReaderB;

namespace ArkaGreenPowerPvtLtd
{
    public partial class FrmMain : Form
    {
        #region for RFID Variable
        string temp = "";
        TextBox maskadr_textbox = new TextBox();
        TextBox Edit_WordPtr = new TextBox();
        TextBox maskLen_textBox = new TextBox();
        TextBox textbox1 = new TextBox();
        TextBox txtrfidno = new TextBox();
        public static bool fAppClosed;
        public static byte fComAdr = 0xff;
        public static int ferrorcode;
        public static byte fBaud;
        public static double fdminfre;
        public static double fdmaxfre;
        public static byte Maskadr;
        public static byte MaskLen;
        public static byte MaskFlag;
        public static int fCmdRet = 30;
        public static int fOpenComIndex;
        public static bool fIsInventoryScan;
        public static bool fisinventoryscan_6B;
        public static byte[] fOperEPC = new byte[36];
        public static byte[] fPassWord = new byte[4];
        public static byte[] fOperID_6B = new byte[8];
        public static int CardNum1 = 0;
        public static bool fTimer_6B_ReadWrite;
        public static string fInventory_EPC_List;
        public static int frmcomportindex;
        public static bool ComOpen = false;
        TextBox Edit_CmdComAddr = new TextBox();
        ComboBox ComboBox_COM = new ComboBox();
        ComboBox ComboBox_baud2 = new ComboBox();
        #endregion

        #region for Constructor
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion
        
        #region for Open Read Tag
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showForm(new ReadTag());
        }
        #endregion
        
        #region for Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        
        #region for open CountryDetails
        private void addCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                showForm(new CountryDetails());
            }
            catch (Exception ex) { }
        }
        #endregion
        
        #region for open ModuleMFG
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                showForm(new ModuleMFG());
            }
            catch (Exception ex) { }
        }
        #endregion
        
        #region for open CellMFG
        private void cellManufactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new CellMFG());
        }
        #endregion
        
        #region for open IEC
        private void iECCertificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new IEC());
        }
        #endregion
        
        #region for open Module
        private void moduleNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new Module());
        }
        #endregion
        
        #region for open CompanySettings
        private void companySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new CompanySettings());
        }
        #endregion
        
        #region for open Tag Write
        private void toolwritetag_Click(object sender, EventArgs e)
        {
            showForm(new WriteTag());
        }
        #endregion

        #region for SetBackGroundColorOfMDIForm
        private void SetBackGroundColorOfMDIForm()
        {
            // If the control is the correct type,
            // change the color.
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)
                {
                    //ctl.BackgroundImage = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\bg.jpg");
                }
            }
        }
        #endregion 

        #region for Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            fOpenComIndex = -1;
            fComAdr = 0;
            ferrorcode = -1;
            fBaud = 5;
            ComboBox_COM.Items.Clear();
            ComboBox_COM.Items.Add(" AUTO");
            for (int i = 1; i < 13; i++)
                ComboBox_COM.Items.Add(" COM" + Convert.ToString(i));
            ComboBox_COM.SelectedIndex = 0;
            ComboBox_baud2.Items.Add("9600bps");
            ComboBox_baud2.Items.Add("19200bps");
            ComboBox_baud2.Items.Add("38400bps");
            ComboBox_baud2.Items.Add("57600bps");
            ComboBox_baud2.Items.Add("115200bps");
            ComboBox_baud2.SelectedIndex = 3;
           // ConnectReader1();
           // ConnectReader107();
        }
        #endregion
        
        #region for Connect Reader
        private void ConnectReader()
        {
            int port = 0;
            int openresult;
            openresult = 30;
            Cursor = Cursors.WaitCursor;
            Edit_CmdComAddr.Text = "FF";
            fComAdr = Convert.ToByte(Edit_CmdComAddr.Text, 16);
            try
            {
                if (ComboBox_COM.SelectedIndex == 0)//Auto
                {
                    fBaud = Convert.ToByte(ComboBox_baud2.SelectedIndex);
                    if (fBaud > 2)
                    {
                        fBaud = Convert.ToByte(fBaud + 2);
                    }
                    openresult = StaticClassReaderB.OpenComPort( ComboBox_COM.SelectedIndex, ref fComAdr, fBaud, ref frmcomportindex);
                    fOpenComIndex = frmcomportindex;
                    if (openresult == 0)
                    {
                        ComOpen = true;
                        if ((fCmdRet == 0x35) | (fCmdRet == 0x30))
                        {
                            MessageBox.Show("Serial Communication Error or Occupied", "Information");
                            StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                            ComOpen = false;
                        }
                        else
                            toolStripStatusLabel1.Text = "Reader Connected";
                    }
                }
                else
                {
                    temp = ComboBox_COM.SelectedItem.ToString();
                    temp = temp.Trim();
                    port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
                    for (int i = 6; i >= 0; i--)
                    {
                        fBaud = Convert.ToByte(i);
                        if (fBaud == 3)
                            continue;
                        openresult = StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref frmcomportindex);
                        fOpenComIndex = frmcomportindex;
                        if (openresult == 0x35)
                        {
                            return;
                        }
                        if (openresult == 0)
                        {
                            ComOpen = true;
                            if ((fCmdRet == 0x35) || (fCmdRet == 0x30))
                            {
                                ComOpen = false;
                                MessageBox.Show("Serial Communication Error or Occupied", "Information");
                                StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                                return;
                            }
                            else
                            {
                                toolStripStatusLabel1.Text = "Reader Connected";
                                return;
                            }
                        }

                    }
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion

        #region for Connect Reader
        private void ConnectReader1()
        {
            int port = 0;
            int openresult;
            openresult = 30;
            string IPAddr;
            Cursor = Cursors.WaitCursor;
            Edit_CmdComAddr.Text = "FF";
            fComAdr = Convert.ToByte(Edit_CmdComAddr.Text, 16);
            try
            {
                port = Convert.ToInt32("6000");
                IPAddr = "192.168.1.190";
                openresult = StaticClassReaderB.OpenNetPort(port, IPAddr, ref fComAdr, ref frmcomportindex);
                fOpenComIndex = frmcomportindex;
                if (openresult == 0)
                {
                    ComOpen = true;
                    if ((fCmdRet == 0x35) | (fCmdRet == 0x30))
                    {
                        MessageBox.Show("Serial Communication Error or Occupied", "Information");
                        StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                        ComOpen = false;
                    }
                    else
                        toolStripStatusLabel1.Text = "Reader Connected";
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion
        
        #region for Daily Report
        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new DatewiseReport());
        }
        #endregion

        private void modulewiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new ModuleReportRFID());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showForm(new frmPanelAlignment());
        }

        #region Close Last Form
        private Form lastForm;
        private void showForm(Form frm)
        {
            frm.FormClosed += (sender, ea) =>
            {
                if (object.ReferenceEquals(lastForm, sender)) lastForm = null;
            };
            frm.MdiParent = this;
            frm.Show();
            if (lastForm != null) lastForm.Close();
            lastForm = frm;
        }
        #endregion

        #region for Connect Reader
        private void ConnectReader107()
        {
            int port = 0;
            int openresult;
            openresult = 30;
            Cursor = Cursors.WaitCursor;
            Edit_CmdComAddr.Text = "FF";
            fComAdr = Convert.ToByte(Edit_CmdComAddr.Text, 16);
            try
            {
                if (ComboBox_COM.SelectedIndex == 0)//Auto
                {
                    fBaud = Convert.ToByte(ComboBox_baud2.SelectedIndex);
                    if (fBaud > 2)
                    {
                        fBaud = Convert.ToByte(fBaud + 2);
                    }
                    openresult = StaticClassReaderB.AutoOpenComPort(ref port, ref fComAdr, fBaud, ref frmcomportindex);
                    fOpenComIndex = frmcomportindex;
                    if (openresult == 0)
                    {
                        ComOpen = true;
                        if ((fCmdRet == 0x35) | (fCmdRet == 0x30))
                        {
                            MessageBox.Show("Serial Communication Error or Occupied", "Information");
                            StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                            ComOpen = false;
                        }
                        else
                            toolStripStatusLabel1.Text = "Reader Connected";
                    }
                    else
                        toolStripStatusLabel1.Text = "Reader Not Connected";
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //showForm(new CompanySettings());
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm(new DatewiseReport());
        }
    }
}
