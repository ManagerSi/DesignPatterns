using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Behavioral.责任链.Model;

namespace DesignPatternsDemo.Behavioral.责任链.V2
{
    public class PurchaseRequestPrisidentHandler: IPurchaseRequestHandler
    {
        private IPurchaseRequestHandler _nextHandler;

        public void SetNextHandler(IPurchaseRequestHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public bool Handle(PurchaseRequest request)
        {
            var result = false;
            if (request.Amount > 1000)
            {
                //主管审批
                result = HandleByPresident(request);

                //下一级审批
                if (result && _nextHandler != null)
                    return _nextHandler.Handle(request);
            }

            return result;
        }

        /// <summary>
        /// 董事长审批
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private bool HandleByPresident(PurchaseRequest request)
        {
            Console.WriteLine("HandleByPresident");
            return true;
        }

    }
}
