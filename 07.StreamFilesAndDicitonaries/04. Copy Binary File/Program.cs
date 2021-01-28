using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream readStream = new FileStream("../../../copyMe.png", FileMode.Open);
            FileStream writeStream = new FileStream("newImage.png", FileMode.Create);
            while (true)
            {

                byte[] buffer = new byte[4096];
                int count = readStream.Read(buffer, 0, buffer.Length);



                if (count == 0)
                {
                    break;
                }
                writeStream.Write(buffer);
            }

        }
    }
}
