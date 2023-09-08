using Z.Common.CustomAttributes;

namespace Z.Models.VModels
{
    [Table("ViewSRegionTemperInfos")]
    public class ViewSRegionTemperInfo
    {
        public int StoreId { get; set; }
        public int SRegionId { get; set; }
        public int TotalCount { get; set; }
        public string SRegionName { get; set; }
        public decimal SRTemperature { get; set; }
        public decimal AllowLowTemperature { get; set; }
        public decimal AllowHighTemperature { get; set; }
        public int TemperState { get; set; }
        public string TemperRange { get; set; }
    }
}
