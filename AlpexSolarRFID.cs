using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ArkaGreenPowerPvtLtd
{
	public class AlpexSolarRFID
	{
		private string strPath;

		private string lExcelFile;

		public DataTable objOrignalTable;

		private int lExcelTableCount = 0;

		public AlpexSolarRFID()
		{
		}

		private void CreateTable(DataTable objExcelDataTable)
		{
			this.objOrignalTable = new DataTable();
			for (int i = 0; i <= objExcelDataTable.Columns.Count - 1; i++)
			{
				this.objOrignalTable.Columns.Add(objExcelDataTable.Columns[i].ColumnName.ToString().Trim());
			}
		}

		public DataTable Extract2007Data(string argSheetName)
		{
			string str = string.Concat("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='", this.lExcelFile.ToString(), "';Extended Properties=Excel 12.0");
			string str1 = string.Concat("SELECT * FROM [", argSheetName, "$]");
			OleDbConnection oleDbConnection = new OleDbConnection(str);
			oleDbConnection.Open();
			OleDbCommand oleDbCommand = new OleDbCommand(str1, oleDbConnection);
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
			DataTable dataTable = new DataTable();
			oleDbDataAdapter.Fill(dataTable);
			oleDbDataAdapter.Dispose();
			oleDbCommand.Dispose();
			oleDbConnection.Close();
			oleDbConnection.Dispose();
			return dataTable;
		}

		public DataTable ExtractData(string argSheetName, string Ext)
		{
			DataTable dataTable = null;
			if (argSheetName.Trim() != "")
			{
				if (Ext.Trim().ToUpper() == "XLS")
				{
					dataTable = this.ExtractData1(argSheetName);
				}
				else if (Ext.Trim().ToUpper() == "XLSX")
				{
					dataTable = this.Extract2007Data(argSheetName);
				}
				if (dataTable == null)
				{
					MessageBox.Show(string.Concat(argSheetName.ToUpper(), " sheet does not exist in the supplied excel file, please check the sheet name and try again"));
				}
				else
				{
					dataTable = this.RemoveBlankRows(dataTable);
				}
			}
			return dataTable;
		}

		public DataTable ExtractData1(string argSheetName)
		{
			DataTable dataTable = null;
			OleDbConnection oleDbConnection = new OleDbConnection(string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='", this.lExcelFile.ToString(), "';Extended Properties=Excel 8.0;"));
			oleDbConnection.Open();
			Guid tables = OleDbSchemaGuid.Tables;
			object[] objArray = new object[] { null, null, null, "TABLE" };
			oleDbConnection.GetOleDbSchemaTable(tables, objArray);
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(string.Concat("Select * from [", argSheetName, "$] "), oleDbConnection);
			DataTable dataTable1 = new DataTable();
			oleDbDataAdapter.Fill(dataTable1);
			if (dataTable1 != null)
			{
				dataTable = dataTable1;
			}
			dataTable1 = null;
			oleDbConnection.Close();
			return dataTable;
		}

		public string GetFolderPath()
		{
			string currentDirectory = Environment.CurrentDirectory;
			string[] strArrays = File.ReadAllLines(string.Concat(currentDirectory, "\\config.ini"));
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				this.strPath = strArrays[i];
			}
			return this.strPath;
		}

		public DataTable ImportCardValue(string argSheetName, string Ext)
		{
			DataTable dataTable;
			DataTable dataTable1 = new DataTable();
			DataTable dataTable2 = this.ExtractData(argSheetName, Ext);
			if (dataTable2 != null)
			{
				this.CreateTable(dataTable2);
				dataTable = this.InsertValueInDataTable(dataTable2);
			}
			else
			{
				dataTable = null;
			}
			return dataTable;
		}

		private DataTable InsertValueInDataTable(DataTable objDataTable1)
		{
			for (int i = 0; i <= objDataTable1.Rows.Count - 1; i++)
			{
				if (objDataTable1.Rows[i][0].ToString().Trim() != "")
				{
					DataRow dataRow = this.objOrignalTable.NewRow();
					for (int j = 0; j < this.objOrignalTable.Columns.Count; j++)
					{
						dataRow[j] = objDataTable1.Rows[i][j].ToString().Trim();
					}
					this.objOrignalTable.Rows.Add(dataRow);
				}
			}
			return this.objOrignalTable;
		}

		public DataTable ReadExcelFile(string lFile, string Ext)
		{
			DataTable dataTable = new DataTable();
			try
			{
				this.lExcelFile = lFile;
				dataTable = this.ImportCardValue("Sheet1", Ext);
				if (dataTable.Rows.Count > 0)
				{
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
			return dataTable;
		}

		private DataTable RemoveBlankRows(DataTable objDataTable)
		{
			int num = 0;
			int i = 0;
			while (i <= objDataTable.Rows.Count - 1)
			{
				if (!(objDataTable.Rows[i][0].ToString().Trim() == ""))
				{
					i++;
				}
				else
				{
					num = i - 1;
					break;
				}
			}
			if (num != 0)
			{
				for (i = objDataTable.Rows.Count - 1; i > num; i--)
				{
					objDataTable.Rows.RemoveAt(i);
				}
			}
			return objDataTable;
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

		public static string SubstringBefore(string source, string value)
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
	}
}