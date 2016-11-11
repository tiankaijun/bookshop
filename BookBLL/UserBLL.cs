using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using BookDAL;

namespace BookBLL
{
    public class UserBLL
    {
        UserDAL ud = new UserDAL();
        public Users GetLoginInfo(string Id, string pwd)
        {
            return ud.GetLoginInfo(Id, pwd);
        }
        public List<Users> GetUserList()
        {
            return ud.GetUserList();
        }

        public bool ValidateName(string n)
        {
            return ud.ValidateName(n);
        }
    }
}
