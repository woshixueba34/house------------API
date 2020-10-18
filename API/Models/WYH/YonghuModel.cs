using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Models.YH;
namespace Models.WYH
{
    [Table("yonghu")]
    public class YonghuModel
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public int sex { get; set; }
        public int age { get; set; }
        public string img { get; set; }
        public string dentification_card_img { get; set; }
        public string phone { get; set; }
        public int UserID { get; set; }
    }
}
