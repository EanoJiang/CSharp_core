namespace 多态_接口习题;

//1.
interface IRegister
{
    void Register();
}
class Person : IRegister
{
    public void Register()
    {
        Console.WriteLine("在派出所登记");
    }
}
class Car : IRegister
{
    public void Register()
    {
        Console.WriteLine("在车管所登记");
    }
}
class House : IRegister
{
    public void Register()
    {
        Console.WriteLine("在房管局登记");
    }
}

//2.
abstract class Animal
{
    public abstract void Walk();
}
interface IFly
{
    void Fly();
}
interface ISwim
{
    void Swim();
}
class helicopter : IFly
{
    public void Fly()
    {
        Console.WriteLine("直升机开始飞");
    }
}
class sparrow : Animal, IFly
{
    public override void Walk()
    {
    }
    public void Fly()
    {
    }
}
class Ostrich : Animal
{
    public override void Walk()
    {
    }
}
class Penguin : Animal, ISwim
{
    public void Swim()
    {
    }
    public override void Walk()
    {
    }
}
class Parrot : Animal, IFly
{
    public void Fly()
    {
    }
    public override void Walk()
    {
    }
}
class Swan : Animal, ISwim,IFly
{
    public void Swim()
    {
    }
    public void Fly()
    {
    }
    public override void Walk()
    {
    }
}

//3.
interface IUSB
{
    void ReadData();
}
class Computer
{
    public IUSB usb1;
}
class StorageDevice : IUSB
{
    public string name;
    public StorageDevice(string name)
    {
        this.name = name;
    }
    public void ReadData()
    {
        Console.WriteLine(name + "读取数据");
    }
}
class Mp3 : IUSB
{
    public void ReadData()
    {
        Console.WriteLine("mp3读取数据");
    }
}



class Program
{
    static void Main(string[] args)
    {
        //1.
        IRegister[] arr = new IRegister[] { new Person(), new Car(), new House() };
        foreach (IRegister item in arr)
        {
            item.Register();
        }

        //3.
        Computer cp1 = new Computer();
        cp1.usb1 = new Mp3();
        cp1.usb1.ReadData();
        cp1.usb1 = new StorageDevice("硬盘");
        cp1.usb1.ReadData();
    }
}
