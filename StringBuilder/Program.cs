using System.Text;

//第二个参数：初始化容量，设定过大会浪费空间
//在后续每次往里增加内容，会自动扩容
StringBuilder str = new StringBuilder("123123",9);
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.Capacity);

//增删查改替换

//增
//不能用+=，用Append()和AppendFormat()
str.Append("111");
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.Capacity);
str.AppendFormat("{0}{1}", "222", "333");
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.Capacity);

//插入
str.Insert(0, "FUCK");
Console.WriteLine(str);

//删
//Remove(开始位置，count)
str.Remove(0, 4);
Console.WriteLine(str);

//清空
// str.Clear();
// Console.WriteLine(str);

//查
//  索引器
Console.WriteLine(str[1]);

//改
//  之前的string是只读不可改的，现在的StringBuilder是可改的
str[1] = 'f';
Console.WriteLine(str);

//替换
//  只替换第一个匹配项
str.Replace("123", "FUCK");
Console.WriteLine(str);

//Equals()
str.Clear();
str.Append("111");
if (str.Equals("111"))
{
    Console.WriteLine("相等");
}