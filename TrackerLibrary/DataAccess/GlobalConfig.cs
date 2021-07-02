using System.Collections.Generic;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnection()
        {
            SqlConnector sql = new SqlConnector();
            Connections.Add(sql);
        }
    }
}