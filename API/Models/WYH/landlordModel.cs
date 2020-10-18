using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Models.YH;
namespace Models.WYH
{
    /// <summary>
    /// 房东表
    /// </summary>
    [Table("landlord")]
   public class landlordModel
    {
        [Key]
        public int      landlord_ID { get; set; }
        public string   landlord_name { get; set; }
        public int      landlord_Sex { get; set; }
        public int      landlord_Age { get; set; }
        public string   landlord_Img { get; set; }
        public string   landlord_poc { get; set; }
        public string   landlord_phone { get; set; }
        public int landlord_HouseID { get; set; }
    }
}
