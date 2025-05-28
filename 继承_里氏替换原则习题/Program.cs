namespace 继承_里氏替换原则习题;

class Monster{
    
}
class Boss : Monster{
    public void Skill(){
        Console.WriteLine("Boss Skill");
    }
}
class Goblin : Monster{
    public void Atk(){
        Console.WriteLine("Goblin Atk");
    }
}

class Player{
    public Weapon nowWeapon;
    public Player(){
        //默认武器：匕首
        nowWeapon = new Dagger();
    }
    //切换武器
    public void Converse(Weapon weapon){
        nowWeapon = weapon;
    }
    public void PrintWeapon(){
        Console.WriteLine("now I have a {0}", nowWeapon.name);
    }

}
class Weapon{
    public string name;

}
class MP9 : Weapon{
    public MP9(){
        name = "MP9";
    }
}
class ShotGun : Weapon{
    public ShotGun(){
        name = "ShotGun";
    }
}
class Pistol : Weapon{
    public Pistol(){
        name = "Pistol";
    }
}
class Dagger : Weapon{
    public Dagger(){
        name = "Dagger";
    }
}

class Program
{
    static void Main(string[] args)
    {
        //习题1
        Random r = new Random();
        int randomNum;
        Monster[] monsters = new Monster[10];
        //随机生成10个怪物，二者生成概率都是50%
        for(int i = 0; i < monsters.Length; i++){
            randomNum = r.Next(0,2);
            if(randomNum == 1){
                monsters[i] = new Boss();
            }
            else{
                monsters[i] = new Goblin();
            }
        }
        for(int i = 0; i < monsters.Length; i++){
            if(monsters[i] is Boss){
                (monsters[i] as Boss).Skill();
            }
            else if(monsters[i] is Goblin){
                (monsters[i] as Goblin).Atk();
            }
        }

        //习题2
        Player player = new Player();
        player.PrintWeapon();
        Console.WriteLine("下面开始捡东西");
        Weapon[] weapons = new Weapon[4]{new MP9(), new ShotGun(), new Pistol(), new Dagger()};
        for(int i = 0; i < weapons.Length; i++){
            player.Converse(weapons[i]);
            player.PrintWeapon();
        }

    }
}
