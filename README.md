# DesignPatterns
Project : Design Patterns Examples in C#

# 一、什么是设计模式                                                                                                                                       

设计模式（Design pattern）是一套被反复使用、多数人知晓的、经过分类编目的、代码设计经验的总结。使用设计模式是为了可重用代码、让代码更容易被他人理解、保证代码可靠性。 毫无疑问，设计模式于己于他人于系统都是多赢的，设计模式使代码编制真正工程化，设计模式是软件工程的基石，如同大厦的一块块砖石一样。项目中合理的运用设计模式可以完美的解决很多问题，每种模式在现在中都有相应的原理来与之对应，每一个模式描述了一个在我们周围不断重复发生的问题，以及该问题的核心解决方案，这也是它能被广泛应用的原因。简单说：

## 模式：在某些场景下，针对某类问题的某种通用的解决方案。

## 场景：项目所在的环境

## 问题：约束条件，项目目标等

## 解决方案：通用、可复用的设计，解决约束达到目标。


# 二、设计模式的三个分类                                                                                                                                

创建型模式：对象实例化的模式，创建型模式用于解耦对象的实例化过程。

结构型模式：把类或对象结合在一起形成一个更大的结构。

行为型模式：类和对象如何交互，及划分责任和算法。

如下图所示：
![设计模式分类](https://github.com/ManagerSi/DesignPatterns/blob/master/DesignPatterns.png "设计模式分类")


# 三、各分类中模式的关键点    

## 创建型模式
单例模式（Singleton Pattern）：某个类只能有一个实例，提供一个全局的访问点。
> Ensure a class has only one instance, and provide a global point of access to it.（确保某一个类只有一个实例，而且自行实例化并向整个系统提供这个实例。）

简单工厂（Sample Factory Pattern）：一个工厂类根据传入的参量决定创建出那一种产品类的实例。

工厂方法（Factory Pattern）：定义一个创建对象的接口，让子类决定实例化那个类。
> Define an interface for creating an object,but let subclass decide which class to instantiate.Factory Method lets a class defer instantiation to subclass.（定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法是一个类的实例化延迟到其子类。）

抽象工厂（Abstract Factory Pattern）：创建相关或依赖对象的家族，而无需明确指定具体类。
> Provide an interface for creating families of related or dependent objects without specifying their concrete classes.（为创建一组相关或相互依赖的对象提供一个接口，而且无需指定它们的具体类。）

建造者模式（Builder Pattern）：封装一个复杂对象的构建过程，并可以按步骤构造。
> Separate the construction of a complex object form its representation so that the same construction process can create different representations.（将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。）

原型模式（Prototype Pattern）：通过复制现有的实例来创建新的实例。
> Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.（用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。）

 

## 结构型模式
适配器模式（Adapter Pattern）：将一个类的方法接口转换成客户希望的另外一个接口。
> Convert the inface of a class into another interface clients expect.Adapter lets classes work together that couldn't otherwise because of incompatible interface.（将一个类的接口变换成客户端所期待的另一种接口，从而使原本因接口不匹配而无法在一起工作的两个类能够在一起工作。）
“系统的数据和行为都正确，单接口不符时，我们应该考虑使用适配器，目的是是控制范围之外的一个原有对象与某个接口匹配。适配器模式主要用于希望复用一些现存的类，但是接口又与复用环境不一致的情况。”（《大话设计模式》）

组合模式（Composite Pattern）：将对象组合成树形结构以表示“”部分-整体“”的层次结构。
> Compose objects into tree structure to represent part-whole hierarchies.Composite lets clients treat individual objects and compositions of objects uniformly.（将对象组合成树形结构以表示“部分-整体”的层次结构，使得用户对单个对象和组合对象的使用具有一致性。）

装饰模式（Decorator Pattern）：动态的给对象添加新的功能。
> Attach additional responsibilities to an object dynamically keeping the same interface.Decorators provide a flexible alternative to subclassing for extending functionality.（动态地给一个对象添加一些额外的职责。就增加功能来说，装饰模式相比生成子类更为灵活。）

代理模式（Proxy pattern）：为其他对象提供一个代理以便控制这个对象的访问。


亨元（蝇量）模式（Flyweight Pattern）：通过共享技术来有效的支持大量细粒度的对象。
> Use sharing to support large numbers of fine-grained objects efficiently.（使用共享对象可有效地支持大量的细粒度对象。）

外观模式：对外提供一个统一的方法，来访问子系统中的一群接口。

桥接模式（Bridge Pattern）：将抽象部分和它的实现部分分离，使它们都可以独立的变化。
> Decouple an abstraction from its implementation so that the two can vary independently.（将抽象和实现解耦，使得两者可以独立的变化。）


## 行为型模式
模板模式（Template Method Pattern）：定义一个算法结构，而将一些步骤延迟到子类实现。
> Define the skeleton of an algorithm in an operation,deferring some steps to subclasses.Template Method lets subclass redefine certain steps of an algorithm without changing the algorithm's structure. （定义一个操作中的算法框架，而将一些步骤延迟到子类中。使得子类可以不改变一个算法的结构即可以重定义该算法的某些特定步骤。）


解释器模式（Interpreter Pattern）：给定一个语言，定义它的文法的一种表示，并定义一个解释器。
> Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences int the language.（给定一门语言，定义它的文法的一种表示，并定义一个解释器，该解释器使用该表示来解释语言中的句子。）

策略模式（Strategy Pattern）：定义一系列算法，把他们封装起来，并且使它们可以相互替换。
> Define a family of algorithms, encapsulate each one, and make them interchangeable.（定义一组算法，将每个算法都封装起来，并且使他们之间可以互换。）

状态模式：允许一个对象在其对象内部状态改变时改变它的行为。
> Allow an object to alter its behavior when its internal state changes.The object will appear to change its class.（当一个对象在状态改变时允许其改变行为，这个对象看起来像改变了其类。）

观察者模式（Observer Pattern）：对象间的一对多的依赖关系。
>Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.（定义对象间一种一对多的依赖关系，使得每当一个对象改变状态，则所有依赖于它的对象都会得到通知并被自动更新。）

备忘录模式（Memento Pattern）：在不破坏封装的前提下，保持对象的内部状态。
> Without violating encapsulation， capture and externalize an object's internal state so that the object can be restored to this state later.（在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样以后就可将该对象恢复到原来保存的状态。）

中介者模式(Mediator Pattern)：用一个中介对象来封装一系列的对象交互。
> Define an object that encapsulates how a set of objects interact.Mediator promotes loose couping by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.（用一个中介对象封装一系列的对象交互，中介者使各对象不需要显示的相互作用，从而使其耦合松散，而且可以独立的改变它们之间的交互。）

命令模式：将命令请求封装为一个对象，使得可以用不同的请求来进行参数化。
> Encapsulate a request as an object,thereby letting you parameterize clients with different requests,queue or log requests, and support undoable operations.（将一个请求封装成一个对象，从而让你使用不同的请求把客户端参数化，对请求排队或者记录请求日志，可以提供命令的撤销和恢复功能。）

访问者模式（Visitor Pattern）：在不改变数据结构的前提下，增加作用于一组对象元素的新功能。
> Represent an operation to be performed on the elements of an object structure.Visitor lets you define a new operation without changing the classes of the elements on which it operates.（封装一些作用于某种数据结构中的各种元素，它可以在不改变数据结构的前提下定义作用于这些元素的新的操作。）

责任链模式：将请求的发送者和接收者解耦，使的多个对象都有处理这个请求的机会。
> Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.Chain the receiving objects and pass the request along the chain until an object handles it.（使多个对象有机会处理请求，从而避免了请求的发送者和接收者之间的耦合关系 。将这些对象连成一个链，并沿着这条链传递请求，知道有对象处理它为止。）

迭代器模式：一种遍历访问聚合对象中各个元素的方法，不暴露该对象的内部结构。
> Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.（它提供一种方法访问一个容器对象中各个元素，而又不需要暴露该对象的内部细节。）
