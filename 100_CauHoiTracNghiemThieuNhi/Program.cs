// See https://aka.ms/new-console-template for more information
class Program
{
    partial int x = 1;
    public static void Main()
    {
        //Console.WriteLine(12 + 08 + "ZendVN" + 44 + 02);  Đáp án đúng là: 20ZendVN442

        //int yourAge = 35;
        //Console.Write(yourAge++ + "-" + (++yourAge * 2));  Đáp án đúng là: 35-74

        B b= new B(); // Cha: x = 5
                        //Con



    }
}
class A
{
    protected int x;
    public A(int x)
    {
        this.x = x;
        Console.WriteLine("Cha: x = " + x);
    }
}

class B : A
{
    public B() : base(5)
    {
        Console.WriteLine("Con");
    }
}
