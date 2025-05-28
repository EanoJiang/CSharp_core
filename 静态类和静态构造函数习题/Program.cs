namespace 静态类和静态构造函数习题;

static class MathCalc{
    const float pi = 3.14f;
    public static float CircleArea(float r){
        Console.WriteLine("半径为{0}的圆的面积为{1}", r, pi * r * r);
        return pi * r * r;
    }
    public static float CirclePerimeter(float r){
        Console.WriteLine("半径为{0}的圆的周长为{1}", r, 2 * pi * r);
        return 2 * pi * r;
    }
    public static float RectangleArea(float a, float b){
        Console.WriteLine("长为{0}宽为{1}的矩形的面积为{2}", a, b, a * b);
        return a * b;
        }
    public static float RectanglePerimeter(float a, float b){
        Console.WriteLine("长为{0}宽为{1}的矩形的周长为{2}", a, b, 2 * (a + b));
        return 2 * (a + b);
    }
    public static float Abs(float n){
        float n1 = (n > 0)?n:-n;
        Console.WriteLine("{0}绝对值为{1}", n, n1);
        return n1;
    }
    static MathCalc(){
        Console.WriteLine("静态构造函数执行");
    }

}

class Program
{
    static void Main(string[] args)
    {
        MathCalc.CircleArea(5);
        MathCalc.CirclePerimeter(5);
        MathCalc.RectangleArea(5, 10);
        MathCalc.RectanglePerimeter(5, 10);
        MathCalc.Abs(-5);
    }
}
