﻿using System;
using DesignPatternsDemo.Structural.责任链.Model;
using DesignPatternsDemo.Structural.责任链.V1;
using DesignPatternsDemo.Structural.责任链.V2;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Behavioral


            #endregion Behavioral

            ////////////////////////////////////////////////////////////////////////////////////////////////

            #region Creational


            #endregion Creational

            ////////////////////////////////////////////////////////////////////////////////////////////////

            #region Structural

            #region 责任链

            var request = new PurchaseRequest() { Amount = 3500 };

            //未使用责任链
            {
                Console.WriteLine("-------------未使用责任链-------------");
                var requstHandler = new PurchaseRequestHandler();
                requstHandler.Handle(request);
            }

            //责任链--接口
            {
                Console.WriteLine("-------------使用责任链--接口方式-------------");
                PurchaseRequestDirectorHandler director = new PurchaseRequestDirectorHandler();
                PurchaseRequestVicePresidentHandler vicePresident = new PurchaseRequestVicePresidentHandler();
                PurchaseRequestPrisidentHandler prisident = new PurchaseRequestPrisidentHandler();
                PurchaseRequestCongressHandler congress = new PurchaseRequestCongressHandler();

                director.SetNextHandler(vicePresident);
                vicePresident.SetNextHandler(prisident);
                prisident.SetNextHandler(congress);

                director.Handle(request);
            }
            //责任链--接口
            {
                Console.WriteLine("-------------使用责任链--抽象类方式-----------");
                Structural.责任链.V3.PurchaseRequestDirectorHandler director = new Structural.责任链.V3.PurchaseRequestDirectorHandler();
                Structural.责任链.V3.PurchaseRequestVicePresidentHandler vicePresident = new Structural.责任链.V3.PurchaseRequestVicePresidentHandler();
                Structural.责任链.V3.PurchaseRequestPrisidentHandler prisident = new Structural.责任链.V3.PurchaseRequestPrisidentHandler();
                Structural.责任链.V3.PurchaseRequestCongressHandler congress = new Structural.责任链.V3.PurchaseRequestCongressHandler();

                director.SetNextHandler(vicePresident);
                vicePresident.SetNextHandler(prisident);
                prisident.SetNextHandler(congress);

                director.Handle(request);
            }

            #endregion 责任链

            #endregion Structural

            Console.WriteLine("Hello World!");
        }
    }
}
