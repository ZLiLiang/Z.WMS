using System.Data.SqlClient;

namespace Z.DAL.Base
{
    public class SqlModel
    {
        //sql语句
        public string Sql { get; set; }
        //参数数组
        public SqlParameter[] SqlParaArray { get; set; }

    }
}
