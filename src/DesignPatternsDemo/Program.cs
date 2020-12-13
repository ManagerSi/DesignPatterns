using System;
using System.Diagnostics;
using System.Threading.Tasks;
using DesignPatternsDemo.Creational.单例模式;
using DesignPatternsDemo.Creational.原型模式.V1;
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
            //    var factoryName = ConfigProvider.GetConfigString("Creational:FactoryMethod:LoggerFactory");
            //    var factoryType = "DesignPatternsDemo.Creational.工厂模式.工厂模式.V1." + factoryName;
            //    var factory = Activator.CreateInstance(Type.GetType(factoryType)) as ILoggerFactory;
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

            //{
            //    Console.WriteLine("-------------抽象工厂模式 V2 从配置文件动态获取factory-------------");
            //    var factoryName = ConfigProvider.GetConfigString("Creational:AbstractFactoryMethod:SkinFactory");
            //    var factoryType = "DesignPatternsDemo.Creational.工厂模式.抽象工厂模式.V1." + factoryName;
            //    var skinFactory = Activator.CreateInstance(Type.GetType(factoryType)) as ISkinFactory;
            //    IButton bt = skinFactory.CreateButton();
            //    IComboBox cb = skinFactory.CreateComboBox();
            //    ITextField tf = skinFactory.CreateTextField();
            //    bt.Display();
            //    cb.Display();
            //    tf.Display();
            //}

            #endregion 抽象工厂模式

            #region 原型模式
            {
                //Console.WriteLine("-------------原型模式 V1 浅拷贝(MemberwiseClone)-------------");
                //Prototype prototype = new Prototype();
                //prototype.PrototypeName = "name1";
                //prototype.Address = new Creational.原型模式.V1.Model.Address() { Country = "中国", City = "上海" };
                //var proto2 = prototype.Clone() as Prototype;

                //prototype.Show();
                //proto2.Show();
                //Console.WriteLine($"prot1 == prot2:{prototype == proto2}");
                //Console.WriteLine($"prot1.Address == prot2.Address:{prototype.Address == proto2.Address}");
                //Console.WriteLine();
            }

            {
                //Console.WriteLine("-------------原型模式 V1 深拷贝-------------");
                //Prototype prototype = new Prototype();
                //prototype.PrototypeName = "name1";
                //prototype.Address = new Creational.原型模式.V1.Model.Address() { Country = "中国", City = "上海" };
                //var proto2 = prototype.DeepCloneByBin(prototype);
                //var proto3 = prototype.DeepCloneByXml(prototype);
                //var proto4 = prototype.DeepCopyByReflection(prototype) as Prototype;
                //var proto5 = prototype.DeepCopyByNewtonSoft(prototype);

                //prototype.Show();
                //proto2.Show();
                //proto3.Show();
                //proto4.Show();
                //proto5.Show();
                //Console.WriteLine($"prot1 == prot2:{prototype == proto2}");
                //Console.WriteLine($"prot1 == prot3:{prototype == proto3}");
                //Console.WriteLine($"prot1 == prot4:{prototype == proto4}");
                //Console.WriteLine($"prot1 == prot5:{prototype == proto5}");
                //Console.WriteLine($"prot1.Address == prot2.Address:{prototype.Address == proto2.Address}");
                //Console.WriteLine($"prot1.Address == prot3.Address:{prototype.Address == proto3.Address}");
                //Console.WriteLine($"prot1.Address == prot4.Address:{prototype.Address == proto4.Address}");
                //Console.WriteLine($"prot1.Address == prot5.Address:{prototype.Address == proto5.Address}");
            }

            {
                //Console.WriteLine("-------------原型模式 V1 深拷贝(测试)-------------");
                //Prototype prototype = new Prototype();
                //prototype.PrototypeName = "p copy test";
                //prototype.Address = new Creational.原型模式.V1.Model.Address() { Country = "中国", City = "上海" };

                //Stopwatch st = new Stopwatch();
                //st.Start();
                //for (int i = 0; i < 100000; i++)
                //{
                //    var copy = prototype.DeepCloneByBin(prototype);
                //}
                //st.Stop();
                //Console.WriteLine($"DeepCloneByBin copy 100000 using {st.ElapsedMilliseconds} ms");

                //st.Restart();
                //for (int i = 0; i < 100000; i++)
                //{
                //    var copy = prototype.DeepCloneByXml(prototype);
                //}
                //st.Stop();
                //Console.WriteLine($"DeepCloneByXml copy 100000 using {st.ElapsedMilliseconds} ms");

                //st.Restart();
                //for (int i = 0; i < 100000; i++)
                //{
                //    var copy = prototype.DeepCopyByNewtonSoft(prototype);
                //}
                //st.Stop();
                //Console.WriteLine($"DeepCopyByNewtonSoft copy 100000 using {st.ElapsedMilliseconds} ms");

                //st.Restart();
                //for (int i = 0; i < 100000; i++)
                //{
                //    var copy = prototype.DeepCopyByReflection(prototype);
                //}
                //st.Stop();
                //Console.WriteLine($"DeepCopyByReflection copy 100000 using {st.ElapsedMilliseconds} ms");
            }

            #endregion 原型模式

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
