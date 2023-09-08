using Z.Common.CustomAttributes;

namespace Z.Models.DModels
{
    /// <summary>
    /// 产品信息实体
    /// </summary>
    [Table("ProductInfos")]
    [PrimaryKey("ProductId")]
    public class ProductInfo
    {
        public int ProductId { get; set; }
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        [Column("FitLowTemperature")]
        public decimal? FitLowTemper { get; set; }
        [Column("FitHighTemperature")]
        public decimal? FitHighTemper { get; set; }
        public int IsDeleted { get; set; }
    }
}
