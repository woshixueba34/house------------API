using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.LJX
{
    [Table("UserRole")]
    public class UserRoleModel
    {
        [Key]
        public int UserRole_ID { get; set; }
        public int UserRole_UserID { get; set; }
        public int UserRole_RoleID { get; set; }
    }
}
