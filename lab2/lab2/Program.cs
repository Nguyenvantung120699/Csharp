using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            string Chon;
            while (true)
            {
                Console.WriteLine("================================");

                Console.WriteLine("Chon 1 de nhap san pham.");
                Console.WriteLine("Chon 2 de them anh.");
                Console.WriteLine("Chon 3 de hien thi san pham.");
                Console.WriteLine("Chon 4 de xoa anh.");
                Console.WriteLine("Chon 5 de chech hang.");

                Console.WriteLine("================================");

                Console.WriteLine("moi nhap : ");
                Chon = Console.ReadLine();
                switch (Chon)
                {
                    case "1":
                        p.AddProduct();
                        break;
                    case "2":
                        p.Addimage();

                        break;
                    case "3":
                        p.ShowProduct();
                        break;
                    case "4":
                        p.Removeimage();
                        break;
                    case "5":
                        p.CheckQty();
                        break;
                }
            }

            Console.ReadKey();
        }

    }
}
