using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.DAL;
using Z.Models.VModels;

namespace Z.BLL
{
    public class ReportBLL
    {
        private ViewProductStoreDAL vpsDAL = new ViewProductStoreDAL();
        private ViewSRegionTemperDAL vsrtDAL = new ViewSRegionTemperDAL();
        private ViewStoreRegionDAL vsrDAL = new ViewStoreRegionDAL();

        /// <summary>
        /// 获取所有的产品库存数据
        /// </summary>
        /// <returns></returns>
        public List<ViewProductStoreInfo> GetAllProductStoreList()
        {
            return vpsDAL.GetAllProductStoreList();
        }

        /// <summary>
        /// 获取所有的分区温度数据
        /// </summary>
        /// <returns></returns>
        public List<ViewSRegionTemperInfo> GetAllSRegionTemperList()
        {
            return vsrtDAL.GetAllSRegionTemperList();
        }

        /// <summary>
        /// 获取所有仓库分区数据
        /// </summary>
        /// <returns></returns>
        public List<ViewStoreRegionInfo> GetAllStoreRegionTemperList()
        {
            return vsrDAL.GetAllStoreRegionList();
        }



    }
}
