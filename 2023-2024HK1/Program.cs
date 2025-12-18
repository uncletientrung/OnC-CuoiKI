// See https://aka.ms/new-console-template for more information
class BT2023
{

    public static void Main(string[] args)
    {

    }
}
abstract class Animal
{
    public string Name { get; set; }
    public void Sleep(){Console.WriteLine("Animal is sleeping");} // Gọi là chạy
    public virtual void Eat() // Có thể viết override hoặc không cần cứ gọi là chạy
    {
        Console.WriteLine("Animal is eating");
    }
    public abstract void Speak(); // Bắt buộc override
    public static void ShowTotal() // Static thì như cũ Animal.ShowTotal
    {
        Console.WriteLine($"Total animals");
    }
}
interface IAnimal
{
    const int MaxAge = 100;
    string Name { get; set; } // Không phải là biến mà là property bên cái kế thừa tạo biến rồi get/set như này
    string Type { get; } // Bên lớp con cứ public string Type => "Dog";
    void Speak();
    void Sleep() // Bản 8+ của C# có thể định nghĩa thân, không thể override nó.
    {
        // Chỉ được gọi IAnimal a = new Dog();
        //a.Sleep();
        Console.WriteLine("Animal is sleeping");
    }
    static void ShowInfo() // Giống các hàm static khác
    {
        Console.WriteLine("This is IAnimal interface");
    }
}
