using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public class B3
    {
        public void ChuyenDoiDoC()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var inputFromKeybỏad = "";
            while (true)
            {
                Console.Write("Nhap do C =: ");
                inputFromKeybỏad = Console.ReadLine();
                if (string.IsNullOrEmpty(inputFromKeybỏad))
                {
                    Console.Write("Ko dc bo trong khi nhap");
                    continue;
                }
                if (int.TryParse(inputFromKeybỏad, out int celsius))
                {
                    Console.WriteLine("Do K tuong ung: {0}", celsius + 273);
                    Console.WriteLine("Do F tuong ung: {0}", celsius * 18 / 10 + 32);
                    break;
                }
                else
                {
                    Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap gia tri so <= 2,147,483,647 & >= -2,147,483,648 ");
                    continue;
                }
            }
        }
    }
}
