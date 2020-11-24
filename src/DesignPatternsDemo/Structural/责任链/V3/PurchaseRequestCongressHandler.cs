using DesignPatternsDemo.Structural.责任链.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.责任链.V3
{
    public class PurchaseRequestCongressHandler: PurchaseRequestHandler
    {
        public override bool Handle(PurchaseRequest request)
        {
            var result = false;
            if (request.Amount > 3000)
            {
                //主管审批
                result = HandleByCongress(request);

                //下一级审批
                if (result && _nextHandler != null)
                    return _nextHandler.Handle(request);
            }

            return result;
        }

        /// <summary>
        /// 董事会审批
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private bool HandleByCongress(PurchaseRequest request)
        {
            Console.WriteLine("HandleByCongress");
            return true;
        }
    }
}
