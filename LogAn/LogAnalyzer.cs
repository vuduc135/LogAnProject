using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogAn
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (!fileName.EndsWith(".SLF"))
            {
                return false;
            }
            return true;
        }
    }
}