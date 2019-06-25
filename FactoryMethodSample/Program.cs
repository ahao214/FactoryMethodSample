using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory;
            Logger logger;
            //factory = new FileLoggerFactory();  //可引入配置文件实现

            // 读取配置文件
            string factoryString = ConfigurationManager.AppSettings["factory"];
            //反射生成对象
            factory = (LoggerFactory)Assembly.Load("FactoryMethodSample").CreateInstance(factoryString);

            logger = factory.CreateLogger();
            logger.WriteLog();

            Console.ReadLine();
        }
    }
}
