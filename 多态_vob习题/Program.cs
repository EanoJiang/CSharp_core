using System.Drawing;

namespace 多态_vob习题;

//1
class Duck
{
    public virtual void Speak()
    {
        Console.WriteLine("嘎嘎叫");
    }
}
class woodenDuck : Duck
{
    public override void Speak()
    {
        Console.WriteLine("吱吱叫");
    }
}
class rubberDuck : Duck
{
    public override void Speak()
    {
        Console.WriteLine("唧唧叫");
    }
}

//3
class Graph
{
    public virtual float area()
    {
        return 0;
    }
    public virtual float perimeter()
    {
        return 0;
    }
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
        return sideLength * 4;
    }
}
class Sphere : Graph
{
    public float radius;
    public Sphere(float radius)
    {
        this.radius = radius;
    }
    public override float area()
    {
        return radius * 3.14f * 3.14f;
    }
    public override float perimeter()
    {
        return radius * 2 * 3.14f;
    }    
}
class Program
{
    static void Main(string[] args)
    {
        //1
        Duck d1 = new Duck();
        d1.Speak();
        Duck w1 = new woodenDuck();
        w1.Speak();
        Duck r1 = new rubberDuck();
        r1.Speak();
        //3
        Graph rect1 = new Rectangle(1, 2);
        Console.WriteLine(rect1.area());
        Console.WriteLine(rect1.perimeter());

        Graph square1 = new Square(1);
        Console.WriteLine(square1.area());
        Console.WriteLine(square1.perimeter());

        Graph sphere1 = new Sphere(1);
        Console.WriteLine(sphere1.area());
        Console.WriteLine(sphere1.perimeter());
    }
}
