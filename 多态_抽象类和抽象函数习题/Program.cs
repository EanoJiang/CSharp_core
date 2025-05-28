namespace 多态_抽象类和抽象函数习题;

//1.
abstract class Animal
{
    public abstract void Speak();
}
class Person : Animal
{
    public override void Speak()
    {
        Console.WriteLine("人叫");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("狗叫");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("猫叫");
    }
}

//2.
abstract class Graph
{
    public abstract float area();
    public abstract float perimeter();
}
class Rectangle : Graph
{
    public float width, length;
    public Rectangle(float width, float length)
    {
        this.width = width;
        this.length = length;
    }
    public override float area()
    {
        return width * length;
    }
    public override float perimeter()
    {
        return 2 * (width + length);
    }
}
class Square : Graph
{
    public float sideLength;
    public Square(float sideLength)
    {
        this.sideLength = sideLength;
    }
    public override float area()
    {
        return sideLength * sideLength;
    }
    public override float perimeter()
    {
        return 4 * sideLength;
    }
}
class Circle : Graph
{
    public float radius;
    public Circle(float radius)
    {
        this.radius = radius;
    }
    public override float area()
    {
        return 3.14f * radius * radius;
    }
    public override float perimeter()
    {
        return 2 * 3.14f * radius;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //1.
        Animal[] animals = new Animal[3] { new Dog(), new Cat(), new Dog() };
        foreach (Animal a in animals)
        {
            a.Speak();
        }

        //2.
        Graph[] graphs = new Graph[3] { new Rectangle(1, 2), new Square(2), new Circle(2) };
        foreach (Graph g in graphs)
        {
            Console.WriteLine(g.GetType().Name + "面积：" + g.area());
            Console.WriteLine(g.GetType().Name + "周长：" + g.perimeter());
        }

    }
}
