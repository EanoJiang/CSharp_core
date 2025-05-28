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
