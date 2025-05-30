namespace String;

class Program
{
    static void Main(string[] args)
    {
        //字符串获取指定位置字符
        string str = "hello world";
        Console.WriteLine(str[0]);
        //ToCharArray()：转成char数组
        char[] chars = str.ToCharArray();
        Console.WriteLine(chars[0]);

        //字符串拼接
        //  str = string.Format(str, "1");  //错误用法
        str = string.Format("{0}111", str);  //必须用占位符的形式
        Console.WriteLine(str);

        //正向查找字符位置
        //找不到返回-1
        int index = str.IndexOf("o");
        Console.WriteLine(index);
        //忽略大小写,StringComparison.OrdinalIgnoreCase
        index = str.IndexOf("o", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(index);
        //反向查找字符位置
        //返回值 最后一次出现的起始索引位置
        //这个索引值还是从前往后的，反向体现在返回值是最后一次出现的起始索引位置
        int lastIndex = str.LastIndexOf("o");
        Console.WriteLine(lastIndex);
        //找最后一次出现目标字符串的第一个字符的位置
        lastIndex = str.LastIndexOf("d111");
        Console.WriteLine(lastIndex);

        //移除指定位置后的字符(含指定位置一起移除)
        string str1 = str.Remove(2);
        Console.WriteLine(str1);
        //移除[开始位置,开始位置+count]的字符
        //第二个参数，count
        str1 = str.Remove(2, 3);
        Console.WriteLine(str1);

        //字符串替换
        str = str.Replace("hello", "FUCK");
        Console.WriteLine(str);

        //大小写转换
        str = str.ToUpper();
        Console.WriteLine(str);
        str = str.ToLower();
        Console.WriteLine(str);

        //字符串截取
        //截取指定位置开始之后的字符串(含指定位置)
        str1 = str.Substring(1);
        Console.WriteLine(str1);
        //截取[开始位置,开始位置+count]
        str1 = str.Substring(1, 3);
        Console.WriteLine(str1);

        //字符串切割
        str = "1_1 | 1_2 | 1_3 | 1_4 | 1_5";
        string[] strs = str.Split(" | ");
        for (int i = 0; i < strs.Length; i++)
        {
            //[1]：取切割符串后的字符串
            strs[i] = strs[i].Split("_")[1];
            Console.WriteLine(strs[i]);
        }
    }
}
