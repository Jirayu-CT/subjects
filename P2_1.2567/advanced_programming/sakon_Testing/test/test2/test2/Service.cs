﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Service : Employee
    {
        public override int Income()
        {
            return _salary * 12;
        }
    }
}