namespace 继承_万物之父与装箱拆箱;

class Father{
    public void Speak(){
        Console.WriteLine("I am Father.");
    }
}
class Son : Father{

}

class Program
{
    static void Main(string[] args)
    {
        //用object容器装任意对象
        object o = new Son();
        Son s = new Son();
        o = s;
        Father f = new Father();
        o = f;
        //用is和as来调用容器里的对象的成员
        if(o is Father)(o as Father).Speak();

        #region object对象的类型转换

        //值类型 —— 强转
        //用object容器装任意值类型
        object o2 = 1f;
        //要当成数字用的话，需要强转
        int f1 = (int)o2;

        //引用类型 —— as转换
        //string类型
        object o3 = "111";
        string s1 = (string)o3;
        s1 = o3 as string;
        s1 = o3.ToString();
        //数组类型
        object o4 = new int[3];
        int[] arr = o4 as int[];
        arr = (int[])o4;

        #endregion

        #region 装箱拆箱
        object o5 = 3;
        int i1 = (int)o5;

        Func(1,2,3.1f,"dsadsajda",new Son());
        //传任意类型参
        void Func(params object[] arr){

        }
        void Func1(object o){

        }

        #endregion

    }
}
