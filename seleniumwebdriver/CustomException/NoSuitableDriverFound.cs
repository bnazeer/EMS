﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.CustomException
{
   public class NoSuitableDriverFound:Exception
    {
       public NoSuitableDriverFound(string msg):base(msg)
       {
           
       }
    }
}
