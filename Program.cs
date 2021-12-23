using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int rows = 3;
            int numberOfFullRows = pictures / rows;
            int remainingOfPictures = pictures % rows;
            Console.WriteLine("Можно будет вывести " + numberOfFullRows +
                " заполненных рядов и " + remainingOfPictures +
                " картинок будет сверх меры");
        }
    }
}
