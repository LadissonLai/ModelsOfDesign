using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace _015_抽象工厂模式
{
    class DataAccess
    {
        private static readonly string AssemblyName = "015-抽象工厂模式";
        private static readonly string SpaceName = "_015_抽象工厂模式";
        private static readonly string db = ConfigurationManager.AppSettings["DB"]; //相当于选择哪一个方法，放在了反射读取的配置文件里面

        private static IFactory CreateFactory()
        {
            string className = string.Format("{0}.{1}Factory", SpaceName, db);
            return (IFactory)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IUserTable CreateUserTable()
        {
            IFactory factory = CreateFactory();
            return factory.CreateUserTable();
        }

        public static IDepartment CreateDeprtTable()
        {
            IFactory factory = CreateFactory();
            return factory.CreateDeprtTable();
        }
    }
}
