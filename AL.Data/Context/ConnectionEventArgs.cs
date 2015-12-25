using System;
using System.Data;

namespace AL.Data
{
	public class ConnectionEventArgs : EventArgs
	{
		public IDbConnection Connection { get; private set; }

		public ConnectionEventArgs(System.Data.IDbConnection connection)
		{
			Connection = connection;
		}
	}
}
