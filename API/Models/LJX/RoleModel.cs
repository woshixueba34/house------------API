using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.LJX
{
    [Table("Role")]
    public class RoleModel
    {
        [Key]
        public int Roles_ID { get; set; }
        public string Roles_Name { get; set; }
    }
}
