using System;
using System.Linq;
using SqlSugar;

namespace Visumall.Data
{

    /// <summary>
    /// 上下文
    /// </summary>
    public class DbContext
    {
        public SqlSugarClient MyDb { get; set; }


        public DbContext()
        {
            MyDb = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=.;database=Visumall-ERP;uid=sa;pwd=123;",
                DbType = DbType.SqlServer,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据库，如果存在事务，在事务结束之后释放。
                InitKeyType = InitKeyType.Attribute//从实体特性中读取主键自增列信息   
            });

            MyDb.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" + MyDb.Utilities.SerializeObject
                    (pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }

        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="Backup"></param>
        /// <param name="StringDefaultLength"></param>
        /// <param name="types"></param>
        public void CreateTable(bool Backup = false, int StringDefaultLength = 50, params Type[] types)
        {
            MyDb.CodeFirst.SetStringDefaultLength(StringDefaultLength);
            MyDb.DbMaintenance.CreateDatabase();
            if (Backup)
            {
                MyDb.CodeFirst.BackupTable().InitTables(types);
            }
            else
            {
                MyDb.CodeFirst.InitTables(types);
            }
        }


    }

}
