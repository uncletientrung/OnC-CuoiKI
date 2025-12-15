//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2022_2023HK1
//{
//    internal class Bai3
//    {
//        private String Name;
//        public Bai3(string name)
//        {
//            Name = name;
//        }   
//        private void ShowSerect()
//        {
//            Console.WriteLine("your name" + Name);
//        }
//        private static void DoSomeThing(string job)
//        {
//            Console.WriteLine("Do job" + job);
//        }
//        class Diary
//        {
//            public void Logging()
//            {
//                //ShowSerect(); // Static ảnh hưởng đến cách gọi không ảnh hưởng đến gọi tử đâu
//                    // Lỗi zì ShowSerect là non-static
//                DoSomeThing("Code Csharp"); 
                
//            }
//        }
//    }
//    class Test
//    {
//        public static void Main(string[] args)
//        {
//            Bai3 a = new Bai3("A");
//            //string name = a.Name; // Lỗi vì Name là private không có get set
//            //a.ShowSerect(); // Lỗi private luôn
//            //a.DoSomeThing(); // Lỗi private và thiếu tham số
//        }
//    }
    
//}
