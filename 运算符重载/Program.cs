namespace 运算符重载;

//语法
//public static 类名 返回类型 operator 运算符(参数类型1 参数名1, 参数类型2 参数名2){
//}

//实例
class Point {
    public int x, y;
    public static Point operator +(Point p1, Point p2) {
        Point p = new Point();
        p.x = p1.x + p2.x;
        p.y = p1.y + p2.y;
        return p;
    }
    //重载
    public static Point operator +(Point p1, int num) {
        Point p = new Point();
        p.x = p1.x + num;
        p.y = p1.y + num;
        return p;
    }
    #region 可重载的运算符
    // 算数运算符：+ - * / %  ++ --
    // (自增自减的参数只有一个)

    // 逻辑运算符：!
    // （ &&和||不能重载 ）

    // 位运算符：~ & | ^ << >>
    // (~只有一个参数)
    // (左移右移的参数Point p,int num)

    // 条件运算符：> < >= <= == !=
    // 条件运算符需要成对实现
    // 也就是>和<需要成对重载，>=和<=需要成对重载，==和!=需要成对重载
    
    #endregion

    #region 不可重载的运算符
    //逻辑运算符：&& ||
    //索引符：[]
    //强转运算符：()
    //特殊运算符：点.  三目运算符的?  赋值符号=
    #endregion
    
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.x = 1;
        p1.y = 2;
        Point p2 = new Point();
        p2.x = 3;
        p2.y = 4;
        Point p3 = p1 + p2;
        Console.WriteLine("p3.x = " + p3.x);
        Point p4 = p1 + 2;
        Console.WriteLine("p4.x = " + p4.x);
        //可以连续使用
        p4 = p1 + p2 + 3;
        Console.WriteLine("p4.x = " + p4.x);
    }
}
