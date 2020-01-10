using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            User fengqingyang = new User()
            {
                ID = "1",
                Name = "风清扬"
            };
            Department pc1depart = new Department()
            {
                ID = 1,
                DeprtName = "PC软件一部",
            };

            //IFactory factory = new SQLserverFcatory();  //想用哪个数据库就用哪个数据库
            //IUserTable userTable = factory.CreateUserTable();
            //userTable.Insert(fengqingyang);
            //userTable.GetUser(1);

            //IFactory factory2 = new AccessFactory();
            //IUserTable userTable2 = factory2.CreateUserTable();
            //userTable2.Insert(fengqingyang);
            //userTable2.GetUser(1);

            #region 利用简单工厂加反射，实现不同平台数据库读取
            IUserTable userTable = DataAccess.CreateUserTable();
            userTable.Insert(fengqingyang);
            IDepartment department = DataAccess.CreateDeprtTable();
            department.Insert(pc1depart);

            #endregion

            Console.ReadKey();
        }
    }
}
