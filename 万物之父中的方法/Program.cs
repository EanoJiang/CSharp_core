namespace 万物之父中的方法;

class Test
{
    //值类型成员变量
    public int i = 1;
    //引用类型成员变量
    public Test2 ttt = new Test2();
    public Test Clone()
    {
        return MemberwiseClone() as Test;
    }
}
class Test2
{
    public int i = 2;
}

class Program
{
    static void Main(string[] args)
    {
        #region object中的静态方法
        //Equals()
        //比较的是二者指向的内存地址是否一样
        //最终判断权交给左侧对象的Equals方法
        //值类型
        Console.WriteLine(Object.Equals(1, 1));
        Console.WriteLine(1.Equals(1));
        //引用类型
        Test t1 = new Test();
        Test t2 = new Test();
        Console.WriteLine(Object.Equals(t1, t2));
        Console.WriteLine(t1.Equals(t2));
        t2 = t1;
        Console.WriteLine(Object.Equals(t1, t2));
        Console.WriteLine(t1.Equals(t2));

        //ReferenceEquals()
        //比较两个对象是否是相同的引用(内存地址)
        //值类型：返回值永远是flase
        //  Console.WriteLine(Object.ReferenceEquals(1, 1));
        //引用类型：
        Test t3 = new Test();
        Test t4 = new Test();
        Console.WriteLine(Object.ReferenceEquals(t3, t4));
        t4 = t3;
        Console.WriteLine(Object.ReferenceEquals(t3, t4));
        #endregion

        #region 成员方法
        //普通方法Type()
        Test t = new Test();
        Type type = t.GetType();

        //普通方法MemberwiseClone()
        Test t_2 = t.Clone();
        Console.WriteLine("克隆对象后");
        Console.WriteLine("t.i = " + t.i);
        Console.WriteLine("t.ttt.i = " + t.ttt.i);
        Console.WriteLine("t_2.i = " + t_2.i);
        Console.WriteLine("t_2.ttt.i = " + t_2.ttt.i);
        Console.WriteLine("改变克隆对象的信息");
        t_2.i = 99;
        t_2.ttt.i = 100;
        Console.WriteLine("t.i = " + t.i);
        Console.WriteLine("t.ttt.i = " + t.ttt.i);
        Console.WriteLine("t_2.i = " + t_2.i);
        Console.WriteLine("t_2.ttt.i = " + t_2.ttt.i);
        #endregion
    }
}
