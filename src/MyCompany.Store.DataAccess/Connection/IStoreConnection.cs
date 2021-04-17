using Microsoft.Data.SqlClient;

namespace MyCompany.Store.DataAccess.Connection
{
    public interface IStoreConnection
    {
        SqlConnection SqlConnection { get; }
    }
}
