namespace 拓展方法习题;

//1
//平方
static class Test{
    public static int Square(this int n){
        Console.WriteLine("Square of " + n + " is " + (n*n));
        return n*n;
    }
    public static void Suicide(this Player player){
        Console.WriteLine("Player " + player.name + " is suiciding!");
    }
}

//2
//玩家
class Player{
    public string name;
    public int hp;
    public int atk;
    public int def;
    public Player(string name, int hp, int atk, int def){
        this.name = name;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
    }
    public void Attack(Player target){
        Console.WriteLine(this.name + " attacks " + target.name + "!");
        target.hp -= this.atk - target.def;
        Console.WriteLine(target.name + " now has " + target.hp + " HP.");
        if(this.atk - target.def > 0){
            Hurted(target);
        }
    }
    public void Move(int x, int y){
        Console.WriteLine(this.name + " moves to (" + x + ", " + y + ").");
    }
    public void Hurted(Player target){
        Console.WriteLine(target.name + " is hurt!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //1
        int num = 3;
        num.Square();
        //2
        Player player1 = new Player("player1", 100, 10, 5);
        Player player2 = new Player("player2", 100, 13, 2);
        player1.Attack(player2);
        player1.Move(1, 2);
        player1.Suicide();
        player2.Attack(player1);
        player2.Suicide();


    }
}
