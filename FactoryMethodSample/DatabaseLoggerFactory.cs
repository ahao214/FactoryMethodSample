using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    /// <summary>
    /// 数据库日志记录器工厂类,充当具体工厂角色
    /// </summary>
    class DatabaseLoggerFactory : LoggerFactory
    {
        public Logger CreateLogger()
        {
            Logger logger = new DatabaseLogger();
            return logger;
        }
    }
}
