using System.Runtime.CompilerServices;

namespace 静态类和静态构造函数;

#region 静态类
static class TestStatic{
    public static void TestFunc(){

    }
    //静态类只能包含静态成员
    // public void Say(){
    // }
    public static int TestIndex{get;set;}
}
#endregion

#region 静态构造函数
//1. 静态类中的静态构造函数
static class StaticClass{
    public static int testInt = 10;
    //静态构造函数不能加访问修饰符
    //无参
    static StaticClass(){
        Console.WriteLine("静态类中的静态构造函数执行");
        //在静态构造函数里初始化成员变量
        testInt = 20;
    }

}
//2. 普通类中的静态构造函数
class NormalClass{
    public static int testInt = 10;
    static NormalClass(){
        Console.WriteLine("普通类中的静态构造函数执行");
        //在静态构造函数里初始化成员变量
        testInt = 20;
    }
    public NormalClass(){
        Console.WriteLine("普通类中的普通构造函数执行");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        //调用两次静态成员，但只执行一次静态构造函数
        Console.WriteLine(StaticClass.testInt);
        Console.WriteLine(StaticClass.testInt);

        //普通类中的静态构造函数也只执行一次
        Console.WriteLine(NormalClass.testInt);
        Console.WriteLine(NormalClass.testInt);
        //普通类中的普通构造函数每次实例化都会执行
        NormalClass nc = new NormalClass();
        NormalClass nc2 = new NormalClass();
        
    }
}
