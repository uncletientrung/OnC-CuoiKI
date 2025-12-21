// See https://aka.ms/new-console-template for more information
public class Base
{
    public int value = 10;
    public virtual void display()
    {
        Console.WriteLine("value "+value);
    }
}
public class Derrived: Base
{
    public override void display()
    {
        value += 20;
        Console.WriteLine("value " + value);
    }
}
public class Progream
{
    private static int giathua(int n)
    {
        if (n == 0 || n==1) return 1;
        return n * giathua(n-1);
    }
    private static double tongS(int n, int x)
    {
        double rs = 0.0;
        for(int i = 0; i <= n;  i++)
        {
            rs += Math.Pow(x, i) / giathua(2 + i);
        }
        return rs;
    }
    public static void Main(string[] args)
    {
        // Câu 1
        //Base a= new Derrived();
        //a.display();

        // Câu 2
        Console.Write("Nhập x:");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhập n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ket qua:" + tongS(n, x));
    }
}
