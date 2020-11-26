using System;
using System.Threading.Tasks;
using DesignPatternsDemo.Creational.单例模式;
using DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V1;
using DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V2;
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

            #region 单例模式

            //{
            //    Console.WriteLine("-------------单例模式--饿汉-----------");
            //    Parallel.For(1, 20, i => Singleton_V1.GetInstance());
            //    Singleton_V1 one = Singleton_V1.GetInstance();
            //    Singleton_V1 two = Singleton_V1.GetInstance();
            //    Console.WriteLine($"one == two : {one == two}");
            //}
            //{
            //    Console.WriteLine("-------------单例模式--懒汉-----------");
            //    Parallel.For(1, 20, i => Singleton_V2.GetInstance());
            //    Singleton_V2 one = Singleton_V2.GetInstance();
            //    Singleton_V2 two = Singleton_V2.GetInstance();
            //    Console.WriteLine($"one == two : {one == two}");
            //}
            //{
            //    Console.WriteLine("-------------单例模式--内部类-----------");
            //    Parallel.For(1, 20, i => Singleton_V3.GetInstance());
            //    Singleton_V3 one = Singleton_V3.GetInstance();
            //    Singleton_V3 two = Singleton_V3.GetInstance();
            //    Console.WriteLine($"one == two : {one == two}");
            //}

            #endregion 单例模式

            #region 简单工厂模式
            //{
            //    Console.WriteLine("-------------简单工厂模式 1-------------");
            //    var prod = SimpleProductFactory.GetProduct("A");
            //    prod.Show();
            //}
            //{
            //    Console.WriteLine("-------------简单工厂模式 2 prod 和 工厂方法整合在一起-------------");
            //    var prod = ProductIncludeFactory.GetProduct("A");
            //    prod.Show();
            //}
            #endregion



            #endregion Creational

            ////////////////////////////////////////////////////////////////////////////////////////////////

            #region Structural

            #region 责任链

            //var request = new PurchaseRequest() { Amount = 3500 };

            ////未使用责任链
            //{
            //    Console.WriteLine("-------------未使用责任链-------------");
            //    var requstHandler = new PurchaseRequestHandler();
            //    requstHandler.Handle(request);
            //}

            ////责任链--接口
            //{
            //    Console.WriteLine("-------------使用责任链--接口方式-------------");
            //    PurchaseRequestDirectorHandler director = new PurchaseRequestDirectorHandler();
            //    PurchaseRequestVicePresidentHandler vicePresident = new PurchaseRequestVicePresidentHandler();
            //    PurchaseRequestPrisidentHandler prisident = new PurchaseRequestPrisidentHandler();
            //    PurchaseRequestCongressHandler congress = new PurchaseRequestCongressHandler();

            //    director.SetNextHandler(vicePresident);
            //    vicePresident.SetNextHandler(prisident);
            //    prisident.SetNextHandler(congress);

            //    director.Handle(request);
            //}
            ////责任链--接口
            //{
            //    Console.WriteLine("-------------使用责任链--抽象类方式-----------");
            //    Structural.责任链.V3.PurchaseRequestDirectorHandler director = new Structural.责任链.V3.PurchaseRequestDirectorHandler();
            //    Structural.责任链.V3.PurchaseRequestVicePresidentHandler vicePresident = new Structural.责任链.V3.PurchaseRequestVicePresidentHandler();
            //    Structural.责任链.V3.PurchaseRequestPrisidentHandler prisident = new Structural.责任链.V3.PurchaseRequestPrisidentHandler();
            //    Structural.责任链.V3.PurchaseRequestCongressHandler congress = new Structural.责任链.V3.PurchaseRequestCongressHandler();

            //    director.SetNextHandler(vicePresident);
            //    vicePresident.SetNextHandler(prisident);
            //    prisident.SetNextHandler(congress);

            //    director.Handle(request);
            //}

            #endregion 责任链

            #endregion Structural

            Console.WriteLine("Hello World!");
            
        }
    }
}
