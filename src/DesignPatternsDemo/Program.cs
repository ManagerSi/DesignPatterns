using System;
using System.Threading.Tasks;
using DesignPatternsDemo.Creational.单例模式;
using DesignPatternsDemo.Creational.工厂模式.工厂模式.V1;
using DesignPatternsDemo.Creational.工厂模式.抽象工厂模式.V1;
using DesignPatternsDemo.Creational.工厂模式.抽象工厂模式.V1.Model;
using DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V1;
using DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V2;
using DesignPatternsDemo.Structural.责任链.Model;
using DesignPatternsDemo.Structural.责任链.V1;
using DesignPatternsDemo.Structural.责任链.V2;
using DesignPatternsDemo.Utility;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

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
            #endregion 简单工厂模式

            #region 工厂模式
            //{
            //    //不同的log有不同的初始化条件，所以放到不同的factory里面，避免代码混淆
            //    Console.WriteLine("-------------工厂模式 V1 default-------------");
            //    ILoggerFactory factory = null;
            //    factory = new DBLoggerFactory();
            //    ILogger logger = factory.GetLogger();
            //    logger.WriteLog();

            //    factory = null;
            //    factory = new FileLoggerFactory();
            //    logger = factory.GetLogger();
            //    logger.WriteLog();

            //    Console.WriteLine("-------------工厂模式 V1 input-------------");
            //    factory = null;
            //    factory = new DBLoggerFactory();
            //    logger = factory.GetLogger("Account");
            //    logger.WriteLog();

            //    factory = null;
            //    factory = new FileLoggerFactory();
            //    logger = factory.GetLogger("Account");
            //    logger.WriteLog();
            //}

            //{
            //    Console.WriteLine("-------------工厂模式 V2 从配置文件动态获取factory-------------");
            //    var factoryName = ConfigProvider.GetConfigString("FactoryMethod:LoggerFactory");
            //    var factoryType = "DesignPatternsDemo.Creational.工厂模式.工厂模式.V1." + factoryName;
            //    var factory =  Activator.CreateInstance(Type.GetType(factoryType)) as ILoggerFactory;
            //    var logger = factory.GetLogger("Account");
            //    logger.WriteLog();
            //}

            #endregion 工厂模式


            #region 抽象工厂模式
            //产品族分类
            //{
            //    Console.WriteLine("-------------抽象工厂模式-------------");
            //    ISkinFactory skinFactory = new SpringSkinFactory();
            //    IButton bt = skinFactory.CreateButton();
            //    IComboBox cb = skinFactory.CreateComboBox();
            //    ITextField tf = skinFactory.CreateTextField();
            //    bt.Display();
            //    cb.Display();
            //    tf.Display();
            //}
            
            #endregion 单例模式

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


        }
    }
}
