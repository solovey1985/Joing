﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Infra.Logger
{
    public interface ILogger
    {
        void Error(Exception exception);
    }
}
