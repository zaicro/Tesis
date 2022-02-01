using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace TesisApi.Infraestructure
{
    public class SqlContextExtends : DbContext
    {
        private static String _defaultSchemaName;

        public static String DefaultSchemaName
        {
            get { return _defaultSchemaName; }
            set
            {
                _defaultSchemaName = String.IsNullOrWhiteSpace(value)
                  ? "dbo"
                  : value;
            }
        }
        private static String ConnectionString { get; set; }
        private static readonly Int32 CommandTimeout = 0;

        public SqlContextExtends(string connectionString)
            : base(GetOptions(connectionString))
        {
            ConnectionString = connectionString;
        }
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        public virtual void BulkCopy(String TableName, DataTable table)
        {
            using SqlConnection sqlCon = new(ConnectionString);
            sqlCon.Open();
            using SqlBulkCopy bulkCopy = new(sqlCon);
            bulkCopy.BulkCopyTimeout = 0;
            bulkCopy.BatchSize = 10000;
            bulkCopy.DestinationTableName = TableName;
            bulkCopy.WriteToServer(table);
        }
        public virtual void BulkCopy(String TableName, IDataReader reader)
        {
            var table = new DataTable();
            table.Load(reader, LoadOption.OverwriteChanges);
            BulkCopy(TableName, table);
        }
        public virtual List<T> RunSP<T>(String procedureName, SqlParameter[] parameters)
        {
            if (procedureName.Split('.').Length < 2)
                procedureName = $"{DefaultSchemaName}.{procedureName}";

            using SqlConnection sqlConn = new(ConnectionString);
            using SqlCommand sqlCommand = new(procedureName, sqlConn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = CommandTimeout;
            if (parameters != null) sqlCommand.Parameters.AddRange(parameters);
            sqlConn.Open();
            var dr = sqlCommand.ExecuteReader();
            return DataReaderMapToList<T>(dr);
        }
        public virtual DataTable RunSp(String procedureName, SqlParameter[] parameters)
        {
            DataTable dt = new();
            using (SqlConnection sqlConn = new(ConnectionString))
            {
                using SqlCommand sqlCommand = new(procedureName, sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = CommandTimeout;
                if (parameters != null) sqlCommand.Parameters.AddRange(parameters);
                using var da = new SqlDataAdapter(sqlCommand);
                sqlConn.Open();
                da.Fill(dt);
            }
            return dt;
        }
        public virtual List<T> RunQuery<T>(String query)
        {
            using SqlConnection sqlConn = new(ConnectionString);
            using SqlCommand sqlCommand = new(query, sqlConn);
            sqlCommand.CommandTimeout = CommandTimeout;
            sqlConn.Open();
            var dr = sqlCommand.ExecuteReader();
            return DataReaderMapToList<T>(dr);
        }
        public virtual DataTable RunQuery(String query)
        {
            var table = new DataTable();
            using SqlConnection sqlConn = new(ConnectionString);
            using SqlCommand sqlCommand = new(query, sqlConn);
            sqlCommand.CommandTimeout = CommandTimeout;
            sqlConn.Open();
            table.Load(sqlCommand.ExecuteReader());
            return table;
        }
        private static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            var list = new List<T>();
            try
            {
                while (dr.Read())
                {
                    var properties = typeof(T).GetProperties().Where(x => Attribute.IsDefined(x, typeof(ColumnAttribute)));
                    var obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo pi in properties)
                    {
                        if (pi.GetCustomAttributes(typeof(NotMappedAttribute), false).Any())
                            continue;

                        var Name = pi.GetCustomAttributes(typeof(ColumnAttribute), false).First() is ColumnAttribute attribute
                            ? attribute.Name
                            : string.Empty;

                        if (!object.Equals(dr[Name], DBNull.Value))
                            pi.SetValue(obj, dr[Name], null);

                    }
                    list.Add(obj);
                }
                return list.ToList();
            }
            catch (IndexOutOfRangeException ex)
            {
                var msg = ex.Message;
                throw new Exception($"Error al mapear campo '{ ex.Message }'", ex.InnerException);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
