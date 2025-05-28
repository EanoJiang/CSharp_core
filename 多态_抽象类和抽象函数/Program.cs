namespace 多态_抽象类和抽象函数;

abstract class Thing
{
    public string name;
    //抽象函数
    public abstract void Show();
    //虚函数
    public virtual void Test()
    {
        
    }
}
class Water : Thing
{
    //继承一个有抽象函数的抽象类，必须要实现抽象函数
    public override void Show()
    {

    }
    //虚函数可以选择是否要覆盖
    public override void Test()
    {

    }
}
class Program
{
    static void Main(string[] args)
    {
        //抽象类不能被实例化
        //  Thing t = new Thing();  // 错误
        //抽象类的子类可以用里氏替换原则用父类装子类
        Thing t = new Water();
        //抽象类的子类可以被实例化
        Water w = new Water();
    }
}
