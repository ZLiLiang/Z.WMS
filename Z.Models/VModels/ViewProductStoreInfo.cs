using Z.Common.CustomAttributes;

namespace Z.Models.VModels
{
    [Table("ViewProductStoreInfos")]
    [PrimaryKey("ProStoreId")]
    public class ViewProductStoreInfo
    {
        public int ProStoreId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int SRegionId { get; set; }
        public string SRegionName { get; set; }
        public int ProductCount { get; set; }
        public int IsDeleted { get; set; }
    }
}
