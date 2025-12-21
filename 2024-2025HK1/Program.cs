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
    public static void Main(string[] args)
    {
        Base a= new Derrived();
        a.display();
    }
}
