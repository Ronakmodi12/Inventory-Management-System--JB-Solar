using System;
using System.Data;

namespace ArkaGreenPowerPvtLtd
{
	public class ClsCheck
	{
		private bool Flag;

		private IDataReader lReader;

		public ClsCheck()
		{
		}

		public bool CheckFunction(string StrSql)
		{
			clscommon _clscommon = new clscommon();
			_clscommon.SetCommandObject(StrSql);
			this.lReader = _clscommon.objCommand.ExecuteReader();
			if (!this.lReader.Read())
			{
				this.Flag = false;
			}
			else
			{
				this.Flag = true;
			}
			_clscommon.DestroyCommandObject();
			_clscommon = null;
			return this.Flag;
		}

        public DataSet FillDataGrid(string StrSql)
        {
            clscommon lComman = new clscommon();
            lComman.SetAdapterObject(StrSql);
            DataSet Ds = new DataSet();
            lComman.lAdapter.Fill(Ds);
            lComman.DestroyAdapterObject();
            lComman = null;
            return Ds;
        }
	}
}