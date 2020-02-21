﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibity.Imp
{
    public class SubNumberHandler : BaseHandler
    {
        public override object ProcessRequest(Request request)
        {
            CalculatorModel calculator = (CalculatorModel)request.Data;
            if (calculator.CalculationType == CalculationType.Sub)
            {
                return calculator.FNumber - calculator.SNumber;
            }
            else
                return Handler.ProcessRequest(request);
        }
    }
}
