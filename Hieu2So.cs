internal class Hieu2So
{
    private static void Mainx(string[] args)
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
                        heSoThu2 = (int) heSoThu2Value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap gia tri <=  2,147,483,647 & >= -2,147,483,648");
                        continue;
                    }
                }

                int sub = a - heSoThu2;
                Console.Write($"Hieu hai so: {sub}");
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
