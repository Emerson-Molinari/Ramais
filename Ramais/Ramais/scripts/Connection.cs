using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Windows.Forms;
using Dapper;

namespace Ramais.scripts
{
    internal class Connection
    {
        private static NpgsqlConnection Conn;

        private static NpgsqlConnection ConnBase()
        {
            Conn = new NpgsqlConnection("Server=192.168.2.200;Port=5432;Database=Ramais;User Id=postgres;Password=1234;");
            Conn.Open();

            return Conn;
        }

        public static DataTable getList;
        public static NpgsqlDataReader GetDr;

        public static DataTable Get(string sql)
        {
            DataTable dt = new DataTable();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = ConnBase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            NpgsqlDataReader dr = cmd.ExecuteReader();
            GetDr = dr;

            if (dr.HasRows)
            {
                dt.Load(dr);
                getList = dt;
            }

            Conn.Dispose();
            Conn.Close();

            return dt;
        }

        public static void Set(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = ConnBase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            ConnBase().Execute(sql);

            Conn.Dispose();
            Conn.Close();
        }

        public static void Delete(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = ConnBase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            ConnBase().Execute(sql);

            Conn.Dispose();
            Conn.Close();
        }

        public static void Query(string sql)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = ConnBase();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            ConnBase().Execute(sql);

            Conn.Dispose();
            Conn.Close();
        }


        /*

        private static SQLiteConnection connect;

        private static SQLiteConnection connectBase()
        {
            connect = new SQLiteConnection("Data Source=C:\\Users\\Zata30\\Documents\\GitHub\\Ramais\\Ramais\\Ramais\\db\\database.db");
            connect.Open();

            return connect;
        }

        public static DataTable getGroups()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {

                using (var cmd = connectBase().CreateCommand())
                {
                    cmd.CommandText = "select * from groups";
                    da = new SQLiteDataAdapter(cmd.CommandText, connectBase());
                    da.Fill(dt);

                    return dt;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static void setUser(User_add user, int group)
        {
            if (existSetUser(user))
            {
                MessageBox.Show("Ramal já cadastrado");
                return;
            }

            try
            {

                var cmd = connectBase().CreateCommand();
                cmd.CommandText = "insert into users (name,ramal,'group') values (@name,@ramal,@group)";
                
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@ramal", user.ramal);
                cmd.Parameters.AddWithValue("@group", group);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ramal Definido na lista! Reabra o aplicativo nos outros computadores para atualizar");
                connectBase().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao graval na lista! contate o Administrador." + ex);
                connectBase().Close();
            }
            

        }

        public static void setGroup(group_add g)
        {
            try
            {

                var cmd = connectBase().CreateCommand();
                cmd.CommandText = "insert into groups (name) values (@name)";

                cmd.Parameters.AddWithValue("@name", g.groupName);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Grupo Criado! Reabra o aplicativo nos outros computadores para atualizar");
                connectBase().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao graval na lista! contate o Administrador." + ex);
                connectBase().Close();
            }
        }

        public static bool existSetUser(User_add user)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd=connectBase().CreateCommand();
            cmd.CommandText = "Select ramal from users where ramal ='" + user.ramal + "'";

            da = new SQLiteDataAdapter(cmd.CommandText, connectBase());
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }


        //load datagrid view

        public static DataTable dt_group;
        
        public static void dataGrouplist()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = connectBase().CreateCommand();
            cmd.CommandText = "select name,id from groups";

            da = new SQLiteDataAdapter(cmd.CommandText, connectBase());
            da.Fill(dt);

            dt_group = dt;
        }


        public static DataTable dt_Users;

        public static void dataUserlist(int group)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = connectBase().CreateCommand();
            cmd.CommandText = "select name,ramal,id from users where \"group\" =" + group;

            da = new SQLiteDataAdapter(cmd.CommandText, connectBase());
            da.Fill(dt);

            dt_Users = dt;
        }

        public static void deleteUser(int userId)
        {
            var cmd = connectBase().CreateCommand();
            cmd.CommandText = "DELETE FROM users WHERE id =" + userId;

            cmd.ExecuteNonQuery();
        }

        public static void deleteGroup(int groupId)
        {
            var cmd = connectBase().CreateCommand();
            cmd.CommandText = "DELETE FROM groups WHERE id =" + groupId;

            cmd.ExecuteNonQuery();
        }
        */
    }
        

    }
