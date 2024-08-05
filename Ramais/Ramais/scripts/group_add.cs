using Dapper;
using System;
using System.Collections.Generic;
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

        public List<Group> Get()
        {
            using var conn = new dbConnection();

            string query = "select name,id from groups";

            var groups = conn.Connection.Query<Group>(sql: query);

            return groups.ToList();

        }


    }
}
