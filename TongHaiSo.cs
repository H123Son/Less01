using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public class TongHaiSo
    {
        public void TongHaiSo_Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // tổng hai số

            var inputFromKeybỏad = "";
            while (true)
            {
                Console.Write(" Nhap he so a: ");
                inputFromKeybỏad = Console.ReadLine();
                if (string.IsNullOrEmpty(inputFromKeybỏad))
                {
                    Console.Write("Ko dc bo trong khi nhap");
                    continue;
                }
                if (int.TryParse(inputFromKeybỏad, out int a))
                {
                    int heSoThu1 = Convert.ToInt32(inputFromKeybỏad);
                    int heSoThu2;
                    while (true)
                    {
                        Console.Write("Nhap he so b: ");
                        inputFromKeybỏad = Console.ReadLine();

                        if (string.IsNullOrEmpty(inputFromKeybỏad))
                        {
                            Console.WriteLine("Ko dc bo trong khi nhap ");
                            continue;
                        }

                        if (long.TryParse(inputFromKeybỏad, out long heSoThu2Value) && heSoThu2Value <= int.MaxValue && heSoThu2Value >= int.MinValue)
                        {
                            heSoThu2 = (int)heSoThu2Value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap gia tri <=  2,147,483,647 & >= -2,147,483,648");
                            continue;
                        }
                    }

                    int sum = a + heSoThu2;
                    Console.Write($"Tong hai so: {sum}");
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
