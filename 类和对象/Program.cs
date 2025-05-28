namespace 面向对象;

class Program
{
    #region 类申明语法
    // 命名：帕斯卡命名法
    // 同一个语句块中的不同类不能重名
    //访问修饰符 class 类名{
    //     //特征——成员变量
    //     //行为——成员方法(函数)
    //     //保护特征——成员属性

    //     //构造函数、析构函数
    //     //索引器
    //     //运算符重载
    //     //静态成员
    // }
    #endregion

    class Person{

    }
    class Machine{

    }
    static void Main(string[] args)
    {
        #region 实例化对象示例(类创建对象)
        //类对象都是引用类型的
        //语法: 类名 对象名 = new 类名();
        //在栈上开辟了一个空间存放地址，但是不开辟 堆内存空间，也就是null
        Person p;
        Person p1 = null;
        //分配堆内存空间
        //创建的每个对象只是模板都是同一个类，但是里面的信息都是不同的————类似造人
        Person p2 = new Person();
        Person p3 = new Person();
        #endregion

    }
}
