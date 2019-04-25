using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class OzelKuyruk
    {
        ArrayList sayilar=new ArrayList();
        public static int ElemanSayisi=0;        
        public void Enqueue(int YeniEleman)
        {
            bool flag = false;
            
            if (ElemanSayisi != 0)
            {

            
            for (int i = 0; i < sayilar.Count; i++)
            {
                if(Convert.ToInt32(sayilar[i]) % 2 == 0)
                {
                        sayilar.Insert(i+1, YeniEleman);
                        flag = true;
                }
            }
                if (flag == false)
                {
                    sayilar.Insert(sayilar.Count, YeniEleman);
                }
            }
            else
            {
                sayilar.Insert(0, YeniEleman);
            }
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.Write(sayilar[i] + " ");
            }
            Console.WriteLine("");
            //implemente edilecek
            ElemanSayisi++;
        }

        public void Dequeue()
        {
            //implemente edilecek
            if (ElemanSayisi == 0)
            {
                Console.WriteLine("Dizi boş");
            }
            else
            {
                sayilar.RemoveAt(sayilar.Count / 2);
                for (int i = 0; i < sayilar.Count; i++)
                {
                    Console.Write(sayilar[i] + " ");
                }
                Console.WriteLine("");
            }
            //OzelKuyruk boş ise istisna fırlatacak
        }

        
    }
}
