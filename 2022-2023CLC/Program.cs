// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

class vector
{
    private int x;
    private int y;
    public vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    ~vector() {}
    public static vector operator +(vector a, vector b)
    {
        return new vector(a.X + b.X, a.Y + b.Y);
    }
    public int X
    {
        get { return x; }
        set { x = value; }
    }
    public int Y
    {
        get { return y; }
        set { y=value; }
    }
}
class Item
{
    public int Id { get; set; }
    public int ItemID { get; set; }
    public int total { get; set; }
    public Item(int id, int itemID, int total)
    {
        Id = id;
        ItemID = itemID;
        this.total = total;
    }
}
class BT{
    private static vector Tong2ToanTu(vector a, vector b)
    {
        vector result = new vector(a.X+b.X, a.Y+b.Y);
        return result;
    }
    private static int Tich(vector a, vector b)
    {
        int result = a.X * b.X + a.Y * b.Y;
        return result;
    }


    public static void Main(string[] args)
    {
        // CÂU 1d
        int[] arr = new int[4]; // Gán rỗng
        int[] arr2 ={ 12, 24, 21, 42 }; // Gán 1 chiều
        int[,] arr3 = {{12, 24, 21, 42},// Gán 2 chiều
                        {99, 68, 32, 92},
                        {95, 34, 21, 71}                 
        };
        int rows = arr3.GetLength(0); // số hàng
        int cols = arr3.GetLength(1); // số cột
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write(arr3[i, j] + " ");
        //    }
        //    Console.WriteLine(); // xuống dòng sau mỗi hàng
        //}
        // CÂU 1e (Sử dụng mảng Jagged)
        int[][] arr4 = new int[3][]; // mảng jagged 3 phần tử
        arr4[0] = new int[] { 2, 4, 6 };
        arr4[1] = new int[] { 3, 5, 9 };
        arr4[2] = new int[] { 15, 9, 11, 17, 21 };
        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    for (int j = 0; j < arr4[i].Length; j++)
        //    {
        //        Console.Write(arr4[i][j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        // Câu 3
        vector a=new vector(1, 3);
        vector b=new vector(2, 6);
        vector sum = Tong2ToanTu(a, b);
        Console.WriteLine($"Vector tổng = ({sum.X}, {sum.Y})");
        Console.WriteLine("Tich: " + Tich(a, b));
        // Nạp chồng    
        vector sum2 = a + b;
        Console.WriteLine($"Vector tổng = ({sum2.X}, {sum2.Y})");

        // Câu 4a
        Item[] arrItem = {new Item(100, 1, 100), new Item(200, 2, 100), new Item(100,3,300), new Item(100,4,400),
                        new Item(300,5,150),new Item(200,6,250)};

        int nv100 = arrItem
        .Where(it => it.Id == 100)
        .Sum(it => it.total);
        int nv200 = arrItem
        .Where(it => it.Id == 200)
        .Sum(it => it.total);
        int nv300 = arrItem
        .Where(it => it.Id == 300)
        .Sum(it => it.total);
        Console.WriteLine(nv300);


    }
}

