using System;
using System.Windows.Forms;

namespace ArkaGreenPowerPvtLtd
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			DateTime.Now.Date.ToShortDateString();
			DateTime dateTime = Convert.ToDateTime("09/09/2035");
			if (DateTime.Now.Date <= dateTime)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new FrmMain());
			}
		}
	}
}