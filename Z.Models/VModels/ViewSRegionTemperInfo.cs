using Z.Common.CustomAttributes;

namespace Z.Models.VModels
{
    [Table("ViewSRegionTemperInfos")]
    public class ViewSRegionTemperInfo
    {
        [Alias("仓库标识")]
        public int StoreId { get; set; }

        [Alias("仓库区域标识")]
        public int SRegionId { get; set; }

        [Alias("总数")]
        public int TotalCount { get; set; }

        [Alias("仓库区域名称")]
        public string SRegionName { get; set; }

        [Alias("仓库区域温度")]
        public decimal SRTemperature { get; set; }

        [Alias("最低温度线")]
        public decimal AllowLowTemperature { get; set; }

        [Alias("最高温度线")]
        public decimal AllowHighTemperature { get; set; }
        public int TemperState { get; set; }
        public string TemperRange { get; set; }
    }
}
