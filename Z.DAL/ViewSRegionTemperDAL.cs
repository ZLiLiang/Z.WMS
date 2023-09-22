using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.DAL.Base;
using Z.Models.VModels;

namespace Z.DAL
{
    public class ViewSRegionTemperDAL : BQuery<ViewSRegionTemperInfo>
    {
        /// <summary>
        /// 查询指定仓库的分区列表
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public List<ViewSRegionTemperInfo> GetSRegionTemperList(int storeId)
        {
            string strWhere = "1=1";
            if (storeId > 0)
            {
                strWhere += $" and StoreId={storeId}";
            }
            strWhere += " order by StoreId,SRegionId";
            string cols = CreateSql.GetColsString<ViewSRegionTemperInfo>("TemperRange");
            return base.GetModelList(strWhere, cols);
        }

        /// <summary>
        /// 查询仓库所有的分区列表
        /// </summary>
        /// <returns></returns>
        public List<ViewSRegionTemperInfo> GetAllSRegionTemperList()
        {
            string strWhere = "1=1";
            string cols = CreateSql.GetColsString<ViewSRegionTemperInfo>("TemperState,TemperRange");
            return base.GetModelList(strWhere, cols);
        }
    }
}
