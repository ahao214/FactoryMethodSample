using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    /// <summary>
    /// 文件日志记录器工厂类,充当具体工厂角色
    /// </summary>
    class FileLoggerFactory : LoggerFactory
    {
        public Logger CreateLogger()
        {
            Logger logger = new FileLogger();
            return logger;
        }
    }
}
