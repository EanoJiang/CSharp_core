namespace 构造_析构函数习题;
#region 1
class Person{
    public string name;
    public int age;
    //构造函数
    public Person(){
        name = "eano";
        age = 25;
    }
    //重载
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
    //特殊的构造函数
    public Person(string name):this(){
        Console.WriteLine("有参构造函数里的name:"+name);
    }

}
#endregion

#region 3
class Ticket{
    uint distance;
    float price;
    //构造函数
    public Ticket(uint distance){
        this.distance = distance;
        //price是通过GetPrice()方法计算出来的
        price = GetPrice();
    }
    //方法
    public float GetPrice(){
        if(distance > 300){
            return distance * 0.8f;
        }
        else if(distance > 200){
            return distance * 0.9f;
        }
        else if(distance > 100){
            return distance * 0.95f;
        }
        else{
            return distance * 1.0f;
        }
    }
    public void PrintPrice(){
        Console.WriteLine("距离{0}的票价为：{1}",distance,GetPrice());
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        //1
        //先进入无参构造函数，再进入有参构造函数
        Person p1 = new Person("John");
        Console.WriteLine(p1.name+" "+p1.age);
        //3
        Ticket t1 = new Ticket(250);
        t1.PrintPrice();
  
    }
}
