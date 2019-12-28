using System;
using System.Collections.Generic;
using System.Text;

namespace _009_第九章_原型模式
{
    class WorkExperience : ICloneable
    {
        private string startTime;
        private string endTime;
        private string corporation;
        public string StartTime
        {
            get
            {
                return startTime;
            }
        }
        public string EndTime
        {
            get
            {
                return endTime;
            }
        }
        public string Corporation
        {
            get
            {
                return corporation;
            }
        }

        public WorkExperience()
        {

        }

        public WorkExperience(string start,string end,string corporation)
        {
            this.startTime = start;
            this.endTime = end;
            this.corporation = corporation;
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
