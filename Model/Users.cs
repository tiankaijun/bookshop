using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Users
    {
        
        public int ID { get; set; }

      
        [Required(ErrorMessage="{0}不能为空")]
        public string LoginID { get; set; }

      
        [StringLength(6,ErrorMessage="{0}长度必须为{1}")]
        [Required(ErrorMessage="{0}密码不能为空")]
        public string LoginPwd { get; set; }
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int UserRoleId { get; set; }
        public int UserStateId { get; set; }
      
    }
}
