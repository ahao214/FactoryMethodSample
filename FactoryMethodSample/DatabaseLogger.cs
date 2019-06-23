using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    /// <summary>
    /// 数据库日志记录器,充当具体产品角色
    /// </summary>
    class DatabaseLogger : Logger
    {
        public void WriteLog()
        {
            Console.WriteLine("数据库日志记录");
        }
    }
}
