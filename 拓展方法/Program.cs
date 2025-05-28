namespace 拓展方法;

    #region 语法
    //访问修饰符 static 返回值类型 函数名(this 拓展类名 参数名，参数数据类型 参数, ...){
    //
    //}
    #endregion

    #region 示例
    static class Tools{
        public static void Print(this string str){
            Console.WriteLine("为string拓展方法："+str);
        }
        public static void PrintInfo(this string str, string str1, int num){
            Console.WriteLine("拓展方法的对象："+str);    
            Console.WriteLine("传入的参数："+str1 + " " + num);
        }
        public static void PrintInfo(this Test t){
            Console.WriteLine("为Test类拓展方法："+t.i);
        }
        //如果拓展的方法名和类里面的方法重名，优先使用类的方法
        public static void Func(this Test t){
            Console.WriteLine("为Test类拓展同名方法：");
        }
    }
    #endregion
    
    #region 为自定义的类型拓展方法
    class Test{
        public int i = 10;
        public void Func(){
            Console.WriteLine("Test类自己的Func方法");
        }
    }
    #endregion

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello World";
        str.Print(); //调用拓展方法
        str.PrintInfo("你好", 123); //调用拓展方法

        //为自定义的类型拓展方法
        Test t = new Test();
        t.PrintInfo(); //调用拓展方法
        t.Func(); //重名，优先调用类自己的方法
    }
}
