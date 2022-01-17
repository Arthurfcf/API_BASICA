/*using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Context
{
    public class IDBConnection : IDisposable
    {
        public IDbConnection Connection { set; get; }
        public IDBConnection(IConfiguration configuration)
        {
            Connection = new SqlConnection(configuration
                .GetConnectionString("DefaultConnection"));

        }

        void IDisposable.Dispose()
        {
            Connection?.Dispose();
        }

       
    }
}
*/