namespace 构造_析构函数;

class Person{
    public string name;
    public int age;
    //构造函数
    //类中允许申明无参构造函数，结构体则不允许
    public Person(){
        name = "eano";    
        age = 18;  
    }
    // //构造函数可以被重载
    // public Person(string name, int age){
    //     this.name = name;
    //     this.age = age;
    // }
    //构造函数的特殊写法，在构造函数后:this(可选参数)
    public Person(string name, int age) : this(){
        Console.WriteLine("先进入无参构造函数");
    }
    //析构函数
    ~Person(){

    }
}


class Program
{
    static void Main(string[] args)
    {
        //现在有了3种申明并初始化对象的方式
        Person p = new Person();
        Console.WriteLine("Name: " + p.name);

        Person p2 = new Person("eano", 18);
        Console.WriteLine("Name: " + p2.name);

        Person p3 = new Person(){name = "eano", age = 18};
        Console.WriteLine("Name: " + p3.name);
        

    }
}
