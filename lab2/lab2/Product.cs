﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Product
    {
        private int id;
        private string name;
        private float price;
        private int qty;
        private string image;
        private string desc;
        public List<string> imgList = new List<string>(10);


        public Product()
        {

        }

        public Product(int id, string name, int price, int qty, string image, string desc)
        {
            id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Qty
        {
            get
            {
                return qty;
            }

            set
            {
                qty = value;
            }
        }

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

        public void AddProduct()
        {
            Console.WriteLine("Nhap ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten : ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap gia : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so luong : ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap anh : ");
            image = Convert.ToString(Console.ReadLine());
            imgList.Add(image);
            Console.WriteLine("Nhap mieu ta : ");
            desc = Console.ReadLine();

        }

        public void ShowProduct()
        {
            Console.WriteLine("ID :" + id);
            Console.WriteLine("Ten SP : " + name);
            Console.WriteLine("Gia : " + price);
            Console.WriteLine("SL : " + qty);
            //hien thi anh
            foreach (string i in imgList)
            {
                Console.WriteLine("anh : "+i);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Desc : " + desc);
        }

        public void CheckQty()
        {
            if (qty > 0)
            {
                Console.WriteLine("Con " + qty + "san pham");
            }
            else { Console.WriteLine("Het Hang"); }
        }

        public void Addimage()
        {

            if (imgList.Count >= 10)
            {
                Console.WriteLine("Thu vien day");
            }
            else
            {
                Console.WriteLine("Nhap anh : ");
                string a = Console.ReadLine();
                imgList.Add(a);
            }
        }

        public void Removeimage()
        {
            foreach (string i in imgList)
            {
                Console.WriteLine("anh : "+i);
            }
            Console.WriteLine("Chon anh de xoa");
            int a = Convert.ToInt32(Console.ReadLine());
            imgList.RemoveAt(a);
            Console.WriteLine("success");

            Console.WriteLine("danh sach anh da cap nhat : ");
            foreach (string i in imgList)
            {
                Console.WriteLine("anh : " + i);
            }
        }

    }
}
