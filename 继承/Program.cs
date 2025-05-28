namespace 继承;

#region 继承语法
class Teacher{
    public string name;
    protected int number;
    public void PrintName(int number){
        //内部可以调用protected属性
        this.number = number;
        Console.WriteLine("My name is " + name + " " + number);
    }
}
//子类
class TeachingTeacher : Teacher{
    public new string name;
    //子类独有的属性
    public string subject;
    public void PrintSubject(int number){
        //子类里可以调用protected属性
        this.number = number;
        Console.WriteLine("My subject is " + subject);
    }
}
//子类的子类
class ChineseTeacher : TeachingTeacher{
    public void PrintChinese(int number){
        this.number = number;
        Console.WriteLine("xxxx");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        //语法
        TeachingTeacher teacher1 = new TeachingTeacher();
        teacher1.name = "John";
        //外部无法调用protected属性number
        // teacher1.number = 9527;
        teacher1.subject = "Math";
        //只能公共方法来传参，因为内部和子类可以访问protected属性
        teacher1.PrintName(9527);
        teacher1.PrintSubject(9527);
        //传递性继承
        ChineseTeacher teacher2 = new ChineseTeacher();
        teacher2.name = "Mary";
        //外部无法调用protected属性number
        // teacher2.number = 9528;
        teacher2.subject = "Chinese";
        //只能公共方法来传参，因为内部和子类可以访问protected属性
        teacher2.PrintName(9528);
        teacher2.PrintSubject(9528);
        teacher2.PrintChinese(9528);
    }
}
