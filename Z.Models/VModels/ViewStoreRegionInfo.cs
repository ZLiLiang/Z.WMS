using Z.Common.CustomAttributes;
using Z.Models.DModels;

namespace Z.Models.VModels
{
    [Table("ViewStoreRegionInfos")]
    [PrimaryKey("SRegionId")]
    public class ViewStoreRegionInfo : StoreRegionInfo
    {
        public string StoreName { get; set; }
        public string TemperStateText { get; set; }
    }
}
