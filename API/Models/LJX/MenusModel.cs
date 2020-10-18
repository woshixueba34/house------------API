using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.LJX
{
    [Table("Menus")]
    public class MenusModel
    {
        [Key]
        public int Menus_ID { get; set; }
        public string Menus_Name { get; set; }
    }
}
