namespace 万物之父中的方法习题;

//1.
class Player
{
    private string name;
    private int hp;
    private int atk;
    private int def;
    private int miss;
    public Player(string name, int hp, int atk, int def, int miss)
    {
        this.name = name;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
        this.miss = miss;
    }
    public override string ToString()
    {
        return String.Format("姓名{0},血量{1},攻击{2},防御{3},闪避{4}", name, hp, atk, def, miss);
    }
}

//2.
class Monster
{
    public Monster m;
    public string Name { get; set; }
    public int Hp{  get; set; }
    public int Atk{  get; set; }
    public int Def{  get; set; }
    public int SkillID{  get; set; }
    public Monster(string name, int hp, int atk, int def, int skillID)
    {
        Name = name;
        Hp = hp;
        Atk = atk;
        Def = def;
        SkillID = skillID;
        m = this;
    }
    public Monster Clone()
    {
        return MemberwiseClone() as Monster;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1.
        Player p = new Player("张三", 100, 10, 5, 5);
        Console.WriteLine(p);

        //2.
        Monster A = new Monster("A", 100, 10, 5, 5);
        Monster B = A.Clone();
        B.Name = "B";
        Console.WriteLine(A.Name);
        //因为是值类型的，所以改克隆体不会改变原来的值
        B.m.Name = "B";
        Console.WriteLine(A.m.Name);
        //引用类型的内容改变，改克隆体，原来的值也会改变
    }
}
