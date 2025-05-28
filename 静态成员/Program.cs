using System.Net.NetworkInformation;

namespace 静态成员;

#region 静态成员申明
class Test{
    static public float PI = 3.14f;
    public int testInt = 10;
    static public float CircleArea(float r){
        #region 静态函数不能访问非静态成员
        // 非静态成员只能在实例化对象后调用
        Test t = new Test();
        Console.WriteLine(t.testInt);
        #endregion
        return PI * r * r;
    }
    public void TestFunc(){
        Console.WriteLine("This is a test function");
        #region 非静态函数可以使用静态成员
        Console.WriteLine(PI);
        Console.WriteLine(CircleArea(5));
        
        #endregion
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        #region 静态成员的使用
        Console.WriteLine(Test.PI);
        // Console.WriteLine(Test.testInt); // 不能直接类名.调用
        
        // 非静态成员只能在实例化对象后调用
        Test t = new Test();
        Console.WriteLine(t.testInt);

        Console.WriteLine(Test.CircleArea(5));
        //Console.WriteLine(Test.TestFunc());// 不能直接类名.调用
        t.TestFunc();
        #endregion

    }
}