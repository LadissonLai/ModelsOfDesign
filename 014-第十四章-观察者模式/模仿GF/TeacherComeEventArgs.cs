using System;
using System.Collections.Generic;
using System.Text;

namespace _014_第十四章_观察者模式
{
    public class TeacherComeEventArgs : EventArgs
    {
        public static readonly int EventId = typeof(TeacherComeEventArgs).GetHashCode();

        public int Id
        {
            get
            {
                return EventId;
            }
        }

        public string TeacherName { get; set; } = "杨幂";

    }
}
