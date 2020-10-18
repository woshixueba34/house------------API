using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.LJX
{
    [Table("User")]
   public class UserModel
    {
        [Key]
        public int Users_ID { get; set; }
        public string Users_Name { get; set; }
        public string User_Pwd { get; set; }
    }
}
