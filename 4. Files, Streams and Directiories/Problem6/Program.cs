using System;
using System.IO.Compression;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "copyMe.png";
            using var archive = ZipFile.Open("archive.zip", ZipArchiveMode.Create);
            archive.CreateEntryFromFile(filePath, "newFile.png");
            archive.Dispose();
            using var readArchive = ZipFile.Open("archive.zip", ZipArchiveMode.Read);
            readArchive.ExtractToDirectory("../../../");
        }
    }
}
