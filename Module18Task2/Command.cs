﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Task2
{
    abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
