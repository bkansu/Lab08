using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***X***");
            OzelKuyruk x = new OzelKuyruk();
            
            x.Enqueue(1);
            x.Enqueue(5);
            x.Enqueue(24);
            x.Enqueue(7);
            x.Enqueue(9);                   
            x.Enqueue(15);
            x.Enqueue(17);
            x.Enqueue(7);
            x.Dequeue();

            Queue y = new Queue();
            y.Enqueue(1);
            y.Enqueue(5);
            y.Enqueue(7);
            y.Enqueue(9);
            y.Enqueue(16);
            y.Enqueue(24);
            y.Enqueue(7);
            y.Dequeue();

            Console.WriteLine("\n***Y***");
            for (int i = 0; i < y.Count; i++)
            {
                Console.Write((y.ToArray())[i]+" ");
            }
            Console.ReadLine();

            //Çeşitli ekleme ve çıkarma yaptıktan sonra kuyrukların görüntüsünü adım adım ekranda gösteriniz
            //yukarıdaki eklemeler
        }
    }
}
