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
