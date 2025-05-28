namespace 成员变量习题;

#region 2
class Student{
    public string name;
    public int age;
    public string num;
    public Student deskmate;
}
#endregion

#region 3
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
#endregion

class Program
{

    static void Main(string[] args)
    {
        //2
        Student s1 = new Student();
        s1.name = "Alice";
        s1.age = 20;
        s1.num = "2018001";
        Student s2 = new Student();
        s2.name = "Bob";
        s2.age = 21;
        s2.num = "2018002";
        s1.deskmate = s2;
        s2.deskmate = s1;

        //3
        Classroom c1 = new Classroom(5);
        c1.major = "Computer Science";
        c1.students = new Student[]{s1, s2};
        Console.WriteLine(c1.students[0].name);
        Console.WriteLine(s1.name);
        //8
        Student s = new Student();
        s.deskmate = new Student();
        s.deskmate.age = 10;
        Student s3 = s.deskmate;
        s3.age = 20;
        Console.WriteLine(s.deskmate.age);
        Console.WriteLine(s3.age);
    }
}
