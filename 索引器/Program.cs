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
