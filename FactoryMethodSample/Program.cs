using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory;
            Logger logger;
            factory = new FileLoggerFactory();  //可引入配置文件实现
            logger = factory.CreateLogger();
            logger.WriteLog();

            Console.ReadLine();
        }
    }
}
