using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.YH
{
    /// <summary>
    /// 市区表
    /// </summary>
    [Table("City")]
    public class City_Model
    {
        [Key]
        public int shi_site_ID { get; set; }
        public string shi_site_name { get; set; }
    }
}
