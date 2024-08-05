using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramais.scripts
{
    internal class dbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public dbConnection()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port:5432;Database=ramais;User Id=postgres;Password=1515;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
