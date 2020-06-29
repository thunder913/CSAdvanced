using System;
using System.IO;
using System.Text;
using System.Linq;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            using var fileStream = new FileStream("copyMe.png", FileMode.Open);
            using var copyImage = new FileStream("copied.png", FileMode.Create);
                byte[] buffer = new byte[fileStream.Length];
                int len = fileStream.Read(buffer, 0, int.Parse(fileStream.Length.ToString()));
            copyImage.Write(buffer);
        }
    }
}
