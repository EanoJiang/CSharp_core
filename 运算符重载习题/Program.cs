namespace 运算符重载习题;

//1
class Position{
    public int x;
    public int y;
    public static bool operator ==(Position p1, Position p2){
        if(p1.x == p2.x && p1.y == p2.y){
            return true;
        }
        return false;
    }
    public static bool operator !=(Position p1, Position p2){
        if(p1.x!= p2.x || p1.y!= p2.y){
            return true;
        }
        return false;
    }
}

//2
class Vector3{
    public int x;
    public int y;
    public int z;
    public static Vector3 operator +(Vector3 v1, Vector3 v2){
        Vector3 result = new Vector3();
        result.x = v1.x + v2.x;
        result.y = v1.y + v2.y;
        result.z = v1.z + v2.z;
        return result;
    }
    public static Vector3 operator -(Vector3 v1, Vector3 v2){
        Vector3 result = new Vector3();
        result.x = v1.x - v2.x;
        result.y = v1.y - v2.y;
        result.z = v1.z - v2.z;
        return result;
    }
    public static Vector3 operator *(Vector3 v1, int n){
        Vector3 result = new Vector3();
        result.x = v1.x * n;
        result.y = v1.y * n;
        result.z = v1.z * n;
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1
        Position a = new Position();
        a.x = 1;
        a.y = 2;
        Position b = new Position();
        b.x = 1;
        b.y = 2;
        Console.WriteLine(a == b); // True
        Console.WriteLine(a!= b); // False
        //2
        Vector3 v1 = new Vector3();
        v1.x = 1;
        v1.y = 2;
        v1.z = 3;
        Vector3 v2 = new Vector3();
        v2.x = 2;
        v2.y = 3;
        v2.z = 4;
        Vector3 v3 = v1 + v2;
        Console.WriteLine("(v3.x, v3.y, v3.z) = ({0}, {1}, {2})", v3.x, v3.y, v3.z);
        Vector3 v4 = v1 - v2;
        Console.WriteLine("(v4.x, v4.y, v4.z) = ({0}, {1}, {2})", v4.x, v4.y, v4.z);
        Vector3 v5 = v1 * 2;
        Console.WriteLine("(v5.x, v5.y, v5.z) = ({0}, {1}, {2})", v5.x, v5.y, v5.z);
    }
}
