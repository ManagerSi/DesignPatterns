using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Structural.责任链.Model;

namespace DesignPatternsDemo.Structural.责任链.V1
{
    /// <summary>
    /// 采购单处理类
    /// </summary>
    public class PurchaseRequestHandler
    {
        public bool Handle(PurchaseRequest request)
        {
            var result = false;
            if (request.Amount > 0)
            {
                //主管审批
                result = HandleByDirector(request);
            }
            if (request.Amount > 500)
            {
                //副董事长审批
                result = HandleByVicePresident(request);
            }
            if (request.Amount > 1000)
            {
                //董事长审批
                result = HandleByPresident(request);
            }
            if (request.Amount > 3000)
            {
                //董事会审批
                result = HandleByCongress(request);
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

        /// <summary>
        /// 副董事长审批
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private bool HandleByVicePresident(PurchaseRequest request)
        {
            Console.WriteLine("HandleByVicePresident");
            return true;
        }

        /// <summary>
        /// 主管审批
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private bool HandleByDirector(PurchaseRequest request)
        {
            Console.WriteLine("HandleByDirector");
            return true;
        }
    }
}
