﻿using System;

public class BT2
{
    public void PTB1()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
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
            if (int.TryParse(inputFromKeybỏad, out int heSoThuNhat))
            {
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

                giaiPTBacNhat(heSoThuNhat, heSoThu2);
                break;
            }
            else
            {
                Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap gia tri so <= 2,147,483,647 & >= -2,147,483,648 ");
                continue;
            }

        }
    }


    public void PTB2()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
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
            if (int.TryParse(inputFromKeybỏad, out int heSoThuNhat))
            {
                int heSoThu2, heSoThu3;
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

                while (true)
                {
                    Console.Write("Nhap he so c: ");
                    inputFromKeybỏad = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputFromKeybỏad))
                    {
                        Console.WriteLine("Ko dc bo trong khi nhap ");
                        continue;
                    }
                    if (long.TryParse(inputFromKeybỏad, out long heSoThu3Value) && heSoThu3Value <= int.MaxValue && heSoThu3Value >= int.MinValue)
                    {
                         heSoThu3 = (int)heSoThu3Value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap gia tri <=  2,147,483,647 & >= -2,147,483,648");
                        continue;
                    }
                }

                giaiPTBac2(heSoThuNhat, heSoThu2, heSoThu3);
                break;
            }
            else
            {
                Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap gia tri so <= 2,147,483,647 & >= -2,147,483,648 ");
                continue;
            }

        }
    }

    private void giaiPTBacNhat(int heSoThuNhat, int heSoThu2)
    {
        if (heSoThuNhat == 0)
        {
            if (heSoThu2 == 0)
            {
                Console.WriteLine("Phương trình này có vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Phương trình này vô nghiệm.");
            }
        }
        else
        {
            double nghiem = (double)-heSoThu2 / heSoThuNhat;
            Console.WriteLine($"Phương trình có nghiệm.x = {nghiem.ToString("0.##")}");
        }
    }

    internal static void giaiPTBac2(int a, int b, int c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình này vô nghiệm.");
            }
            else
            {
                double nghiem = (double)-c / b;
                Console.WriteLine($"Phương trình có 1 nghiệm.x = {nghiem.ToString("0.##")}.");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình này vô nghiệm.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = {x.ToString("0.##")}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1.ToString("0.##")}, x2 = {x2.ToString("0.##")}");
            }
        }
    }
}
