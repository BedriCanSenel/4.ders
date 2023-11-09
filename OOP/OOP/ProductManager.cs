using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2; // return kullanmadaki amaç; buradan gelecek sonucu kullanmak istiyorum.
        //}
        //public void Topla2(int sayi1, int sayi2) // void'e sahip fonksiyon, işlemini yapıyor ve ekrana yazdırıyor.
        //{
        //    Console.WriteLine(sayi1 + sayi2); yazdır.
        
    }
}
