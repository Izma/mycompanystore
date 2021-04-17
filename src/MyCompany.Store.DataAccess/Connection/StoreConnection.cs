using Microsoft.Data.SqlClient;

namespace MyCompany.Store.DataAccess.Connection
{
    public class StoreConnection : IStoreConnection
    {
        private readonly string _connectionString;

        public StoreConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection SqlConnection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }
    }
}
