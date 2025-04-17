using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp01;

namespace ConsoleAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var tongHaiSo = new TongHaiSo();
            //tongHaiSo.TongHaiSo_Main();

            var hieuHaiSo = new Hieu2So();
            //hieuHaiSo.tinhHieu();

            BT2 pt = new BT2();
            //pt.PTB1();
            pt.PTB2();

        }
    }
}
