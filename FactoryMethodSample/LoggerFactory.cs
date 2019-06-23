using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    /// <summary>
    /// 日志记录器工厂接口,充当抽象工厂角色
    /// </summary>
    interface LoggerFactory
    {
        Logger CreateLogger();  //抽象工厂方法
    }
}
