using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Common
{
    public class DBHelper
    {
        static string connStr = "server=.;database=bookshopplus;uid=sa;pwd=sasa";

        /// <summary>
        /// 首行首列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras">参数数组</param>
        /// <returns></returns>
        public static object GetObject(string sql,SqlParameter[]paras)
        {
            object obj = null;
            using (SqlConnection conn=new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (paras != null)
                    {
                        //配置参数
                        cmd.Parameters.AddRange(paras);
                    }
                    obj = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return obj;
        }

        /// <summary>
        /// 增删改是否成功
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static bool GetOperation(string sql,SqlParameter[]paras)
        {
            bool falg = false;
            using (SqlConnection conn=new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        falg = true;
                    }
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
            }
            return falg;
        
        }
        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql,SqlParameter[]paras)
        {
            DataSet ds = new DataSet();
            //自己写的时候将using加到try里面
            using(SqlConnection conn=new SqlConnection(connStr))
            {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                if (paras != null)
                {
                    da.SelectCommand.Parameters.AddRange(paras);
                }
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            }

            return ds;
        }
        /// <summary>
        /// 返回dataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql,SqlParameter[]paras)
        {
            SqlDataReader dr = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                //关闭dr的时候,关闭connection对象
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return dr;
        }
        /// <summary>
        /// 调用存储过程返回数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet GetDataSetByProc(string sql,SqlParameter[]paras)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn=new SqlConnection(connStr))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    if (paras != null)
                    {
                        da.SelectCommand.Parameters.AddRange(paras);
                    }
                    //设置执行对象的属性,sql语句为存储过程名
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return ds;
        }
       
       
    }
}
