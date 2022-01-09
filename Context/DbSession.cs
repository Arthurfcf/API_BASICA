using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Context
{
    public class DbSession : IDisposable
    {
        public IDbConnection Connection { get; }
        public DbSession(IConfiguration configuration)
        {
            Connection = new SqlConnection(configuration
                .GetConnectionString("."));

        }

        public void Dispose() => Connection?.Dispose();
       
    }
}
