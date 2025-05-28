namespace 成员变量;


#region 成员变量的申明
//在类中申明成员变量

//性别枚举
enum E_SexType{
    Male,
    Female,
}
//位置结构体
struct Position{

}
//宠物类
class Pet{

}
class Person{
    //特征——成员变量
    public string name = "Eano";//可以初始化也可以不初始化
    public int age;
    public E_SexType sex;
    public Position position;

    //可以申明任意类的对象，包括自身类
    // (这点和结构体就不同，结构体如果申明自身结构体的变量就会无限循环导致报错
    // 而在类里申明自身类的对象则没有问题，因为类是引用类型，只是声明一个对该对象的引用，也就是开辟了一个地址空间
    // 不能实例化自身类的对象，因为这样的话在后面创建对象的时候就会陷入无限循环)
    public Person girlfriend;  //不能实例化自身类的对象,初始化为null是可以的
    public Person[] friends;
    public Pet pet; //可以实例化其他类的对象
}
#endregion

#region 访问修饰符——3P
//public
//private
//protected 只有自己(类的内部)和子类可以访问
#endregion

class Program
{

    static void Main(string[] args)
    {
        //创建对象
        Person p = new Person();
        #region 成员变量的使用与初始值
        //值类型的默认值 都是0
        //  相应的bool——false  , char——'' ,string——""
        //引用类型的默认值 都是null
        //调用defalut()方法可以查看默认值
        Console.WriteLine(default(int));
        Console.WriteLine(default(bool));
        Console.WriteLine(default(char));
        //如果不申明，那么这个成员变量就是默认值
        Console.WriteLine(p.age);
        p.age = 25;
        Console.WriteLine(p.age);

        #endregion
    }
}
