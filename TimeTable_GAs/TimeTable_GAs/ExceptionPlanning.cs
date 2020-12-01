using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable_GAs
{
    class ExceptionPlanning : Exception
    {
        public ChuongTrinh Obj { get; set; }

        public ExceptionPlanning(ChuongTrinh input)
        {
            this.Obj = input;
        }
    }
}
