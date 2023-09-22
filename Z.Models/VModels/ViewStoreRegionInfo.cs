using Z.Common.CustomAttributes;
using Z.Models.DModels;

namespace Z.Models.VModels
{
    [Table("ViewStoreRegionInfos")]
    [PrimaryKey("SRegionId")]
    public class ViewStoreRegionInfo : StoreRegionInfo
    {
        [Alias("仓库名称")]
        public string StoreName { get; set; }

        [Alias("温度状态")]
        public string TemperStateText { get; set; }
    }
}
