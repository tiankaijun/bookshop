using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BookDAL
{
    public class UserDAL
    {
        public Users GetLoginInfo(string Id,string pwd)
        {
            Users u = null;
            string sql = string.Format("select * from Users where LoginId=@id and LoginPwd=@pwd and userStateId=1");
            SqlParameter[]paras=new SqlParameter[2];
            paras[0]=new SqlParameter("@id",SqlDbType.VarChar);
            paras[0].Value=Id;
            paras[1]=new SqlParameter("@pwd",SqlDbType.VarChar);
            paras[1].Value=pwd;
          SqlDataReader dr=  DBHelper.GetDataReader(sql, paras);
          if (dr.Read())
          {
              u = new Users();
              u.ID =int.Parse( dr[0].ToString());
              u.LoginID = dr[1].ToString();
              u.LoginPwd = dr[2].ToString();
              u.Name = dr[3].ToString();
              u.Address = dr[4].ToString();
              u.Phone = dr[5].ToString();
              u.Mail = dr[6].ToString();
              u.UserRoleId =int.Parse( dr[7].ToString());
              u.UserStateId = int.Parse(dr[8].ToString());
          }
            return u;

        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUserList()
        {
            List<Users> UserList = new List<Users>();
            string sql = "select * from UserS where UserRoleId=1 and UserStateId=1";
           SqlDataReader dr= DBHelper.GetDataReader(sql, null);
           while (dr.Read())
           {
               Users u = new Users();
               u.ID = Convert.ToInt32(dr["id"]);
               u.Name = dr["name"].ToString();
               u.Address = dr["address"].ToString();
               UserList.Add(u);
           }

            return UserList;
        }

        public bool ValidateName(string n)
        {
            bool falg = false;
            string sql = "select COUNT(*) from Users where LoginId=@name";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar);
            param[0].Value = n;
            int count = Convert.ToInt32(DBHelper.GetObject(sql, param));
            if (count > 0)
            {
                falg = true;
            }
            return falg;
        }
    }
}
