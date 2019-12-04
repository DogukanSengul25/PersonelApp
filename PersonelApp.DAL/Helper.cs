// Decompiled with JetBrains decompiler
// Type: PersonelApp.DAL.Helper
// Assembly: PersonelApp.DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4198690C-DEF5-4248-978F-5CD598546035
// Assembly location: C:\Users\Dogukan\source\repos\PersonelApp\PersonelApp\bin\Debug\PersonelApp.DAL.dll

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PersonelApp.DAL
{
    public class Helper : IDisposable
    {
        private SqlConnection cn = (SqlConnection)null;
        private SqlCommand cmd = (SqlCommand)null;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            this.cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
            this.cmd = new SqlCommand(cmdtext, this.cn);
            if (p != null)
                this.cmd.Parameters.AddRange(p);
            this.Ac();
            int num = this.cmd.ExecuteNonQuery();
            this.Kapa();
            return num;
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            this.cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
            this.cmd = new SqlCommand(cmdtext, this.cn);
            if (p != null)
                this.cmd.Parameters.AddRange(p);
            this.Ac();
            return this.cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void Ac()
        {
            try
            {
                if (this.cn == null || this.cn.State == ConnectionState.Open)
                    return;
                this.cn.Open();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Kapa()
        {
            try
            {
                if (this.cn == null || (uint)this.cn.State <= 0U)
                    return;
                this.cn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Dispose()
        {
            if (this.cn == null || this.cmd == null)
                return;
            this.cn.Dispose();
            this.cmd.Dispose();
        }
    }
}
