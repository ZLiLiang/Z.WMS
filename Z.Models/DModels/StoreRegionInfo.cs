using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Common.CustomAttributes;

namespace Z.Models.DModels
{
    /// <summary>
    /// 仓库分区实体
    /// </summary>
    [Table("StoreRegionInfos")]
    [PrimaryKey("SRegionId")]
    public class StoreRegionInfo
    {
        [Column("仓库区域标识")]
        public int SRegionId { get; set; }

        [Column("仓库区域名字")]
        public string SRegionName { get; set; }

        [Column("仓库区域编号")]
        public string SRegionNo { get; set; }

        [Column("仓库标识")]
        public int StoreId { get; set; }

        [Column("仓库区域温度")]
        public decimal? SRTemperature { get; set; }

        [Column("最低温度线")]
        public decimal? AllowLowTemperature { get; set; }

        [Column("最高温度线")]
        public decimal? AllowHighTemperature { get; set; }
        public int TemperState { get; set; }

        [Column("注释")]
        public string Remark { get; set; }
        public int IsDeleted { get; set; }
    }
}
