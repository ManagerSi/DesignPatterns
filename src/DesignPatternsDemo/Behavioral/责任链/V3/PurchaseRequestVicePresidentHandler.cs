﻿using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Behavioral.责任链.Model;

namespace DesignPatternsDemo.Behavioral.责任链.V3
{
    public class PurchaseRequestVicePresidentHandler: PurchaseRequestHandler
    {
        public override bool Handle(PurchaseRequest request)
        {
            var result = false;
            if (request.Amount > 500)
            {
                //主管审批
                result = HandleByVicePresident(request);

                //下一级审批
                if (result && _nextHandler != null)
                    return _nextHandler.Handle(request);
            }

            return result;
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
    }
}
