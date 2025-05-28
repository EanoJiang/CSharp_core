namespace 静态成员习题;

//单例模式
class Test{
    private static Test t = new Test();
    public int testInt = 10;
    public static Test T{
        get{
            return t;
        }
    }
    private Test(){

    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Test.T.testInt);
        Test.T.testInt = 20;
        // Test t1 = new Test();    //外部无法实例化
        Console.WriteLine(Test.T.testInt);
    }
}
