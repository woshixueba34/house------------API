using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.YH
{
    /// <summary>
    /// 省份表
    /// </summary>
    [Table("province")]
   public class provinceModel
    {
        [Key]
        public int sheng_site_ID { get; set; }
        public string sheng_site_name { get; set; }
    }
}
