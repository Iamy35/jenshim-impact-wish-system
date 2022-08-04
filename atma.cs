using System;
using System.Collections.Generic;

namespace algoritamaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            Console.WriteLine("Bir sayı giriniz");
            int num1 = Convert.ToInt32(Console.ReadLine());
            string numara = num1.ToString();
            bool kontrol = false;
            for (int i = 0; i< numara.Length; i++)
            {
                if (numara.Length % 2 == 1)
                {
                    if (numara[i]  == numara[numara.Length - i - 1])
                    {
                        kontrol = true;
                    }
                    else
                    {
                        kontrol = false;
                    }
                }
                else if (numara.Length % 2 == 0)
                {
                    if (numara[i] == numara[numara.Length - i - 1])
                    {
                        kontrol = true;
                    }
                    else
                    {
                        kontrol = false;
                    }
                }
            }
            if (kontrol == true)
            {
                Console.WriteLine("Sayınız palidromdur --->{0}", num1);
            }
            else if(kontrol == false)
            {
                Console.WriteLine("Sayınız palidrom değildir --->{0}", num1);
            }
        }
    }
}