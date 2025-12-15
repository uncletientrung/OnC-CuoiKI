// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    // CÂU 1 Viết phương thức xác định năm nhuận
    public static bool IsLeapYear(int year)
    {
        return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
    }
    // CÂU 2 Viết phương thức đảo ngược chuỗi
    public static void ReverseString(string a)
    {
        char []chars = a.ToCharArray();
        string result = "";
        for(int i = chars.Length - 1; i >= 0; i--)
        {
            result += chars[i];
        }
        Console.WriteLine(result);
    }
    // Câu 4 khởi tạo và sử dụng một delegate có kiểu trả về là int và tham số truyền vào là kiểu string.
    // Delegate này sẽ được sử dụng cho mỗi phương thức
    static int ConverStringToInt(string number)
    {
        return int.Parse(number);
    }
    static int ShowString(string s)
    {
        Console.WriteLine(s);
        return s.Length;
    }
    delegate int MyDelegate(string value);
    public static void Main(string[] args)
    {
        //Console.WriteLine(IsLeapYear(2024));
        //ReverseString("Hello");

        // Khởi tạo delegate với phương thức ConvertStringToInt
        MyDelegate d1 = ConverStringToInt;
        int result1 = d1("123");
        Console.WriteLine("ConvertStringToInt result: " + result1);
        // Gán delegate sang phương thức ShowString
        MyDelegate d2 = ShowString;
        int result2 = d2("Hello CSharp");
        Console.WriteLine("ShowString result: " + result2);
    }
}