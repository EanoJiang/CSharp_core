namespace 继承_构造函数;

#region 继承中构造函数的调用顺序
class GameObject{
    public GameObject(){
        Console.WriteLine("GameObject 构造函数");
    }
}
class Player: GameObject{
    public Player(){
        Console.WriteLine("Player 构造函数");
    }
}
class MainPlayer: Player{
    public MainPlayer(){
        Console.WriteLine("MainPlayer 构造函数");
    }
}
#endregion

#region 父类无参构造函数的重要性
// class Parent{
//     //有参构造函数会顶掉无参构造函数
//     public Parent(int i){
//         Console.WriteLine("Parent 构造函数");
//     }
// }
// class Child: Parent{
//     //子类默认调用的是父类的无参构造函数
//     //找不到父类无参构造函数，会报错
//     public Child(){
//         Console.WriteLine("Child 构造函数");
//     }
// }
#endregion

#region 通过base关键字,调用父类的指定构造函数
class Parent{
    //有参构造函数会顶掉无参构造函数
    public Parent(int i){
        Console.WriteLine("Parent 有参int构造函数");
    }
    public Parent(string str){
        Console.WriteLine("Parent 有参string构造函数");
    }
}
class Child: Parent{
    //base(传入父类构造函数的参数)
    public Child(int i) : base(i){
        Console.WriteLine("Child int参数构造函数");
    }
    public Child(string str) : base(str){
        Console.WriteLine("Child str参数构造函数");
    }
    //调用父类的有参int构造函数
    public Child(int i, string str) : base(i){
        Console.WriteLine("Child 两个参数构造函数");
    }
    //通过调用该子类的第一个构造函数(int i)，
    // 间接调用父类的有参int构造函数
    // public Child(int i, string str):this(i){
    // }
    //  和上面是等价的
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        //从根开始调用构造函数，也就是从父类开始向下调用
        MainPlayer mainPlayer = new MainPlayer();

        Child child = new Child(10);
        Child child2 = new Child("111");
        Child child3 = new Child(20, "222");
        
    }
}
