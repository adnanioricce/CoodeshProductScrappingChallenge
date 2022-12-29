using Microsoft.Data.SqlClient;
using System.Data;

namespace Lib
{
    public static class AppConnection
    {
        public static IDbConnection CreateConnection(Func<string> getConnectionString)
        {
            var connStr = getConnectionString();
            return new SqlConnection(connStr);
        }
        public static IDbConnection CreateConnection()
        {
            var getConnectionString = () => Environment.GetEnvironmentVariable("DATABASE_URL");
            return CreateConnection(getConnectionString);
        }
        public static T OnConnection<T>(CreateConnection createConnection,Func<IDbConnection,T> onConn)
        {
            using (var conn = createConnection())
            {
                return onConn(conn);
            }
        }
        public static Task<T> OnConnection<T>(CreateConnection createConnection, Func<IDbConnection, Task<T>> onConn)
        {
            using (var conn = createConnection())
            {
                return onConn(conn);
            }
        }
    }
}
