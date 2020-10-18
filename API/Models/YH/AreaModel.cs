using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.YH
{
    /// <summary>
    /// 区域表
    /// </summary>
    [Table("Area")]
    public  class AreaModel
    {
        [Key]
        public int qu_site_ID { get; set; }
        public string qu_site_name { get; set; }
    }
}
