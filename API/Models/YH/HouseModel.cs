using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.YH
{
    /// <summary>
    /// 房屋信息表
    /// </summary>
    [Table("House")]
   public class HouseModel
    {
        [Key]
        public int house_id { get; set; }
        public string house_name { get; set; }
        public int house_sheng { get; set; }
        public int house_shi { get; set; }
        public int house_qu { get; set; }
        public string House_img { get; set; }
        public string house_floor { get; set; }
        public string house_lxname { get; set; }
        public string house_phone { get; set; }
        public string house_area { get; set; }
        public string house_rent { get; set; }
        public int house_state { get; set; }

    }
}
