﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibity
{
    public sealed class Request
    {
        public object Data { get; private set; }

        public Request(object data)
        {
            Data = data;
        }
    }
}
