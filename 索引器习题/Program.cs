namespace 索引器习题;

class IntArray{
    public int[] arr;
    public int length;
    public IntArray(int size){
        length = 0;
        arr = new int[size];
    }
    //增
    public void Add(int index, int value){
        if(index < 0 || index > length){
            Console.WriteLine("索引超出范围");
            return;
        }
        else{
            if(length < arr.Length){
                arr[length] = value;
                length++;
            }
            else{
                int[] newArr = new int[arr.Length + 1];
                for(int i=0;i<arr.Length;i++){
                    newArr[i] = arr[i]; 
                }
                arr = newArr;
                //后面元素后移
                for(int i = length-1;i>=index;i--){
                    arr[i+1] = arr[i];
                }
                arr[index] = value;
                length++;
            }    
        }           
    }
    //删
    public void Remove(int index){
        if(index > length-1 || index < 0){
            Console.WriteLine("索引超出范围");
            return;
        }
        else{
            //后面元素前移
            for(int i = index;i<length-1;i++){
                arr[i] = arr[i+1];
            }
            length--;
        }
    }
    //索引器
    //查
    //改
    public int this[int index]{
        get{
            return arr[index];
        }
        set{
            arr[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IntArray arr = new IntArray(5);
        arr.Add(0,1);
        arr.Add(1,2);
        arr.Add(2,3);
        arr.Add(3,4);
        arr.Add(4,5);
        arr.Add(5,6);
        for(int i=0;i<arr.length;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(arr.length);

        arr.Remove(2);
        for(int i=0;i<arr.length;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(arr.length);
        arr[0] = 10;
        Console.WriteLine(arr[0]);
        
    }
}
