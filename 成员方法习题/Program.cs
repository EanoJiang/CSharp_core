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
