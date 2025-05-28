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
