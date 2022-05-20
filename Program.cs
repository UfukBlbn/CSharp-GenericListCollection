using System;
using System.Collections.Generic;
namespace GenericListCollection
{

    class Product
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            List<string> myList2 = new List<string>();

            myList2.Add("Ufuk");
            myList2.Add("Yasin");
            myList2.Add(null);

            List<Product> phones = new List<Product>()
            {
                new Product() {Name="Samsung Galaxy s6"},
                new Product() {Name="Samsung Galaxy Edge"},
                new Product() {Name="Iphone X"},
                new Product() {Name="Xiaomi"}

            };

             List<Product> phones2 = new List<Product>()
            {
                new Product() {Name="Huawei s6"},
                new Product() {Name="Ipad"},
                new Product() {Name="Iphone X"},
                new Product() {Name="Xiaomi"}

            };

            phones.AddRange(phones2);
            
        }
    }
}
