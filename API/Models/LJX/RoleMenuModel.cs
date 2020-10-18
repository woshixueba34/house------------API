using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.LJX
{
    [Table("RoleMenu")]
   public class RoleMenuModel
    {
        [Key]
        public int RoleMenu_ID { get; set; }
        public int RoleMenu_RolrID { get; set; }
        public int RoleMenu_MenuID { get; set; }

    }
}
