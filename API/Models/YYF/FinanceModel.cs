using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.YYF
{
    /// <summary>
    /// 财务管理
    /// </summary>
    [Table("Finance")]
   public class FinanceModel
    {
        [Key]
        public int finance_ID { get; set; }
        public string finance_number { get; set; }
        public string finance_contract { get; set; }
        public DateTime finance_time { get; set; }
        public string finance_ysmoney { get; set; }
        public string finance_yfmoney { get; set; }
    }
}
