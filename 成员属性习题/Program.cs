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
