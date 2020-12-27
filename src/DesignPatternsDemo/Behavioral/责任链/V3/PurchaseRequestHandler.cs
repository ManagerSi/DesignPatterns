using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Behavioral.责任链.Model;

namespace DesignPatternsDemo.Behavioral.责任链.V3
{
    public abstract class PurchaseRequestHandler
    {
        protected PurchaseRequestHandler _nextHandler;

        public void SetNextHandler(PurchaseRequestHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract bool Handle(PurchaseRequest request);
    }
}
