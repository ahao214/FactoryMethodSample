using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    /// <summary>
    /// 文件日志记录器,充当具体产品角色
    /// </summary>
    class FileLogger : Logger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志记录");
        }
    }
}
