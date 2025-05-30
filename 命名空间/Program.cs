//命名空间可以同名，也就是分段写，也可以分文件写
namespace MyGame
{
    class GameObject
    {
    }
}
namespace MyGame
{
    class Player : GameObject
    {
    }
}

//不同命名空间允许有同名的类
namespace MyGame2
{
    class GameObject
    {
    }
}

namespace MyGame
{
    namespace UI
    {

    }
    namespace Game
    {
        
    }
}

namespace 命名空间
{
    class Program
    {
        static void Main()
        {
            //不同命名空间中相互使用，需要引用命名空间或指明出处
            MyGame.GameObject g = new MyGame.GameObject();
            MyGame2.GameObject g2 = new MyGame2.GameObject();
        }
    }
}
