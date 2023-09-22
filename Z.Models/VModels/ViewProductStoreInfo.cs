using Z.Common.CustomAttributes;

namespace Z.Models.VModels
{
    [Table("ViewProductStoreInfos")]
    [PrimaryKey("ProStoreId")]
    public class ViewProductStoreInfo
    {
        [Alias("产品仓库标识")]
        public int ProStoreId { get; set; }

        [Alias("产品标识")]
        public int ProductId { get; set; }

        [Alias("产品名称")]
        public string ProductName { get; set; }

        [Alias("仓库标识")]
        public int StoreId { get; set; }

        [Alias("仓库名称")]
        public string StoreName { get; set; }

        [Alias("仓库区域编号")]
        public int SRegionId { get; set; }

        [Alias("仓库区域名称")]
        public string SRegionName { get; set; }

        [Alias("商品数量")]
        public int ProductCount { get; set; }
        public int IsDeleted { get; set; }
    }
}
