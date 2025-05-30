namespace 多态_密封方法;

abstract class Animal
{
    public string name;
    public abstract void Atk();
    public virtual void Fuck()
    {
        Console.WriteLine("fuck");
    }
}
class Person : Animal
{
    public sealed override void Atk()
    {
    }
    public sealed override void Fuck()
    {
        Console.WriteLine("fuck me");
    }
}
// class Test : Person
// {
//     //后续子类就不能重写了
//     public override void Atk()
//     {
//     }
//     public override void Fuck()
//     {
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
