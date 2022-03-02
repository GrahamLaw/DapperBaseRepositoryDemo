using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DapperBaseRepositoryDemo.Repositories
{
    public class BaseRepository
    {
        private readonly IConfiguration configuration;
        private readonly string connString;
        public BaseRepository(IConfiguration configuration) 
        {
            this.configuration = configuration;
            var conn = configuration.GetConnectionString("DefaultConnection");
        }

        public List<T> Query<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    return conn.Query<T>(query, parameters).ToList();
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return new List<T>();
            }
        }

        public T QueryFirst<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn
                       = new SqlConnection("Your Connection String"))
                {
                    return conn.QueryFirst<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public T QueryFirstOrDefault<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn
                       = new SqlConnection("Your Connection String"))
                {
                    return conn.QueryFirstOrDefault<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public T QuerySingle<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn
                       = new SqlConnection("Your Connection String"))
                {
                    return conn.QuerySingle<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public T QuerySingleOrDefault<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn
                       = new SqlConnection("Your Connection String"))
                {
                    return conn.QuerySingleOrDefault<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
                return default; //Or however you want to handle the return
            }
        }

        public void Execute(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn
                       = new SqlConnection("Your Connection String"))
                {
                    conn.Execute(query, parameters);
                }
            }
            catch (Exception ex)
            {
                //Handle the exception
            }
        }

    }
}
