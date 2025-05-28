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
    
    #region get和set可以只有一个
    //一般只会出现 只有get的情况，只能获取值，不能修改值————只读属性
    //只有一个的时候，不要加修饰符
    public bool Sex{
        get{
            return sex;
        }
    }
    #endregion

    #region 自动属性
    //作用：外部只读不写的特性
    //使用场景：一个特征是只希望外部只读不可写，也不加别的特殊处理
    public float Height { get; private set; }
    //只可以在类内部set
    #endregion
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

        p.Age = 25; //set可以访问
        //Console.WriteLine(p.Age); //get前加了private，所以不能访问
        

    }
}
