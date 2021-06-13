using System.Collections.Generic;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnection()
        {
            // Establish DB Connections
        }
    }
}