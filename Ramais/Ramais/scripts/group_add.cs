using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramais.scripts
{
    internal class group_add
    {
        public string groupName;
        
        public bool Add(group_add g)
        {
            using var conn = new dbConnection();

            string query = @"insert into public.groups(name) values (@name)";

            var result = conn.Connection.Execute(sql: query, param: g);

            return result == 1;
        }
    }
}
