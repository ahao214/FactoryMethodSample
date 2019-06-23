using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    /// <summary>
    /// 日志记录器接口，充当抽象产品角色
    /// </summary>
    interface Logger
    {
        void WriteLog();
    }
}
