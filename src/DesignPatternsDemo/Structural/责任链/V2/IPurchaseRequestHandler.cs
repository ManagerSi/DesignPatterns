using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Structural.责任链.Model;

namespace DesignPatternsDemo.Structural.责任链.V2
{
    public interface IPurchaseRequestHandler
    {
        bool Handle(PurchaseRequest request);
        void SetNextHandler(IPurchaseRequestHandler nextHandler);
    }
}
