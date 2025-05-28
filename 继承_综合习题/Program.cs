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
