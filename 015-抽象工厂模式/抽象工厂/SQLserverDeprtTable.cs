﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_抽象工厂模式
{
    class SQLserverDeprtTable : IDepartment
    {
        public void GetDepartment(int id)
        {
            Console.WriteLine("根据id，获取SQL的department数据");
        }

        public void Insert(Department deprt)
        {
            Console.WriteLine("在SQL中插入，depart数据");
        }
    }
}
