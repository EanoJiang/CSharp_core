//1.
//  SubString
//  Replace

//2.
string str = "1|2|3|4|5|6|7";
string[] strs = str.Split('|');
str = "";
for (int i = 0; i < strs.Length; i++)
{
    str += int.Parse(strs[i]) + 1;
    if (i != strs.Length - 1) str += "|";
}
Console.WriteLine(str);

//3.
//别名

//4.
//3个堆空间
//str = "123";
//str2 = "321";
//str2 += "123";
//只要重新赋值string就会重新分配内存

//5.
string str2 = "hello";
char[] str2s = str2.ToCharArray();
for (int i = 0; i < str2.Length / 2; i++)
{
    str2s[i] = (char)(str2s[i] + str2s[str2.Length - 1 - i]);
    str2s[str2.Length - 1 - i] = (char)(str2s[i] - str2s[str2.Length - 1 - i]);
    str2s[i] = (char)(str2s[i] - str2s[str2.Length - 1 - i]);
}
foreach (char c in str2s) Console.Write(c);
Console.WriteLine();
