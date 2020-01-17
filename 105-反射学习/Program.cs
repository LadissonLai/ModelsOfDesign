using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _105_反射学习
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionClass mRF = new ReflectionClass()
            {
                MyProperty1 = "属性1",
                MyProperty2 = "属性2"
            };
            Type myType = mRF.GetType();
            foreach (var item in myType.GetProperties())
            {
                Console.WriteLine("反射获取类属性名称:" + item.Name); //获取属性的名称
                Console.WriteLine("反射获取属性的值:  " + item.GetValue(mRF)); //获取属性的值
            }
            Console.WriteLine(new string('-', 30));

            #region 利用反射访问 程序集 模块 类型（Type） 类（class）, 以及实例化类 访问其实例化对象成员
            //获取程序集信息
            string assembleName = "105-反射学习";
            Assembly assembly = Assembly.Load(assembleName);
            Console.WriteLine("程序集的名称:       " + assembly.FullName);
            Console.WriteLine("程序集的位置:       " + assembly.Location);
            Console.WriteLine("程序集需要的CLR版本:" + assembly.ImageRuntimeVersion);
            Console.WriteLine(new string('-', 30));

            //获取模块信息
            Module[] modules = assembly.GetModules();
            foreach (Module item in modules)
            {
                Console.WriteLine("模块名称：  " + item.Name); //模块名称和程序集的名称一样.exe
                //Console.WriteLine("模块全称：" + item.ScopeName);
                //Console.WriteLine("模块全称：" + item.FullyQualifiedName);
                Console.WriteLine("模块版本ID：" + item.ModuleVersionId);
            }
            Console.WriteLine(new string('-', 30));

            //获取类型信息，一个类对应一个类型
            Type[] types = assembly.GetTypes();
            foreach (Type item in types)
            {
                Console.WriteLine("类名称：      " + item.Name);  //其实是类上面的信息
                Console.WriteLine("类命名空间：  " + item.Namespace);
                Console.WriteLine("类完全命名：  " + item.FullName); //全名是 命名空间.类名
                Console.WriteLine("类的关联特性：" + item.Attributes);
                Console.WriteLine("类的GUID：   " + item.GUID);
            }
            Console.WriteLine(new string('-', 30));

            //获取类型成员信息
            Type type = assembly.GetType("_105_反射学习.ReflectionClass");
            //Type type = typeof(ReflectionClass);
            MemberInfo[] mis = type.GetMembers(); //获取公共成员
            foreach (MemberInfo item in mis)
            {
                Console.WriteLine("类成员名称：" + item.Name); //获取了所有公共方法和字段 Method,Property,Field
                Console.WriteLine("类成员类型：" + item.MemberType);
            }
            Console.WriteLine(new string('-', 30));

            //获取方法
            BindingFlags flags = BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance; //枚举的或运算
            MethodInfo[] methods = type.GetMethods(flags);
            foreach (MethodInfo item in methods)
            {
                Console.WriteLine("public类型，不包括积累继承的实例化方法：" + item.Name);
            }
            Console.WriteLine(new string('-', 30));
            BindingFlags flags2 = BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance; //枚举的或运算
            MethodInfo[] methods2 = type.GetMethods(flags2);
            foreach (MethodInfo item in methods2)
            {
                Console.WriteLine("非public类型的实例化方法：" + item.Name);
            }

            //获取属性
            BindingFlags flags3 = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance;
            PropertyInfo[] ppts = type.GetProperties(flags3);
            foreach (PropertyInfo item in ppts)
            {
                Console.WriteLine("属性名称：" + item.Name);
            }
            Console.WriteLine(new string('-', 30));

            //实例化对象的3种方法
            string className = assembly.GetTypes().Where(s => s.Name == "ReflectionClass").ToArray()[0].FullName;
            ReflectionClass mRF2 = (ReflectionClass)assembly.CreateInstance(className); //根据程序集和类的全名实例化对象
            ReflectionClass mRF3 = (ReflectionClass)Activator.CreateInstance(type); //根据Type创建实例化对象

            //访问属性，修改属性，调用方法
            Console.WriteLine("修改前的属性：" + type.GetProperty("MyProperty1").GetValue(mRF));
            type.GetProperty("MyProperty1").SetValue(mRF, "修改后的属性1");
            Console.WriteLine("修改后的属性：" + mRF.MyProperty1);
            type.GetMethod("MyPublicFunc").Invoke(mRF, new object[] { "Ladisson利用反射调用了该方法！！" });
            #endregion

            Console.ReadKey();
        }
    }
}
