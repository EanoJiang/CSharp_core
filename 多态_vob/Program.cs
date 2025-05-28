namespace 多态_vob;

class GameObject
{
    public string name;
    public GameObject(string name)
    {
        this.name = name;
    }
    public virtual void Atk()
    {
        Console.WriteLine("GameObject对象的攻击");
    }
}
class Player : GameObject
{
    //子类默认找的是父类的无参构造函数，但是上面父类中已经有参构造，顶掉了无参构造
    //所以需要:base()继承构造函数
    public Player(string name) : base(name)
    {

    }
    //虚函数可以被子类重写
    public override void Atk()
    {
        //base.Atk();   //保留父类的虚函数行为，可以写在这个override方法的任何需要的地方
        Console.WriteLine("Player对象的攻击");
    }
}

class Program
{
    static void Main(string[] args)
    {
        GameObject p1 = new Player("sb");
        p1.Atk();
        //这就和原来用as的方式结果一样，但是可读性更强
        // (p1 as Player).Atk();
    }
}
