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
using DesignPatternsDemo.Creational.建造者模式.V2;
using DesignPatternsDemo.Behavioral.责任链.Model;
using DesignPatternsDemo.Behavioral.责任链.V1;
using DesignPatternsDemo.Behavioral.责任链.V2;
using DesignPatternsDemo.Structural.外观模式.V1;
using DesignPatternsDemo.Structural.桥接模式.V1.Bridge;
using DesignPatternsDemo.Structural.桥接模式.V1.PlatformInterface;
using DesignPatternsDemo.Structural.桥接模式.V2.Color;
using DesignPatternsDemo.Utility;
using ActorBuilder = DesignPatternsDemo.Creational.建造者模式.V1.ActorBuilder;
using AngelActorBuilder = DesignPatternsDemo.Creational.建造者模式.V1.AngelActorBuilder;
using DevilActorBuilder = DesignPatternsDemo.Creational.建造者模式.V1.DevilActorBuilder;
using DesignPatternsDemo.Structural.适配器模式.对象适配器模式;
using DesignPatternsDemo.Structural.组合模式.V1;
using DesignPatternsDemo.Structural.组合模式.V1.LeafNode;
using DesignPatternsDemo.Structural.装饰模式.透明装饰模式.Component;
using DesignPatternsDemo.Structural.装饰模式.透明装饰模式;
using DesignPatternsDemo.Structural.享元模式.V1;
using DesignPatternsDemo.Structural.享元模式.V2;
using DesignPatternsDemo.Behavioral.命令模式.V1;
using DesignPatternsDemo.Behavioral.解释器模式.V1;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            #region Behavioral 行为型设计模式

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

            #region 命令模式
            //将请求的发送者和接收者解耦
            //
            //{
            //    Console.WriteLine("-------------命令模式 V1基础版-------------");
            //    var command = new ConcreteCommand();
            //    var client = new Client(command);
            //    client.Call();
            //}

            //{
            //    Console.WriteLine("-------------命令模式 V2窗体功能示例-------------");
            //    var command1 = new DesignPatternsDemo.Behavioral.命令模式.V2.Commands.HelperCommand();
            //    var command2 = new DesignPatternsDemo.Behavioral.命令模式.V2.Commands.MinimizeCommand();

            //    var button1 = new DesignPatternsDemo.Behavioral.命令模式.V2.Client.FunctionButton("帮助文档");
            //    button1.SetCommand(command1);
            //    var button2 = new DesignPatternsDemo.Behavioral.命令模式.V2.Client.FunctionButton("最小化窗体");
            //    button2.SetCommand(command2);

            //    var settingWindows = new DesignPatternsDemo.Behavioral.命令模式.V2.Client.SettingWindow();
            //    settingWindows.AddButton(button1);
            //    settingWindows.AddButton(button2);
            //    settingWindows.Display();

            //    Console.WriteLine("--------------------------");
            //    //手动模拟触发click
            //    button1.Click();
            //    button2.Click();
            //}

            //{
            //    Console.WriteLine("-------------命令模式 V3撤销操作-------------");
            //    var command = new DesignPatternsDemo.Behavioral.命令模式.V3.AddCommand();
            //    var form = new DesignPatternsDemo.Behavioral.命令模式.V3.CalculatorForm();
            //    form.SetCommnad(command);

            //    form.Compute(1);
            //    form.Compute(2);
            //    form.Compute(3);

            //    form.Undo();
            //    form.Undo();
            //    form.Undo();
            //    form.Undo();

            //    form.Redo();
            //    form.Redo();

            //    form.Compute(5);
            //    form.Redo();
            //    form.Undo();
            //}

            //{
            //    Console.WriteLine("-------------命令模式 V4命令队列-------------");
            //    DesignPatternsDemo.Behavioral.命令模式.V4.AbstractCommand command1 = new DesignPatternsDemo.Behavioral.命令模式.V4.Handler1Command();
            //    DesignPatternsDemo.Behavioral.命令模式.V4.AbstractCommand command2 = new DesignPatternsDemo.Behavioral.命令模式.V4.Handler2Command();
            //    DesignPatternsDemo.Behavioral.命令模式.V4.AbstractCommand command3 = new DesignPatternsDemo.Behavioral.命令模式.V4.Handler3Command();

            //    DesignPatternsDemo.Behavioral.命令模式.V4.Client client = new DesignPatternsDemo.Behavioral.命令模式.V4.Client();
            //    client.SetCommand(command1);
            //    client.SetCommand(command2);
            //    client.SetCommand(command3);

            //    client.Call();
            //}
            #endregion 命令模式

            #region 解释器模式
            //{
            //    Console.WriteLine("-------------解释器模式 V1 自己写的-------------");
            //    ExpressionContext ec = new ExpressionContext();
            //    ec.Input = "left run 10 and down walk 20";

            //    Console.WriteLine("-------------TerminalExpression: left run 10 -------------");
            //    AbstractExpression terminalExpression = new TerminalExpression("left", "10","run");
            //    terminalExpression.Interpreter(ec);

            //    Console.WriteLine("-------------ComplexExpression: left run 10 and down walk 20 -------------");
            //    AbstractExpression nonterminal = new NonterminalExpression(ec.Input);
            //    nonterminal.Interpreter(ec);
            //}

            #endregion 解释器模式

            #endregion Behavioral

            ////////////////////////////////////////////////////////////////////////////////////////////////

            #region Creational 创建型设计模式

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

            #region 建造者模式

            //{
            //    //actorBuilder 构造 目标对象
            //    Console.WriteLine("-------------建造者模式 V1 actorBuilder-------------");
            //    ActorBuilder ab = new AngelActorBuilder();
            //    var actor = ab.GetActor();
            //    actor.Show();
            //    Console.WriteLine();
            //}
            //{
            //    //actorBuilder 构造 目标对象
            //    //actorController 控制 构造流程
            //    Console.WriteLine("-------------建造者模式 V2 actorBuilder/actorController 控制流程-------------");
            //    DesignPatternsDemo.Creational.建造者模式.V2.ActorBuilder ab = new DesignPatternsDemo.Creational.建造者模式.V2.DevilActorBuilder();
            //    ActorController actorController = new ActorController(ab);
            //    var actor = actorController.ConstructActor();
            //    actor.Show();
            //}

            #endregion 建造者模式

            #endregion Creational

            ////////////////////////////////////////////////////////////////////////////////////////////////

            #region Structural 结构性设计模式

            #region 适配器模式

            //{
            //    Console.WriteLine("-------------适配器模式 V1 对象适配器-------------");
            //    //被适配的对象
            //    Adaptee adaptee = new Adaptee();
            //    //适配器
            //    Target target = new Adapter(adaptee);
            //    target.DoSomething();
            //    target.DoSomething2();
            //}
            //{
            //    Console.WriteLine("-------------适配器模式 V2 类适配器-------------");
            //    //适配器
            //    Structural.适配器模式.类适配器模式.Target target = new Structural.适配器模式.类适配器模式.Adapter();
            //    target.DoSomething();
            //    target.DoSomething2();
            //}

            //{
            //    Console.WriteLine("-------------适配器模式 V3 双向适配器-------------");
            //    Structural.适配器模式.双向适配器模式.Target target = new Structural.适配器模式.双向适配器模式.Target();
            //    Structural.适配器模式.双向适配器模式.Adaptee adaptee = new Structural.适配器模式.双向适配器模式.Adaptee();

            //    //适配器
            //    Structural.适配器模式.双向适配器模式.Adapter adapter = new Structural.适配器模式.双向适配器模式.Adapter();
            //    adapter.SetAdaptee(adaptee);
            //    adapter.SetTarget(target);

            //    adapter.DoAdapterSomething();
            //    adapter.DoTargetSomething2();
            //}

            //{
            //    Console.WriteLine("-------------适配器模式 V4 缺省适配器-------------");
            //    // target 方法较多，但并非全都需要，定义AbstractAdapter使用默认实现所有方法
            //    // 定义adapter类继承AbstractAdapter类，覆写需要的方法

            //    //被适配的对象
            //    Structural.适配器模式.缺省适配器模式.Adaptee adaptee = new Structural.适配器模式.缺省适配器模式.Adaptee();
            //    //适配器
            //    Structural.适配器模式.缺省适配器模式.Target target = new Structural.适配器模式.缺省适配器模式.Adapter(adaptee);
            //    target.DoSomething();
            //    target.DoSomething2();
            //}
            #endregion 适配器模式

            #region 桥接模式
            //{
            //    Console.WriteLine("-------------桥接模式 V1 图片显示-------------");
            //    var platformName = ConfigProvider.GetConfigString("Structural:Bridge:V1:Platform");
            //    var platformType = "DesignPatternsDemo.Structural.桥接模式.V1.PlatformInterface." + platformName;
            //    var platform = Activator.CreateInstance(Type.GetType(platformType)) as IPlantformImageImp;

            //    var imageTypeName = ConfigProvider.GetConfigString("Structural:Bridge:V1:ImageType");
            //    var imageTypeType = "DesignPatternsDemo.Structural.桥接模式.V1.Bridge." + imageTypeName;
            //    var image = Activator.CreateInstance(Type.GetType(imageTypeType)) as Image;

            //    image.SetImageImp(platform);
            //    image.ParseFile("tempPath");
            //}

            //{
            //    Console.WriteLine("-------------桥接模式 V2 字号及颜色-------------");
            //    var colorName = ConfigProvider.GetConfigString("Structural:Bridge:V2:Color");
            //    var colorType = "DesignPatternsDemo.Structural.桥接模式.V2.Color." + colorName;
            //    using (var color = Activator.CreateInstance(Type.GetType(colorType)) as IColor)
            //    {
            //        var penName = ConfigProvider.GetConfigString("Structural:Bridge:V2:Pen");
            //        var penType = "DesignPatternsDemo.Structural.桥接模式.V2.Pen." + penName;
            //        var pen = Activator.CreateInstance(Type.GetType(penType)) as Structural.桥接模式.V2.Pen.AbstractPen;

            //        pen.SetColor(color);
            //        pen.Draw();
            //    }

            //    Console.WriteLine("test normal color");
            //}
            #endregion  桥接模式

            #region 组合模式

            //{
            //    Console.WriteLine("-------------组合模式 V1 文件夹/文件杀毒-------------");
            //    AbstractFile folder1 = new Folder("foder1");
            //    AbstractFile folder2 = new Folder("foder2");
            //    AbstractFile folder3 = new Folder("foder3");

            //    AbstractFile file1 = new TextFile("file1");
            //    AbstractFile file2 = new TextFile("file2");
            //    AbstractFile file3 = new ImgFile("file3");
            //    AbstractFile file4 = new ImgFile("file4");

            //    folder1.Add(folder2);
            //    folder1.Add(folder3);
            //    folder2.Add(file1);
            //    folder2.Add(file2);
            //    folder3.Add(file3);
            //    folder3.Add(file4);

            //    //执行
            //    folder1.KillVirus();
            //}

            //{
            //    Console.WriteLine("-------------组合模式 V2 透明组合模式 文件夹/文件杀毒-------------");
            //    DesignPatternsDemo.Structural.组合模式.透明组合模式.AbstractFile folder1 = new DesignPatternsDemo.Structural.组合模式.透明组合模式.Folder("foder1");
            //    DesignPatternsDemo.Structural.组合模式.透明组合模式.AbstractFile folder2 = new DesignPatternsDemo.Structural.组合模式.透明组合模式.Folder("foder2");
            //    DesignPatternsDemo.Structural.组合模式.透明组合模式.AbstractFile folder3 = new DesignPatternsDemo.Structural.组合模式.透明组合模式.Folder("foder3");

            //    DesignPatternsDemo.Structural.组合模式.透明组合模式.AbstractFile file1 = new DesignPatternsDemo.Structural.组合模式.透明组合模式.LeafNode.TextFile("file1");
            //    DesignPatternsDemo.Structural.组合模式.透明组合模式.AbstractFile file2 = new DesignPatternsDemo.Structural.组合模式.透明组合模式.LeafNode.TextFile("file2");
            //    DesignPatternsDemo.Structural.组合模式.透明组合模式.AbstractFile file3 = new DesignPatternsDemo.Structural.组合模式.透明组合模式.LeafNode.ImgFile("file3");
            //    DesignPatternsDemo.Structural.组合模式.透明组合模式.AbstractFile file4 = new DesignPatternsDemo.Structural.组合模式.透明组合模式.LeafNode.ImgFile("file4");

            //    folder1.Add(folder2);
            //    folder1.Add(folder3);
            //    folder2.Add(file1);
            //    folder2.Add(file2);
            //    folder3.Add(file3);
            //    folder3.Add(file4);

            //    //执行
            //    folder1.KillVirus();
            //}

            //{
            //    Console.WriteLine("-------------组合模式 V3 安全组合模式 文件夹/文件杀毒-------------");
            //    DesignPatternsDemo.Structural.组合模式.安全组合模式.Folder folder1 = new DesignPatternsDemo.Structural.组合模式.安全组合模式.Folder("foder1");
            //    DesignPatternsDemo.Structural.组合模式.安全组合模式.Folder folder2 = new DesignPatternsDemo.Structural.组合模式.安全组合模式.Folder("foder2");
            //    DesignPatternsDemo.Structural.组合模式.安全组合模式.Folder folder3 = new DesignPatternsDemo.Structural.组合模式.安全组合模式.Folder("foder3");

            //    DesignPatternsDemo.Structural.组合模式.安全组合模式.AbstractFile file1 = new DesignPatternsDemo.Structural.组合模式.安全组合模式.LeafNode.TextFile("file1");
            //    DesignPatternsDemo.Structural.组合模式.安全组合模式.AbstractFile file2 = new DesignPatternsDemo.Structural.组合模式.安全组合模式.LeafNode.TextFile("file2");
            //    DesignPatternsDemo.Structural.组合模式.安全组合模式.AbstractFile file3 = new DesignPatternsDemo.Structural.组合模式.安全组合模式.LeafNode.ImgFile("file3");
            //    DesignPatternsDemo.Structural.组合模式.安全组合模式.AbstractFile file4 = new DesignPatternsDemo.Structural.组合模式.安全组合模式.LeafNode.ImgFile("file4");

            //    folder1.Add(folder2);//folder 自身方法
            //    folder1.Add(folder3);//folder 自身方法
            //    folder2.Add(file1);//folder 自身方法
            //    folder2.Add(file2);//folder 自身方法
            //    folder3.Add(file3);//folder 自身方法
            //    folder3.Add(file4);//folder 自身方法

            //    //执行
            //    folder1.KillVirus();//公共方法
            //}

            #endregion 组合模式

            #region 装饰模式
            //{
            //    Console.WriteLine("-------------装饰模式 V1 透明装饰模式-------------");
            //    DesignPatternsDemo.Structural.装饰模式.透明装饰模式.Component.Component c1, c2, c3, c4;//全部使用抽象基类定义
            //    c1 = new ListBox();
            //    c2 = new Window();
            //    Console.WriteLine("----原有显示-------------");
            //    c1.Display();
            //    c2.Display();

            //    Console.WriteLine("----增加透明装饰模式(无限嵌套)-------------");
            //    c3 = new BlackBorderDecorator(c1);
            //    c4 = new ScrollBarDecorator(c3);//将装饰后的对象继续注入另一个装饰器中
            //    c4.Display();
            //}
            //{
            //    Console.WriteLine("-------------装饰模式 V2 半透明装饰模式-------------");
            //    DesignPatternsDemo.Structural.装饰模式.透明装饰模式.Component.Component c1; //使用抽象基类定义
            //    c1 = new ListBox(); //具体子类实现

            //    DesignPatternsDemo.Structural.装饰模式.半透明装饰模式.ScrollBarDecorator c3; //直接使用具体装饰器定义实现
            //    c3 = new DesignPatternsDemo.Structural.装饰模式.半透明装饰模式.ScrollBarDecorator(c1);
            //    c3.Display(); //调用原有业务
            //    c3.CloseWindow();//调用自身业务（所以需要直接声明本类才能调用）
            //}
            #endregion 装饰模式

            #region 外观模式

            //{
            //    Console.WriteLine("-------------外观模式 V1 --------------------");
            //    Facade facade = new Facade();
            //    facade.Method();
            //}

            //{
            //    Console.WriteLine("-------------外观模式 V1 抽象外观--------------------");
            //    Console.WriteLine("-----IFacade: Facade");
            //    DesignPatternsDemo.Structural.外观模式.V2.IFacade facade = new DesignPatternsDemo.Structural.外观模式.V2.Facade();
            //    facade.Method();

            //    Console.WriteLine("-----IFacade: Facade_V2");
            //    facade = new DesignPatternsDemo.Structural.外观模式.V2.Facade_V2();
            //    facade.Method();
            //}
            #endregion 外观模式

            #region 享元模式
            //{
            //    Console.WriteLine("-------------享元模式 V1 --------------------");
            //    FlyweightFactory ff = new FlyweightFactory();
            //    var flyweight = ff.GetFlyweight("1");
            //    flyweight.ShowState("2");
            //}

            //{
            //    Console.WriteLine("-------------享元模式 V2 --------------------");
            //    IgoChessmanFactory ff = IgoChessmanFactory.GetInstance;
            //    var igo1 = ff.GetIgoChessman("b");
            //    var igo2 = ff.GetIgoChessman("b");
            //    var igo3 = ff.GetIgoChessman("w");
            //    var igo4 = ff.GetIgoChessman("w");
            //    Console.WriteLine($"igo1 == igo2: {igo1 == igo2}");
            //    Console.WriteLine($"igo3 == igo4: {igo3 == igo4}");
            //    igo1.Display(new Coordinates(1,2));
            //    igo2.Display(new Coordinates(3,4));
            //    igo3.Display(new Coordinates(2,1));
            //    igo4.Display(new Coordinates(2, 2));
            //}
            #endregion 享元模式

            #endregion Structural


        }
    }
}
