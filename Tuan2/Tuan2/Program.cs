using System;

namespace Tuan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập họ và tên: ");
            string input = Console.ReadLine();

            // bai1
            if (!string.IsNullOrWhiteSpace(input))
            {
                string name = input.Trim();
                string[] words = name.Split(' ');

                string result = "";
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] != "")
                    {
                        string ten = words[i];
                        ten = char.ToUpper(name[0]) + ten.Substring(1).ToLower();
                        result += ten + " ";
                    }
                }

                Console.WriteLine("Họ tên chuẩn hoá: " + result.Trim());
                Console.WriteLine("Số từ trong tên : " + result.Length);
            }



            //bai3
            if (input == null)
            {
                Console.WriteLine("Chuỗi không đối xứng");
            }
            else
            {
                string p = input.Replace(" ", "").ToLower();
                bool doiXung = true;

                for (int i = 0; i < p.Length / 2; i++)
                {
                    if (p[i] != p[p.Length - 1 - i])
                    {
                        doiXung = false;
                        break;
                    }
                }

                if (doiXung)
                    Console.WriteLine("Chuỗi đối xứng");
                else
                    Console.WriteLine("Chuỗi không đối xứng");
            }
            //bai4
            Console.WriteLine("Nhập số phần tử mảng: ");
            int sptm = int.Parse(Console.ReadLine());
            int[] mang = new int[sptm];
            int tong = 0;
            for (int i = 0; i < sptm; i++)
            {
                Console.WriteLine("Phần tử thứ " + (i) + ": ");
                mang[i] = int.Parse(Console.ReadLine());
                tong = tong + mang[i];
            }
            Console.WriteLine("Tổng mảng: " + tong);
            //bai5

        }
    }
}
