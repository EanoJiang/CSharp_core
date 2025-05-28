namespace 多态;

class Father
{
    public void SpeakName()
    {
        Console.WriteLine("Father类");
    }
}
class Son : Father
{
    public new void SpeakName()
    {
        Console.WriteLine("Son类");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //如果用里氏替换原则
        Father s = new Son();
        s.SpeakName();  //这里会打印父类的方法
        //只有用as转换成子类对象才会调用子类的方法
        (s as Son).SpeakName();
    }
}
