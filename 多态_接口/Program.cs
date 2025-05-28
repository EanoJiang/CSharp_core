namespace 多态_接口;

interface IFly
{
    //接口不能包含成员变量
    //  int a; //错误

    //方法
    void Fly();

    //属性
    string Name { get; set; }

    //索引器
    int this[int index] { get; set; }

    //事件
    event Action doSomething;
}

//接口的使用
class Animal
{

}
class Person : Animal, IFly
{
    //实现接口中的函数，可以申明为虚函数virtual，在子类中重写
    public virtual void Fly()
    {

    }
    public string Name { get; set; }

    public int this[int index]
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }
    public event Action doSomething;
}

//接口继承接口
interface IWalk
{
    void Walk();
}
//接口继承接口，不需要实现
interface IMove : IWalk, IFly
{

}
//类继承接口，必须实现所有成员
class Test : IMove
{
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event Action doSomething;

    public void Fly()
    {

    }

    public void Walk()
    {

    } 
}

//显示实现接口
interface IAtk
{
    void Atk();
}
interface ISuperAtk
{
    void Atk();
}
class Player : IAtk, ISuperAtk
{
    //继承接口的方法
    //类继承接口时，不加public，就必须要显示实现接口中的方法
    //接口名.方法名
    void IAtk.Atk()
    {

    }
    void ISuperAtk.Atk()
    {

    }
    //玩家自身的方法
    public void Atk()
    {

    }
}



class Program
{
    static void Main(string[] args)
    {
        //接口不能实例化
        //  IFly f = new IFly();    //错误
        //接口可以作为容器，里氏替换原则
        IFly f = new Person();

        IMove im = new Test();
        IFly ifly = new Test();
        IWalk iw = new Test();
        //用什么接口装，其对象就只能是该接口含有的方法
        im.Walk();
        im.Fly();
        //IFly只有Fly()
        ifly.Fly();
        //IWalk只有Walk()
        iw.Walk();

        //显示实现的使用
        IAtk ia = new Player();
        ISuperAtk isa = new Player();
        ia.Atk();
        isa.Atk();

        Player p = new Player();
        (p as IAtk).Atk();
        (p as ISuperAtk).Atk();
        p.Atk();
    }
}
