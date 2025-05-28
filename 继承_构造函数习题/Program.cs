namespace 继承_构造函数习题;

class Worker{
    public string jobType;
    public string jobContent;
    public Worker(){
    }
    public Worker(string jobType, string jobContent){
        this.jobType = jobType;
        this.jobContent = jobContent;
    }
    public void Work(){
        Console.WriteLine("I am a worker, my job is {0} and my job content is {1}", jobType, jobContent);
    }
}
class Programmer : Worker{
    public Programmer():base("Programmer", "Coding"){

    }
}
class Strategist : Worker{
    public Strategist():base("Strategist", "Planning"){

    }
}
class Artist : Worker{
    public Artist():base("Artist", "Drawing"){
    }
}


class Program
{
    static void Main(string[] args)
    {
        Programmer p = new Programmer();
        p.Work();
        Strategist s = new Strategist();
        s.Work();
        Artist a = new Artist();
        a.Work();
    }
}
