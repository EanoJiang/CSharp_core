namespace 继承_里氏替换原则;

class GameObject{
    
}
class Player : GameObject{
    public void Attack(GameObject target){
        Console.WriteLine("{0} Attack {1}", this, target);
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

        #region is 和 as 关键字
        if(player is Player){

        }
        else if(player is Monster){

        }
        Player p = player as Player;
        Monster m = player as Monster;
        Console.WriteLine(p);
        Console.WriteLine(m == null);//true
        #endregion

        #region is和as的配合使用
        if(player is Player){

            // Player p1 = player as Player;
            // p1.Attack(monster);

            (player as Player).Attack(monster);

        }

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
        #endregion

        
        
    }
}
