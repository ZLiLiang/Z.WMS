using Z.Common.CustomAttributes;
using Z.Models.DModels;

namespace Z.Models.VModels
{
    [Table("ViewStoreRegionInfos")]
    [PrimaryKey("SRegionId")]
    public class ViewStoreRegionInfo : StoreRegionInfo
    {
        [Column("仓库名称")]
        public string StoreName { get; set; }

        [Column("温度状态")]
        public string TemperStateText { get; set; }
    }
}
