# C#核心篇

> Github仓库：[https://github.com/EanoJiang/CSharp_core](https://github.com/EanoJiang/CSharp_core)

![1748613324370](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530215808701-272444150.png)

![1748613299870](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530215809525-1146266723.png)

## 面向对象的概念

封装(类)、继承，多态

## 类

### 类的基本概念

1. 具有相同特征、相同行为、一类事物的抽象
2. 类是对象的模板，可以通过类创建出对象
3. 关键词class

#### 类的申明

申明在nameplace语句块中——也就是要写在class Program 的外面，如果在类(class)里面申明类，那就是内部类

#### 语法

```csharp
namespace 面向对象;

    #region 类申明语法
    // 命名：帕斯卡命名法
    // 同一个语句块中的不同类不能重名
    //访问修饰符 class 类名{
    //     //特征——成员变量
    //     //行为——成员方法(函数)
    //     //保护特征——成员属性

    //     //构造函数、析构函数
    //     //索引器
    //     //运算符重载
    //     //静态成员
    // }
    #endregion

class Program
{

    static void Main(string[] args)
    {

    }
}

```

#### 使用

```csharp
namespace 面向对象;

class Person{
}
class Machine{
}
class Program
{
    static void Main(string[] args)
    {
        #region 实例化对象示例(类创建对象)
        //类对象都是引用类型的
        //语法: 类名 对象名 = new 类名();
        //在栈上开辟了一个空间存放地址，但是不开辟 堆内存空间，也就是null
        Person p;
        Person p1 = null;
        //分配堆内存空间
        //创建的每个对象只是模板都是同一个类，但是里面的信息都是不同的————类似造人
        Person p2 = new Person();
        Person p3 = new Person();
        #endregion
    }
}
```

> 习题

![1745540568134](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230158521-449838655.png)

```csharp
namespace 类和对象习题;

class Person{
}
class Animal{
}
class Machine{
}
class Plant{
}
class Astro{
}
class Program
{   
    static void Main(string[] args)
    {
        // 1
        Machine robot = new Machine();
        Machine machine = new Machine();
        Person people = new Person();
        Animal cat = new Animal();
        Person aunt = new Person();
        Person uncle_Wang = new Person();
        Machine car = new Machine();
        Machine plane = new Machine();
        Plant sunflower = new Plant();
        Plant chrysanthemum = new Plant();
        Astro sun = new Astro();
        Astro star = new Astro();
        Plant lotus = new Plant();
    }
}
```

```
A指向一个地址指向一块堆内存
B指向一个地址，地址拷贝自A的地址，所以也指向A的堆内存
B = null ：把B的地址与堆内存之间的指向关系断开
所以，A的堆内存没变
```

```
A和B没关系
```

### 成员变量——类的特征

1. 申明在类语句块中
2. 用来描述对象的特征
3. 任意变量类型
4. 数量不限
5. 赋不赋值都行

```csharp
namespace 成员变量;

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
```

总结：

1. 访问修饰符——3P
2. 在类里面申明自身类的对象的时候，不能实例化
3. defalut()方法得到数据类型的默认值

> 习题

![1745544012622](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230159397-6004606.png)

```csharp
3P:
private
public
protected
```

```csharp
namespace 成员变量习题;

class Student{
    public string name;
    public int age;
    public string num;
    public Student deskmate;
}

class Classroom{
    public string major;
    public int capacity;
    public Student[] students;
    public Classroom(int capacity)
    {
        this.capacity = capacity;
        students = new Student[capacity];
    }
}

class Program
{
    static void Main(string[] args)
    {
        //3
        Student s1 = new Student();
        Student s2 = new Student();
        //4
        Classroom c1 = new Classroom(5);
    }
}
```

```csharp
p.age = 10
```

```csharp
p2.age 是引用类型，拷贝的时候拷贝的是p.age的地址，改变p2.age的值，p.age也会改变
p.age = 20
```

```csharp
age是值类型，只是拷贝了s.age的值，不指向同一地址，所以s.age不变
s.age = 10
```

```csharp
s.deskmate.age = 20
```

### 成员方法——类的行为

不要加static关键字

```csharp
namespace 成员方法;

class Person{
    //成员方法
    public void Speak(string message){
        Console.WriteLine("{0}说{1}",name,message);
    }
    public bool IsAdult(){
        return age>=18;
    }
    public void AddFriend(Person p){
        if(friends==null) friends = new Person[]{p};
        else{
            Person[] temp = new Person[friends.Length+1];
            for(int i=0;i<friends.Length;i++){
                temp[i] = friends[i];
            }
            friends = temp;
            friends[friends.Length-1] = p;
        }
    }
    //成员变量
    public Person[] friends;
    public string name;
    public int age;
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Speak("Hello");
        p.name = "Tom";
        p.age = 20;
        Console.WriteLine(p.IsAdult());
        Person p2 = new Person(){name="Jerry",age=25};
        p.AddFriend(p2);
        Console.WriteLine(string.Join(",",p.friends.Select(f=>f.name)));
    }
}
```

> 习题

![1745715723169](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230200035-889430089.png)

```csharp
namespace 成员方法习题;

class Student{
    public void Speak(string message){
        Console.WriteLine("{0} says: {1}",name,message);
    }
    public void Eat(Food food){
        Console.WriteLine("{0} is eating {1},calories: {2}",name,food.name,food.calories);
    }
    public string name;
}

class Food{
    public string name;
    public int calories;
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(){name="Alice"};
        Food apple = new Food(){name="apple",calories=50};
        student.Eat(apple);
    }
}
```

### 构造、析构函数、垃圾回收机制

#### 构造函数——初始化时调用

1. 在类里面用于调用时快速初始化的函数
2. 没有构造函数的时候默认存在一个无参构造函数
   也就是 `Person p = new Person();`

##### 写法：

和结构体一样，构造函数名要和类名相同

```csharp
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
    //构造函数可以被重载
    public Person(string name, int age){
        this.name = name;
        this.age = age;
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
```

注意：

1. 有参构造函数 会顶掉 默认的无参构造函数。
2. 想要保留无参构造函数，需要重载出来
3. this用来区分类内成员变量和外部传入参数

##### 构造函数的特殊写法

`:this(可选参数)`复用代码

先进入无参构造函数

作用：复用先进入的构造函数代码

```csharp
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
        public Person(string name, int age) : this(name){
            Console.WriteLine("先进入string类型参数的构造函数");
        }
    }
```

:this(可选参数)可以指定先进入的构造函数

可选参数可以写死，比如

:this(int类型参数名)就是先进入参数为int类型的构造函数

:this(string类型参数名)就是先进入参数为string类型的构造函数

> 习题

![1745723937810](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230200696-1084955434.png)

```csharp
namespace 构造_析构函数习题;

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

class Ticket{
    uint distance;
    float price;
    //构造函数
    public Ticket(uint distance){
        this.distance = distance;
        //price是通过GetPrice()方法计算出来的
        price = GetPrice();
    }
    //成员方法
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

```

#### 析构函数——释放时调用

当引用类型的堆内存真正被回收时，调用析构函数

C++需要手动管理内存，所以才需要在析构函数中做内存回收处理

C#有自带的自动垃圾回收机制，所以不太需要析构函数，除非想在某个对象被垃圾回收时做一些特殊处理

**要写在类里面**

```csharp
~类名(){

}
```

#### 垃圾回收机制GC

原理：遍历堆(Heap)上动态分配的所有对象，通过识别是否被引用来确定哪些对象是垃圾，然后回收释放

垃圾回收的算法：

1. 引用计数
2. 标记清除
3. 标记整理
4. 复制集合

堆(Heap)内存由GC垃圾回收，引用类型

栈(Stack)内存由系统自动管理，值类型在栈中分配内存，有自己的申明周期，自动分配和释放

C#中内存回收机制的原理：

> 分代算法
>
> 0代内存		1代内存		2代内存

新分配的对象都被配置在0代内存中，(0代内存满时)触发垃圾回收

在一次内存回收过程开始时，垃圾回收器会认为堆中全是垃圾，进行以下两步：

1. 标记对象：从根（静态字段、方法参数）开始检查引用对象，标记后为可达对象，被标记的为不可达对象——不可达对象就是垃圾
2. 搬迁对象压缩堆：（挂起执行托管代码线程）释放未标记的对象，搬迁可达对象到一代内存中，修改可达对象的引用地址为连续的地址

![1745723658051](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230201461-166929389.png)

大对象：

大对象是第二代内存，目的是减少性能损耗以提高性能

不会对大对象进行搬迁压缩，85000字节(83kb)以上的对象是大对象

> 这个机制有点像三级缓存
>
> 速度：0 > 1 > 2
>
> 容量：0 < 1 < 2

##### 手动进行GC

`GC.Collect()`

一般在Loading过场动画的时候调用

### 小节

```csharp
class 类名{
//特征——成员变量
//行为——成员的方法
//初始化时调用——构造函数
//释放时调用——析构函数
}
```

### 成员属性——保护成员变量

1. 通过在get和set里面写逻辑，来保护成员变量
2. 解决3p的局限性
3. 用来让成员变量在外部：只能获取不能修改  /  只能修改不能获取

#### 语法:

```csharp
    //访问修饰符 属性类型 属性名{
    //    get{}
    //    set{}
    //}
```

#### 使用：

```csharp
namespace 成员属性;

    //访问修饰符 属性类型 属性名{
    //    get{}
    //    set{}
    //}
    class Person{
        private string name;
        private int age;
        private int money;
        private bool sex;

        //成员属性
        public string Name{
            get{
                //返回之前可以写逻辑规则
                return name;
            }
            set{
                //设置之前可以写逻辑规则
                //value用来接收外部传入的值
                name = value;
            }
        }
        public int Money{
            get{
                //加密处理
                return money - 5;
            }
            set{
                //逻辑处理
                if(value < 0){
                    value = 0;
                    Console.WriteLine("金额不能为负数");
                }
                //加密处理
                //这一部分涉及到加密算法，这里省略
                money = value + 5;
            }
        }
    }

class Program
{

    static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "eano";//调用的是set语句块
        Console.WriteLine(p.Name);//调用的是get语句块
        p.Money = -999;
        Console.WriteLine(p.Money);

        p.Money = 1000;
        Console.WriteLine(p.Money);
  
    }
}

```

#### get和set前可以加访问修饰符

```csharp
        #region get和set前可以加访问修饰符
        //1. 默认不加，会使用成员属性的访问修饰符(这里就是public)
        //2. 加的修饰符要低于成员属性的访问修饰符，否则会报错
        //3. 不能让get和set的访问权限都低于成员属性的权限
        public int Age{
            private get{
                return age;
            }
            set{
                age = value;
            }
        }
        #endregion
```

#### get和set可以只有一个

```csharp
        #region get和set可以只有一个
        //一般只会出现 只有get的情况，只能获取值，不能修改值————只读属性
        //只有一个的时候，不要加修饰符
        public bool Sex{
            get{
                return sex;
            }
        }
        #endregion

```

#### 自动属性

```csharp
        #region 自动属性
        //作用：外部只读不写的特性
        //使用场景：一个特征是只希望外部只读不可写，也不加别的特殊处理
        public float Height { get; private set; }
        //只可以在类内部set
        #endregion
```

> 习题

![1745798639830](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230202170-1462821562.png)

```csharp
namespace 成员属性习题;

class Student{
    private string name;
    private string sex;
    private int age;
    private int csGrade;
    private int unityGrade;
    public string Name{get; private set;}
    public string Sex{
        get{
            return sex;
        }
        private set{
            if(value != "男" && value != "女") sex = "unknown";
            else sex = value;
        }
    }
    public int Age{
        get{
            return age;
        } 
        private set{
            if(value < 0) age = 0;
            else if(value > 150) age = 150;
            else age = value;
        }
    }
    public int CsGrade{get; private set;} 
    public int UnityGrade{
        get{
            return unityGrade;
        } 
        private set{
            if(value < 0) unityGrade = 0;
            else if(value > 120) unityGrade = 120;
            else unityGrade = value;
        }
    }
  
    public Student(string name, string sex, int age, int csGrade, int unityGrade){
        Name = name;
        Sex = sex;
        Age = age;
        CsGrade = csGrade;
        UnityGrade = unityGrade;
    }
    public void Saymyself(){
        Console.WriteLine("My name is {0}, I am {1} years old, a {2}.", Name, Age, Sex);
    }
    public void SayGrade(){
        int sum = CsGrade + UnityGrade;
        float average = (float)sum / 2;
        Console.WriteLine("My sum grade is {0}, my average grade is {1}.", sum, average);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Tom", "男", 18, 90, 80);
        student1.Saymyself();
        student1.SayGrade();
        Student student2 = new Student("Jerry", "女", 160, 100, 90);
        student2.Saymyself();
        student2.SayGrade();  
    }
}
```

### 索引器——像数组一样访问元素

让对象可以像数组一样通过索引访问元素

注意：结构体中也支持索引器

#### 语法

```csharp
    class Person{
        private string name;
        private int age;
        private Person[] friends;

        #region 索引器语法
        //访问修饰符 返回值 this[数据类型 参数名1，数据类型 参数名2，...]{ 
        //   和属性的写法相同：
        //   get{
        //   }
        //   set{
        //   }
        // }
        public Person this[int index]{
            get{
                return friends[index];
            }
            set{
                friends[index] = value;
            }
        }

        #endregion

    }

```

#### 用法

```csharp
namespace 索引器;

class Person{
    private string name;
    private int age;
    private Person[] friends;
    private int[,] array;
    public string Name{get;private set;}
    public int Age{get;private set;}
    public Person[] Friends{get;private set;}
    public int[,] Array{get;private set;}
    public Person(string name, int age){
        Name = name;
        Age = age;
        friends = new Person[5];
        Friends = friends;
        array = new int[3, 4];
        Array = array;
    }

    #region 索引器语法
    //访问修饰符 返回值 this[数据类型 参数名1，数据类型 参数名2，...]{ 
    //   和属性的写法相同：
    //   get{
    //   }
    //   set{
    //   }
    // }
    public Person this[int index]{
        get{
            #region 索引器里也能写逻辑
            if(friends == null || index < 0 || index >= friends.Length){
                return null;
            }
            else{
                return friends[index];
            }
            #endregion
        }
        set{
            if(friends == null){
                friends = new Person[]{value};
            }
            //如果越界，顶掉最后一个元素
            else if(index < 0 || index >= friends.Length){
                friends[friends.Length - 1] = value;
            }
            else friends[index] = value;
        }
    }
    #endregion

    #region 索引器可以重载
    //参数不同
    public int this[int row, int col]{
        get{
            return array[row, col];
        }
        set{
            array[row, col] = value;
        }
    }
    public string this[string str]{
        get{
            switch(str){
                case "name":
                    return Name;
                case "age":
                    return Age.ToString();
                default:
                    return "Invalid index";
            }
        }
    }
    #endregion
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Alice", 25);
        p1.Friends[0] = new Person("Bob", 20);
        p1[1] = new Person("Charlie", 22);
        Console.WriteLine(p1[0].Name);
        p1[2, 3] = 10;
        Console.WriteLine(p1[2, 3]);
        Console.WriteLine("{0}的年龄是{1}, 朋友是{2}", p1["name"],p1["age"],p1[0]["name"]);
    }
}
```

> 索引器就相当于给对象加一个属性，用中括号[参数]调用这个属性的内容

> 习题

![1745803440897](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230202804-607628857.png)

```csharp
namespace 索引器习题;

class IntArray{
    public int[] arr;
    public int length;
    public IntArray(int size){
        length = 0;
        arr = new int[size];
    }
    //增
    public void Add(int index, int value){
        if(index < 0 || index > length){
            Console.WriteLine("索引超出范围");
            return;
        }
        else{
            if(length < arr.Length){
                arr[length] = value;
                length++;
            }
            else{
                int[] newArr = new int[arr.Length + 1];
                for(int i=0;i<arr.Length;i++){
                    newArr[i] = arr[i]; 
                }
                arr = newArr;
                //后面元素后移
                for(int i = length-1;i>=index;i--){
                    arr[i+1] = arr[i];
                }
                arr[index] = value;
                length++;
            }  
        }   
    }
    //删
    public void Remove(int index){
        if(index > length-1 || index < 0){
            Console.WriteLine("索引超出范围");
            return;
        }
        else{
            //后面元素前移
            for(int i = index;i<length-1;i++){
                arr[i] = arr[i+1];
            }
            length--;
        }
    }
    //索引器
    //查
    //改
    public int this[int index]{
        get{
            return arr[index];
        }
        set{
            arr[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IntArray arr = new IntArray(5);
        arr.Add(0,1);
        arr.Add(1,2);
        arr.Add(2,3);
        arr.Add(3,4);
        arr.Add(4,5);
        arr.Add(5,6);
        for(int i=0;i<arr.length;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(arr.length);

        arr.Remove(2);
        for(int i=0;i<arr.length;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(arr.length);
        arr[0] = 10;
        Console.WriteLine(arr[0]);
    }
}
```

### 静态成员——类名.出来使用

静态关键字 static

修饰成员变量、方法、属性

静态成员可以用 `类名.静态成员名`直接调用

一般写成public公共的

#### 申明与使用

```csharp
namespace 静态成员;

class Test{
    static public float PI = 3.14f;
    public int testInt = 10;
    static public float CircleArea(float r){
        #region 静态函数不能访问非静态成员
        // 非静态成员只能在实例化对象后调用
        Test t = new Test();
        Console.WriteLine(t.testInt);
        #endregion
        return PI * r * r;
    }
    public void TestFunc(){
        Console.WriteLine("This is a test function");
        #region 非静态函数可以使用静态成员
        Console.WriteLine(PI);
        Console.WriteLine(CircleArea(5));
        #endregion
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region 静态成员的使用
        Console.WriteLine(Test.PI);
        // Console.WriteLine(Test.testInt); // 不能直接类名.调用
  
        // 非静态成员只能在实例化对象后调用
        Test t = new Test();
        Console.WriteLine(t.testInt);

        Console.WriteLine(Test.CircleArea(5));
        //Console.WriteLine(Test.TestFunc());// 不能直接类名.调用
        t.TestFunc();
        #endregion
    }
}
```

#### 为什么可以类名.静态成员名使用

程序开始运行的时候，就会给静态成员分配内存空间

静态成员与程序共生死

每个静态成员都会有一个唯一的内存空间

直到程序结束，静态成员的内存空间才会被释放

#### 作用

1. 申明唯一变量
2. 方便在其他地方获取的对象的申明
3. 申明唯一方法——相同规则的数学计算

#### 问题

长期占用内存空间，其他非静态成员gc的阈值变小，程序性能降低

#### 常态和静态变量

相同点：

1. 都可以通过类名.出来使用

不同点：

1. const修饰常量，必须初始化，不能修改
2. const要直接写在变量的前面，也就是访问修饰符的后面
3. const只能修饰变量，static还可以修饰方法、属性

> 习题

![1745823537297](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230203353-1759878110.png)

```csharp
namespace 静态成员习题;

//单例模式
class Test{
    private static Test t = new Test();
    public int testInt = 10;
    public static Test T{
        get{
            return t;
        }
    }
    private Test(){
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Test.T.testInt);
        Test.T.testInt = 20;
        // Test t1 = new Test();    //外部无法实例化
        Console.WriteLine(Test.T.testInt);
    }
}
```

### 静态类和静态构造函数

作为工具使用，就像Console类一样，直接类名.出来使用静态成员

#### 静态类

static修饰的类

1. 只能包含静态成员
2. 不能被实例化

作用：

1. 将常用的静态成员写在静态类中
2. 静态类不能被实例化，体现工具类的唯一性

#### 静态构造函数

static修饰的构造函数

1. 静态类和非静态类都可以用静态构造函数
2. 静态构造函数不能使用访问修饰符
3. 不能有参数
4. 只会调用一次

静态构造函数只会在第一次使用类的时候调用一次，与类是否是静态类无关

普通构造函数每次实例化类的对象都会调用一次

```csharp
using System.Runtime.CompilerServices;

namespace 静态类和静态构造函数;

#region 静态类
static class TestStatic{
    public static void TestFunc(){

    }
    //静态类只能包含静态成员
    // public void Say(){
    // }
    public static int TestIndex{get;set;}
}
#endregion

#region 静态构造函数
//1. 静态类中的静态构造函数
static class StaticClass{
    public static int testInt = 10;
    //静态构造函数不能加访问修饰符
    //无参
    static StaticClass(){
        Console.WriteLine("静态类中的静态构造函数执行");
        //在静态构造函数里初始化成员变量
        testInt = 20;
    }

}
//2. 普通类中的静态构造函数
class NormalClass{
    public static int testInt = 10;
    static NormalClass(){
        Console.WriteLine("普通类中的静态构造函数执行");
        //在静态构造函数里初始化成员变量
        testInt = 20;
    }
    public NormalClass(){
        Console.WriteLine("普通类中的普通构造函数执行");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        //调用两次静态成员，但只执行一次静态构造函数
        Console.WriteLine(StaticClass.testInt);
        Console.WriteLine(StaticClass.testInt);

        //普通类中的静态构造函数也只执行一次
        Console.WriteLine(NormalClass.testInt);
        Console.WriteLine(NormalClass.testInt);
        //普通类中的普通构造函数每次实例化都会执行
        NormalClass nc = new NormalClass();
        NormalClass nc2 = new NormalClass();
  
    }
}

```

> 习题

![1745938803133](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230203930-1707158414.png)

```csharp
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

```

### 拓展方法

为现有非静态变量类型 添加新方法

作用：

1. 提升程序拓展性
2. 不需要在对象中重新写方法
3. 不需要继承来添加方法
4. 为别人封装的类写额外的方法

特点：

1. 一定写在静态类中
2. 一定是一个静态函数
3. 第一个参数是拓展目标(想要拓展方法的类型)，要用this修饰

#### 语法

```csharp
访问修饰符 static 返回值类型 函数名(this 拓展类名 参数名，参数数据类型 参数, ...){

}
```

```csharp
namespace 拓展方法;

    #region 语法
    //访问修饰符 static 返回值类型 函数名(this 拓展类名 参数名，参数数据类型 参数, ...){
    //
    //}
    #endregion

    #region 示例
    static class Tools{
        public static void Print(this string str){
            Console.WriteLine("为string拓展方法："+str);
        }
    }

    #endregion

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello World";
        str.Print(); //调用拓展方法
    }
}

```

#### 使用

```csharp
namespace 拓展方法;

    #region 语法
    //访问修饰符 static 返回值类型 函数名(this 拓展类名 参数名，参数数据类型 参数, ...){
    //
    //}
    #endregion

    #region 示例
    static class Tools{
        public static void Print(this string str){
            Console.WriteLine("为string拓展方法："+str);
        }
        public static void PrintInfo(this string str, string str1, int num){
            Console.WriteLine("拓展方法的对象："+str);  
            Console.WriteLine("传入的参数："+str1 + " " + num);
        }
        public static void PrintInfo(this Test t){
            Console.WriteLine("为Test类拓展方法："+t.i);
        }
        //如果拓展的方法名和类里面的方法重名，优先使用类的方法
        public static void Func(this Test t){
            Console.WriteLine("为Test类拓展同名方法：");
        }
    }
    #endregion
  
    #region 为自定义的类型拓展方法
    class Test{
        public int i = 10;
        public void Func(){
            Console.WriteLine("Test类自己的Func方法");
        }
    }
    #endregion

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello World";
        str.Print(); //调用拓展方法
        str.PrintInfo("你好", 123); //调用拓展方法

        //为自定义的类型拓展方法
        Test t = new Test();
        t.PrintInfo(); //调用拓展方法
        t.Func(); //重名，优先调用类自己的方法
    }
}

```

注意：

如果拓展的方法名和类里面的方法重名，优先使用类的方法

> 习题

![1745975969697](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230204576-1609497964.png)

```csharp
namespace 拓展方法习题;

//1
//平方
static class Test{
    public static int Square(this int n){
        Console.WriteLine("Square of " + n + " is " + (n*n));
        return n*n;
    }
    public static void Suicide(this Player player){
        Console.WriteLine("Player " + player.name + " is suiciding!");
    }
}

//2
//玩家
class Player{
    public string name;
    public int hp;
    public int atk;
    public int def;
    public Player(string name, int hp, int atk, int def){
        this.name = name;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
    }
    public void Attack(Player target){
        Console.WriteLine(this.name + " attacks " + target.name + "!");
        target.hp -= this.atk - target.def;
        Console.WriteLine(target.name + " now has " + target.hp + " HP.");
        if(this.atk - target.def > 0){
            Hurted(target);
        }
    }
    public void Move(int x, int y){
        Console.WriteLine(this.name + " moves to (" + x + ", " + y + ").");
    }
    public void Hurted(Player target){
        Console.WriteLine(target.name + " is hurt!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //1
        int num = 3;
        num.Square();
        //2
        Player player1 = new Player("player1", 100, 10, 5);
        Player player2 = new Player("player2", 100, 13, 2);
        player1.Attack(player2);
        player1.Move(1, 2);
        player1.Suicide();
        player2.Attack(player1);
        player2.Suicide();


    }
}

```

### 运算符重载——自定义对象能够运算

让自定义的类和结构体对象 能够使用运算符

关键字： operator

特点：

1. 必须是公共的静态方法
2. 返回值写在operator前

注意：

1. 条件运算符需要成对实现
2. 一个符号可以多个重载
3. 不能使用ref和out

#### 语法

```csharp
    //语法
    //public static 类名 返回类型 operator 运算符(参数类型1 参数名1, 参数类型2 参数名2){
    //}
```

#### 用法实例

```csharp
namespace 运算符重载;

class Program
{
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
    }
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

```

#### 可重载和不可重载的运算符

```csharp
    #region 可重载的运算符
    //算数运算符：+ - * / %  ++ --
    // (自增自减的参数只有一个)

    //逻辑运算符：!
    // （ &&和||不能重载 ）

    //位运算符：~ & | ^ << >>
    // (~只有一个参数)
    // (左移右移的参数Point p,int num)

    //条件运算符：> < >= <= == !=
    //条件运算符需要成对实现
    // 也就是>和<需要成对重载，>=和<=需要成对重载，==和!=需要成对重载
  
    #endregion

    #region 不可重载的运算符
    //逻辑运算符：&& ||
    //索引符：[]
    //强转运算符：()
    //特殊运算符：点.  三目运算符的?  赋值符号=
    #endregion
```

> 习题

![1745982049807](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230205225-1861371618.png)

```csharp
namespace 运算符重载习题;

//1
class Position{
    public int x;
    public int y;
    public static bool operator ==(Position p1, Position p2){
        if(p1.x == p2.x && p1.y == p2.y){
            return true;
        }
        return false;
    }
    public static bool operator !=(Position p1, Position p2){
        if(p1.x!= p2.x || p1.y!= p2.y){
            return true;
        }
        return false;
    }
}

//2
class Vector3{
    public int x;
    public int y;
    public int z;
    public static Vector3 operator +(Vector3 v1, Vector3 v2){
        Vector3 result = new Vector3();
        result.x = v1.x + v2.x;
        result.y = v1.y + v2.y;
        result.z = v1.z + v2.z;
        return result;
    }
    public static Vector3 operator -(Vector3 v1, Vector3 v2){
        Vector3 result = new Vector3();
        result.x = v1.x - v2.x;
        result.y = v1.y - v2.y;
        result.z = v1.z - v2.z;
        return result;
    }
    public static Vector3 operator *(Vector3 v1, int n){
        Vector3 result = new Vector3();
        result.x = v1.x * n;
        result.y = v1.y * n;
        result.z = v1.z * n;
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1
        Position a = new Position();
        a.x = 1;
        a.y = 2;
        Position b = new Position();
        b.x = 1;
        b.y = 2;
        Console.WriteLine(a == b); // True
        Console.WriteLine(a!= b); // False
        //2
        Vector3 v1 = new Vector3();
        v1.x = 1;
        v1.y = 2;
        v1.z = 3;
        Vector3 v2 = new Vector3();
        v2.x = 2;
        v2.y = 3;
        v2.z = 4;
        Vector3 v3 = v1 + v2;
        Console.WriteLine("(v3.x, v3.y, v3.z) = ({0}, {1}, {2})", v3.x, v3.y, v3.z);
        Vector3 v4 = v1 - v2;
        Console.WriteLine("(v4.x, v4.y, v4.z) = ({0}, {1}, {2})", v4.x, v4.y, v4.z);
        Vector3 v5 = v1 * 2;
        Console.WriteLine("(v5.x, v5.y, v5.z) = ({0}, {1}, {2})", v5.x, v5.y, v5.z);
    }
}

```

### 内部类和分部类

#### 内部类——在一个类中申明一个类

要用包裹者点出这个内部类

作用：亲密关系的体现，有点像继承

注意：访问修饰符作用很大

```csharp
namespace 内部类和分部类;

#region 内部类
class Person{
    public string name;
    public int age;
    public Body body;

    public class Body{
        Arm leftArm;
        Arm rightArm;
        class Arm{

        }
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.body = new Person.Body();
        //访问修饰符的作用，不写public，则无法访问
        //  person.body.leftArm = new Person.Body.Arm();

    }
}

```

#### 分部类——一个类分成几部分申明

关键字：partial

作用：分部描述一个类，增加程序的可拓展性

注意：

1. 分部类可以写在多个脚本文件中
2. 分部类的访问修饰符要一致
3. 分部类中不能有重复的成员

```csharp
namespace 内部类和分部类;

#region 内部类
class Person{
    public string name;
    public int age;
    public Body body;

    public class Body{
        Arm leftArm;
        Arm rightArm;
        class Arm{

        }
    }
}
#endregion

#region 分部类
partial class Student{
    public bool sex;
    public string name;
}
partial class Student{
    public int age;
    //注意不要重复成员名
    //  public string name; 
    public void SayHello(){
        Console.WriteLine("Hello,I'm {0},age is {1}",name,age);
    }
}

#endregion

class Program
{
    static void Main(string[] args)
    {
        //内部类
        Person person = new Person();
        person.body = new Person.Body();
        //访问修饰符的作用，不写public，则无法访问
        //  person.body.leftArm = new Person.Body.Arm();

        //分部类
        Student student = new Student();
        student.age = 18;
        student.name = "Tom";
        student.sex = true;
        student.SayHello();
    }
}

```

#### 分部方法——将方法的申明和实现分离

注意：

1. 不能加访问修饰符，默认私有
2. 只能在分部类里申明
3. 返回值只能是void
4. 参数不能用out关键字

```csharp
namespace 内部类和分部类;

#region 内部类
class Person{
    public string name;
    public int age;
    public Body body;

    public class Body{
        Arm leftArm;
        Arm rightArm;
        class Arm{

        }
    }
}
#endregion

#region 分部类
partial class Student{
    public bool sex;
    public string name;
    public partial void SayHello();
}
partial class Student{
    public int age;
    //注意不要重复成员名
    //  public string name; 

    public partial void SayHello(){
        Console.WriteLine("I'm {0},age:{1}", name, age);
    }
}

#endregion

class Program
{
    static void Main(string[] args)
    {
        //内部类
        Person person = new Person();
        person.body = new Person.Body();
        //访问修饰符的作用，不写public，则无法访问
        //  person.body.leftArm = new Person.Body.Arm();

        //分部类
        Student student = new Student();
        student.age = 18;
        student.name = "Tom";
        student.sex = true;
        student.SayHello();
    }
}

```

## 继承

### 继承的基本概念

子类继承父类的所有成员、特征和行为

子类可以有自己的特征和行为

**单根性**：子类只能有一个父类

**传递性**：子类可以**间接继承父类的父类**

#### 语法

```csharp
namespace 继承;

#region 继承语法
class Teacher{
    public string name;
    public int number;
    public void PrintName(){
        Console.WriteLine("My name is " + name + " " + number);
    }
}
//子类
class TeachingTeacher : Teacher{
    //子类独有的属性
    public string subject;
    public void PrintSubject(){
        Console.WriteLine("My subject is " + subject);
    }
}
//子类的子类
class ChineseTeacher : TeachingTeacher{
    public void PrintChinese(){
        Console.WriteLine("xxxx");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        TeachingTeacher teacher1 = new TeachingTeacher();
        teacher1.name = "John";
        teacher1.number = 9527;
        teacher1.subject = "Math";
        teacher1.PrintName();
        teacher1.PrintSubject();
        //传递性继承
        ChineseTeacher teacher2 = new ChineseTeacher();
        teacher2.name = "Mary";
        teacher2.number = 9528;
        teacher2.subject = "Chinese";
        teacher2.PrintName();
        teacher2.PrintSubject();
        teacher2.PrintChinese();
    }
}

```

#### 访问修饰符对继承的影响

private、public、protected、internal

private：只有内部能访问，子类不能访问，但是子类里可以调用父类的公共方法来间接传入private参数(实际上还是在父类里面调用的private参数)

```csharp
class Teacher{
    public string name;
    private int number;
    public void PrintName(int number){
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
        //子类里可以调用父类的公共方法来间接传入private参数
        PrintName(number);
        Console.WriteLine("My subject is " + subject);
    }
}
```

**protected**：保护的是内部和子类

也就是希望**外部不能调用，但是其内部和子类可以调用**

```csharp
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

```

internal：内部的，只有在同一个程序集文件中，内部类型或成员才能访问

> 在后面命名空间再讲internal

#### 子类和父类的同名成员

C#中允许出现子类和父类存在同名成员：

子类里可以命名和父类同名的成员，但是声明子类对象的时候，子类的成员会顶替父类。

最好别用这个特性

要用的时候，最好在前面加上new，用来表明这是一个新的成员，顶替父类里的同名成员。

![1746585122615](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222441758-289765390.png)

> 习题

![1746585220823](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222442832-1715955100.png)

```csharp
namespace 继承习题;

class Person{
    public string name;
    public int age;
    public void SayHello(){
        Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
    }
}

class Warrior : Person{
    public void Atk(Person person){
        Console.WriteLine("Warrior {0} attacks {1}!", name, person.name);
    } 
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.name = "Alice";

        Warrior warrior = new Warrior();
        warrior.name = "John";
        warrior.age = 30;
        warrior.SayHello();
        warrior.Atk(person);
    }
}

```

### 继承_里氏替换原则

> **面向对象七大原则**
>
> 开闭原则：对扩展开放，对修改封闭
>
> 单一职责原则：一个类只负责一项职责
>
> 依赖倒置原则：高层模块不应该依赖低层模块，二者都应该依赖抽象
>
> 接口隔离原则：使用多个专门的接口，而不使用单一的总接口
>
> 迪米特法则：一个对象应该对其他对象有最少的了解
>
> 里氏替换原则：子类对象必须能够替换其父类对象
>
> 违反开闭原则：违反开闭原则的设计是不好的设计

#### 里氏替换原则的基本概念

任何父类出现的地方，子类都可以替代

父类容器装子类对象，因为子类对象包含了父类的所有内容

**作用**：方便进行对象储存和管理

#### 语法

```csharp
namespace 继承_里氏替换原则;

class GameObject{
  
}
class Player : GameObject{
    public void Attack(GameObject target){
        Console.WriteLine("{0}Attack{1}", this, target);
    }
}
class Monster : GameObject{

}
class Boss : GameObject{

}

class Program
{
    static void Main(string[] args)
    {
        #region 里氏替换原则语法
        //父类容器 装 子类对象
        GameObject player = new Player();
        GameObject monster = new Monster();
        GameObject boss = new Boss();

        GameObject[] objects = new GameObject[] { new Player(), new Monster(), new Boss()};
        #endregion
  
    }
}

```

这样写了之后不能子类名.调用其方法，所以有了下面的两个关键字。

#### is 和 as 关键字

is判断，as转换

 **is**：判断一个对象是否是指定类对象

返回：bool

语法很接近自然语言

```csharp
        #region is 和 as 关键字
        if(player is Player){
  
        }
        else if(player is Monster){

        }
        #endregion
```

**as**：讲一个对象转换为指定类对象

返回：指定类型对象，否则失败就返回null

```csharp
       Player p = player as Player;
       Monster m = player as Monster;
       Console.WriteLine(p);
       Console.WriteLine(m == null);//true
```

**is和as配合使用**

```csharp
       #region is和as的配合使用
       if(player is Player){

        // Player p1 = player as Player;
        // p1.Attack(monster);
  
        (player as Player).Attack(monster);

       }
       #endregion
```

```csharp
        //当不知道objects数组里的内容，需要遍历判断
        for(int i = 0; i < objects.Length; i++){
            //objects数组里的Player类型对象
            if(objects[i] is Player){
                (objects[i] as Player).Attack(monster);
            }
            else if(objects[i] is Monster){
                //objects数组里的Monster类型对象
                //...
            }
            else if(objects[i] is Boss){
                //objects数组里的Boss类型对象
                //...
            }
        }
```

#### **不能用子类容器装父类对象**

因为父类对象的方法比子类少

```csharp
// Player p2 = new GameObjects();	//错误
```

> 习题

![1746670802429](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222443596-639089371.png)

```csharp
namespace 继承_里氏替换原则习题;

class Monster{
  
}
class Boss : Monster{
    public void Skill(){
        Console.WriteLine("Boss Skill");
    }
}
class Goblin : Monster{
    public void Atk(){
        Console.WriteLine("Goblin Atk");
    }
}

class Player{
    public Weapon nowWeapon;
    public Player(){
        //默认武器：匕首
        nowWeapon = new Dagger();
    }
    //切换武器
    public void Converse(Weapon weapon){
        nowWeapon = weapon;
    }
    public void PrintWeapon(){
        Console.WriteLine("now I have a {0}", nowWeapon.name);
    }

}
class Weapon{
    public string name;

}
class MP9 : Weapon{
    public MP9(){
        name = "MP9";
    }
}
class ShotGun : Weapon{
    public ShotGun(){
        name = "ShotGun";
    }
}
class Pistol : Weapon{
    public Pistol(){
        name = "Pistol";
    }
}
class Dagger : Weapon{
    public Dagger(){
        name = "Dagger";
    }
}

class Program
{
    static void Main(string[] args)
    {
        //习题1
        Random r = new Random();
        int randomNum;
        Monster[] monsters = new Monster[10];
        //随机生成10个怪物，二者生成概率都是50%
        for(int i = 0; i < monsters.Length; i++){
            randomNum = r.Next(0,2);
            if(randomNum == 1){
                monsters[i] = new Boss();
            }
            else{
                monsters[i] = new Goblin();
            }
        }
        for(int i = 0; i < monsters.Length; i++){
            if(monsters[i] is Boss){
                (monsters[i] as Boss).Skill();
            }
            else if(monsters[i] is Goblin){
                (monsters[i] as Goblin).Atk();
            }
        }

        //习题2
        Player player = new Player();
        player.PrintWeapon();
        Console.WriteLine("下面开始捡东西");
        Weapon[] weapons = new Weapon[4]{new MP9(), new ShotGun(), new Pistol(), new Dagger()};
        for(int i = 0; i < weapons.Length; i++){
            player.Converse(weapons[i]);
            player.PrintWeapon();
        }

    }
}

```

### 继承中的构造函数

当申明一个子类对象的时候，先执行父类的构造函数，再执行子类的构造函数

注意：

1. 父类的无参构造

子类默认调用的是父类的无参构造函数

```csharp
#region 父类无参构造函数的重要性
class Parent{
    //有参构造函数会顶掉无参构造函数
    public Parent(int i){
        Console.WriteLine("Parent 构造函数");
    }
}
class Child: Parent{
    //子类默认调用的是父类的无参构造函数
    //找不到父类无参构造函数，会报错
    public Child(){
        Console.WriteLine("Child 构造函数");
    }
}
#endregion
```

2. 子类可以通过base关键字，调用父类的指定构造函数
   (先调用父类，再调用子类另外写的)

```csharp
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
```

> 习题

![1746775248315](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222444353-1212244995.png)

```csharp
namespace 继承_构造函数习题;

class Worker{
    public string jobType;
    public string jobContent;
    public Worker(){
    }
    public Worker(string jobType, string jobContent){
        this.jobType = jobType;
        this.jobContent = jobContent;
    }
    public void Work(){
        Console.WriteLine("I am a worker, my job is {0} and my job content is {1}", jobType, jobContent);
    }
}
class Programmer : Worker{
    public Programmer():base("Programmer", "Coding"){

    }
}
class Strategist : Worker{
    public Strategist():base("Strategist", "Planning"){

    }
}
class Artist : Worker{
    public Artist():base("Artist", "Drawing"){
    }
}


class Program
{
    static void Main(string[] args)
    {
        Programmer p = new Programmer();
        p.Work();
        Strategist s = new Strategist();
        s.Work();
        Artist a = new Artist();
        a.Work();
    }
}

```

### 万物之父和装箱拆箱

#### 万物之父

**关键字**：object

object是所有类型的基类

**作用**：

1. 利用里氏替换原则，用object作为父类容器装所有对象
2. 用来表示不确定类型，作为函数的参数类型

```csharp
namespace 继承_万物之父与装箱拆箱;

class Father{
    public void Speak(){
        Console.WriteLine("I am Father.");
    }
}
class Son : Father{

}

class Program
{
    static void Main(string[] args)
    {
        //用object容器装任意对象
        object o = new Son();
        Son s = new Son();
        o = s;
        Father f = new Father();
        o = f;
        //用is和as来调用容器里的对象的成员
        if(o is Father)(o as Father).Speak();

        #region object对象的类型转换

        //值类型 —— 强转
        //用object容器装任意值类型
        object o2 = 1f;
        //要当成数字用的话，需要强转
        int f1 = (int)o2;

        //引用类型 —— as转换
        //string类型
        object o3 = "111";
        string s1 = (string)o3;
        s1 = o3 as string;
        s1 = o3.ToString();
        //数组类型
        object o4 = new int[3];
        int[] arr = o4 as int[];
        arr = (int[])o4;

        #endregion

    }
}

```

#### 装箱拆箱

装箱：用object存值类型——引用类型存值类型，栈内存会迁移到堆内存

拆箱：把object转为值类型——值类型从引用类型取出，堆内存迁移到栈内存

优点：方便在不确定类型时对参数进行存储和传递

缺点：存在内存迁移，增加性能消耗

```csharp
        #region 装箱拆箱
        object o5 = 3;
        int i1 = (int)o5;

        Func(1,2,3.1f,"dsadsajda",new Son());
        //传任意类型参
        void Func(params object[] arr){

        }
        void Func1(object o){

        }

        #endregion
```

### 密封类

关键字**sealed修饰的类**

让类无法再被继承

类似**结扎**

```csharp
class Father{

}
//表示这就是最后一个子类，不能再往下继承了
//类似结扎
sealed class Son : Father{

}
```

**作用：**

在面向对象程序设计中，密封类就是不允许某个最底层子类再被继承

可以保证程序的规范性和安全性

### 继承部分综合习题

![1746780536078](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222445009-624308117.png)

```csharp
namespace 继承_综合习题;

class Car{
    public int speed;
    public int maxSpeed;
    //当前的人数
    public int num;
    public Person[] persons;
    public Car(int speed, int maxSpeed, int maxNum){
        this.speed = speed;
        this.maxSpeed = maxSpeed;
        this.num = 0;
        persons = new Person[maxNum];
    }
    public void AddPerson(Person person){
        if(num >= persons.Length){
            Console.WriteLine("车子已满");
            return;
        }
        persons[num] = person;
        num++;
    }
    public void RemovePerson(Person delPerson){
        if(delPerson is Driver){
            Console.WriteLine("驾驶员不能下车");
            return;
        }
        //只有乘客下车
        else{
            for(int i = 0; i < persons.Length; i++){
                //结束循环的条件是找到空位
                if(persons[i] == null){
                    break;
                }
                // 找到要删除的对象
                else if(persons[i] == delPerson){
                    // 找到了要删除的对象，将其后面的元素前移一位
                    for(int j = 0; j < num - 1; j++){
                        persons[j] = persons[j+1];
                    }
                    //最后一个位置清空
                    persons[num-1] = null;
                    num--;
                    break;
                }
            }
        }
    }

    public void Move(){
    }
    public void Accident(){
        if(speed > maxSpeed)
            Console.WriteLine("发生事故");
        else
            Console.WriteLine("正常");
    }
    public void PrintNum(){
        Console.WriteLine("当前车子乘客数量：" + num);
    }
}
class Person{

}
class Driver:Person{

}
class Passenger:Person{

}

class Program
{
    static void Main(string[] args)
    {
        Person d1 = new Driver();
        Person p1 = new Passenger();
        Person p2 = new Passenger();
        Car car = new Car(60, 80, 5);
        car.AddPerson(d1);
        car.AddPerson(p1);
        car.AddPerson(p2);
        car.PrintNum();
        car.RemovePerson(d1);
        car.PrintNum();
        car.RemovePerson(p1);
        car.PrintNum();
        car.Accident();
        car.speed = 100;
        car.Accident();
   
    }
}

```

## 多态

### 多态的基本概念

让继承同一父类的子类们，在执行相同方法的时候有不同的表现

解决问题：**让同一个对象有唯一行为的特征**

```csharp
class Father
{
    public void SpeakName()
    {
        Console.WriteLine("Father类");
    }
}
class Son : Father
{
    public new void SpeakName()
    {
        Console.WriteLine("Son类");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //如果用里氏替换原则
        Father s = new Son();
        s.SpeakName();  //这里会打印父类的方法
        //只有用as转换成子类对象才会调用子类的方法
        (s as Son).SpeakName();
    }
}
```

这样写很容易造成混乱，于是就有了多态

### 多态的实现

前面学过函数重载，这是编译时候的多态，也叫做静态的多态，意思是在程序编译阶段，编译器根据**参数的类型和数量**来决定调用哪个具体的重载函数版本。

下面介绍的是运行时的多态(vob、抽象函数、接口)

### vob

v：virtual（虚函数）

o：override（重写）

b：base（父类）

父类的虚函数，在子类用override重写该函数，可以选择用/不用base。

用里氏替换或者其他方法声明对象，new什么就调用什么的方法ß

```csharp
namespace 多态_vob;

class GameObject
{
    public string name;
    public GameObject(string name)
    {
        this.name = name;
    }
    public virtual void Atk()
    {
        Console.WriteLine("GameObject对象的攻击");
    }
}
class Player : GameObject
{
    //子类默认找的是父类的无参构造函数，但是上面父类中已经有参构造，顶掉了无参构造
    //所以需要:base()继承构造函数
    public Player(string name) : base(name)
    {

    }
    //虚函数可以被子类重写
    public override void Atk()
    {
        //base.Atk();   //保留父类的虚函数行为，可以写在这个override方法的任何需要的地方
        Console.WriteLine("Player对象的攻击");
    }
}

class Program
{
    static void Main(string[] args)
    {
        GameObject p1 = new Player("sb");
        p1.Atk();
        //这就和原来用as的方式结果一样，但是可读性更强
        // (p1 as Player).Atk();
    }
}

```

#### 什么时候需要base？

需要保留父类行为就base.方法名()

> 习题

![1748268507365](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250529004208654-1776721813.png)

```csharp
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

```

### 抽象类和抽象函数

#### 抽象类

关键字：`abstract`

特点：

1. **不能被实例化**，但是可以用里氏替换原则作为容器存储对象
2. 可以包含抽象方法
3. 继承抽象类必须重写他的抽象方法

```csharp
namespace 多态_抽象类和抽象函数;

abstract class Thing
{
    public string name;
    //抽象函数

}
class Water : Thing
{
  
}
class Program
{
    static void Main(string[] args)
    {
        //抽象类不能被实例化
        //  Thing t = new Thing();  // 错误
        //抽象类的子类可以用里氏替换原则用父类装子类
        Thing t = new Water();
        //抽象类的子类可以被实例化
        Water w = new Water();
    }
}

```

#### 抽象函数

又名：纯虚方法

关键字：abstarct

特点：

1. 只能在抽象类中申明
2. 没有函数体，就是不要写花括号{}
3. 不能是私有的
4. 继承后必须用override重写

```csharp
abstract class Thing
{
    public string name;
    //抽象函数
    public abstract void Show();
    //虚函数
    public virtual void Test()
    {
  
    }
}
class Water : Thing
{
    //继承一个有抽象函数的抽象类，必须要实现抽象函数
    public override void Show()
    {

    }
    //虚函数可以选择是否要覆盖
    public override void Test()
    {

    }
}
```

##### 抽象函数和虚函数的区别

抽象函数：父类里面一定不能有函数体，只能在抽象类里申明，必须要在其子类里实现，但在子类的子类就可以不用实现了

虚函数：可以选择在父类中写不写函数体，可以在任意类申明，可以选择在子类是否重写

##### 抽象函数和虚函数的共同点

都可以在子类/子类的子类无限重写

> 习题

![1748357566289](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250529004209555-925458747.png)

```csharp
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

```

### 接口

*——接口就是抽象出来的一种行为父类，不同类的子类都可以继承这个接口*

> 比如鸟和飞机，分别是动物类的子类和机器的子类，但是都有飞这个行为，就可以抽象出来一个接口：IFly

关键字：`interface`

接口是行为的抽象规范，是一种自定义类型。

特点：

* 接口和类的申明相似
* 接口是用来继承的
* 接口不能被实例化，但是可以用里氏替换原则作为容器存储对象

#### 接口的申明

**接口是抽象行为的父类**

**接口命名**：帕斯卡命名法前加一个“ I "

接口申明的规范：

1. 不包含成员变量
2. 只包含方法、属性、索引器、事件
3. 成员不能被实现
4. 成员可以不用写访问修饰符，但绝对不能是私有的
5. 接口不能继承于类，但是可以继承另一个接口

```csharp
interface IFly
{
    //接口不能包含成员变量
    //  int a; //错误

    //方法
    void Fly();

    //属性
    string Name { get; set; }

    //索引器
    int this[int index] { get; set; }

    //事件
    event Action doSomething;
}
```

#### 接口的使用

接口的使用规范：

1. 接口是用来继承的
2. 类可以继承1个类，n个接口
3. 接口本身可以不用写访问修饰符，默认就是public
4. **继承了接口后，必须实现接口中的所有成员，并且必须用public**(如果用protected，那就必须显示实现)

```csharp
//接口的使用
class Animal
{

}
class Person : Animal, IFly
{
    //实现接口中的函数，可以申明为虚函数virtual，在子类中重写
    public virtual void Fly()
    {

    }
    public string Name { get; set; }

    public int this[int index]
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }
    public event Action doSomething;
}

```

接口遵循里氏替换原则

```csharp
class Program
{
    static void Main(string[] args)
    {
        //接口不能实例化
        //  IFly f = new IFly();    //错误
        //接口可以作为容器，里氏替换原则
        IFly f = new Person();

    }
}
```

#### 接口可以继承接口

1. 接口继承接口后，不需要实现
2. 类继承接口后，类必须实现所有内容

```csharp
//接口继承接口
interface IWalk
{
    void Walk();
}
//接口继承接口，不需要实现
interface IMove : IWalk, IFly
{

}
//类继承接口，必须实现所有成员
class Test : IMove
{
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event Action doSomething;

    public void Fly()
    {

    }

    public void Walk()
    {

    } 
}
```

里氏替换，接口作为容器

```csharp
        IMove im = new Test();
        IFly ifly = new Test();
        IWalk iw = new Test();
        //用什么接口装，其对象就只能是该接口含有的方法
        im.Walk();
        im.Fly();
        //IFly只有Fly()
        ifly.Fly();
        //IWalk只有Walk()
        iw.Walk();
```

#### 显示实现接口

当一个类继承2个接口，但是接口存在同名方法时

显示实现接口不能写访问修饰符

```csharp
//显示实现接口
interface IAtk
{
    void Atk();
}
interface ISuperAtk
{
    void Atk();
}
class Player : IAtk, ISuperAtk
{
    //继承接口的方法
    //类继承接口时，不加public，就必须要显示实现接口中的方法
    //接口名.方法名
    void IAtk.Atk()
    {

    }
    void ISuperAtk.Atk()
    {

    }
    //玩家自身的方法
    public void Atk()
    {

    }
}

```

```csharp
        //显示实现的使用
        IAtk ia = new Player();
        ISuperAtk isa = new Player();
        ia.Atk();
        isa.Atk();

        Player p = new Player();
        (p as IAtk).Atk();
        (p as ISuperAtk).Atk();
        p.Atk();
```

#### 总结

* 继承类：是对象间的继承
* 继承接口：行为间的继承，继承接口里的行为规范去实现内容

接口可以作为容器装对象

接口的引入，可以实现装载各种不同类但是有相同行为的对象

特别注意：

* 接口包含 成员方法、属性、索引器、事件，并且都不实现，都没有访问修饰符
* 可以继承多个接口，但只能继承一个类
* 接口可以继承接口，这就相当于行为的合并，在子类继承的时候再去实现具体的行为
* 接口可以被显示实现，用来解决不同接口中的同名函数的不同实现
* 接口方法在子类实现的时候可以加virtual申明为虚函数，然后在之后的子类中重写

> 习题

![1748450451796](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250529004211638-1168007505.png)

```csharp
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

```

### 密封方法

关键字：`consealed`

子类对虚函数和抽象函数override的时候加上了关键字sealed，那么在这个子类的子类就不能再重写了。

特点：

* 密封方法可以让虚函数和抽象函数不能再次被子类重写
* 和override一起出现

```csharp
abstract class Animal
{
    public string name;
    public abstract void Atk();
    public virtual void Fuck()
    {
        Console.WriteLine("fuck");
    }
}
class Person : Animal
{
    public sealed override void Atk()
    {
    }
    public sealed override void Fuck()
    {
        Console.WriteLine("fuck me");
    }
}
// class Test : Person
// {
//     //后续子类就不能重写了
//     public override void Atk()
//     {
//     }
//     public override void Fuck()
//     {
//     }
// }
```

## 命名空间

作用：用来组织和复用代码

> 命名空间：工具包，类：工具包里面的一个个工具(申明在命名空间中)

### 使用

命名空间可以同名，也就是分段写，也可以分文件写

```csharp
namespace MyGame
{
    class GameObject
    {
    }
}
namespace MyGame
{
    class Player : GameObject
    {
    }
}
```

### 不同命名空间中互相使用：需要引用命名空间/指明出处

1. using 命名空间名;

```csharp
using MyGame;

namespace 命名空间
{
    class Program
    {
        static void Main()
        {
            //不同命名空间中相互使用，需要引用命名空间或指明出处
            GameObject g = new GameObject();
        }
    }
}

```

2. 命名空间名.类名

```csharp
            //不同命名空间中相互使用，需要引用命名空间或指明出处
            MyGame.GameObject g = new MyGame.GameObject();
```

### 不同命名空间中允许有同名类

```csharp
namespace MyGame
{
    class GameObject
    {
    }
}
//不同命名空间允许有同名的类
namespace MyGame2
{
    class GameObject
    {
    }
}
```

如果要在另一个命名空间调用不同命名空间的同名类，只能必须指明出处

```csharp
            MyGame.GameObject g = new MyGame.GameObject();
            MyGame2.GameObject g2 = new MyGame2.GameObject();
```

### 命名空间可以包裹命名空间

也就是命名空间里细分命名空间

```csharp
namespace MyGame
{
    namespace UI
    {

    }
    namespace Game
    {
  
    }
}
```

调用的时候一层层点就行，或者引用命名空间using MyGame.UI

### 修饰类的访问修饰符

public	默认公开

internal	只能在该程序集里用

abstract	抽象类

sealed	密封类

partial	分部类

## 万物之父中的方法

### object中的静态方法

#### Equals()

作用：判断两个对象是否相等，比较的是二者指向的内存地址是否一样

最终判断权交给左侧对象的Equals方法

```csharp
        //Equals()
        //比较的是二者指向的内存地址是否一样
        //最终判断权交给左侧对象的Equals方法
        //值类型
        Console.WriteLine(Object.Equals(1, 1));
        Console.WriteLine(1.Equals(1));
        //引用类型
        Test t1 = new Test();
        Test t2 = new Test();
        Console.WriteLine(Object.Equals(t1, t2));
        Console.WriteLine(t1.Equals(t2));
        t2 = t1;
        Console.WriteLine(Object.Equals(t1, t2));
        Console.WriteLine(t1.Equals(t2));
```

#### ReferenceEquals()

作用：比较两个对象是否是相同的引用(内存地址)

```csharp
        //ReferenceEquals()
        //比较两个对象是否是相同的引用(内存地址)
        //值类型：返回值永远是flase
        Console.WriteLine(Object.ReferenceEquals(1, 1));
        //引用类型：
        Test t3 = new Test();
        Test t4 = new Test();
        Console.WriteLine(Object.ReferenceEquals(t3, t4));
        t4 = t3;
        Console.WriteLine(Object.ReferenceEquals(t3, t4));
```

object可以省略，因为是万物之父，只要在类里，这个类肯定继承于Object，所以也包含这个方法

### object中的成员方法

#### 普通方法GetType()

作用：获取对象运行时的类型Type，返回一个Type类型的对象

通过Type结合后面的反射相关特性，可以做很多关于对象的操作

```csharp
        //普通方法Type()
        Test t5 = new Test();
        Type type = t5.GetType();
```

#### 普通方法MemberwiseClone()

作用：获取对象的浅拷贝对象，返回一个新的对象。

但是新对象(克隆体)的引用变量改了之后，老对象相应的引用变量也会改变

```csharp
class Test
{
    //值类型成员变量
    public int i = 1;
    //引用类型成员变量
    public Test2 ttt = new Test2();
    public Test Clone()
    {
        return MemberwiseClone() as Test;
    }
}
class Test2
{
    public int i = 2;
}
```

```csharp
        //普通方法MemberwiseClone()
        Test t_2 = t.Clone();
        Console.WriteLine("克隆对象后");
        Console.WriteLine("t.i = " + t.i);
        Console.WriteLine("t.ttt.i = " + t.ttt.i);
        Console.WriteLine("t_2.i = " + t_2.i);
        Console.WriteLine("t_2.ttt.i = " + t_2.ttt.i);
        Console.WriteLine("改变克隆对象的信息");
        t_2.i = 99;
        t_2.ttt.i = 100;
        Console.WriteLine("t.i = " + t.i);
        Console.WriteLine("t.ttt.i = " + t.ttt.i);
        Console.WriteLine("t_2.i = " + t_2.i);
        Console.WriteLine("t_2.ttt.i = " + t_2.ttt.i);
```

![1748530266350](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530101100567-1717636512.png)

### object中的虚函数方法

#### 虚函数Equals()

默认实现还是比较二者是否为同一个引用，等同于ReferenceEquals()

但是微软在所有值类型的基类System.ValueType中重写了Equals()，用来比较值相等

**我们也可以对Equals()进行重写**

#### 虚函数GetHashCode()

作用：获取对象的哈希码

可以重写

#### 虚函数ToString()

作用：返回当前对象的字符串

可重写

当调用打印方法，默认会使用ToString()

> 习题

![1748563698568](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530101101373-33714842.png)

```csharp
namespace 万物之父中的方法习题;

//1.
class Player
{
    private string name;
    private int hp;
    private int atk;
    private int def;
    private int miss;
    public Player(string name, int hp, int atk, int def, int miss)
    {
        this.name = name;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
        this.miss = miss;
    }
    public override string ToString()
    {
        return String.Format("姓名{0},血量{1},攻击{2},防御{3},闪避{4}", name, hp, atk, def, miss);
    }
}

//2.
class Monster
{
    public Monster m;
    public string Name { get; set; }
    public int Hp{  get; set; }
    public int Atk{  get; set; }
    public int Def{  get; set; }
    public int SkillID{  get; set; }
    public Monster(string name, int hp, int atk, int def, int skillID)
    {
        Name = name;
        Hp = hp;
        Atk = atk;
        Def = def;
        SkillID = skillID;
        m = this;
    }
    public Monster Clone()
    {
        return MemberwiseClone() as Monster;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1.
        Player p = new Player("张三", 100, 10, 5, 5);
        Console.WriteLine(p);

        //2.
        Monster A = new Monster("A", 100, 10, 5, 5);
        Monster B = A.Clone();
        B.Name = "B";
        Console.WriteLine(A.Name);
        //因为是值类型的，所以改克隆体不会改变原来的值
        B.m.Name = "B";
        Console.WriteLine(A.m.Name);
        //引用类型的内容改变，改克隆体，原来的值也会改变
    }
}

```

## String

### 获取字符串指定位置字符

字符串本质是char的数组

可以直接用索引器，或ToCharArray()转成数组后再索引

```csharp
        //字符串获取指定位置字符
        string str = "hello world";
        Console.WriteLine(str[0]);
        //ToCharArray()：转成char数组
        char[] chars = str.ToCharArray();
        Console.WriteLine(chars[0]);
```

### 字符串拼接

string.Format()

```csharp
        //字符串拼接
        //  str = string.Format(str, "1");  //错误用法
        str = string.Format("{0}111",str);  //必须用占位符的形式
        Console.WriteLine(str);
```

### 正向查找字符位置

IndexOf()

```csharp
        //正向查找字符位置
        //找不到返回-1
        int index = str.IndexOf("o");
        Console.WriteLine(index);
        //忽略大小写,StringComparison.OrdinalIgnoreCase
        index = str.IndexOf("o",StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(index);
```

### 反向查找字符位置

LastIndexOf()

返回值：最后一次出现的起始索引位置

> 这个索引值还是从前往后的
>
> 反向体现在返回值是最后一次出现的起始索引位置

```csharp
        //反向查找字符位置
        //返回值 最后一次出现的起始索引位置
        int lastIndex = str.LastIndexOf("o");
        Console.WriteLine(lastIndex);
        //找最后一次出现目标字符串的第一个字符的位置
        lastIndex = str.LastIndexOf("d111");
        Console.WriteLine(lastIndex);
```

### 移除指定位置后的字符

Remove()

```csharp
        //移除指定位置后的字符(含指定位置一起移除)
        string str1 = str.Remove(2);
        Console.WriteLine(str1);
        //移除[开始位置,开始位置+count]的字符
        //第二个参数，count
        str1 = str.Remove(2, 3);
        Console.WriteLine(str1);
```

### 字符串替换

Replace()

```csharp
        //字符串替换
        str = str.Replace("hello", "FUCK");
        Console.WriteLine(str);
```

### 大小写转换

ToUpper()

ToLower()

```csharp
        //大小写转换
        str = str.ToUpper();
        Console.WriteLine(str);
        str = str.ToLower();
        Console.WriteLine(str);
```

### 字符串截取

Substring()

```csharp
        //字符串截取
        //截取指定位置开始之后的字符串(含指定位置)
        str1 = str.Substring(1);
        Console.WriteLine(str1);
        //截取[开始位置,开始位置+count]
        str1 = str.Substring(1, 3);
        Console.WriteLine(str1); 
```

### 字符串切割

Split()

```csharp
        //字符串切割
        str = "1_1 | 1_2 | 1_3 | 1_4 | 1_5";
        string[] strs = str.Split(" | ");
        for (int i = 0; i < strs.Length; i++)
        {
            //[1]：取切割符串后的字符串
            strs[i] = strs[i].Split("_")[1];
            Console.WriteLine(strs[i]);
        }
```

> 习题

![1748568223999](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530101102253-662457769.png)

```csharp
//1.
//  SubString
//  Replace

//2.
string str = "1|2|3|4|5|6|7";
string[] strs = str.Split('|');
str = "";
for (int i = 0; i < strs.Length; i++)
{
    str += int.Parse(strs[i]) + 1;
    if (i != strs.Length - 1) str += "|";
}
Console.WriteLine(str);

//3.
//别名

//4.
//3个堆空间
//str = "123";
//str2 = "321";
//str2 += "123";
//只要重新赋值string就会重新分配内存

//5.
string str2 = "hello";
char[] str2s = str2.ToCharArray();
for (int i = 0; i < str2.Length / 2; i++)
{
    str2s[i] = (char)(str2s[i] + str2s[str2.Length - 1 - i]);
    str2s[str2.Length - 1 - i] = (char)(str2s[i] - str2s[str2.Length - 1 - i]);
    str2s[i] = (char)(str2s[i] - str2s[str2.Length - 1 - i]);
}
foreach (char c in str2s) Console.Write(c);
Console.WriteLine();

```

## StringBuilder

一个用于处理字符串的公共类

作用：修改字符串而不用每次都创建新的对象

对于需要频繁修改和拼接的字符串可以使用它，用来提升性能，因为每次创建新的对象都会加快gc的到来

使用前需要using 命名空间：`using System.Text;`

### 申明

```csharp
using System.Text;

//第二个参数：初始化容量，设定过大会浪费空间
//在后续每次往里增加内容，会自动扩容
StringBuilder str = new StringBuilder("123123",100);
Console.WriteLine(str);
Console.WriteLine(str.Capacity);
```

### 增删查改替换

```csharp
//增删查改替换

//增
//不能用+=，用Append()和AppendFormat()
str.Append("111");
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.Capacity);
str.AppendFormat("{0}{1}", "222", "333");
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.Capacity);

//插入
str.Insert(0, "FUCK");
Console.WriteLine(str);

//删
//Remove(开始位置，count)
str.Remove(0, 4);
Console.WriteLine(str);

//清空
// str.Clear();
// Console.WriteLine(str);

//查
//  索引器
Console.WriteLine(str[1]);

//改
//  之前的string是只读不可改的，现在的StringBuilder是可改的
str[1] = 'f';
Console.WriteLine(str);

//替换
//  只替换第一个匹配项
str.Replace("123", "FUCK");
Console.WriteLine(str);

//Equals()
str.Clear();
str.Append("111");
if (str.Equals("111"))
{
    Console.WriteLine("相等");
}
```

> 习题

![1748609786046](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530215810005-621816605.png)

//1.

string每次改动都会创建一个新的对象，也就更容易产生垃圾，更容易触发gc

stringbuilder因为有初始容量的存在，只有达到初始容量上限才会扩容

string更加灵活，内置方法更多：IndexOf()、LastIndexOf()、ToUpper()、ToLower()、Substring()、Split()

stringbuilder适合需要频繁改动的字符串

//2.

> 就目前已学知识

如何节约内存：少new对象、合理使用static

如何尽可能的减少gc：合理使用string和stringbuilder

## 结构体和类的区别(面试常考)

1. 存储空间：结构体是值，在栈上；类是引用，在堆上
2. 使用：结构体不具备继承和多态的特性，只有封装的思想，也不能使用protected保护成员变量

### 详细对比：

| 结构体                                                             | 类       |
| ------------------------------------------------------------------ | -------- |
| 值类型                                                             | 引用类型 |
| 栈内存                                                             | 堆内存   |
| 不能用protected                                                    | 可以     |
| 结构体成员变量的申明不能设定初始值                                 | 可以     |
| 结构体不能自己申明无参构造函数，因为自带                           | 可以     |
| 结构体申明有参构造函数时，无参构造函数不会被顶掉                   | 会被顶掉 |
| 结构体不能申明析构函数                                             | 可以     |
| 结构体不能被继承                                                   | 可以     |
| **结构体需要在构造函数中初始化所有成员变量**                 | 随意     |
| 结构体不能被static修饰(不存在静态结构体)，但是结构体可以有静态成员 | 可以     |
| 结构体不能在内部申明和自己一样的结构体变量                         | 可以     |

对于最后一点：C# 的结构体是值类型，**不允许结构体中直接包含自身类型字段**

**C / C++：允许使用指针实现自引用结构体**

```csharp
struct Node {
    int value;
    struct Node* next; // ✅ C / C++允许：使用指针实现自引用
};
```

不能直接嵌套自身类型：

```csharp
struct Node {
    int value;
    struct Node next; // ❌ 错误：会导致无限大小的结构体
};
```

### 结构体的特别之处

结构体可以继承接口，但是结构体不能继承结构体和类

### 如何选择：结构体or类？

当需要继承和多态，只能用类(玩家、怪物)

当对象是数据集合，优先考虑结构体(位置、坐标)

从值和引用类型的赋值上的区别考虑：

因为结构体是值类型，所以当对象经常需要被赋值传递，但是又不希望原对象被改变，就用结构体。(坐标、向量、旋转)

## 抽象类和接口的区别(面试常考)

抽象类：abstract，不能实例化，抽象函数只能在抽象类里面申明，是个纯虚函数，必须在子类中实现

接口：interface，是行为的抽象，不能实例化，但是可以作为容器，不含成员变量，只有方法、属性、索引器、事件， 这些成员都不能实现，最好不要写访问修饰符，默认public，避免显示实现(接口名.方法名)

### 相同点

都可以被继承

都不能直接实例化

都可以包含方法等的申明

其子类必须实现

遵循里氏替换原则

### 不同点

| 抽象类                                                               | 接口                                                                  |
| -------------------------------------------------------------------- | --------------------------------------------------------------------- |
| 可以有构造函数                                                       | 没有                                                                  |
| 只能被单一继承<br />这是类的通性，只能继承一个父类和但是可以多个接口 | 可以被继承多个                                                        |
| 有成员变量                                                           | 没有                                                                  |
| 可以申明成员方法、虚函数、抽象函数、静态函数                         | 只能申明没有实现的函数                                                |
| 可以使用访问修饰符                                                   | 最好不写，默认为public<br />(否则就要在子类中显示实现：接口名.方法名) |

### 如何选择抽象类和接口

抽象出来的对象，用抽象类

一个规范行为，用接口

不同对象的共有行为，用接口

> OVER~
